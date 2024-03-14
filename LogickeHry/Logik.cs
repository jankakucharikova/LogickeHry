﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickeHry
{
    internal class Logik : Hra
    {
        List<Bitmap> obrazky;
        NumericUpDown Nvyber, Nmoznosti;
        CheckBox CBopakovani;
        RadioButton lehke, stredni, tezke, vlastni;
        int[] kod;
        int kolik, z;
        Size velikost_radku = new Size(30, 30);
        Size velikost_kolecek = new Size(20, 20);
        Size velikost_puntiku = new Size(10, 10);
        TableLayoutPanel vysledky;
        int aktualniradek = 1;
        TableLayoutPanel aktualnityp;
        Button testButton, clear;
        int odcitanibile, odcitanispatne;
        
        public Logik(GameForm form) : base(form)
        {
            Nazev = "Logik";
            obrazky = NactiIkonky(LogickeHry.Properties.Resources.logik);
            navod = "Hráč hádá barevnou kombinaci o počtu koleček, který si hráč sám zvolí. Barvy se mohou opakovat, pokud si tak hráč zvolí. \r\nHráč musí uhodnout barevnou kombinaci a její správné pořadí ve dvanácti krocích.\r\nHráč vybírá barvy ze spodní lišty. Pokud vyplnil všechny políčka může zažádat o kontrolu tlačítkem „Test“. \r\nPokud chce svou odpověď změnit, smaže svůj výběr tlačítkem „Clear“. \r\nKaždý odehraný pokus je vyhodnocený černými a bílými puntíky. Za každé kolečko, které udává správnou barvu, ale je na špatném místě, se uděluje bílý puntík. Za každé kolečko se správnou barvou na správném místě se dává černý puntík. Pořadí puntíků není stejné jako pořadí koleček, zobrazují se vždy nejprve černé a pak bílé puntíky.\r\nPokud chce hráč vygenerovat novou barevnou kombinaci stiskne tlačítko „Nová hra“.\r\nStisknutím tlačítka „Ukončit hru“ se hráč dostane zpět na úvodní stránku hry.\r\nHra končí v momentě, kdy je uhodnuta barevná kombinace nebo je-li vyčerpáno všech 12 pokusů. \r\nObtížnost:\r\nLehká: 4-místný kód ze 6 barev\r\nStřední: 5-místný kód z 8 barev\r\nTěžká: 6-místný kód z 10 barev\r\nVlastní: 4 až 10-místný kód ze 4 až 10 barev\r\n";
        }
        protected override void KonecHry()
        {
            stopky.Stop();
            ukazVysledek();
            clear.Enabled= false;
            testButton.Enabled= false;
        }

        protected override void PouzijNastaveni()
        {
            kolik = (int)Nvyber.Value;
            z=(int)Nmoznosti.Value;
            kod=new int[kolik];
            List<int> v=new List<int>();
            for (int i = 0;i<z;i++)
            {
                v.Add(i);
            }
            Random rnd= new Random();
            for(int i = 0; i<kolik;i++)
            {
                int r = rnd.Next() % v.Count;
                kod[i] = v[r];
                if(!CBopakovani.Checked)
                {
                    v.RemoveAt(r);
                }
            }
        }

        protected override void ProhraVlastni() { }
           

        protected override void Reset()
        {
            kod = null;
            kolik = 0;
            z=0;
            aktualniradek = 1;
            uplynulycas = 0;
            if (stopky != null)
            {
                stopky.Dispose();
            }
        }

        protected override void VyhraVlastni(){ }

        protected override void VytvorHerniPlochu()
        {
            switch (obtiznost)
            {
                case Obtiznost.Tezke:
                    ziskaneskore = 37200;
                    odcitanibile = 258;
                    odcitanispatne = 516;
                    break;
                case Obtiznost.Stredni:
                    ziskaneskore = 20800;
                    odcitanibile = 173;
                    odcitanispatne = 346;
                    break;
                case Obtiznost.Lehke:
                    ziskaneskore = 8400;
                    odcitanibile = 87;
                    odcitanispatne = 175;
                    break;
                default:
                    ziskaneskore = 0;
                    break;
            }
            plocha = new TableLayoutPanel()
            {
                CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble,
                Anchor = AnchorStyles.None,
                AutoSize = true,
                BackColor = Color.Peru,
                Visible = false
            };
            form.HraBox.Controls.Add(plocha, 0, 0);
            form.HraBox.SetRowSpan(plocha, 14);
            plocha.RowStyles.Clear();
            plocha.ColumnStyles.Clear();
            for (int i = 0; i < 14; i++)
            {
                plocha.RowStyles.Add(new RowStyle(SizeType.Absolute, velikost_radku.Height));
            }
            plocha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, velikost_radku.Width * 2));
            plocha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, velikost_radku.Width * kolik));
            plocha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, velikost_radku.Width * kolik));
            plocha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, velikost_kolecek.Width * kolik));
            for (int i = 0; i < 12; i++)
            {
                plocha.Controls.Add(new Label()
                {
                    Text = (i + 1).ToString(),
                    Font = new Font("Segoe UI", 10, FontStyle.Regular, GraphicsUnit.Point),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                }, 0, 12 - i);
            }
            TableLayoutPanel buttonybarev = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = z+1,
                BackColor = Color.Peru,
            };
            plocha.Controls.Add(buttonybarev, 1, 13);
            plocha.SetColumnSpan(buttonybarev, 3);
            for (int i = 0; i < z; i++)
            {
                buttonybarev.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, velikost_radku.Width));
                PictureBox b = new PictureBox()
                {
                    Name = i.ToString(),
                    BackgroundImage = obrazky[i],
                    BackgroundImageLayout=ImageLayout.Stretch,
                    Size = velikost_kolecek
                };
                b.Click += klikNaBarvu;
                buttonybarev.Controls.Add(b, i, 0);
            }
            buttonybarev.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            vysledky = novyPanel();
            for (int i = 0; i < kolik; i++)
            {
                PictureBox l = new PictureBox()
                {
                    Name = kod[i].ToString(),
                    BackgroundImage= obrazky[11],
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Size = velikost_kolecek
                };
                vysledky.Controls.Add(l, i, 0);
            }
            plocha.Controls.Add(vysledky, 1, 0);
            aktualnityp = novyPanel();
            plocha.Controls.Add(aktualnityp, 1, 12);
            testButton = new RoundedButton()
            {
                Text = "Test",
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            testButton.Font=new Font(testButton.Font,FontStyle.Bold);
            testButton.Click += Test;
            plocha.Controls.Add(testButton, 2, 12);
            clear = new RoundedButton()
            {
                Text = "Clear",
                Dock = DockStyle.Fill,
                BackColor= Color.White
                
            };
            clear.Click += (s, e) =>
            {
                if (Stav != StavHry.Bezi)
                    return;
                aktualnityp.Controls.Clear();
            };
            plocha.Controls.Add(clear, 3, 12);
            plocha.Visible = true;
        }

        private void Test(object? sender, EventArgs e)
        {
            if (Stav != StavHry.Bezi)
                return;
            if (aktualnityp.Controls.Count < kolik)
                return;
            plocha.SuspendLayout();
            TableLayoutPanel odpoved = novyPanel();
            List<int> spravne= new List<int>();
            spravne.AddRange(kod);
            List<int> tip = new List<int>();
            foreach(Control c in aktualnityp.Controls) { 
                tip.Add(int.Parse(c.Name));
            }

            for(int i = 0;i < tip.Count; i++)
            {
                if (spravne[i] == tip[i])
                {
                    odpoved.Controls.Add(new PictureBox()
                    {
                        BackgroundImage = obrazky[10],
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Size = velikost_puntiku
                    });
                    spravne.RemoveAt(i);
                    tip.RemoveAt(i);
                    i--;
                }
            }
            if(spravne.Count == 0) { Vyhra();return; }
            if (aktualniradek == 12) { Prohra(); return; }
            for (int i = 0; i < tip.Count; i++)
            {
                if (spravne.Contains(tip[i]))
                {
                    odpoved.Controls.Add(new PictureBox()
                    {
                        BackgroundImage = obrazky[11],
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Size= velikost_puntiku
                    });
                    spravne.Remove(tip[i]);
                    tip.RemoveAt(i);
                    i--;
                    ziskaneskore -= odcitanibile;
                }
            }
            ziskaneskore -= spravne.Count() * odcitanispatne;
            aktualnityp = novyPanel();
            
            plocha.Controls.Remove(clear);
            plocha.Controls.Remove(testButton);
            plocha.Controls.Add(aktualnityp, 1, 12 - aktualniradek);
            plocha.Controls.Add(testButton, 2, 12 - aktualniradek);
            plocha.Controls.Add(clear, 3, 12 - aktualniradek);
            plocha.Controls.Add(odpoved, 2, 13 - aktualniradek);
            aktualniradek++;
            plocha.ResumeLayout();
        }

        private void klikNaBarvu(object? sender, EventArgs e)
        {
            if (Stav != StavHry.Bezi)
                return;
            if (aktualnityp.Controls.Count < kolik)
            {
                
                PictureBox l = (PictureBox)sender;
                if (!CBopakovani.Checked) {
                    foreach (Control c in aktualnityp.Controls) {
                        if (c.Name.Equals(l.Name))
                            return;
                    }
                }
                aktualnityp.Controls.Add(new PictureBox()
                {
                    Name = l.Name,
                    BackgroundImage = obrazky[int.Parse(l.Name)],
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Size = velikost_kolecek
                });
            }
        }
        private TableLayoutPanel novyPanel()
        {
            TableLayoutPanel typ = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = kolik+1,
            };
            for (int i = 0; i < kolik; i++)
            {
                typ.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, velikost_radku.Width));
            }
            typ.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            return typ;
        }

        protected override void VytvorBocniPanel()
        {
            form.HraBox.ColumnCount = 3;
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            form.HraBox.RowCount = 14;
            for (int i = 0; i < 14; i++)
            {
                form.HraBox.RowStyles.Add(new RowStyle(SizeType.Percent, (float)100 / 14));
            }
            lcas = new Label()
            {
                Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point),
                Text = "0:00",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            form.HraBox.Controls.Add(lcas, 1, 0);
            form.HraBox.SetColumnSpan(lcas, 2);
            form.HraBox.SetRowSpan(lcas, 5);

            Label lopakovani = new Label()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Text = "Opakování barev:",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            form.HraBox.Controls.Add(lopakovani, 1, 5);
            form.HraBox.SetRowSpan(lopakovani, 3);
            Label lo = new Label()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Text = CBopakovani.Checked ? "Zapnuto" : "Vypnuto",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            form.HraBox.Controls.Add(lo, 2, 5);
            form.HraBox.SetRowSpan(lo, 3);

            Button restart = new RoundedButton()
            {
                Text = "Nová hra",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point),
                TextAlign = ContentAlignment.MiddleCenter
            };
            restart.Click += (s, e) => { SpustiHru(); };
            form.HraBox.Controls.Add(restart, 1, 8);
            form.HraBox.SetColumnSpan(restart, 2);
            form.HraBox.SetRowSpan(restart, 3);

            Button ukoncit = new RoundedButton()
            {
                Text = "Ukončit hru",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point),
                TextAlign = ContentAlignment.MiddleCenter
            };
            ukoncit.Click += (s, e) => { SpustiUvod(); };
            form.HraBox.Controls.Add(ukoncit, 1, 11);
            form.HraBox.SetColumnSpan(ukoncit, 2);
            form.HraBox.SetRowSpan(ukoncit, 3);

        }

        private void ukazVysledek()
        {
            foreach(var x in vysledky.Controls)
            {
                PictureBox l =(PictureBox)x;
                l.BackgroundImage = obrazky[int.Parse(l.Name)];
            }
        }
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
                    Image = Properties.Resources.logik_uvod
                };
                form.HraBox.Controls.Add(obrazek, 0, 0);
                form.HraBox.SetRowSpan(obrazek, 9);

                //groupbox obtiznost
                GroupBox obtiznost = new GroupBox()
                {
                    Dock = DockStyle.Fill,
                    Text = "Obtížnost",
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    FlatStyle = FlatStyle.Flat,
                    
                };  
                form.HraBox.Controls.Add(obtiznost, 1, 0);
                form.HraBox.SetRowSpan(obtiznost, 3);
                form.HraBox.SetColumnSpan(obtiznost, 2);
                //rozlozeni obtiznosti
                TableLayoutPanel obtiznostpanel = new TableLayoutPanel()
                {
                    ColumnCount = 2,
                    RowCount = 2,
                    Dock = DockStyle.Fill,
                    BackColor = Color.Transparent

        };
                obtiznostpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                obtiznostpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                obtiznostpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                obtiznostpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                obtiznost.Controls.Add(obtiznostpanel);

                Label lvyber = new Label()
                {
                    Text = "Délka kódu:",
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                form.HraBox.Controls.Add(lvyber, 1, 3);

                Label lmoznosti = new Label()
                {
                    Text = "Počet barev:",
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                form.HraBox.Controls.Add(lmoznosti, 1, 4);

                               

                if (Nvyber == null || Nmoznosti == null || CBopakovani == null || lehke == null || stredni == null || tezke == null || vlastni == null)
                {
                    lehke = new RadioButton()
                    {
                        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                        Text = "Lehké",
                        Checked = true,
                        Dock = DockStyle.Fill,
                    };
                    lehke.CheckedChanged += (s, e) =>
                    {
                        if (lehke.Checked)
                        {
                            Nvyber.Value = 4;
                            Nmoznosti.Value = 6;
                            this.obtiznost = Obtiznost.Lehke;
                        }
                    };

                    stredni = new RadioButton()
                    {
                        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                        Text = "Střední",
                        Dock = DockStyle.Fill
                    };
                    stredni.CheckedChanged += (s, e) =>
                    {
                        if (stredni.Checked)
                        {
                            Nvyber.Value = 5;
                            Nmoznosti.Value = 8;
                            this.obtiznost = Obtiznost.Stredni;
                        }
                    };

                tezke = new RadioButton()
                    {
                        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                        Text = "Těžké",
                        Dock = DockStyle.Fill
                    };
                tezke.CheckedChanged += (s, e) =>
                {
                    if (tezke.Checked)
                    {
                        Nvyber.Value = 6;
                        Nmoznosti.Value = 10;
                        this.obtiznost = Obtiznost.Tezke;
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
                    Nvyber.Enabled=vlastni.Checked;
                    Nmoznosti.Enabled=vlastni.Checked;
                    if (vlastni.Checked)
                    {
                        this.obtiznost = Obtiznost.Vlastni;
                    }
                    
                };


                    Nvyber = new NumericUpDown()
                    {
                        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                        Value = 4,
                        Minimum = 4,
                        Maximum = 6,
                        Increment = 1,
                        DecimalPlaces = 0,
                        Dock = DockStyle.Fill,
                        Enabled = false,
                    };


                    Nmoznosti = new NumericUpDown()
                    {
                        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                        Value = 6,
                        Minimum = 4,
                        Maximum = 10,
                        Increment = 1,
                        DecimalPlaces = 0,
                        Enabled = false,
                        Dock = DockStyle.Fill
                    };
                Nmoznosti.ValueChanged += (s, e) => { 
                    if(!CBopakovani.Checked)
                        Nvyber.Maximum = Nmoznosti.Value;
                };

                    CBopakovani = new CheckBox()
                    {
                        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                        Dock = DockStyle.Fill,
                        Text = "S opakovanim"
                    };
                CBopakovani.CheckedChanged += (s, e) =>
                {
                    if (!CBopakovani.Checked)
                        Nvyber.Maximum = Nmoznosti.Value;
                    else
                        Nvyber.Maximum = 10;
                };
                }
                obtiznostpanel.Controls.Add(lehke, 0, 0);
                obtiznostpanel.Controls.Add(stredni, 1, 0);
                obtiznostpanel.Controls.Add(tezke, 0, 1);
                obtiznostpanel.Controls.Add(vlastni, 1, 1);
                form.HraBox.Controls.Add(Nvyber, 2, 3);
                form.HraBox.Controls.Add(Nmoznosti, 2, 4);
                form.HraBox.Controls.Add(CBopakovani, 1, 5);
                form.HraBox.SetColumnSpan(CBopakovani, 2);

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
                    Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = "Hrát",
                };
                bhrat.Click += (s, e) => SpustiHru();
                form.HraBox.Controls.Add(bhrat, 1, 8);
                form.HraBox.SetColumnSpan(bhrat, 2);
            }
    }
}
