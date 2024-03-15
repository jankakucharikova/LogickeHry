using LogickeHry.Properties;
using System.Security.Cryptography;
using System.Text;

namespace LogickeHry;

// Třída reprezentující hlavní okno aplikace.
public sealed partial class GameForm : Form
{
    private readonly List<TableLayoutPanel> _boxy;
    private Hra? _aktualnihra;
    internal readonly DataContext databaze;
    internal readonly bool dostupnaDatabaze;
    internal Uzivatel? aktualniuzivatel;
    private TableLayoutPanel? _minula, _aktualni;

    // Konstruktor třídy GameForm.
    public GameForm()
    {

        InitializeComponent();
        BackColor = Color.Turquoise;
        _minula = UvodBox;
        _aktualni = UvodBox;
        DoubleBuffered = true;


        _boxy = Controls.OfType<TableLayoutPanel>().ToList();
        databaze = new DataContext();
        dostupnaDatabaze = databaze.Database.CanConnect();

        if (dostupnaDatabaze)
        {
            if (Settings.Default.prihlaseny)
            {
                aktualniuzivatel = databaze.Uzivatele!.FirstOrDefault(u => u.Id == Settings.Default.uzivatel);
                if (aktualniuzivatel == null)
                {
                    Settings.Default.prihlaseny = false;
                }
                else
                {
                    Prihlaseni(aktualniuzivatel);
                }
            }
        }
        else
        {
            PreskocitBezDatabaze();
        }

        // Nastavení vykreslování statistik.
        Statistika.Vysledky.Nastav(this);
    }
    // Metoda pro zobrazení konkrétního boxu.
    internal void Ukazbox(TableLayoutPanel box)
    {
        if (_aktualni != box)
        {
            _minula = _aktualni;
            _aktualni = box;
        }
        foreach (var b in _boxy.Where(b => b.Visible))
        {
            b.Hide();
        }

        box.Show();
        box.Select();
    }

    // Metoda pro zobrazení předchozího boxu.
    private void UkazBoxZpet() => Ukazbox(_minula!);

    // Metoda pro přeskočení přihlašování v případě nedostupnosti připojení k databázi.
    private void PreskocitBezDatabaze()
    {
        HlavniLDatabaze.Text = @"Připojení k databázi není k dispozici.";
        ProfilBProfil.Text = @" 👤 
 Jméno Uživatele ";
        ProfilBProfil.DropDownItems.Clear();
        Ukazbox(HlavniBox);
    }

    // Metoda pro rychlé hashování hesla.
    private static string QuickHash(string input)
    {
        var inputBytes = Encoding.UTF8.GetBytes(input);
        var inputHash = SHA256.HashData(inputBytes);
        return Convert.ToHexString(inputHash);
    }
    // Událost při změně viditelnosti boxu PRBox.
    private void PRBox_VisibleChanged(object sender, EventArgs e)
    {
        var t = (TableLayoutPanel)sender;
        if (t.Visible)
        {
            t.BringToFront();
            PRLPodnadpis.Text = (string)t.Tag;
            PRHlavicka.Show();
            PRHlavicka.BringToFront();
        }
        else
        {
            PRHlavicka.Hide();
        }

    }

    // Událost při změně viditelnosti boxu NastaveniBox.
    private void NastaveniBox_VisibleChanged(object sender, EventArgs e)
    {
        if (NastaveniBox.Visible)
        {
            if (aktualniuzivatel != null)
            {
                NastaveniTBJmeno.Text = aktualniuzivatel.jmeno;
                NastaveniCBPohlavi.Text = aktualniuzivatel.pohlavi;
                NastaveniCBVek.Text = aktualniuzivatel.vek;
            }

            NastaveniBox.BringToFront();
            HlavniLPodnadpis.Text = @"Nastavení";
            HlavniHlavicka.Show();
            HlavniHlavicka.BringToFront();
        }
        else
        {
            HlavniHlavicka.Hide();
        }
    }

    // Událost při změně viditelnosti boxu HlavniBox.
    private void HlavniBox_VisibleChanged(object sender, EventArgs e)
    {
        var t = (TableLayoutPanel)sender;
        if (t.Visible)
        {
            t.BringToFront();
            HlavniLPodnadpis.Text = @"Hlavní stránka";
            HlavniHlavicka.Show();
            HlavniHlavicka.BringToFront();
        }
        else
        {
            HlavniHlavicka.Hide();
        }
    }

    // Událost při změně viditelnosti boxu StatistikaBox.
    private void StatistikaBox_VisibleChanged(object sender, EventArgs e)
    {
        var t = (TableLayoutPanel)sender;
        if (t.Visible)
        {
            t.BringToFront();
            HlavniLPodnadpis.Text = @"Statistika";
            HlavniHlavicka.Show();
            HlavniHlavicka.BringToFront();
        }
        else
        {
            HlavniHlavicka.Hide();
        }
    }

