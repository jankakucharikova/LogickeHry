using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickeHry
{
    internal abstract class Hra
    {
        internal GameForm form;
        internal String Nazev;
        public Hra(GameForm form)
        {
            this.form = form;
        }
        public void SmazHerniPole()
        {
            while (form.HraBox.Controls.Count > 0)
            {
                form.HraBox.Controls[0].Dispose();
            }
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
        }

        protected abstract void VytvorUvodniStranku();

        internal virtual void SpustiHru()
        {
            PouzijNastaveni();
            SmazHerniPole();
            VytvorHerniStranku();
            ZobrazStranku();
            NastavCasovac();
        }

        protected abstract void PouzijNastaveni();
        protected abstract void NastavCasovac();
        internal virtual void ZobrazStranku()
        {
            form.Ukazbox(form.HraBox);
        }

        protected abstract void VytvorHerniStranku();
        protected virtual void Prohra() { }
        protected virtual void Vyhra() { }
    }
}
