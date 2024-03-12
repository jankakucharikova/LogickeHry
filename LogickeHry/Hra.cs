using static System.Windows.Forms.LinkLabel;
using System.Drawing.Imaging;

namespace LogickeHry
{
    internal enum StavHry
    {
        Pripravena, Bezi, Prohra, Vyhra
    }
    internal enum Obtiznost
    {
        Tezke, Lehke, Stredni, Vlastni
    }
    internal abstract class Hra
    {
        internal GameForm form;
        internal string Nazev;
        internal StavHry Stav;
        internal System.Windows.Forms.Timer stopky;
        internal int uplynulycas,ziskaneskore;
        internal Obtiznost obtiznost = Obtiznost.Lehke;
        internal Label lcas,lskore;
        internal TableLayoutPanel plocha;
        protected string navod;
        public Hra(GameForm form)
        {
            this.form = form;
        }
        protected void UkazNavod(object sender, EventArgs e)
        {
            MessageBox.Show(navod,$"Návod ke hře {Nazev}");
        }
        public void SmazHerniPole()
        {

            form.HraBox.Controls.Clear();
            form.HraBox.ColumnCount = 0;
            form.HraBox.ColumnStyles.Clear();
            form.HraBox.RowCount = 0;
            form.HraBox.RowStyles.Clear();
        }
        internal virtual void SpustiUvod()
        {
            ZobrazStranku();
            SmazHerniPole();
            VytvorUvodniStranku();
            Stav = StavHry.Pripravena;
        }

        protected abstract void VytvorUvodniStranku();

        internal virtual void SpustiHru()
        {
            Reset();
            PouzijNastaveni();
            SmazHerniPole();
            VytvorHerniStranku();
            ZobrazStranku();
            Stav = StavHry.Bezi;
            NastavCasovac();
        }

        protected abstract void PouzijNastaveni();
        protected virtual void NastavCasovac()
        {
            stopky.Interval = 1000;
            stopky.Tick += (s, e) =>
            {
                uplynulycas++;
                lcas.TextChanged += (s, e) => lcas.Invalidate();
                lcas.Text = TimeSpan.FromSeconds(uplynulycas).ToString(@"mm\:ss");
            };
            stopky.Start();
        }
        internal virtual void ZobrazStranku()
        {
            form.Ukazbox(form.HraBox);
        }

        protected virtual void VytvorHerniStranku()
        {
            stopky = new System.Windows.Forms.Timer();
            form.HraBox.SuspendLayout();
            VytvorBocniPanel();
            VytvorHerniPlochu();
            form.HraBox.ResumeLayout();
        }
        protected abstract void VytvorBocniPanel();
        protected abstract void VytvorHerniPlochu();
        protected virtual void Prohra()
        {
            Stav = StavHry.Prohra;
            KonecHry();
            ProhraVlastni();
            MessageBox.Show("Prohra!");
        }

        protected abstract void ProhraVlastni();
        protected abstract void KonecHry();

        protected virtual void Vyhra()
        {
            Stav = StavHry.Vyhra;
            KonecHry();
            VyhraVlastni();
            if (form.aktualniuzivatel != null && form.DostupnaDatabaze)
            {
                VysledekHry v = form.databaze.statistiky.Where(e => e.uzivatel == form.aktualniuzivatel && e.hra == Nazev && e.obtiznost == obtiznost.ToString()).FirstOrDefault();
                if (v == null)
                {
                    form.databaze.statistiky.Add(
                        new VysledekHry()
                        {
                            uzivatel = form.aktualniuzivatel,
                            hra = Nazev,
                            obtiznost = obtiznost.ToString(),
                            cas = uplynulycas,
                            skore = ziskaneskore,
                        }); ;
                }
                else
                {
                    if (v.cas > uplynulycas)
                    {
                        v.cas = uplynulycas;
                    }
                }
                form.databaze.SaveChanges();
            }
            MessageBox.Show($"Vyhra!\nSkóre: {ziskaneskore}");
        }

        protected abstract void VyhraVlastni();
        protected abstract void Reset();
        protected List<Bitmap> NactiIkonky(Bitmap bmp)
        {
            int RozmerIkonky = bmp.Height;
            var pocet = bmp.Width / RozmerIkonky; 

            var vyrezy = new Rectangle[pocet];
            for (var i = 0; i < pocet; i++)
            {
                vyrezy[i] = new Rectangle(i * RozmerIkonky, 0, RozmerIkonky, RozmerIkonky);
            }
            List<Bitmap> v = new List<Bitmap>();
            for(int i = 0; i < vyrezy.Length; i++) 
            {
                v.Add(bmp.Clone(vyrezy[i], PixelFormat.DontCare));
            }
            return v;
        }
    }
}