    // Událost při změně viditelnosti boxu HraBox.
    private void HraBox_VisibleChanged(object sender, EventArgs e)
    {
        if (HraBox.Visible)
        {
            HraBox.BringToFront();
            if (_aktualnihra != null)
                HlavniLPodnadpis.Text = _aktualnihra.nazev;
            HlavniHlavicka.Show();
            HlavniHlavicka.BringToFront();
        }
        else
        {
            HlavniHlavicka.Hide();
        }
    }

    // Metoda pro odhlášení uživatele.
    private void Odhlaseni()
    {
        Settings.Default.prihlaseny = false;
        Settings.Default.Save();
        aktualniuzivatel = null;
        ProfilBProfil.DropDownItems.Clear();
        ProfilBProfil.DropDownItems.AddRange(new ToolStripItem[] { ProfilBPrihlaseni, toolStripSeparator3, ProfilBRegistrace });
        ProfilBProfil.Text = @" 👤 
 Jméno Uživatele ";
        MenuBMenu.DropDownItems.Remove(MenuBNastaveni);
        Ukazbox(UvodBox);
    }

    // Metoda pro přihlášení uživatele.
    private void Prihlaseni(Uzivatel u)
    {
        aktualniuzivatel = u;
        Settings.Default.prihlaseny = true;
        Settings.Default.uzivatel = u.Id;
        Settings.Default.Save();
        ProfilBProfil.DropDownItems.Clear();
        ProfilBProfil.DropDownItems.AddRange(new ToolStripItem[] { ProfilLJmeno, ProfilLPohlavi, ProfilLVek, toolStripSeparator1, ProfilBNastaveni, toolStripSeparator2, ProfilBOdhlasit });
        ProfilBProfil.Text = $@" 👤 
 {aktualniuzivatel.jmeno} ";
        ProfilLJmeno.Text = aktualniuzivatel.jmeno;
        ProfilLPohlavi.Text = aktualniuzivatel.pohlavi;
        ProfilLVek.Text = aktualniuzivatel.vek;
        MenuBMenu.DropDownItems.Add(MenuBNastaveni);
        Ukazbox(HlavniBox);
    }

    // Metoda pro registraci nového uživatele.
    private void RegistraceBRegistrovat_Click(object sender, EventArgs e)
    {
        if (!dostupnaDatabaze)
        {
            PreskocitBezDatabaze();
            return;
        }
        if (RegistraceTBJmeno.Text.Trim().Equals("") || RegistraceCBPohlavi.Text.Trim().Equals("") || RegistraceCBVek.Text.Trim().Equals("") || RegistraceTBHeslo.Text.Trim().Equals(""))
        {
            RegistraceChHlaska.Text = @"Nejsou vyplněné všechny údaje";
            RegistraceChHlaska.Show();
        }
        else
        {
            if (!databaze.Uzivatele.Any(u => u.jmeno == RegistraceTBJmeno.Text.Trim()))
            {

                var u = new Uzivatel
                {
                    jmeno = RegistraceTBJmeno.Text.Trim(),
                    vek = RegistraceCBVek.Text.Trim(),
                    pohlavi = RegistraceCBPohlavi.Text.Trim(),
                    hashHesla = QuickHash(RegistraceTBHeslo.Text.Trim())
                };
                databaze.Add(u);
                databaze.SaveChanges();
                Prihlaseni(u);
                RegistraceTBJmeno.Text = "";
                RegistraceTBHeslo.Text = "";
                RegistraceCBPohlavi.Text = "";
                RegistraceCBVek.Text = "";
                RegistraceChHlaska.Hide();
                Ukazbox(HlavniBox);
            }
            else
            {
                RegistraceChHlaska.Text = @"Uživatel už existuje";
                RegistraceChHlaska.Show();
            }
        }
    }

    // Metoda pro uložení nastavení uživatele.
    private void NastaveniBUlozit_Click(object sender, EventArgs e)
    {
        if (!dostupnaDatabaze)
        {
            PreskocitBezDatabaze();
            return;
        }
        if (NastaveniTBJmeno.Text.Trim().Equals("") || NastaveniCBPohlavi.Text.Trim().Equals("") || NastaveniCBVek.Text.Trim().Equals("") || NastaveniTBHeslo.Text.Trim().Equals(""))
        {
            NastaveniLChHlaska.Text = @"Nejsou vyplněné všechny údaje";
            NastaveniLChHlaska.Show();
        }
        else
        {
            if (aktualniuzivatel != null && aktualniuzivatel.jmeno == NastaveniTBJmeno.Text.Trim() || !databaze.Uzivatele.Any(u => u.jmeno == NastaveniTBJmeno.Text.Trim()))
            {
                aktualniuzivatel.jmeno = NastaveniTBJmeno.Text.Trim();
                aktualniuzivatel.vek = NastaveniCBVek.Text.Trim();
                aktualniuzivatel.pohlavi = NastaveniCBPohlavi.Text.Trim();
                aktualniuzivatel.hashHesla = QuickHash(NastaveniTBHeslo.Text.Trim());
                databaze.SaveChanges();
                NastaveniTBJmeno.Text = "";
                NastaveniTBHeslo.Text = "";
                NastaveniCBPohlavi.Text = "";
                NastaveniCBVek.Text = "";
                NastaveniLChHlaska.Hide();
                Prihlaseni(aktualniuzivatel);
            }
            else
            {
                NastaveniLChHlaska.Text = @"Uživatel už existuje";
                NastaveniLChHlaska.Show();
            }
        }
    }

