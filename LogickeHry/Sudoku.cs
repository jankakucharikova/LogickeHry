using LogickeHry.Properties;
using Microsoft.EntityFrameworkCore;

namespace LogickeHry;

// Třída Sudoku, odvozená od abstraktní třídy Hra
internal class Sudoku : Hra
{
    protected List<Bitmap> obrazky;
    protected Bitmap uvodniobrazek;
    private RadioButton? _lehke;
    private RadioButton? _stredni, _tezke, _vlastni;
    private Label? _lchyb;
    private Button? _starachyba = new();
    private int[,] _tabulka;
    private int[,] _tabulkaVyresena;
    private int _zbyvaPolicek, _chyb;
    private readonly Size _velikostTlacitka = new(45, 45);
    private readonly Font _font = new("Segoe UI", 13, FontStyle.Bold, GraphicsUnit.Point);
    private Button? _vybranecislo;
    private Button? _vybranysymbol;
    private List<Button>? _tlacitka;
    private int _multiplikator;
    private int _chyba;

    // Konstruktor třídy Sudoku
    public Sudoku(GameForm form) : base(form)
    {
        nazev = "SUDOKU";
        obrazky = NactiIkonky(Resources.sudoku_bile);
        uvodniobrazek = Resources.sudoku_uvod;
        navod = $"{nazev} je mřížka 9x9 s některými prázdnými, jinými předvyplněnými poli čísel 1-9. Hráč na základě 3 pravidel vyplňuje čísla do prázdných polí. Každé číslo se musí nacházet právě 1-krát v každém řádku, sloupci a vyznačeném čtverci 3x3. \r\n\r\nVýběr čísel ze spodní lišty se potvrdí kliknutím. Dalšími kliknutími na hrací pole se číslo doplňuje. Pokud ho doplní na nesprávné místo, číslo se nezobrazí, ale bude mu započítaná chyba. Hráč má povolené maximálně 3 chyby. \r\n\r\nPokud chce hráč vygenerovat novou hru stiskne tlačítko „Nová hra“.\r\nStisknutím tlačítka „Ukončit hru“ se hráč dostane zpět na úvodní stránku hry.\r\nPokud hráč vyplní všechna políčka správnými obrázky a neudělá během toho víc jak 3 chyby vyhrál. \r\n";
    }

    // Metoda pro zpracování události ukončení hry
    protected override void KonecHry()
    {
        stopky.Stop();// Zastavení stopky
    }

    // Metoda pro použití nastavení hry
    protected override void PouzijNastaveni()
    {
        Uzivatel u = null;
        List<SudokuZadani> l = null;
        if (form is { aktualniuzivatel: not null, dostupnaDatabaze: true })
        {
            u = form.databaze.Uzivatele.Include(e => e.videl).FirstOrDefault(e => e.Id == form.aktualniuzivatel.Id);
            l = form.databaze.Sudoku.Where(e => e.obtiznost == obtiznost.ToString() && !u.videl.Contains(e)).ToList();
        }


        SudokuZadani s;
        if (l != null && l.Any())
        {
            s = l[0];
            u.videl.Add(s);
            s.Load();
        }
        else
        {
            s = new SudokuZadani();
            s.Vygeneruj(obtiznost);
            s.Save();
            u?.videl.Add(s);
            if (form.dostupnaDatabaze)
            {
                form.databaze.Sudoku.Add(s);
            }

        }
        _tabulka = s.zadani;
        _tabulkaVyresena = s.kompletni;
        if (form.dostupnaDatabaze)
        {
            form.databaze.SaveChanges();
        }

    }
    
    protected override void ProhraVlastni()
    {

    }

    // Metoda pro resetování hry na výchozí hodnoty
    protected override void Reset()
    {
        _chyb = 0;
        _zbyvaPolicek = 0;
        _tabulkaVyresena = null;
        _tabulka = null;
        _tlacitka = null;
        uplynulycas = 0;
        ziskaneskore = 0;
        stopky?.Dispose();
    }

