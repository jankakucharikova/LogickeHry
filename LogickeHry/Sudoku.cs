using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.LinkLabel;
using System.Text;

namespace LogickeHry
{
    
    internal class Sudoku : Hra
    {
        protected List<Bitmap> obrazky;
        protected Bitmap uvodniobrazek;
        protected RadioButton lehke, stredni, tezke, vlastni;
        protected Label lchyb;
        protected Button starachyba=new();
        protected int[,] tabulka,tabulka_vyresena;
        protected int zbyva_policek,chyb;
        protected Size velikostTlacitka =new Size(40,40);
        protected Font font = new Font("Segoe UI", 13, FontStyle.Bold, GraphicsUnit.Point);
        protected Button vybranecislo;
        protected List<Button> tlacitka;
        public Sudoku(GameForm form) : base(form)
        {
            Nazev = "SUDOKU";
            obrazky = NactiIkonky(LogickeHry.Properties.Resources.sudoku_bile);
            uvodniobrazek = Properties.Resources.sudoku_uvod;
            navod = $"{Nazev} je mřížka 9x9 s některými prázdnými, jinými předvyplněnými poli čísel 1-9. Hráč na základě 3 pravidel vyplňuje čísla do prázdných polí. Každé číslo se musí nacházet právě 1-krát v každém řádku, sloupci a vyznačeném čtverci 3x3. \r\n\r\nVýběr čísel ze spodní lišty se potvrdí kliknutím. Dalšími kliknutími na hrací pole se číslo doplňuje. Pokud ho doplní na nesprávné místo, číslo se nezobrazí, ale bude mu započítaná chyba. Hráč má povolené maximálně 3 chyby. \r\n\r\nPokud chce hráč vygenerovat novou hru stiskne tlačítko „Nová hra“.\r\nStisknutím tlačítka „Ukončit hru“ se hráč dostane zpět na úvodní stránku hry.\r\nPokud hráč vyplní všechna políčka správnými obrázky a neudělá během toho víc jak 3 chyby vyhrál. \r\n";
        }

        protected override void KonecHry()
        {
            stopky.Stop();
        }

        protected override void PouzijNastaveni()
        {
            Uzivatel u=null;
            List<SudokuZadani> l=null;
            if (form.aktualniuzivatel != null)
            {
                u = form.databaze.uzivatele.Include(e => e.videl).FirstOrDefault(e => e.Id == form.aktualniuzivatel.Id);
                l = form.databaze.sudoku.Where(e => e.obtiznost == obtiznost.ToString() && !u.videl.Contains(e)).ToList();
            }

             
            SudokuZadani s;
            if (l!=null && l.Count() > 0)
            {
                s = l[0];
                u.videl.Add(s);
                s.Load();
            }
            else
            {
                s = new SudokuZadani();
                s.vygeneruj(obtiznost);
                s.save();
                if (u != null)
                {
                    u.videl.Add(s);
                }
                form.databaze.sudoku.Add(s);
            }
            tabulka = s.zadani;
            tabulka_vyresena = s.kompletni;
            form.databaze.SaveChanges();
        }

        
        protected override void ProhraVlastni()
        {
            
        }

        protected override void Reset()
        {
            chyb = 0;
            zbyva_policek = 0;
            tabulka_vyresena = null;
            tabulka = null;
            tlacitka = null;
            uplynulycas = 0;
            if (stopky != null)
            {
                stopky.Dispose();
            }
        }

