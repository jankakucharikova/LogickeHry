using System.Drawing.Imaging;
using Timer = System.Windows.Forms.Timer;

namespace LogickeHry;

// Výčtový typ pro různé stavy hry
internal enum StavHry
{
    Pripravena, Bezi, Prohra, Vyhra
}

// Výčtový typ pro různé obtížnosti hry
internal enum Obtiznost
{
    Tezke, Lehke, Stredni, Vlastni
}

// Abstraktní třída pro hru
internal abstract class Hra
{
    internal readonly GameForm form;
    internal string nazev;
    internal StavHry stav;
    internal Timer? stopky;
    internal int uplynulycas, ziskaneskore;
    internal Obtiznost obtiznost = Obtiznost.Lehke;
    internal Label lcas, lskore;
    internal TableLayoutPanel plocha;
    protected string navod;

    protected Hra(GameForm form)
    {
        this.form = form;
    }

    // Metoda pro zobrazení návodu k hře
    protected void UkazNavod(object sender, EventArgs e)
    {
        MessageBox.Show(navod, $@"Návod ke hře {nazev}");
    }

    private void SmazHerniPole()
    {

        form.HraBox.Controls.Clear();
        form.HraBox.ColumnCount = 0;
        form.HraBox.ColumnStyles.Clear();
        form.HraBox.RowCount = 0;
        form.HraBox.RowStyles.Clear();
    }

    // Metoda pro spuštění úvodní obrazovky hry
    internal void SpustiUvod()
    {
        ZobrazStranku();
        SmazHerniPole();
        VytvorUvodniStranku();
        stav = StavHry.Pripravena;
    }
    // Abstraktní metoda pro vytvoření úvodní obrazovky hry
    protected abstract void VytvorUvodniStranku();
    
    //Metoda pro spuštění samotné hry
    internal void SpustiHru()
    {
        Reset();
        PouzijNastaveni();
        SmazHerniPole();
        VytvorHerniStranku();
        ZobrazStranku();
        stav = StavHry.Bezi;
        NastavCasovac();
    }

    // Abstraktní metoda pro použití nastavení hry
    protected abstract void PouzijNastaveni();

    // Metoda pro nastavení časovače
    private void NastavCasovac()
    {
        stopky.Interval = 1000;
        stopky.Tick += (_, _) =>
        {
            uplynulycas++;
            lcas.TextChanged += (_, _) => lcas.Invalidate();
            lcas.Text = TimeSpan.FromSeconds(uplynulycas).ToString(@"mm\:ss");
        };
        stopky.Start();
    }

    // Metoda pro zobrazení herní stránky
    private void ZobrazStranku()
    {
        form.Ukazbox(form.HraBox);
    }

    // Metoda pro vytvoření herní stránky
    private void VytvorHerniStranku()
    {
        stopky = new Timer();
        form.HraBox.SuspendLayout();
        VytvorBocniPanel();
        VytvorHerniPlochu();
        form.HraBox.ResumeLayout();
    }
    protected abstract void VytvorBocniPanel();
    protected abstract void VytvorHerniPlochu();

    // Metoda pro ukončení hry při prohře
    protected void Prohra()
    {
        stav = StavHry.Prohra;
        KonecHry();
        ProhraVlastni();
        MessageBox.Show(@"Prohra!");
    }

    protected abstract void ProhraVlastni();
    protected abstract void KonecHry();

    // Metoda pro ukončení hry při výhře
    protected void Vyhra()
    {
        stav = StavHry.Vyhra;
        KonecHry();
        VyhraVlastni();
        if (form is { aktualniuzivatel: not null, dostupnaDatabaze: true })
        {
            var vysledek = new VysledekHry
            {
                uzivatel = form.aktualniuzivatel,
                hra = nazev,
                obtiznost = obtiznost.ToString(),
                cas = uplynulycas,
                skore = ziskaneskore,
                datum = DateTime.Now
            };
            form.databaze.Statistiky.Add(vysledek);
            form.databaze.SaveChanges();
        }
        MessageBox.Show($@"Vyhra!
Skóre: {ziskaneskore}");
    }

    protected abstract void VyhraVlastni();
    protected abstract void Reset();

    // Metoda pro načtení ikonek ze zadané bitmapy
    protected static List<Bitmap> NactiIkonky(Bitmap bmp)
    {
        var rozmerIkonky = bmp.Height;
        var pocet = bmp.Width / rozmerIkonky;

        var vyrezy = new Rectangle[pocet];
        for (var i = 0; i < pocet; i++)
        {
            vyrezy[i] = new Rectangle(i * rozmerIkonky, 0, rozmerIkonky, rozmerIkonky);
        }

        return vyrezy.Select(t => bmp.Clone(t, PixelFormat.DontCare)).ToList();
    }
}