    // Metoda pro vlastní akci při výhře
    protected override void VyhraVlastni()
    {
        if (_multiplikator > 0)
        {
            ziskaneskore += _multiplikator * 15 * 2;
            ziskaneskore += (15 - uplynulycas % 15) * 2;
        }
        lskore.Text = ziskaneskore.ToString();
    }

    // Metoda pro vytvoření bočního panelu
    protected override void VytvorBocniPanel()
    {

        form.HraBox.ColumnCount = 3;
        form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
        form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
        form.HraBox.RowCount = 9;
        for (var i = 0; i < 9; i++)
        {
            form.HraBox.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        }
        lcas = new Label
        {
            Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point),
            Text = @"0:00",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lcas, 1, 0);
        form.HraBox.SetColumnSpan(lcas, 2);
        form.HraBox.SetRowSpan(lcas, 2);

        var lskorenazev = new Label
        {
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Text = @"Skóre:",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lskorenazev, 1, 2);
        lskore = new Label
        {
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Text = @"0",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lskore, 2, 2);
        var lopakovani = new Label
        {
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Text = @"Obtížnost:",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lopakovani, 1, 3);
        var lo = new Label
        {
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        lo.Text = obtiznost switch
        {
            Obtiznost.Tezke => @"Těžké",
            Obtiznost.Stredni => @"Střední",
            Obtiznost.Lehke => @"Lehké",
            _ => lo.Text
        };
        form.HraBox.Controls.Add(lo, 2, 3);
        form.HraBox.SetRowSpan(lo, 1);
        var lchybtext = new Label
        {
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Text = @"Chyby:",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lchybtext, 1, 4);
        form.HraBox.SetRowSpan(lchybtext, 1);
        _lchyb = new Label
        {
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            Text = $@"{_chyb}/3"
        };
        form.HraBox.Controls.Add(_lchyb, 2, 4);
        form.HraBox.SetRowSpan(_lchyb, 1);

        Button restart = new RoundedButton
        {
            Text = @"Nová hra",
            Dock = DockStyle.Fill,
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point),
            TextAlign = ContentAlignment.MiddleCenter
        };
        restart.Click += (_, _) => { SpustiHru(); };
        form.HraBox.Controls.Add(restart, 1, 5);
        form.HraBox.SetColumnSpan(restart, 2);
        form.HraBox.SetRowSpan(restart, 2);

