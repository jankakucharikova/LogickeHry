namespace LogickeHry
{
    internal enum StavHry
    {
        Pripravena, Bezi, Prohra, Vyhra
    }
    internal abstract class Hra
    {
        internal GameForm form;
        internal string Nazev;
        internal StavHry Stav;
        internal System.Windows.Forms.Timer stopky;
        internal int uplynulycas;
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
        protected abstract void NastavCasovac();
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
        }

        protected abstract void VyhraVlastni();
        protected abstract void Reset();
    }
}
