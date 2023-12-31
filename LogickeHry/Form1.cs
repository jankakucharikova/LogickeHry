﻿using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace LogickeHry
{
    public partial class GameForm : Form
    {
        List<TableLayoutPanel> boxy;
        internal Hra aktualnihra;
        internal DataContext databaze;
        internal Uzivatel aktualniuzivatel;
        public GameForm()
        {

            InitializeComponent();

            boxy = this.Controls.OfType<TableLayoutPanel>().ToList();
            databaze = new DataContext();
            databaze.Database.EnsureCreated();
            if (Properties.Settings.Default.prihlaseny)
            {
                aktualniuzivatel = databaze.uzivatele.FirstOrDefault(u => u.Id == Properties.Settings.Default.uzivatel);
                Prihlaseni(aktualniuzivatel);

            }
            Statistika.vysledky.Nastav(this);
        }
        internal void Ukazbox(TableLayoutPanel box)
        {
            foreach (var b in boxy)
                b.Hide();
            box.Show();
            box.Select();
        }
        string QuickHash(string input)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);
            var inputHash = SHA256.HashData(inputBytes);
            return Convert.ToHexString(inputHash);
        }
        private void PRBox_VisibleChanged(object sender, EventArgs e)
        {
            TableLayoutPanel t = (TableLayoutPanel)sender;
            if (t.Visible)
            {
                t.BringToFront();
                PRLPodnadpis.Text = t.Name;
                PRHlavicka.Show();
                PRHlavicka.BringToFront();
            }
            else
                PRHlavicka.Hide();
        }

        private void NastaveniBox_VisibleChanged(object sender, EventArgs e)
        {
            if (NastaveniBox.Visible)
            {
                NastaveniTBJmeno.Text = aktualniuzivatel.Jmeno;
                NastaveniCBPohlavi.Text = aktualniuzivatel.Pohlavi;
                NastaveniCBVek.Text = aktualniuzivatel.Vek;
                NastaveniBox.BringToFront();
                HlavniLPodnadpis.Text = "Nastavení";
                HlavniHlavicka.Show();
                HlavniHlavicka.BringToFront();
            }
            else
            {
                HlavniHlavicka.Hide();
            }
        }

        private void HlavniBox_VisibleChanged(object sender, EventArgs e)
        {
            TableLayoutPanel t = (TableLayoutPanel)sender;
            if (t.Visible)
            {
                t.BringToFront();
                HlavniLPodnadpis.Text = t.Name;
                HlavniHlavicka.Show();
                HlavniHlavicka.BringToFront();
            }
            else
            {
                HlavniHlavicka.Hide();
            }
        }

        private void HraBox_VisibleChanged(object sender, EventArgs e)
        {
            if (HraBox.Visible)
            {
                HraBox.BringToFront();
                HlavniLPodnadpis.Text = aktualnihra.Nazev;
                HlavniHlavicka.Show();
                HlavniHlavicka.BringToFront();
            }
            else
            {
                HlavniHlavicka.Hide();
            }
        }
        private void Odhlaseni()
        {
            Properties.Settings.Default.prihlaseny = false;
            Properties.Settings.Default.Save();
            aktualniuzivatel = null;
            ProfilBProfil.DropDownItems.Clear();
            ProfilBProfil.DropDownItems.AddRange(new ToolStripItem[] { ProfilBPrihlaseni, toolStripSeparator3, ProfilBRegistrace });
            ProfilBProfil.Text = $"👤 \n Nepřihlášený";
            MenuBMenu.DropDownItems.Remove(MenuBNastaveni);
            Ukazbox(UvodBox);
        }
        private void Prihlaseni(Uzivatel u)
        {
            aktualniuzivatel = u;
            Properties.Settings.Default.prihlaseny = true;
            Properties.Settings.Default.uzivatel = u.Id;
            Properties.Settings.Default.Save();
            ProfilBProfil.DropDownItems.Clear();
            ProfilBProfil.DropDownItems.AddRange(new ToolStripItem[] { ProfilLJmeno, ProfilLPohlavi, ProfilLVek, toolStripSeparator1, ProfilBNastaveni, toolStripSeparator2, ProfilBOdhlasit });
            ProfilBProfil.Text = $"👤 \n {aktualniuzivatel.Jmeno}";
            ProfilLJmeno.Text = aktualniuzivatel.Jmeno;
            ProfilLPohlavi.Text = aktualniuzivatel.Pohlavi;
            ProfilLVek.Text = aktualniuzivatel.Vek;
            MenuBMenu.DropDownItems.Add(MenuBNastaveni);
            Ukazbox(HlavniBox);
        }
        private void RegistraceBRegistrovat_Click(object sender, EventArgs e)
        {
            if (RegistraceTBJmeno.Text.Trim().Equals("") || RegistraceCBPohlavi.Text.Trim().Equals("") || RegistraceCBVek.Text.Trim().Equals("") || RegistraceTBHeslo.Text.Trim().Equals(""))
            {
                RegistraceChHlaska.Text = "Nejsou vyplněné všechny údaje";
                RegistraceChHlaska.Show();
            }
            else
            {
                if (!databaze.uzivatele.Any(u => u.Jmeno == RegistraceTBJmeno.Text.Trim()))
                {

                    Uzivatel u = new Uzivatel()
                    {
                        Jmeno = RegistraceTBJmeno.Text.Trim(),
                        Vek = RegistraceCBVek.Text.Trim(),
                        Pohlavi = RegistraceCBPohlavi.Text.Trim(),
                        HashHesla = QuickHash(RegistraceTBHeslo.Text.Trim())
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
                    RegistraceChHlaska.Text = "Uživatel už existuje";
                    RegistraceChHlaska.Show();
                }
            }
        }
        private void NastaveniBUlozit_Click(object sender, EventArgs e)
        {
            if (NastaveniTBJmeno.Text.Trim().Equals("") || NastaveniCBPohlavi.Text.Trim().Equals("") || NastaveniCBVek.Text.Trim().Equals("") || NastaveniTBHeslo.Text.Trim().Equals(""))
            {
                NastaveniLChHlaska.Text = "Nejsou vyplněné všechny údaje";
                NastaveniLChHlaska.Show();
            }
            else
            {
                if (aktualniuzivatel.Jmeno == NastaveniTBJmeno.Text.Trim() || !databaze.uzivatele.Any(u => u.Jmeno == NastaveniTBJmeno.Text.Trim()))
                {
                    aktualniuzivatel.Jmeno = NastaveniTBJmeno.Text.Trim();
                    aktualniuzivatel.Vek = NastaveniCBVek.Text.Trim();
                    aktualniuzivatel.Pohlavi = NastaveniCBPohlavi.Text.Trim();
                    aktualniuzivatel.HashHesla = QuickHash(NastaveniTBHeslo.Text.Trim());
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
                    NastaveniLChHlaska.Text = "Uživatel už existuje";
                    NastaveniLChHlaska.Show();
                }
            }
        }
        private void PrihlaseniBPrihlaseni_Click(object sender, EventArgs e)
        {
            Uzivatel u;
            if (null != (u = databaze.uzivatele.FirstOrDefault(u => u.Jmeno == PrihlaseniTBJmeno.Text.Trim())))
            {
                if (u.HashHesla == QuickHash(PrihlaseniTBHeslo.Text.Trim()))
                {
                    Prihlaseni(u);
                    PrihlaseniTBJmeno.Text = "";
                    PrihlaseniTBHeslo.Text = "";
                    PrihlaseniLChHlaska.Hide();

                }
                PrihlaseniLChHlaska.Text = "Špatné heslo";
                PrihlaseniLChHlaska.Show();

            }
            else
            {
                PrihlaseniLChHlaska.Text = "Neexistující uživatel";
                PrihlaseniLChHlaska.Show();
            }
        }
        private void BNastaveni_Click(object sender, EventArgs e)
        {
            Ukazbox(NastaveniBox);
        }
        private void BUvodPreskocit_Click(object sender, EventArgs e)
        {
            Ukazbox(HlavniBox);
        }
        private void PRBZpet_Click(object sender, EventArgs e)
        {
            Ukazbox(UvodBox);
        }
        private void BHlavniStranka_Click(object sender, EventArgs e)
        {
            Ukazbox(HlavniBox);
        }
        private void BOdhlaseni_Click(object sender, EventArgs e)
        {
            Odhlaseni();
            Ukazbox(UvodBox);
        }
        private void BPrihlaseni_Click(object sender, EventArgs e)
        {
            Ukazbox(PrihlaseniBox);
        }
        private void BRegistrace_Click(object sender, EventArgs e)
        {
            Ukazbox(RegistraceBox);
        }
        private void BStatistiky_Click(object sender, EventArgs e)
        {
            Ukazbox(StatistikaBox);
        }

        private void BMiny_Click(object sender, EventArgs e)
        {
            aktualnihra = new Miny(this);
            aktualnihra.SpustiUvod();
        }

        private void BLogik_Click(object sender, EventArgs e)
        {
            aktualnihra = new Logik(this);
            aktualnihra.SpustiUvod();
        }

        private void BSudoku_Click(object sender, EventArgs e)
        {
            aktualnihra = new Sudoku(this);
            aktualnihra.SpustiUvod();
        }

        private void StatistikaCBObtiznost_SelectedIndexChanged(object sender, EventArgs e)
        {
            Statistika.vysledky.Aktualizace(sender, e);
        }
    }
}