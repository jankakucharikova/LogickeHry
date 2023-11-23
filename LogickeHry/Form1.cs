namespace LogickeHry
{
    public partial class GameForm : Form
    {
        List<TableLayoutPanel> boxy;
        internal Hra aktualnihra;
        public GameForm()
        {

            InitializeComponent();
            boxy = this.Controls.OfType<TableLayoutPanel>().ToList();
        }
        internal void Ukazbox(TableLayoutPanel box)
        {
            foreach (var b in boxy)
                b.Hide();
            box.Show();
            box.Select();
        }
        private void ButtonPrihlaseni_Click(object sender, EventArgs e)
        {
            Ukazbox(PrihlaseniBox);
        }

        private void ButtonRegistrace_Click(object sender, EventArgs e)
        {
            UvodBox.Hide();
            RegistraceBox.Show();
            this.AutoSize = true;
        }

        private void UvodButtonPreskocit_Click(object sender, EventArgs e)
        {
            Ukazbox(HlavniBox);
        }
        private void PRBZpet_Click(object sender, EventArgs e)
        {
            Ukazbox(UvodBox);
        }

        private void PrihlaseniBPrihlaseni_Click(object sender, EventArgs e)
        {
            Ukazbox(HlavniBox);
        }

        private void RegistraceBRegistrovat_Click(object sender, EventArgs e)
        {
            Ukazbox(HlavniBox);
        }


        private void ButtonNastaveni_Click(object sender, EventArgs e)
        {
            HlavniHlavicka.Hide();
            NastaveniBox.Show();
        }

        private void RegistraceBox_VisibleChanged(object sender, EventArgs e)
        {
            if (RegistraceBox.Visible)
            {
                RegistraceBox.BringToFront();
                PRLPodnadpis.Text = "Registrace";
                PRHlavicka.Show();
                PRHlavicka.BringToFront();
            }
            else
                PRHlavicka.Hide();
        }

        private void PrihlaseniBox_VisibleChanged(object sender, EventArgs e)
        {
            if (PrihlaseniBox.Visible)
            {
                PrihlaseniBox.BringToFront();
                PRLPodnadpis.Text = "Prihlaseni";
                PRHlavicka.Show();
                PRHlavicka.BringToFront();
            }
            else
                PRHlavicka.Hide();
        }

        private void prihlaseny_CheckedChanged(object sender, EventArgs e)
        {
            if (prihlaseny.Checked)
            {
                ProfilBProfil.DropDownItems.Clear();
                ProfilBProfil.DropDownItems.AddRange(new ToolStripItem[] { ProfilLJmeno, ProfilLPohlavi, ProfilLVek, toolStripSeparator1, ProfilBNastaveni, toolStripSeparator2, ProfilBOdhlasit });
            }
            else
            {
                ProfilBProfil.DropDownItems.Clear();
                ProfilBProfil.DropDownItems.AddRange(new ToolStripItem[] { ProfilBPrihlaseni, toolStripSeparator3, ProfilBRegistrace });

            }
        }

        private void NastaveniBox_VisibleChanged(object sender, EventArgs e)
        {
            if (NastaveniBox.Visible)
            {
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
            if (HlavniBox.Visible)
            {
                HlavniBox.BringToFront();
                HlavniLPodnadpis.Text = "Hlavní stránka";
                HlavniHlavicka.Show();
                HlavniHlavicka.BringToFront();
            }
            else
            {
                HlavniHlavicka.Hide();
            }
        }

        private void ButtonHlavniStranka_Click(object sender, EventArgs e)
        {
            Ukazbox(HlavniBox);
        }
        private void ButtonOdhlaseni_Click(object sender, EventArgs e)
        {
            Ukazbox(UvodBox);
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

        private void HlavniBMiny_Click(object sender, EventArgs e)
        {
            aktualnihra = new Miny(this);
            aktualnihra.SpustiUvod();
        }

        private void HlavniBLogik_Click(object sender, EventArgs e)
        {
            aktualnihra = new Logik(this);
            aktualnihra.SpustiUvod();
        }
    }
}