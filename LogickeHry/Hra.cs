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
        internal int uplynulycas;
        internal Obtiznost obtiznost = Obtiznost.Lehke;
        internal Label lcas;
        public Hra(GameForm form)
        {
            this.form = form;
        }
        public void SmazHerniPole()
        {
            /*while (form.HraBox.Controls.Count > 0)
            {
                form.HraBox.Controls[0].Dispose();
            }*/
            form.HraBox.Controls.Clear();
            form.HraBox.ColumnCount = 0;
            form.HraBox.ColumnStyles.Clear();
            form.HraBox.RowCount = 0;
            form.HraBox.RowStyles.Clear();
        }
        internal virtual void SpustiUvod()
        {
            SmazHerniPole();
            VytvorUvodniStranku();
            ZobrazStranku();
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
            stopky = new System.Windows.Forms.Timer();
            stopky.Interval = 1000;
            stopky.Tick += (s, e) => uplynulycas++;
            stopky.Tick += (s, e) => lcas.Text = TimeSpan.FromSeconds(uplynulycas).ToString(@"mm\:ss");
            stopky.Start();
        }
        internal virtual void ZobrazStranku()
        {
            form.Ukazbox(form.HraBox);
        }

        protected abstract void VytvorHerniStranku();
        protected virtual void Prohra()
        {
            KonecHry();
            ProhraVlastni();
        }

        protected abstract void ProhraVlastni();
        protected abstract void KonecHry();

        protected virtual void Vyhra()
        {
            KonecHry();
            VyhraVlastni();
            vysledek_hry v = form.databaze.statistiky.Where(e => e.uzivatel == form.aktualniuzivatel && e.hra == Nazev && e.obtiznost == obtiznost.ToString()).FirstOrDefault();
            if (v == null)
            {
                form.databaze.statistiky.Add(
                    new vysledek_hry()
                    {
                        uzivatel = form.aktualniuzivatel,
                        hra = Nazev,
                        obtiznost = obtiznost.ToString(),
                        cas = uplynulycas,
                    });
            }
            else
            {
                if (v.cas> uplynulycas)
                {
                    v.cas = uplynulycas;
                }
            }
            form.databaze.SaveChanges();
        }

        protected abstract void VyhraVlastni();
        protected abstract void Reset();
    }
}