        Button ukoncit = new RoundedButton
        {
            Text = @"Ukončit hru",
            Dock = DockStyle.Fill,
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point),
            TextAlign = ContentAlignment.MiddleCenter
        };
        ukoncit.Click += (_, _) => { SpustiUvod(); };
        form.HraBox.Controls.Add(ukoncit, 1, 7);
        form.HraBox.SetColumnSpan(ukoncit, 2);
        form.HraBox.SetRowSpan(ukoncit, 2);

    }

    // Metoda pro vytvoření herní plochy
    protected override void VytvorHerniPlochu()
    {
        stopky.Tick += (_, _) =>
        {
            if (uplynulycas % 15 != 14) return;
            if (_multiplikator > 0)
                _multiplikator--;
        };
        _multiplikator = obtiznost switch
        {
            Obtiznost.Lehke => 40,
            Obtiznost.Stredni => 80,
            Obtiznost.Tezke => 120,
            _ => 0
        };
        _chyba = _multiplikator * 5;
        _tlacitka = new List<Button>();
        var velke = new TableLayoutPanel
        {
            Anchor = AnchorStyles.None,
            RowCount = 4,
            ColumnCount = 2,
            RowStyles = { new RowStyle(SizeType.Absolute, 100), new RowStyle(SizeType.Absolute, 120), new RowStyle(SizeType.AutoSize), new RowStyle(SizeType.AutoSize) },
            ColumnStyles = { new ColumnStyle(SizeType.Absolute, 120), new ColumnStyle(SizeType.AutoSize) },
            AutoSize = true
        };
        form.HraBox.Controls.Add(velke, 0, 0);
        form.HraBox.SetRowSpan(velke, 9);
        var symbol = new Label
        {
            Text = @"Vybraný symbol:",
            Font = _font,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        _vybranysymbol = new Button
        {
            BackgroundImageLayout = ImageLayout.Stretch,
            Dock = DockStyle.Fill
        };
        velke.Controls.Add(symbol, 0, 0);
        velke.Controls.Add(_vybranysymbol, 0, 1);
        var cisla = new TableLayoutPanel
        {
            AutoSize = true,
            Anchor = AnchorStyles.Top,
            ColumnCount = 9,
            RowCount = 1,
            RowStyles = { new RowStyle(SizeType.AutoSize) }
        };
        velke.Controls.Add(cisla, 1, 3);
        for (var i = 0; i < 9; i++)
        {
            cisla.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, _velikostTlacitka.Width + 10));
        }
        for (var i = 0; i < 9; i++)
        {
            var button = new Button
            {
                Dock = DockStyle.None,
                Font = _font,
                BackgroundImage = obrazky[i],
                BackgroundImageLayout = ImageLayout.Stretch,
                Name = (i + 1).ToString(),
                Size = _velikostTlacitka
            };
            button.Click += VyberCislo;
            cisla.Controls.Add(button, i, 0);
        }
        plocha = new TableLayoutPanel
        {
            BackColor = Color.Black,
            Anchor = AnchorStyles.None,
            AutoSize = true,
            RowCount = 3,
            ColumnCount = 3
        };
        velke.Controls.Add(plocha, 1, 0);
        velke.SetRowSpan(plocha, 3);
        plocha.Visible = false;
        for (var i = 0; i < 3; i++)
        {
            plocha.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            plocha.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            for (var j = 0; j < 3; j++)
            {
                var ctverec = new TableLayoutPanel
                {
                    CellBorderStyle = TableLayoutPanelCellBorderStyle.Single,
                    AutoSize = true,
                    BackColor = Color.White,
                    Margin = new Padding(1)
                };
                plocha.Controls.Add(ctverec, i, j);
                for (var k = 0; k < 3; k++)
                {
                    ctverec.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, _velikostTlacitka.Width));
                    ctverec.RowStyles.Add(new RowStyle(SizeType.Absolute, _velikostTlacitka.Height));
                    for (var l = 0; l < 3; l++)
                    {

                        var x = 3 * i + k;
                        var y = 3 * j + l;
                        var button = new Button
                        {
                            Font = _font,
                            Name = $"{x},{y}",
                            Margin = Padding.Empty,
                            Size = _velikostTlacitka,
                            BackgroundImageLayout = ImageLayout.Stretch

                        };
                        if (_tabulka[x, y] == 0)
                        {
                            button.BackgroundImage = obrazky[9];
                            _zbyvaPolicek++;
                        }
                        else
                        {
                            button.BackgroundImage = obrazky[_tabulka[x, y] - 1];
                            button.Enabled = false;
                        }

                        button.Click += VyberPolicko;
                        ctverec.Controls.Add(button, k, l);
                        _tlacitka.Add(button);
                    }
                }
            }
        }
        plocha.Visible = true;
    }

    // Metoda pro zpracování události výběru políčka
    private void VyberPolicko(object? sender, EventArgs e)
    {
        if (_vybranecislo == null || stav != StavHry.Bezi)
            return;
        var b = (Button)sender;
        var souradnice = b.Name.Split(',');
        var x = int.Parse(souradnice[0]);
        var y = int.Parse(souradnice[1]);
        var c = int.Parse(_vybranecislo.Name);

        if (_tabulkaVyresena[x, y] == c)
        {
            ziskaneskore += 5 * _multiplikator;
            _starachyba.BackColor = Color.White;
            b.BackColor = Color.White;
            b.BackgroundImage = obrazky[c - 1];
            if (_tabulka[x, y] == 0)
            {
                _zbyvaPolicek--;
                _tabulka[x, y] = c;
                if (_zbyvaPolicek == 0)
                {
                    Vyhra();
                }
            }
        }
        else
        {
            ziskaneskore -= _chyba;
            _starachyba.BackColor = Color.White;
            b.BackgroundImage = null;
            b.BackColor = Color.Red;
            if (_tabulka[x, y] != 0)
            {
                _zbyvaPolicek++;
                _tabulka[x, y] = 0;
            }
            _chyb++;
            _starachyba = b;
            _lchyb.Text = $@"{_chyb}/3";
            if (_chyb == 3)
                Prohra();
        }
        lskore.Text = ziskaneskore.ToString();
    }

    // Metoda pro zpracování události výběru čísla
    private void VyberCislo(object? sender, EventArgs e)
    {
        if (stav != StavHry.Bezi)
            return;
        _starachyba.BackColor = Color.White;
        if (_vybranecislo != null)
        {
            _vybranecislo.Enabled = true;
            _vybranecislo.BackColor = Color.Azure;
        }

        _vybranecislo = (Button)sender;
        _vybranecislo.Enabled = false;
        _vybranecislo.BackColor = Color.LightCyan;
        _vybranysymbol.BackgroundImage = _vybranecislo.BackgroundImage;
        _vybranecislo.Parent.Select();
    }

    // Metoda pro vytvoření úvodní stránky hry
    protected override void VytvorUvodniStranku()
    {
        //Rozlozeni cele stranky
        {
            form.HraBox.ColumnCount = 3;
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300));

            form.HraBox.RowCount = 9;
            for (var i = 0; i < 9; i++)
            {
                form.HraBox.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            }
        }
        //Vlevo obrazek
        {
            var obrazek = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.CenterImage,
                Image = uvodniobrazek
            };
            form.HraBox.Controls.Add(obrazek, 0, 0);
            form.HraBox.SetRowSpan(obrazek, 9);
        }
        //Groupbox obtiznostGB
        {
            var gBobtiznost = new GroupBox
            {
                Dock = DockStyle.Fill,
                Text = @"Obtížnost",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            };
            form.HraBox.Controls.Add(gBobtiznost, 1, 0);
            form.HraBox.SetRowSpan(gBobtiznost, 3);
            //Rozlozeni obtiznosti a radiobuttony
            {
                var obtiznostpanel = new TableLayoutPanel
                {
                    ColumnCount = 1,
                    RowCount = 2,
                    Dock = DockStyle.Fill
                };
                obtiznostpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                obtiznostpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
                obtiznostpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
                obtiznostpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
                gBobtiznost.Controls.Add(obtiznostpanel);

                if (_lehke == null || _stredni == null || _tezke == null || _vlastni == null)
                {
                    _lehke = new RadioButton
                    {
                        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                        Text = @"Lehké",
                        Checked = true,
                        Dock = DockStyle.Fill
                    };
                    _lehke.CheckedChanged += (_, _) =>
                    {
                        if (_lehke.Checked)
                        {
                            obtiznost = Obtiznost.Lehke;
                        }
                    };

                    _stredni = new RadioButton
                    {
                        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                        Text = @"Střední",
                        Dock = DockStyle.Fill
                    };
                    _stredni.CheckedChanged += (_, _) =>
                    {
                        if (_stredni.Checked)
                        {
                            obtiznost = Obtiznost.Stredni;
                        }
                    };

                    _tezke = new RadioButton
                    {
                        Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                        Text = @"Těžké",
                        Dock = DockStyle.Fill
                    };
                    _tezke.CheckedChanged += (_, _) =>
                    {
                        if (_tezke.Checked)
                        {
                            obtiznost = Obtiznost.Tezke;
                        }
                    };



                }
                obtiznostpanel.Controls.Add(_lehke, 0, 0);
                obtiznostpanel.Controls.Add(_stredni, 0, 1);
                obtiznostpanel.Controls.Add(_tezke, 0, 2);
            }
        }
        //buttony
        {
            Button bnavod = new RoundedButton
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = @"Návod"
            };
            bnavod.Click += UkazNavod;
            form.HraBox.Controls.Add(bnavod, 1, 3);
            form.HraBox.SetRowSpan(bnavod, 2);

            Button bstatistiky = new RoundedButton
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = @"Statistiky"
            };
            bstatistiky.Click += (_, _) =>
            {
                form.StatistikyCBHra.Text = nazev;
                form.Ukazbox(form.StatistikaBox);
            };
            form.HraBox.Controls.Add(bstatistiky, 1, 5);
            form.HraBox.SetRowSpan(bstatistiky, 2);

            Button bhrat = new RoundedButton
            {
                Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Text = @"Hrát"
            };
            bhrat.Click += (_, _) => SpustiHru();
            form.HraBox.Controls.Add(bhrat, 1, 7);
            form.HraBox.SetRowSpan(bhrat, 2);
        }
    }

}

