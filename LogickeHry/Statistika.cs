using Microsoft.EntityFrameworkCore;

namespace LogickeHry;

// Třída pro zpracování a zobrazení statistiky her.
internal class Statistika
{
    private GameForm _form; // Reference na hlavní formulář aplikace
    private TableLayoutPanel _panel; // Panel pro zobrazení statistiky
    private readonly List<Label> _nadpisy = new(); // Seznam nadpisů sloupců v tabulce statistik
    internal static readonly Statistika Vysledky = new(); // Statická instance třídy pro správu statistik

    private Statistika()
    {
        // Privátní konstruktor pro zabránění vytvoření dalších instancí třídy
    }

    // Metoda pro nastavení statistiky
    public void Nastav(GameForm form)
    {
        _form = form; // Nastavení reference na hlavní formulář

        // Pokud je databáze dostupná
        if (form.dostupnaDatabaze)
        {
            // Inicializace panelu pro zobrazení statistiky
            _panel = new TableLayoutPanel
            {
                GrowStyle = TableLayoutPanelGrowStyle.AddRows,
                ColumnCount = 6,
                AutoScroll = true,
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble,
                ColumnStyles = { new ColumnStyle(SizeType.Percent, 20), new ColumnStyle(SizeType.Percent, 20), new ColumnStyle(SizeType.Percent, 20), new ColumnStyle(SizeType.Percent, 20), new ColumnStyle(SizeType.Percent, 20), new ColumnStyle(SizeType.Percent, 20) }
            };

            // Přidání panelu do hlavního boxu pro statistiku
            form.StatistikaBox.Controls.Add(_panel, 0, 1);
            form.StatistikaBox.SetColumnSpan(_panel, 6);

            // Přidání události pro aktualizaci statistiky při změně viditelnosti hlavního boxu pro statistiku
            form.StatistikaBox.VisibleChanged += Aktualizace;

            // Inicializace nadpisů sloupců v tabulce statistik
            _nadpisy.Add(new Label { Text = @"Jméno" });
            _nadpisy.Add(new Label { Text = @"Hra" });
            _nadpisy.Add(new Label { Text = @"Obtížnost" });
            _nadpisy.Add(new Label { Text = @"Čas (s)" });
            _nadpisy.Add(new Label { Text = @"Skóre" });
            _nadpisy.Add(new Label { Text = @"Datum" });

            // Nastavení formátování pro nadpisy sloupců
            foreach (var t in _nadpisy)
                t.Font = new Font(t.Font, FontStyle.Bold);
        }
        else
        {
            // Pokud není databáze dostupná, zobrazí se v hlavním boxu pro statistiku chybová zpráva
            var text = new Label
            {
                Dock = DockStyle.Fill,
                Text = @"Statistiky nejsou k dispozici, protože se nelze připojit k databázi. Zkuste se ujistit, že máte připojení k internetu a restartovat aplikaci.",
                TextAlign = ContentAlignment.MiddleCenter
            };
            form.StatistikaBox.Controls.Add(text, 0, 1);
            form.StatistikaBox.SetColumnSpan(text, 6);
        }
    }

    // Metoda pro aktualizaci statistiky
    public void Aktualizace(object sender, EventArgs e)
    {
        // Pokud není uživatel přihlášen, vypne se checkbox pro filtrování podle uživatele
        if (_form.aktualniuzivatel == null)
        {
            _form.StatistikyCBMoje.Checked = false;
            _form.StatistikyCBMoje.Enabled = false;
        }

        // Pokud není dostupná databáze, metoda končí
        if (!_form.dostupnaDatabaze)
        {
            return;
        }

        // Načtení statistiky her z databáze podle zadaných filtrů
        var s = NactiStatistiky(_form.StatistikyCBMoje.Checked ? _form.aktualniuzivatel : null, _form.StatistikyCBHra.Text, _form.StatistikaCBObtiznost.Text);

        // Příprava na zobrazení statistiky v panelu
        _panel.SuspendLayout();
        _panel.Controls.Clear();
        _panel.RowStyles.Clear();
        _panel.RowCount = s.Count + 2;

        // Přidání nadpisů sloupců do panelu
        _panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        for (var i = 0; i < _nadpisy.Count; i++)
            _panel.Controls.Add(_nadpisy[i], i, 0);

        // Naplnění tabulky statistikou
        for (var i = 0; i < s.Count; i++)
        {
            _panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            _panel.Controls.Add(new Label { Text = s[i].uzivatel.jmeno, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 0, i + 1);
            _panel.Controls.Add(new Label { Text = s[i].hra, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 1, i + 1);
            _panel.Controls.Add(new Label { Text = s[i].obtiznost, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 2, i + 1);
            _panel.Controls.Add(new Label { Text = s[i].cas.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 3, i + 1);
            _panel.Controls.Add(new Label { Text = s[i].obtiznost != Obtiznost.Vlastni.ToString() ? s[i].skore.ToString() : "Nelze unifikovat", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 4, i + 1);
            _panel.Controls.Add(new Label { Text = s[i].datum.ToString("g"), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 5, i + 1);
        }

        _panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _panel.ResumeLayout(true);
    }

    // Metoda pro načtení statistiky her z databáze podle zadaných filtrů
    private List<VysledekHry> NactiStatistiky(Uzivatel? u, string? hra, string? obtiznost)
    {
        if (!_form.dostupnaDatabaze)
        {
            return new List<VysledekHry>();
        }

        // Načtení statistiky her z databáze pomocí Entity Framework Core
        IQueryable<VysledekHry> x = _form.databaze.Statistiky.Include(d => d.uzivatel);

        // Aplikace filtrů na statistiku her
        if (u != null)
            x = x.Where(e => e.uzivatel == u);
        if (!string.IsNullOrEmpty(hra) && hra != "Všechny hry")
            x = x.Where(e => e.hra == hra);
        if (!string.IsNullOrEmpty(obtiznost) && obtiznost != "Všechny obtížnosti")
            x = x.Where(e => e.obtiznost == obtiznost);

        // Seřazení statistiky her podle skóre a času
        return x.OrderByDescending(s => s.skore).ThenBy(s => s.cas).ToList();
    }
}