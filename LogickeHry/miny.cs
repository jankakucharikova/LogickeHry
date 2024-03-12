
namespace LogickeHry
{
    internal class Miny : Hra
    {

        List<Bitmap> obrazky;
        const int hodnota_bomby = 1000;
        static readonly Color[] barvy = { Color.Gray, Color.Blue, Color.Green, Color.Red, Color.Purple, Color.LightBlue, Color.Pink, Color.Orange, Color.LightGreen };
        int[,] mapka;
        NumericUpDown Nvyska, Nsirka, Npocmin;
        RadioButton lehke, stredni, tezke, vlastni;
        Label lmin, lpolicek;
        Button hint;
        int hintu = 3;
        List<Button> tlacitka;
        int sirka, vyska, pocmin, pocet_vlajek, pocetpolicek;
        public Miny(GameForm form) : base(form)
        {
            Nazev = "Miny";
            obrazky= NactiIkonky(LogickeHry.Properties.Resources.miny);
            navod = "Pole je poseto minami, které musí hráč najít a neodkrýt, nebo je označit pravým tlačítkem myši (vlajkou). \r\nKliknutím na poličko se hráč doví jestli políčko obsahuje minu nebo nikoliv. Pokud jo, hra je ukončena prohrou, pokud ne, na políčku se objeví číslo s počtem bomb v jejím nejbližším okolí (na všech osmi políčkách s ním sousedících). \r\nPokud je zřejmé, že některé neodkryté políčko obsahuje minu, hráč může pro přehlednost označit políčko vlaječkou. Tímto se stává políčko neaktivní pro další neúmyslné odkrytí.\r\nHráč může také použít 3 hinty, kdy je odhaleno náhodné bezpečné políčko.\r\nTlačítko „Nová hra“ vygeneruje nové hrací pole.\r\nStisknutím tlačítka „Ukončit hru“ se hráč dostane zpět na úvodní stránku hry.\r\nPo správném označení všech políček s minami, nebo odkrytí všech polí bez min hráč vyhrává.\r\nObtížnost: \r\nLehká: pole o velikosti 9x9, počet min 10\r\nStřední: pole o velikosti 16x16, počet min 40\r\nTěžká: pole o velikosti 30x16, počet min 99\r\nVlastní: pole o velikosti 9x9 – 30x24, počet min 10–667, maximálně (x − 1) × (y − 1); x, y = rozměry hracího pole\r\n";
        }

        //reset do uvodniho stavu
        protected override void Reset()
        {
            hintu = 3;
            vyska = 0;
            sirka = 0;
            pocmin = 0;
            pocet_vlajek = 0;
            pocetpolicek = 0;
            uplynulycas = 0;
            if (stopky != null)
            {
                stopky.Dispose();
            }
            
        }

        //Nastav Uvod
        protected override void VytvorUvodniStranku()
        {
            //vytvorim rozlozeni
            form.HraBox.ColumnCount = 3;
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));