// Další třídy odvozené od třídy Sudoku
internal class ObrazkoveSudoku : Sudoku
{
    protected ObrazkoveSudoku(GameForm form) : base(form)
    {
        navod = " je mřížka 9x9 s některými prázdnými, jinými předvyplněnými poli obrázků. Hráč na základě 3 pravidel vyplňuje obrázky do prázdných polí. Každý obrázek se musí nacházet právě 1-krát v každém řádku, sloupci a vyznačeném čtverci 3x3. \r\n\r\nVýběr obrázku ze spodní lišty se potvrdí kliknutím. Dalšími kliknutími na hrací pole se obrázek doplňuje. Pokud ho doplní na nesprávné místo, obrázek se nezobrazí, ale bude mu započítaná chyba. Hráč má povolené maximálně 3 chyby. \r\n\r\nPokud chce hráč vygenerovat novou hru stiskne tlačítko „Nová hra“.\r\nStisknutím tlačítka „Ukončit hru“ se hráč dostane zpět na úvodní stránku hry.\r\nPokud hráč vyplní všechna políčka správnými čísly a neudělá během toho víc jak 3 chyby vyhrál. \r\n";
    }
}
internal class SudokuPlanety : ObrazkoveSudoku
{
    public SudokuPlanety(GameForm form) : base(form)
    {
        nazev = "Vesmírné SUDOKU";
        navod = nazev + navod;
        obrazky = NactiIkonky(Resources.sudoku_planety_bile);
        uvodniobrazek = Resources.planety_uvod;
    }
}