    // Metoda pro přihlášení uživatele.
    private void PrihlaseniBPrihlaseni_Click(object sender, EventArgs e)
    {
        if (!dostupnaDatabaze)
        {
            PreskocitBezDatabaze();
            return;
        }
        Uzivatel u;
        if (null != (u = databaze.Uzivatele.FirstOrDefault(x => x.jmeno == PrihlaseniTBJmeno.Text.Trim())))
        {
            if (u.hashHesla == QuickHash(PrihlaseniTBHeslo.Text.Trim()))
            {
                Prihlaseni(u);
                PrihlaseniTBJmeno.Text = "";
                PrihlaseniTBHeslo.Text = "";
                PrihlaseniLChHlaska.Hide();

            }
            PrihlaseniLChHlaska.Text = @"Špatné heslo";
            PrihlaseniLChHlaska.Show();

        }
        else
        {
            PrihlaseniLChHlaska.Text = @"Neexistující uživatel";
            PrihlaseniLChHlaska.Show();
        }
    }

    // Metoda pro přechod na box NastaveniBox.
    private void BNastaveni_Click(object sender, EventArgs e)
    {
        if (!dostupnaDatabaze)
        {
            PreskocitBezDatabaze();
            return;
        }
        Ukazbox(NastaveniBox);
    }

    // Metoda pro přechod na úvodní box bez přihlášení .
    private void BUvodPreskocit_Click(object sender, EventArgs e)
    {
        Ukazbox(HlavniBox);
    }
    // Metoda pro přechod na úvodní box z rřihlášení a registrace.
    private void PRBZpet_Click(object sender, EventArgs e)
    {
        Ukazbox(UvodBox);
    }
    // Metoda pro přechod na hlavní stránku.
    private void BHlavniStranka_Click(object sender, EventArgs e)
    {
        Ukazbox(HlavniBox);
    }
    // Metoda pro odhlášení uživatele.
    private void BOdhlaseni_Click(object sender, EventArgs e)
    {
        Odhlaseni();
        Ukazbox(UvodBox);
    }
    // Metoda pro přechod na box přihlášení.
    private void BPrihlaseni_Click(object sender, EventArgs e)
    {
        Ukazbox(PrihlaseniBox);
    }
    // Metoda pro přechod na box registrace.
    private void BRegistrace_Click(object sender, EventArgs e)
    {
        Ukazbox(RegistraceBox);
    }
    // Metoda pro přechod na box statistiky.
    private void BStatistiky_Click(object sender, EventArgs e)
    {
        Ukazbox(StatistikaBox);
    }
    // Metoda pro spuštění hry s minami.
    private void BMiny_Click(object sender, EventArgs e)
    {
        _aktualnihra = new Miny(this);
        _aktualnihra.SpustiUvod();
    }
    // Metoda pro spuštění logické hry.
    private void BLogik_Click(object sender, EventArgs e)
    {
        _aktualnihra = new Logik(this);
        _aktualnihra.SpustiUvod();
    }
    // Metoda pro spuštění hry Sudoku.
    private void BSudoku_Click(object sender, EventArgs e)
    {
        _aktualnihra = new Sudoku(this);
        _aktualnihra.SpustiUvod();
    }
    // Metoda pro spuštění hry Sudoku se zvířaty.
    private void BSudokuZvirata_Click(object sender, EventArgs e)
    {
        _aktualnihra = new SudokuZoo(this);
        _aktualnihra.SpustiUvod();
    }
    // Metoda pro aktualizaci statistiky podle obtížnosti.
    private void StatistikaCBObtiznost_SelectedIndexChanged(object sender, EventArgs e)
    {
        Statistika.Vysledky.Aktualizace(sender, e);
    }
    // Metoda pro spuštění hry Sudoku s planetami.
    private void BSudokuPlanety_Click(object sender, EventArgs e)
    {
        _aktualnihra = new SudokuPlanety(this);
        _aktualnihra.SpustiUvod();
    }
    // Metoda pro spuštění hry Sudoku s ovocem.
    private void BSudokuOvoce_Click(object sender, EventArgs e)
    {
        _aktualnihra = new SudokuOvoce(this);
        _aktualnihra.SpustiUvod();
    }
    // Metoda pro spuštění hry Sudoku s písmeny.
    private void BSudokuPismenka_Click(object sender, EventArgs e)
    {
        _aktualnihra = new SudokuPismenka(this);
        _aktualnihra.SpustiUvod();
    }
    // Metoda pro spuštění hry Sudoku s tvary.
    private void BSudokuTvary_Click(object sender, EventArgs e)
    {
        _aktualnihra = new SudokuTvary(this);
        _aktualnihra.SpustiUvod();
    }
    // Metoda pro obsluhu události kliknutí na tlačítko pro návrat z aktuálního boxu na předchozí box.
    private void HlavniBZpet_Click(object sender, EventArgs e)
    {
        UkazBoxZpet();
    }
}