        protected override void VyhraVlastni()
        {
        }
        protected override void VytvorBocniPanel()
        {
            //form.HraBox.Anchor = AnchorStyles.Top;
            //form.HraBox.Dock = DockStyle.None;
            //form.HraBox.AutoSize = true;
            
            form.HraBox.ColumnCount = 3;
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute,150));
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            form.HraBox.RowCount = 9;
            for (int i = 0; i < 9; i++)
            {
                form.HraBox.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
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
            form.HraBox.SetRowSpan(lcas, 3);

            Label lopakovani = new Label()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Text = "Obtížnost:",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            form.HraBox.Controls.Add(lopakovani, 1, 3);
            form.HraBox.SetRowSpan(lopakovani, 1);
            Label lo = new Label()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            switch (obtiznost)
            {
                case Obtiznost.Tezke:
                    lo.Text = "Těžké";
                    break;
                case Obtiznost.Stredni:
                    lo.Text = "Střední";
                    break;
                case Obtiznost.Lehke:
                    lo.Text = "Lehké";
                    break;
            }
            form.HraBox.Controls.Add(lo, 2, 3);
            form.HraBox.SetRowSpan(lo, 1);
            Label lchybtext = new Label()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Text = "Chyby:",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };
            form.HraBox.Controls.Add(lchybtext, 1, 4);
            form.HraBox.SetRowSpan(lchybtext, 1);
            lchyb = new Label()
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = $"{chyb}/3",
            };
            form.HraBox.Controls.Add(lchyb, 2, 4);
            form.HraBox.SetRowSpan(lchyb, 1);

            Button restart = new RoundedButton()
            {
                Text = "Nová hra",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point),
                TextAlign = ContentAlignment.MiddleCenter
            };
            restart.Click += (s, e) => { SpustiHru(); };
            form.HraBox.Controls.Add(restart, 1, 5);
            form.HraBox.SetColumnSpan(restart, 2);
            form.HraBox.SetRowSpan(restart, 2);

            Button ukoncit = new RoundedButton()
            {
                Text = "Ukončit hru",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point),
                TextAlign = ContentAlignment.MiddleCenter
            };
            ukoncit.Click += (s, e) => { SpustiUvod(); };
            form.HraBox.Controls.Add(ukoncit, 1, 7);
            form.HraBox.SetColumnSpan(ukoncit, 2);
            form.HraBox.SetRowSpan(ukoncit, 2);

        }
        protected override void VytvorHerniPlochu()
        {
            tlacitka = new List<Button>();
            TableLayoutPanel velke = new TableLayoutPanel()
            {
                Anchor = AnchorStyles.None,
                RowCount =2,
                ColumnCount = 1,
                RowStyles = { new RowStyle(SizeType.AutoSize), new RowStyle(SizeType.AutoSize) },
                ColumnStyles = { new ColumnStyle(SizeType.AutoSize) },
               // CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                AutoSize = true,
            };
            form.HraBox.Controls.Add(velke, 0, 0);
            form.HraBox.SetRowSpan(velke, 9);
            TableLayoutPanel cisla = new TableLayoutPanel()
            {
                AutoSize =true,
                Anchor  = AnchorStyles.Top,
                ColumnCount = 9,
                RowCount=1,
                RowStyles = { new RowStyle(SizeType.AutoSize)},
            };
            velke.Controls.Add(cisla, 0, 1);
            for (int i = 0; i < 9; i++)
            {
                cisla.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, velikostTlacitka.Width+10));
            }
            for (int i = 0; i < 9; i++)
            {
                Button button = new Button()
                {
                    Dock = DockStyle.None,
                    Font = font,
                    BackgroundImage = obrazky[i],
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Name = (i + 1).ToString(),
                    Size = velikostTlacitka,
                };
                button.Click += VyberCislo;
                cisla.Controls.Add(button, i, 0);
            }
            plocha = new TableLayoutPanel()
            {
                BackColor = Color.Black,
                Anchor = AnchorStyles.None,
                AutoSize = true,
                RowCount = 3,
                ColumnCount = 3,
            };
            velke.Controls.Add(plocha, 0, 0);
            plocha.Visible = false;
            for (int i = 0; i < 3; i++)
            {
                plocha.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                plocha.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                for (int j = 0; j < 3; j++)
                {
                    TableLayoutPanel ctverec = new TableLayoutPanel()
                    {
                        CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                        AutoSize=true,
                        BackColor = Color.White,
                        Margin = new Padding (1),
                    };
                    plocha.Controls.Add(ctverec, i, j);
                    for (int k = 0; k < 3; k++)
                    {
                        ctverec.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute,velikostTlacitka.Width));
                        ctverec.RowStyles.Add(new RowStyle(SizeType.Absolute,velikostTlacitka.Height));
                        for (int l = 0; l < 3; l++)
                        {

                            int x = 3 * i + k;
                            int y = 3 * j + l;
                            Button button = new Button()
                            {
                                Font = font,
                                Name = $"{x},{y}",
                                Margin = Padding.Empty,
                                Size = velikostTlacitka,
                                BackgroundImageLayout = ImageLayout.Stretch,

                            };
                            if (tabulka[x, y] == 0)
                            {
                                button.BackgroundImage=obrazky[9];
                                zbyva_policek++;
                            }
                            else
                            {
                                button.BackgroundImage = obrazky[tabulka[x, y]-1];
                                button.Enabled = false;
                            }

                            button.Click += VyberPolicko;
                            ctverec.Controls.Add(button, k, l);
                            tlacitka.Add(button);
                        }
                    }
                }
            }
            plocha.Visible = true;
        }

        private void VyberPolicko(object? sender, EventArgs e)
        {
            if (vybranecislo == null || Stav != StavHry.Bezi)
                return;
            Button b = (Button)sender;
            String[] souradnice=b.Name.Split(',');
            int x = int.Parse(souradnice[0]);
            int y = int.Parse(souradnice[1]);
            int c = int.Parse(vybranecislo.Name);
            
            if (tabulka_vyresena[x, y] == c)
            {
                b.BackColor = Color.White;
                b.BackgroundImage = obrazky[c - 1];
                if (tabulka[x,y]==0)
                {
                    zbyva_policek--;
                    tabulka[x, y] = c;
                    if (zbyva_policek == 0)
                    {
                        Vyhra();
                    }
                }
            }
            else
            {
                starachyba.BackColor = Color.White;
                b.BackgroundImage = null;
                b.BackColor = Color.Red;
                if (tabulka[x, y] != 0)
                {
                    zbyva_policek++;
                    tabulka[x, y] = 0;
                }
                chyb++;
                starachyba = b;
                lchyb.Text = $"{chyb}/3";
                if (chyb == 3)
                    Prohra();
            }
            
        }

        private void VyberCislo(object? sender, EventArgs e)
        {
            if (Stav != StavHry.Bezi)
                return;
            starachyba.BackColor = Color.White;
            if (vybranecislo != null)
            {
                vybranecislo.Enabled = true;
                //vybranecislo.BackColor= SystemColors.Window;
                vybranecislo.BackColor = Color.Azure;
            }
            vybranecislo = (Button)sender;
            vybranecislo.Enabled = false;
            vybranecislo.BackColor = Color.LightCyan;           
            vybranecislo.Parent.Select();
        }

        protected override void VytvorUvodniStranku()
        {
            //rozlozeni cele stranky
            {
                form.HraBox.ColumnCount = 3;
                form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300));

                form.HraBox.RowCount = 9;
                for (int i = 0; i < 9; i++)
                {
                    form.HraBox.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / 9));
                }
            }
            //vlevo obrazek
            {
                PictureBox obrazek = new PictureBox()
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    Image = uvodniobrazek
                };
                form.HraBox.Controls.Add(obrazek, 0, 0);
                form.HraBox.SetRowSpan(obrazek, 9);
            }
            //groupbox obtiznost
            {
                GroupBox GBobtiznost = new GroupBox()
                {
                    Dock = DockStyle.Fill,
                    Text = "Obtížnost",
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                };
                form.HraBox.Controls.Add(GBobtiznost, 1, 0);
                form.HraBox.SetRowSpan(GBobtiznost, 3);
                //rozlozeni obtiznosti a radiobuttony
                {
                    TableLayoutPanel obtiznostpanel = new TableLayoutPanel()
                    {
                        ColumnCount = 1,
                        RowCount = 2,
                        Dock = DockStyle.Fill
                    };
                    obtiznostpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                    obtiznostpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
                    obtiznostpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
                    obtiznostpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
                    GBobtiznost.Controls.Add(obtiznostpanel);

                    if (lehke == null || stredni == null || tezke == null || vlastni == null)
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
                                obtiznost = Obtiznost.Lehke;
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
                                obtiznost = Obtiznost.Stredni;
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
                                obtiznost = Obtiznost.Tezke;
                            }
                        };



                    }
                    obtiznostpanel.Controls.Add(lehke, 0, 0);
                    obtiznostpanel.Controls.Add(stredni, 0, 1);
                    obtiznostpanel.Controls.Add(tezke, 0, 2);
                }
            }
            //buttony
            {
                Button bnavod = new RoundedButton()
                {
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = "Návod",
                };
                bnavod.Click += UkazNavod;
                form.HraBox.Controls.Add(bnavod, 1, 3);
                form.HraBox.SetRowSpan(bnavod, 2);

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
                form.HraBox.Controls.Add(bstatistiky, 1, 5);
                form.HraBox.SetRowSpan(bstatistiky, 2);

                Button bhrat = new RoundedButton()
                {
                    Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point),
                    //ForeColor = Color.White,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = "Hrát",
                    //BackColor = Color.Navy,
                };
                bhrat.Click += (s, e) => SpustiHru();
                form.HraBox.Controls.Add(bhrat, 1, 7);
                form.HraBox.SetRowSpan(bhrat, 2);
            }
        }

    }
    internal class ObrazkoveSudoku : Sudoku
    {
        public ObrazkoveSudoku(GameForm form) : base(form) {
            navod = " je mřížka 9x9 s některými prázdnými, jinými předvyplněnými poli obrázků. Hráč na základě 3 pravidel vyplňuje obrázky do prázdných polí. Každý obrázek se musí nacházet právě 1-krát v každém řádku, sloupci a vyznačeném čtverci 3x3. \r\n\r\nVýběr obrázku ze spodní lišty se potvrdí kliknutím. Dalšími kliknutími na hrací pole se obrázek doplňuje. Pokud ho doplní na nesprávné místo, obrázek se nezobrazí, ale bude mu započítaná chyba. Hráč má povolené maximálně 3 chyby. \r\n\r\nPokud chce hráč vygenerovat novou hru stiskne tlačítko „Nová hra“.\r\nStisknutím tlačítka „Ukončit hru“ se hráč dostane zpět na úvodní stránku hry.\r\nPokud hráč vyplní všechna políčka správnými čísly a neudělá během toho víc jak 3 chyby vyhrál. \r\n";
        }
    }
    internal class SudokuPlanety : ObrazkoveSudoku
    {
        public SudokuPlanety(GameForm form) : base(form)
        {
            Nazev = "Vesmírné SUDOKU";
            navod = Nazev + navod;
            obrazky = NactiIkonky(LogickeHry.Properties.Resources.sudoku_planety_bile);
            uvodniobrazek = Properties.Resources.planety_uvod;
        }
    }

    internal class SudokuOvoce : ObrazkoveSudoku
    {
        public SudokuOvoce(GameForm form) : base(form)
        {
            Nazev = "SUDOKU ovoce";
            navod = Nazev + navod;
            obrazky = NactiIkonky(LogickeHry.Properties.Resources.sudoku_ovoce_bile);
            uvodniobrazek = Properties.Resources.ovoce_uvod;
        }
    }
    internal class SudokuPismenka : ObrazkoveSudoku
    {
        public SudokuPismenka(GameForm form) : base(form)
        {
            Nazev = "SUDOKU písmenka";
            navod = Nazev + navod;
            obrazky = NactiIkonky(LogickeHry.Properties.Resources.sudoku_pismenka_bile);
            uvodniobrazek = Properties.Resources.pismenka_uvod;
        }
    }
    internal class SudokuTvary : ObrazkoveSudoku
    {
        public SudokuTvary(GameForm form) : base(form)
        {
            Nazev = "SUDOKU tvary";
            navod = Nazev + navod;
            obrazky = NactiIkonky(LogickeHry.Properties.Resources.sudoku_tvary_bile);
            uvodniobrazek = Properties.Resources.tvary_uvod;
        }
    }
    internal class SudokuZOO : ObrazkoveSudoku
    {
        public SudokuZOO(GameForm form) : base(form)
        {
            Nazev = "SUDOKU ZOO";
            navod = Nazev + navod;
            obrazky = NactiIkonky(LogickeHry.Properties.Resources.sudoku_zoo_bile);
            uvodniobrazek = Properties.Resources.zoo_uvod;
        }
    }



}
