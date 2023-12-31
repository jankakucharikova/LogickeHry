﻿using Microsoft.EntityFrameworkCore;
using System.Text;

namespace LogickeHry
{
    
    internal class Sudoku : Hra
    {
        RadioButton lehke, stredni, tezke, vlastni;
        TableLayoutPanel plocha;
        Label lchyb;
        int[,] tabulka,tabulka_vyresena;
        int zbyva_policek,chyb;
        Size velikostTlacitka=new Size(40,40);
        Font font = new Font("Segoe UI", 13, FontStyle.Bold, GraphicsUnit.Point);
        Button vybranecislo;
        List<Button> tlacitka;
        public Sudoku(GameForm form) : base(form)
        {
            Nazev = "Sudoku";
        }

        protected override void KonecHry()
        {
            stopky.Stop();
        }

        protected override void PouzijNastaveni()
        {
            Uzivatel u = form.databaze.uzivatele.Include(e => e.videl).FirstOrDefault(e=> e.Id == form.aktualniuzivatel.Id);

            List<SudokuZadani> l = form.databaze.sudoku.Where(e=> e.obtiznost == obtiznost.ToString() && !u.videl.Contains(e)).ToList();
            SudokuZadani s;
            if (l.Count() > 0)
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
                u.videl.Add(s);
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

        protected override void VytvorHerniStranku()
        {
            VytvorBocniPanel();
            VytvorHerniPlochu();
        }
        private void VytvorBocniPanel()
        {
            form.HraBox.ColumnCount = 3;
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
            form.HraBox.RowCount = 9;
            for (int i = 0; i < 9; i++)
            {
                form.HraBox.RowStyles.Add(new RowStyle(SizeType.Percent, (float)100 / 9));
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
                Text = "Chyb:",
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

            Button restart = new Button()
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

            Button ukoncit = new Button()
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
        private void VytvorHerniPlochu()
        {
            tlacitka = new List<Button>();
            TableLayoutPanel velke = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                RowCount =2,
                ColumnCount = 1,
                RowStyles = { new RowStyle(SizeType.Percent, 100), new RowStyle(SizeType.Absolute, velikostTlacitka.Height+10) },
                ColumnStyles = { new ColumnStyle(SizeType.Percent, 100) },
            };
            form.HraBox.Controls.Add(velke, 0, 0);
            form.HraBox.SetRowSpan(velke, 9);
            TableLayoutPanel cisla = new TableLayoutPanel()
            {
                AutoSize =true,
                Anchor  = AnchorStyles.None,
                ColumnCount = 9,
                RowCount=1,
                RowStyles = { new RowStyle(SizeType.Absolute,velikostTlacitka.Height+10)},
            };
            velke.Controls.Add(cisla, 0, 1);
            for (int i = 0; i < 9; i++)
            {
                cisla.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, velikostTlacitka.Width));
            }
            for (int i = 0; i < 9; i++)
            {
                Button button = new Button()
                {
                    Font = font,
                    Text = (i + 1).ToString(),
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

                                
                            };
                            if (tabulka[x, y] == 0)
                            {
                                button.Text = "";
                                zbyva_policek++;
                            }
                            else
                            {
                                button.Text = tabulka[x, y].ToString();
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
                b.Text = vybranecislo.Text;
                b.BackColor = Color.LightCyan;
                b.ForeColor = Color.DodgerBlue;
                b.Text = vybranecislo.Text;
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
                if (b.Text == vybranecislo.Text)
                {
                    b.Text = "";
                    return;
                }
                    
                b.ForeColor = Color.Red;
                if (tabulka[x, y] != 0)
                {
                    zbyva_policek++;
                    tabulka[x, y] = 0;
                }
                chyb++;
                lchyb.Text = $"{chyb}/3";
                if (chyb == 3)
                    Prohra();
            }
            
        }

        private void VyberCislo(object? sender, EventArgs e)
        {
            if (vybranecislo != null)
            {
                vybranecislo.Enabled = true;
                vybranecislo.BackColor= SystemColors.Window;
            }
            vybranecislo = (Button)sender;
            vybranecislo.Enabled = false;
            vybranecislo.BackColor = Color.LightCyan;
            foreach(Button b in tlacitka)
            {
                if (b.Text.Equals(vybranecislo.Text)) {
                    b.BackColor = Color.LightCyan;
                }
                else
                    b.BackColor = Color.White;
            }
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
                    SizeMode = PictureBoxSizeMode.StretchImage
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
                Button bnavod = new Button()
                {
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = "Návod",
                };
                form.HraBox.Controls.Add(bnavod, 1, 3);
                form.HraBox.SetRowSpan(bnavod, 2);

                Button bstatistiky = new Button()
                {
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = "Statistiky",
                };
                form.HraBox.Controls.Add(bstatistiky, 1, 5);
                form.HraBox.SetRowSpan(bstatistiky, 2);

                Button bhrat = new Button()
                {
                    Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = "Hrát",
                };
                bhrat.Click += (s, e) => SpustiHru();
                form.HraBox.Controls.Add(bhrat, 1, 7);
                form.HraBox.SetRowSpan(bhrat, 2);
            }
        }

    }
}