            form.HraBox.RowCount = 9;
            for (int i = 0; i < 9; i++)
            {
                form.HraBox.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / 9));
            }

            //vlevo obrazek
            PictureBox obrazek = new PictureBox()
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.CenterImage,
                Image = Properties.Resources.miny_uvod
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

            if (Nvyska == null || Nsirka == null || Npocmin == null || lehke == null || stredni == null || tezke == null || vlastni == null)
            {
                lehke = new RadioButton()
                {
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Text = "Lehké",
                    Checked = true,
                    Dock = DockStyle.Fill,
                };
                lehke.CheckedChanged += (s, e) => {
                    if (lehke.Checked) { 
                        nastavRozmery(9, 9, 10);
                        this.obtiznost = Obtiznost.Lehke;
                    }
                };


                stredni = new RadioButton()
                {
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Text = "Střední",
                    Dock = DockStyle.Fill
                };
                stredni.CheckedChanged += (s, e) => {
                    if (stredni.Checked)
                    {
                        nastavRozmery(16, 16, 40);
                        this.obtiznost = Obtiznost.Stredni;
                    } 
                };

                tezke = new RadioButton()
                {
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Text = "Těžké",
                    Dock = DockStyle.Fill
                };
                tezke.CheckedChanged += (s, e) => {
                    if (tezke.Checked)
                    {
                        nastavRozmery(30, 16, 99);
                        this.obtiznost= Obtiznost.Tezke;
                    }
                };


                vlastni = new RadioButton()
                {
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Text = "Vlastní",
                    Dock = DockStyle.Fill
                };
                vlastni.CheckedChanged += (s, e) =>
                {
                    prepniNaVlastni(vlastni.Checked);
                    if (vlastni.Checked)
                    {
                        this.obtiznost = Obtiznost.Vlastni;
                    }
                };


                Nvyska = new NumericUpDown()
                {
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Value = 9,
                    Minimum = 9,
                    Maximum = 30,
                    Increment = 1,
                    DecimalPlaces = 0,
                    Dock = DockStyle.Fill,
                    Enabled = false,
                };
                Nvyska.ValueChanged += (s, e) => Npocmin.Maximum = (Nvyska.Value - 1) * (Nsirka.Value - 1);


                Nsirka = new NumericUpDown()
                {
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Value = 9,
                    Minimum = 9,
                    Maximum = 24,
                    Increment = 1,
                    DecimalPlaces = 0,
                    Enabled = false,
                    Dock = DockStyle.Fill
                };
                Nsirka.ValueChanged += (s, e) => Npocmin.Maximum = (Nvyska.Value - 1) * (Nsirka.Value - 1);


                Npocmin = new NumericUpDown()
                {
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Value = 10,
                    Minimum = 10,
                    Maximum = 667,
                    Increment = 1,
                    DecimalPlaces = 0,
                    Enabled = false,
                    Dock = DockStyle.Fill
                };
            }
            obtiznostpanel.Controls.Add(lehke, 0, 0);
            obtiznostpanel.Controls.Add(stredni, 1, 0);
            obtiznostpanel.Controls.Add(tezke, 0, 1);
            obtiznostpanel.Controls.Add(vlastni, 1, 1);
            form.HraBox.Controls.Add(Nvyska, 2, 3);
            form.HraBox.Controls.Add(Nsirka, 2, 4);
            form.HraBox.Controls.Add(Npocmin, 2, 5);

            Button bnavod = new RoundedButton()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Návod",
            };
            bnavod.Click += UkazNavod;
            form.HraBox.Controls.Add(bnavod, 1, 6);
            form.HraBox.SetColumnSpan(bnavod, 2);

            Button bstatistiky = new RoundedButton()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = "Statistiky",
            };
            bstatistiky.Click += (s, e) =>
            {
                form.StatistikyCBHra.Text = Nazev;
                form.Ukazbox(form.StatistikaBox);
            };
            form.HraBox.Controls.Add(bstatistiky, 1, 7);
            form.HraBox.SetColumnSpan(bstatistiky, 2);

            Button bhrat = new RoundedButton()
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

        //Pouzij nastaveni
        protected override void PouzijNastaveni()
        {
            sirka = (int)Nsirka.Value;
            vyska = (int)Nvyska.Value;
            pocmin = (int)Npocmin.Value;
            mapka = new int[sirka, vyska];
            generuj();
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

        protected override void VytvorBocniPanel()
        {
            form.HraBox.ColumnCount = 3;
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));

            form.HraBox.RowCount = 6;
            for (int i = 0; i < 6; i++)
            {
                form.HraBox.RowStyles.Add(new RowStyle(SizeType.Percent, (float)100 / 6));
            }


            lcas = new Label()
            {
                Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point),
                Text = "0:00",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
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

            hint = new RoundedButton()
            {
                Text = $"Hint({hintu})",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                TextAlign = ContentAlignment.MiddleCenter
            };
            hint.Click += Hint_Click;
            
            form.HraBox.Controls.Add(hint, 1, 3);
            form.HraBox.SetColumnSpan(hint, 2);

            Button restart = new RoundedButton()
            {
                Text = "Nová hra",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                TextAlign = ContentAlignment.MiddleCenter
            };
            restart.Click += (s, e) => { SpustiHru(); };
            form.HraBox.Controls.Add(restart, 1, 4);
            form.HraBox.SetColumnSpan(restart, 2);

            Button ukoncit = new RoundedButton()
            {
                Text = "Ukončit hru",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                TextAlign = ContentAlignment.MiddleCenter
            };
            ukoncit.Click += (s, e) => { SpustiUvod(); };
            form.HraBox.Controls.Add(ukoncit, 1, 5);
            form.HraBox.SetColumnSpan(ukoncit, 2);

        }

        private void Hint_Click(object? sender, EventArgs e)
        {
            if (Stav != StavHry.Bezi)
                return;
            if (hintu < 1)
                return;
            hintu--;
            hint.Text = $"Hint({hintu})";
            Random rnd = new Random();
            var kliknutelne = from b in tlacitka where jeKliknutelne(b)==true select b;
            Button k = kliknutelne.ElementAt(rnd.Next() % kliknutelne.Count());
            levy_klik(k);
        }
        private bool jeKliknutelne(Button b)
        {
            String[] parametry = b.Name.Split(" ");
            int i = int.Parse(parametry[0]);
            int j = int.Parse(parametry[1]);
            if (parametry[2].Equals("true"))
                return false;
            if (parametry[3].Equals("false"))
                return false;
            return mapka[i, j] != hodnota_bomby;
        }

        protected override void VytvorHerniPlochu()
        {
            tlacitka = new List<Button>();
            plocha = new TableLayoutPanel()
            {
                Anchor = AnchorStyles.None,
                AutoScroll = true,
                AutoSize = true,
            };
            form.HraBox.Controls.Add(plocha, 0, 0);
            form.HraBox.SetRowSpan(plocha, 6);
            plocha.Visible = false;
            Size rozmerbuttonu = new Size(50, 50);
            plocha.RowCount = vyska;
            plocha.ColumnCount = sirka;
            plocha.RowStyles.Clear();
            for (int i = 0; i < vyska; i++)
            {
                plocha.RowStyles.Add(new RowStyle(SizeType.Absolute, rozmerbuttonu.Height));
            }
            plocha.ColumnStyles.Clear();
            for (int i = 0; i < sirka; i++)
            {
                plocha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, rozmerbuttonu.Width));
            }
            for (int i = 0; i < sirka; i++)
            {
                for (int j = 0; j < vyska; j++)
                {
                    Button b = new Button();
                    b.Name = $"{i} {j} false true";
                    b.Image = obrazky[11];
                    b.Size = rozmerbuttonu;
                    b.Anchor = AnchorStyles.None;
                    b.Font = new Font("Segoe UI", 14, FontStyle.Bold, GraphicsUnit.Point);
                    b.MouseDown += (s, e) => vyhodnot_kliknuti(s, e);
                    b.Margin = new Padding(0);
                    b.Padding = new Padding(0);
                    tlacitka.Add(b);
                    plocha.Controls.Add(b, i, j);
                }
            }
            plocha.Visible = true;
        }

        //Procedury vyvolavane eventy
        internal void vyhodnot_kliknuti(object s, MouseEventArgs e)
        {
            if (Stav != StavHry.Bezi)
                return;
            Button b = (Button)s;
            String[] x = b.Name.Split(' ');
            String enabled = x[3];
            if (!enabled.Equals("true"))
                return;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    levy_klik(b);
                    break;

                case MouseButtons.Right:
                    pravy_klik(b);
                    break;
            }
            b.Parent.Select();
            Obnoveni();

        }
        public void levy_klik(Button b, bool konec=false)
        {
            String[] parametry = b.Name.Split(' ');
            String enabled = parametry[3];
            int i = int.Parse(parametry[0]);
            int j = int.Parse(parametry[1]);
            if (!enabled.Equals("true"))
                return;  
            
            string vlajka = parametry[2];
            b.Name = $"{i} {j} {vlajka} false";
            if (vlajka.Equals("false"))
            {
                if (mapka[i, j] != hodnota_bomby)
                {
                    b.Image = obrazky[mapka[i, j]];
                    pocetpolicek--;
                    if(mapka[i, j]==0)
                    foreach(Button t in tlacitka)
                    {
                            String[] s = t.Name.Split(' ');
                            int x = int.Parse(s[0]);
                            int y = int.Parse(s[1]);
                            if (Math.Abs(i-x)<=1 && Math.Abs(j-y)<=1)
                            {
                                levy_klik(t);
                            }
                    }
                }
                else
                {
                    b.Image = obrazky[9];
                    if(Stav==StavHry.Bezi)Prohra();
                    b.BackColor = Color.Red;
                }
                
            }
            else if (konec)
            {
                if(mapka[i, j] != hodnota_bomby)
                    b.Image= obrazky[12];
            }
        }
        public void pravy_klik(Button b)
        {
            String[] x = b.Name.Split(' ');
            int i = int.Parse(x[0]);
            int j = int.Parse(x[1]);
            String vlajka = x[2];
            String enabled = x[3];
            if (!enabled.Equals("true"))
                return;
            if (vlajka.Equals("false"))
            {
                b.Image = obrazky[10];
                pocet_vlajek++;
                b.Name = $"{i} {j} true {enabled}";
            }
            else
            {
                b.Image = obrazky[11];
                pocet_vlajek--;
                b.Name = $"{i} {j} false {enabled}";
            }
        }


        private void nastavRozmery(int vyska, int sirka, int pocbomb)
        {
            Nvyska.Value = vyska;
            Nsirka.Value = sirka;
            Npocmin.Value = pocbomb;
        }
        private void prepniNaVlastni(bool zap)
        {
            Nvyska.Enabled = zap;
            Nsirka.Enabled = zap;
            Npocmin.Enabled = zap;

        }


        internal void Obnoveni()
        {
            lmin.Text = (pocmin - pocet_vlajek).ToString();
            lpolicek.Text = (pocetpolicek).ToString();
            if (pocetpolicek == 0 && Stav == StavHry.Bezi)
                Vyhra();
        }

        protected override void KonecHry()
        {
            stopky.Stop();
        }

        protected override void ProhraVlastni()
        {
            Stav = StavHry.Prohra;
            foreach (var v in plocha.Controls)
            {
                Button b = (Button)v;
                levy_klik(b,true);
            }
        }

        protected override void VyhraVlastni()
        {
            Stav = StavHry.Vyhra;
        }


    }
}
