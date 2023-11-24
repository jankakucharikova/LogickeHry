using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickeHry
{
    internal class Logik : Hra
    {
        static readonly Color[] barvy = { Color.DeepSkyBlue, Color.Green, Color.Red, Color.Yellow, Color.Orange, Color.Magenta, Color.Sienna, Color.Pink, Color.GreenYellow,Color.MediumBlue };
        NumericUpDown Nvyber, Nmoznosti;
        CheckBox CBopakovani;
        RadioButton lehke, stredni, tezke, vlastni;
        int[] kod;
        int kolik, z;
        TableLayoutPanel plocha;
        Label lcas;
        Size velka=new Size(35,35),mala=new Size(20,20);
        const int velkyfont = 11, malyfont = 6;
        TableLayoutPanel vysledky;
        int aktualniradek = 1;
        TableLayoutPanel aktualnityp;
        Button testButton, clear;
        public Logik(GameForm form) : base(form)
        {
            Nazev = "Logik";
        }
        protected override void KonecHry()
        {

            stopky.Stop();
            ukazVysledek();
            clear.Enabled= false;
            testButton.Enabled= false;
        }

        protected override void NastavCasovac()
        {
            stopky = new System.Windows.Forms.Timer();
            stopky.Interval = 1000;
            stopky.Tick += (s, e) => uplynulycas++;
            stopky.Tick += (s, e) => lcas.Text = TimeSpan.FromSeconds(uplynulycas).ToString(@"mm\:ss");
            stopky.Start();
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

        protected override void ProhraVlastni()
        {
            
        }

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

        protected override void VyhraVlastni()
        {
            
        }

        protected override void VytvorHerniStranku()
        {
            VytvorBocniPanel();
            VytvorHerniPlochu();

        }

        private void VytvorHerniPlochu()
        {
            plocha = new TableLayoutPanel()
            {
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                Anchor = AnchorStyles.None,
                AutoSize = true,
                BackColor = Color.Gray,
            };
            form.HraBox.Controls.Add(plocha, 0, 0);
            form.HraBox.SetRowSpan(plocha, 14);
            for (int i = 0; i < 14; i++)
            {
                plocha.RowStyles.Add(new RowStyle(SizeType.Absolute, velka.Height));
            }
            plocha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, velka.Width * 2));
            plocha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, velka.Width * kolik));
            plocha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, mala.Width * kolik));
            plocha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, mala.Width * kolik));
            for (int i = 0; i < 12; i++)
            {
                plocha.Controls.Add(new Label()
                {
                    Text = (i + 1).ToString(),
                    Font = new Font("Segoe UI", velkyfont, FontStyle.Regular, GraphicsUnit.Point),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                }, 0, 12 - i);
            }
            TableLayoutPanel buttonybarev = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = z,
            };
            plocha.Controls.Add(buttonybarev, 1, 13);
            plocha.SetColumnSpan(buttonybarev, 3);
            for (int i = 0; i < z; i++)
            {
                buttonybarev.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                Label l = new Label()
                {
                    Name = i.ToString(),
                    ForeColor = barvy[i],
                    Font = new Font("Segoe UI", velkyfont, FontStyle.Bold, GraphicsUnit.Point),
                    Text = "\U00002B24",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.TopCenter

                };
                l.Click += klikNaBarvu;
                buttonybarev.Controls.Add(l, i, 0);
            }
            vysledky = novyPanel();
            for (int i = 0; i < kolik; i++)
            {
                Label l = new Label()
                {
                    Name = kod[i].ToString(),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", velkyfont, FontStyle.Bold, GraphicsUnit.Point),
                    Text = "\U00002B24",
                };
                vysledky.Controls.Add(l, i, 0);
            }
            plocha.Controls.Add(vysledky, 1, 0);
            aktualnityp = novyPanel();
            plocha.Controls.Add(aktualnityp, 1, 12);
            testButton = new Button()
            {
                Text = "Test",
                Dock = DockStyle.Fill
            };
            testButton.Click += Test;
            plocha.Controls.Add(testButton, 2, 12);
            clear = new Button()
            {
                Text = "Clear",
                Dock = DockStyle.Fill
            };
            clear.Click += (s,e)=>aktualnityp.Controls.Clear();
            plocha.Controls.Add(clear, 3, 12);

        }

        private void Test(object? sender, EventArgs e)
        {
            if (aktualnityp.Controls.Count < kolik)
                return;
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
                    odpoved.Controls.Add(new Label()
                    {
                        ForeColor = Color.Black,
                        Font = new Font("Segoe UI", malyfont, FontStyle.Regular, GraphicsUnit.Point),
                        Text = "\U00002B24",
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
                    odpoved.Controls.Add(new Label()
                    {
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", malyfont, FontStyle.Regular, GraphicsUnit.Point),
                        Text = "\U00002B24",
                    });
                    spravne.Remove(tip[i]);
                    tip.RemoveAt(i);
                    i--;
                }
            }
            aktualnityp = novyPanel();
            
            plocha.Controls.Remove(clear);
            plocha.Controls.Remove(testButton);
            plocha.Controls.Add(aktualnityp, 1, 12 - aktualniradek);
            plocha.Controls.Add(testButton, 2, 12 - aktualniradek);
            plocha.Controls.Add(clear, 3, 12 - aktualniradek);
            plocha.Controls.Add(odpoved, 2, 13 - aktualniradek);
            aktualniradek++;
        }

        private void klikNaBarvu(object? sender, EventArgs e)
        {
            if(aktualnityp.Controls.Count < kolik)
            {
                
                Label l = (Label)sender;
                if (!CBopakovani.Checked) {
                    foreach (Control c in aktualnityp.Controls) {
                        if (c.Name.Equals(l.Name))
                            return;
                    }
                }
                aktualnityp.Controls.Add(new Label()
                {
                    Name = l.Name,
                    ForeColor = barvy[int.Parse(l.Name)],
                    Font = new Font("Segoe UI", velkyfont, FontStyle.Regular, GraphicsUnit.Point),
                    Text = "\U00002B24",
                });
            }
        }
        private TableLayoutPanel novyPanel()
        {
            TableLayoutPanel typ = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                RowCount = 1,
                ColumnCount = kolik,
            };
            for (int i = 0; i < kolik; i++)
            {
                typ.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            }
            return typ;
        }

        private void VytvorBocniPanel()
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

            Button restart = new Button()
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

            Button ukoncit = new Button()
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
                Label l =(Label)x;
                l.ForeColor = barvy[int.Parse(l.Name)];
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

                Label lvyber = new Label()
                {
                    Text = "Výběr:",
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                form.HraBox.Controls.Add(lvyber, 1, 3);

                Label lmoznosti = new Label()
                {
                    Text = "Možností:",
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
    }
}