internal class SudokuOvoce : ObrazkoveSudoku
{
    public SudokuOvoce(GameForm form) : base(form)
    {
        nazev = "SUDOKU ovoce";
        navod = nazev + navod;
        obrazky = NactiIkonky(Resources.sudoku_ovoce_bile);
        uvodniobrazek = Resources.ovoce_uvod;
    }
}
internal class SudokuPismenka : ObrazkoveSudoku
{
    public SudokuPismenka(GameForm form) : base(form)
    {
        nazev = "SUDOKU písmenka";
        navod = nazev + navod;
        obrazky = NactiIkonky(Resources.sudoku_pismenka_bile);
        uvodniobrazek = Resources.pismenka_uvod;
    }
}
internal class SudokuTvary : ObrazkoveSudoku
{
    public SudokuTvary(GameForm form) : base(form)
    {
        nazev = "SUDOKU tvary";
        navod = nazev + navod;
        obrazky = NactiIkonky(Resources.sudoku_tvary_bile);
        uvodniobrazek = Resources.tvary_uvod;
    }
}
internal class SudokuZoo : ObrazkoveSudoku
{
    public SudokuZoo(GameForm form) : base(form)
    {
        nazev = "SUDOKU ZOO";
        navod = nazev + navod;
        obrazky = NactiIkonky(Resources.sudoku_zoo_bile);
        uvodniobrazek = Resources.zoo_uvod;
    }
}