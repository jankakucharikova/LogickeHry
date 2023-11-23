﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickeHry
{
    internal class Miny : Hra
    {
        static int hodnota_bomby = 1000;
        int[,] mapka;
        NumericUpDown Nvyska, Nsirka, Npocmin;
        TableLayoutPanel plocha;
        Label lcas, lmin, lpolicek;
        int uplynulycas;
        int sirka, vyska, pocmin, pocet_vlajek = 0, pocetpolicek;
        public Miny(GameForm form) : base(form)
        {
            Nazev = "Miny";
        }

        private void vytvor_tlacitka()
        {
            plocha.RowCount = vyska;
            plocha.ColumnCount = sirka;
            plocha.RowStyles.Clear();
            for (int i = 0; i < vyska; i++)
            {
                plocha.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / vyska));
            }
            plocha.ColumnStyles.Clear();
            for (int i = 0; i < vyska; i++)
            {
                plocha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / vyska));
            }
            for (int i = 0; i < sirka; i++)
            {
                for (int j = 0; j < vyska; j++)
                {
                    Button b = new Button();
                    b.Name = $"{i} {j}";
                    b.Text = "";
                    b.Dock = DockStyle.Fill;
                    b.Font = new Font("Segoe UI", b.Size.Height, FontStyle.Bold, GraphicsUnit.Point);
                    b.MouseDown += (s, e) => vyhodnot_kliknuti(s, e);
                    b.Margin = Padding.Empty;
                    b.Padding = Padding.Empty;
                    plocha.Controls.Add(b, i, j);
                }
            }
        }
        internal void vyhodnot_kliknuti(object s, MouseEventArgs e)
        {
            Button b = (Button)s;
            String[] x = b.Name.Split(' ');
            int i = int.Parse(x[0]);
            int j = int.Parse(x[1]);
            switch (e.Button)
            {
                case MouseButtons.Left:
                    levy_klik(b, i, j);
                    break;

                case MouseButtons.Right:
                    pravy_klik(b);
                    break;
            }
            Obnoveni();
        }
        public void levy_klik(Button b, int i, int j)
        {
            if (!b.Text.Equals("\U0001F6A9"))
            {
                if (mapka[i, j] != hodnota_bomby)
                {
                    b.Text = mapka[i, j].ToString();
                    pocetpolicek--;
                }
                else
                {
                    b.Text = "\U0001F4A3";
                    Prohra();
                }
                b.Enabled = false;
            }
        }

        public void pravy_klik(Button b)
        {
            if (!b.Text.Equals("\U0001F6A9"))
            {
                b.Text = "\U0001F6A9";
                pocet_vlajek++;
            }
            else
            {
                b.Text = "";
                pocet_vlajek--;
            }
        }

        private void generuj()
        {
            pocetpolicek = vyska * sirka - pocmin;
            List<int> vyber = new List<int>();
            for (int i = 0; i < vyska * sirka; i++)
            {
                vyber.Add(i < pocmin ? hodnota_bomby : 0);
            }
            Random rnd = new Random();
            for (int i = 0; i < sirka; i++)
            {
                for (int j = 0; j < vyska; j++)
                {
                    int r = rnd.Next() % vyber.Count;
                    mapka[i, j] = vyber[r];
                    vyber.RemoveAt(r);
                }
            }
            for (int i = 0; i < sirka; i++)
            {
                for (int j = 0; j < vyska; j++)
                {
                    if (mapka[i, j] != hodnota_bomby)
                    {
                        for (int k = Math.Max(0, i - 1); k < Math.Min(i + 2, sirka); k++)
                        {
                            for (int l = Math.Max(0, j - 1); l < Math.Min(j + 2, vyska); l++)
                            {
                                if (k != i || l != j)
                                    mapka[i, j] += mapka[k, l];
                            }
                        }
                        mapka[i, j] /= hodnota_bomby;
                    }
                }
            }

        }
        private void nastavRozmery(int vyska, int sirka, int pocbomb)
        {
            Nvyska.Value = vyska;
            Nsirka.Value = sirka;
            Npocmin.Value = pocbomb;
        }
        private void prepniVyber(bool zap)
        {
            Nvyska.Enabled = zap;
            Nsirka.Enabled = zap;
            Npocmin.Enabled = zap;

        }
        protected override void VytvorUvodniStranku()
        {
            //vytvorim rozlozeni
            form.HraBox.ColumnCount = 3;
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));

            form.HraBox.RowCount = 9;
            for (int i = 0; i < 9; i++)
            {
                form.HraBox.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / 9));
            }

            //vpravo obrazek
            PictureBox obrazek = new PictureBox()
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            form.HraBox.Controls.Add(obrazek, 0, 0);
            form.HraBox.SetRowSpan(obrazek, 9);

            //groupbox obtiznost
            GroupBox obtiznost = new GroupBox()
            {
                Dock = DockStyle.Fill,
                Text = "Obtížnost",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            };
            form.HraBox.Controls.Add(obtiznost, 1, 0);
            form.HraBox.SetRowSpan(obtiznost, 3);
            form.HraBox.SetColumnSpan(obtiznost, 2);
            //rozlozeni obtiznosti
            TableLayoutPanel obtiznostpanel = new TableLayoutPanel()
            {
                ColumnCount = 2,
                RowCount = 2,
                Dock = DockStyle.Fill
            };
            obtiznostpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            obtiznostpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            obtiznostpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            obtiznostpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            obtiznost.Controls.Add(obtiznostpanel);


            RadioButton lehke = new RadioButton()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Text = "Lehké",
                Checked = true,
                Dock = DockStyle.Fill,
            };
            lehke.CheckedChanged += (s, e) => { if (lehke.Checked) nastavRozmery(9, 9, 10); };
            obtiznostpanel.Controls.Add(lehke, 0, 0);

            RadioButton stredni = new RadioButton()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Text = "Střední",
                Dock = DockStyle.Fill
            };
            stredni.CheckedChanged += (s, e) => { if (stredni.Checked) nastavRozmery(16, 16, 40); };
            obtiznostpanel.Controls.Add(stredni, 1, 0);

            RadioButton tezke = new RadioButton()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Text = "Těžké",
                Dock = DockStyle.Fill
            };
            tezke.CheckedChanged += (s, e) => { if (tezke.Checked) nastavRozmery(30, 16, 99); };
            obtiznostpanel.Controls.Add(tezke, 0, 1);

            RadioButton vlastni = new RadioButton()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Text = "Vlastní",
                Dock = DockStyle.Fill
            };
            vlastni.CheckedChanged += (s, e) => prepniVyber(vlastni.Checked);
            obtiznostpanel.Controls.Add(vlastni, 1, 1);

            Label lvyska = new Label()
            {
                Text = "Výška:",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            form.HraBox.Controls.Add(lvyska, 1, 3);

            Label lsirka = new Label()
            {
                Text = "Šířka:",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            form.HraBox.Controls.Add(lsirka, 1, 4);

            Label lpocmin = new Label()
            {
                Text = "Počet min:",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            form.HraBox.Controls.Add(lpocmin, 1, 5);

            Nvyska = new NumericUpDown()
            {
                Value = 9,
                Minimum = 9,
                Maximum = 30,
                Increment = 1,
                DecimalPlaces = 0,
                Enabled = false,
                Dock = DockStyle.Fill
            };
            Nvyska.ValueChanged += (s, e) => Npocmin.Maximum = (Nvyska.Value - 1) * (Nsirka.Value - 1);
            form.HraBox.Controls.Add(Nvyska, 2, 3);

            Nsirka = new NumericUpDown()
            {
                Value = 9,
                Minimum = 9,
                Maximum = 24,
                Increment = 1,
                DecimalPlaces = 0,
                Enabled = false,
                Dock = DockStyle.Fill
            };
            Nsirka.ValueChanged += (s, e) => Npocmin.Maximum = (Nvyska.Value - 1) * (Nsirka.Value - 1);
            form.HraBox.Controls.Add(Nsirka, 2, 4);

            Npocmin = new NumericUpDown()
            {
                Value = 10,
                Minimum = 10,
                Maximum = 667,
                Increment = 1,
                DecimalPlaces = 0,
                Enabled = false,
                Dock = DockStyle.Fill
            };
            form.HraBox.Controls.Add(Npocmin, 2, 5);

            Button bnavod = new Button()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Návod",
            };
            form.HraBox.Controls.Add(bnavod, 1, 6);
            form.HraBox.SetColumnSpan(bnavod, 2);

            Button bstatistiky = new Button()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Statistiky",
            };
            form.HraBox.Controls.Add(bstatistiky, 1, 7);
            form.HraBox.SetColumnSpan(bstatistiky, 2);

            Button bhrat = new Button()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Hrát",
            };
            bhrat.Click += (s, e) => SpustiHru();
            form.HraBox.Controls.Add(bhrat, 1, 8);
            form.HraBox.SetColumnSpan(bhrat, 2);
        }

        protected override void NastavCasovac()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) => uplynulycas++;
            timer.Tick += (s, e) => Obnoveni();
            timer.Start();
        }
        internal void Obnoveni()
        {
            lcas.Text = TimeSpan.FromSeconds(uplynulycas).ToString(@"mm\:ss");
            lmin.Text = (pocmin - pocet_vlajek).ToString();
            lpolicek.Text = (pocetpolicek).ToString();
        }

        protected override void VytvorHerniStranku()
        {
            form.HraBox.ColumnCount = 3;
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70));
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));

            form.HraBox.RowCount = 6;
            for (int i = 0; i < 6; i++)
            {
                form.HraBox.RowStyles.Add(new RowStyle(SizeType.Percent, (float)100 / 6));
            }
            plocha = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
            };
            form.HraBox.Controls.Add(plocha, 0, 0);
            form.HraBox.SetRowSpan(plocha, 6);

            lcas = new Label()
            {
                Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point),
                Text = "0:00",
                Dock = DockStyle.Fill,
                TextAlign=ContentAlignment.MiddleCenter
            };
            form.HraBox.Controls.Add(lcas, 1, 0);
            form.HraBox.SetColumnSpan(lcas, 2);

            Label lm = new Label()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Text = "Zbývá min:",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };
            form.HraBox.Controls.Add(lm, 1, 1);

            lmin = new Label()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Text = pocmin.ToString(),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight
            };
            form.HraBox.Controls.Add(lmin, 2, 1);

            Label lp = new Label()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Text = "Zbývá volných políček:",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };
            form.HraBox.Controls.Add(lp, 1, 2);

            lpolicek = new Label()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Text = pocetpolicek.ToString(),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight
            };
            form.HraBox.Controls.Add(lpolicek, 2, 2);

            vytvor_tlacitka();
        }

        protected override void PouzijNastaveni()
        {
            sirka = (int)Nsirka.Value;
            vyska = (int)Nvyska.Value;
            pocmin = (int)Npocmin.Value;
            mapka = new int[sirka, vyska];
            generuj();
        }
    }
}
