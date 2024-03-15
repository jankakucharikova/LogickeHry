using LogickeHry.Properties;

namespace LogickeHry;

// Třída Logik reprezentuje logiku hry "Logik" a dědí z abstraktní třídy Hra.
internal class Logik : Hra
{
    // Proměnné pro uchování grafických prvků a dat hry
    private readonly List<Bitmap> _obrazky;
    private NumericUpDown? _nvyber, _nmoznosti;
    private CheckBox? _cBopakovani;
    private RadioButton? _lehke, _stredni, _tezke, _vlastni;
    private int[] _kod;
    private int _kolik, _z;
    private readonly Size _velikostRadku = new(30, 30);
    private readonly Size _velikostKolecek = new(20, 20);
    private readonly Size _velikostPuntiku = new(10, 10);
    private TableLayoutPanel? _vysledky;
    private int _aktualniradek = 1;
    private TableLayoutPanel? _aktualnityp;
    private Button? _testButton, _clear;
    private int _odcitanibile, _odcitanispatne;

    // Konstruktor třídy Logik
    public Logik(GameForm form) : base(form)
    {
        nazev = "Logik";
        _obrazky = NactiIkonky(Resources.logik);
        navod = "Hráč hádá barevnou kombinaci o počtu koleček, který si hráč sám zvolí. Barvy se mohou opakovat, pokud si tak hráč zvolí. \r\nHráč musí uhodnout barevnou kombinaci a její správné pořadí ve dvanácti krocích.\r\nHráč vybírá barvy ze spodní lišty. Pokud vyplnil všechny políčka může zažádat o kontrolu tlačítkem „Test“. \r\nPokud chce svou odpověď změnit, smaže svůj výběr tlačítkem „Clear“. \r\nKaždý odehraný pokus je vyhodnocený černými a bílými puntíky. Za každé kolečko, které udává správnou barvu, ale je na špatném místě, se uděluje bílý puntík. Za každé kolečko se správnou barvou na správném místě se dává černý puntík. Pořadí puntíků není stejné jako pořadí koleček, zobrazují se vždy nejprve černé a pak bílé puntíky.\r\nPokud chce hráč vygenerovat novou barevnou kombinaci stiskne tlačítko „Nová hra“.\r\nStisknutím tlačítka „Ukončit hru“ se hráč dostane zpět na úvodní stránku hry.\r\nHra končí v momentě, kdy je uhodnuta barevná kombinace nebo je-li vyčerpáno všech 12 pokusů. \r\nObtížnost:\r\nLehká: 4-místný kód ze 6 barev\r\nStřední: 5-místný kód z 8 barev\r\nTěžká: 6-místný kód z 10 barev\r\nVlastní: 4 až 10-místný kód ze 4 až 10 barev\r\n";
    }

    // Implementace abstraktní metody KonecHry
    protected override void KonecHry()
    {
        // Zastavení stopky, zobrazení výsledku a zablokování tlačítek
        stopky.Stop();
        UkazVysledek();
        _clear.Enabled = false;
        _testButton.Enabled = false;
    }

    // Metoda pro použití nastavení hry
    protected override void PouzijNastaveni()
    {
        // Nastavení počtu koleček a barev podle uživatelského vstupu
        _kolik = (int)_nvyber.Value;
        _z = (int)_nmoznosti.Value;
        _kod = new int[_kolik];
        var v = new List<int>();
        for (var i = 0; i < _z; i++)
        {
            v.Add(i);
        }
        var rnd = new Random();
        for (var i = 0; i < _kolik; i++)
        {
            var r = rnd.Next() % v.Count;
            _kod[i] = v[r];
            if (!_cBopakovani.Checked)
            {
                v.RemoveAt(r);
            }
        }
    }

    protected override void ProhraVlastni() { }

    // Metoda pro resetování stavu hry
    protected override void Reset()
    {
        _kod = null;
        _kolik = 0;
        _z = 0;
        _aktualniradek = 1;
        uplynulycas = 0;
        stopky?.Dispose();
    }

    protected override void VyhraVlastni() { }

    // Metoda pro vytvoření herní plochy
    protected override void VytvorHerniPlochu()
    {
        switch (obtiznost)
        {
            case Obtiznost.Tezke:
                ziskaneskore = 37200;
                _odcitanibile = 258;
                _odcitanispatne = 516;
                break;
            case Obtiznost.Stredni:
                ziskaneskore = 20800;
                _odcitanibile = 173;
                _odcitanispatne = 346;
                break;
            case Obtiznost.Lehke:
                ziskaneskore = 8400;
                _odcitanibile = 87;
                _odcitanispatne = 175;
                break;
            case Obtiznost.Vlastni:
            default:
                ziskaneskore = 0;
                break;
        }
        plocha = new TableLayoutPanel
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
        for (var i = 0; i < 14; i++)
        {
            plocha.RowStyles.Add(new RowStyle(SizeType.Absolute, _velikostRadku.Height));
        }
        plocha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, _velikostRadku.Width * 2));
        plocha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, _velikostRadku.Width * _kolik));
        plocha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, _velikostRadku.Width * _kolik));
        plocha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, _velikostKolecek.Width * _kolik));
        for (var i = 0; i < 12; i++)
        {
            plocha.Controls.Add(new Label
            {
                Text = (i + 1).ToString(),
                Font = new Font("Segoe UI", 10, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            }, 0, 12 - i);
        }
        var buttonybarev = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            RowCount = 1,
            ColumnCount = _z + 1,
            BackColor = Color.Peru
        };
        plocha.Controls.Add(buttonybarev, 1, 13);
        plocha.SetColumnSpan(buttonybarev, 3);
        for (var i = 0; i < _z; i++)
        {
            buttonybarev.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, _velikostRadku.Width));
            var b = new PictureBox
            {
                Name = i.ToString(),
                BackgroundImage = _obrazky[i],
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = _velikostKolecek
            };
            b.Click += KlikNaBarvu;
            buttonybarev.Controls.Add(b, i, 0);
        }
        buttonybarev.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        _vysledky = NovyPanel();
        for (var i = 0; i < _kolik; i++)
        {
            var l = new PictureBox
            {
                Name = _kod[i].ToString(),
                BackgroundImage = _obrazky[11],
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = _velikostKolecek
            };
            _vysledky.Controls.Add(l, i, 0);
        }
        plocha.Controls.Add(_vysledky, 1, 0);
        _aktualnityp = NovyPanel();
        plocha.Controls.Add(_aktualnityp, 1, 12);
        _testButton = new RoundedButton
        {
            Text = @"Test",
            Dock = DockStyle.Fill,
            BackColor = Color.White
        };
        _testButton.Font = new Font(_testButton.Font, FontStyle.Bold);
        _testButton.Click += Test;
        plocha.Controls.Add(_testButton, 2, 12);
        _clear = new RoundedButton
        {
            Text = @"Clear",
            Dock = DockStyle.Fill,
            BackColor = Color.White

        };
        _clear.Click += (_, _) =>
        {
            if (stav != StavHry.Bezi)
                return;
            _aktualnityp.Controls.Clear();
        };
        plocha.Controls.Add(_clear, 3, 12);
        plocha.Visible = true;
    }

    // Metoda pro testování aktuálního řádku.
    private void Test(object? sender, EventArgs e)
    {
        if (stav != StavHry.Bezi)
            return;
        if (_aktualnityp.Controls.Count < _kolik)
            return;
        plocha.SuspendLayout();
        var odpoved = NovyPanel();
        var spravne = new List<int>();
        spravne.AddRange(_kod);
        var tip = (from Control c in _aktualnityp.Controls select int.Parse(c.Name)).ToList();

        for (var i = 0; i < tip.Count; i++)
        {
            if (spravne[i] != tip[i]) continue;
            odpoved.Controls.Add(new PictureBox
            {
                BackgroundImage = _obrazky[10],
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = _velikostPuntiku
            });
            spravne.RemoveAt(i);
            tip.RemoveAt(i);
            i--;
        }
        if (spravne.Count == 0) { Vyhra(); return; }
        if (_aktualniradek == 12) { Prohra(); return; }
        for (var i = 0; i < tip.Count; i++)
        {
            if (!spravne.Contains(tip[i])) continue;
            odpoved.Controls.Add(new PictureBox
            {
                BackgroundImage = _obrazky[11],
                BackgroundImageLayout = ImageLayout.Stretch,
                Size = _velikostPuntiku
            });
            spravne.Remove(tip[i]);
            tip.RemoveAt(i);
            i--;
            ziskaneskore -= _odcitanibile;
        }
        ziskaneskore -= spravne.Count * _odcitanispatne;
        _aktualnityp = NovyPanel();

        plocha.Controls.Remove(_clear!);
        plocha.Controls.Remove(_testButton!);
        plocha.Controls.Add(_aktualnityp, 1, 12 - _aktualniradek);
        plocha.Controls.Add(_testButton!, 2, 12 - _aktualniradek);
        plocha.Controls.Add(_clear!, 3, 12 - _aktualniradek);
        plocha.Controls.Add(odpoved, 2, 13 - _aktualniradek);
        _aktualniradek++;
        plocha.ResumeLayout();
    }

    // Metoda pro obsluhu kliknutí na barevné kolečko.
    private void KlikNaBarvu(object? sender, EventArgs e)
    {
        if (stav != StavHry.Bezi)
            return;
        if (_aktualnityp.Controls.Count >= _kolik) return;
        var l = (PictureBox)sender;
        if (!_cBopakovani.Checked)
        {
            if (_aktualnityp.Controls.Cast<Control>().Any(c => c.Name.Equals(l.Name)))
            {
                return;
            }
        }
        _aktualnityp.Controls.Add(new PictureBox
        {
            Name = l.Name,
            BackgroundImage = _obrazky[int.Parse(l.Name)],
            BackgroundImageLayout = ImageLayout.Stretch,
            Size = _velikostKolecek
        });
    }
    private TableLayoutPanel NovyPanel()
    {
        var typ = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            RowCount = 1,
            ColumnCount = _kolik + 1
        };
        for (var i = 0; i < _kolik; i++)
        {
            typ.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, _velikostRadku.Width));
        }
        typ.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        return typ;
    }

    // Metoda pro vytvoření bočního panelu.
    protected override void VytvorBocniPanel()
    {
        form.HraBox.ColumnCount = 3;
        form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
        form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
        form.HraBox.RowCount = 14;
        for (var i = 0; i < 14; i++)
        {
            form.HraBox.RowStyles.Add(new RowStyle(SizeType.Percent, (float)100 / 14));
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
        form.HraBox.SetRowSpan(lcas, 5);

        var lopakovani = new Label
        {
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Text = @"Opakování barev:",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lopakovani, 1, 5);
        form.HraBox.SetRowSpan(lopakovani, 3);
        var lo = new Label
        {
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Text = _cBopakovani.Checked ? "Zapnuto" : "Vypnuto",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lo, 2, 5);
        form.HraBox.SetRowSpan(lo, 3);

        Button restart = new RoundedButton
        {
            Text = @"Nová hra",
            Dock = DockStyle.Fill,
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point),
            TextAlign = ContentAlignment.MiddleCenter
        };
        restart.Click += (_, _) => { SpustiHru(); };
        form.HraBox.Controls.Add(restart, 1, 8);
        form.HraBox.SetColumnSpan(restart, 2);
        form.HraBox.SetRowSpan(restart, 3);

        Button ukoncit = new RoundedButton
        {
            Text = @"Ukončit hru",
            Dock = DockStyle.Fill,
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point),
            TextAlign = ContentAlignment.MiddleCenter
        };
        ukoncit.Click += (_, _) => { SpustiUvod(); };
        form.HraBox.Controls.Add(ukoncit, 1, 11);
        form.HraBox.SetColumnSpan(ukoncit, 2);
        form.HraBox.SetRowSpan(ukoncit, 3);

    }

    // Metoda pro zobrazení výsledku.
    private void UkazVysledek()
    {
        foreach (var x in _vysledky.Controls)
        {
            var l = (PictureBox)x;
            l.BackgroundImage = _obrazky[int.Parse(l.Name)];
        }
    }

    // Metoda pro vytvoření úvodní stránky hry.
    protected override void VytvorUvodniStranku()
    {
        //vytvorim rozlozeni
        form.HraBox.ColumnCount = 3;
        form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
        form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));

        form.HraBox.RowCount = 9;
        for (var i = 0; i < 9; i++)
        {
            form.HraBox.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        }

        //vlevo obrazek
        var obrazek = new PictureBox
        {
            Dock = DockStyle.Fill,
            SizeMode = PictureBoxSizeMode.CenterImage,
            Image = Resources.logik_uvod
        };
        form.HraBox.Controls.Add(obrazek, 0, 0);
        form.HraBox.SetRowSpan(obrazek, 9);

        //groupbox obtiznostGB
        var obtiznostGb = new GroupBox
        {
            Dock = DockStyle.Fill,
            Text = @"Obtížnost",
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            FlatStyle = FlatStyle.Flat

        };
        form.HraBox.Controls.Add(obtiznostGb, 1, 0);
        form.HraBox.SetRowSpan(obtiznostGb, 3);
        form.HraBox.SetColumnSpan(obtiznostGb, 2);
        //rozlozeni obtiznosti
        var obtiznostpanel = new TableLayoutPanel
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
        obtiznostGb.Controls.Add(obtiznostpanel);

        var lvyber = new Label
        {
            Text = @"Délka kódu:",
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lvyber, 1, 3);

        var lmoznosti = new Label
        {
            Text = @"Počet barev:",
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lmoznosti, 1, 4);



        if (_nvyber == null || _nmoznosti == null || _cBopakovani == null || _lehke == null || _stredni == null || _tezke == null || _vlastni == null)
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
                if (!_lehke.Checked) return;
                _nvyber.Value = 4;
                _nmoznosti.Value = 6;
                obtiznost = Obtiznost.Lehke;
            };

            _stredni = new RadioButton
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Text = @"Střední",
                Dock = DockStyle.Fill
            };
            _stredni.CheckedChanged += (_, _) =>
            {
                if (!_stredni.Checked) return;
                _nvyber.Value = 5;
                _nmoznosti.Value = 8;
                obtiznost = Obtiznost.Stredni;
            };

            _tezke = new RadioButton
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Text = @"Těžké",
                Dock = DockStyle.Fill
            };
            _tezke.CheckedChanged += (_, _) =>
            {
                if (!_tezke.Checked) return;
                _nvyber.Value = 6;
                _nmoznosti.Value = 10;
                obtiznost = Obtiznost.Tezke;
            };


            _vlastni = new RadioButton
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Text = @"Vlastní",
                Dock = DockStyle.Fill

            };
            _vlastni.CheckedChanged += (_, _) =>
            {
                _nvyber.Enabled = _vlastni.Checked;
                _nmoznosti.Enabled = _vlastni.Checked;
                if (_vlastni.Checked)
                {
                    obtiznost = Obtiznost.Vlastni;
                }

            };


            _nvyber = new NumericUpDown
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Value = 4,
                Minimum = 4,
                Maximum = 6,
                Increment = 1,
                DecimalPlaces = 0,
                Dock = DockStyle.Fill,
                Enabled = false
            };


            _nmoznosti = new NumericUpDown
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
            _nmoznosti.ValueChanged += (_, _) =>
            {
                if (!_cBopakovani.Checked)
                    _nvyber.Maximum = _nmoznosti.Value;
            };

            _cBopakovani = new CheckBox
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Dock = DockStyle.Fill,
                Text = @"S opakováním"
            };
            _cBopakovani.CheckedChanged += (_, _) =>
            {
                _nvyber.Maximum = !_cBopakovani.Checked ? _nmoznosti.Value : 10;
            };
        }
        obtiznostpanel.Controls.Add(_lehke, 0, 0);
        obtiznostpanel.Controls.Add(_stredni, 1, 0);
        obtiznostpanel.Controls.Add(_tezke, 0, 1);
        obtiznostpanel.Controls.Add(_vlastni, 1, 1);
        form.HraBox.Controls.Add(_nvyber, 2, 3);
        form.HraBox.Controls.Add(_nmoznosti, 2, 4);
        form.HraBox.Controls.Add(_cBopakovani, 1, 5);
        form.HraBox.SetColumnSpan(_cBopakovani, 2);

        Button bnavod = new RoundedButton
        {
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            Text = @"Návod"
        };
        bnavod.Click += UkazNavod;
        form.HraBox.Controls.Add(bnavod, 1, 6);
        form.HraBox.SetColumnSpan(bnavod, 2);

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
        form.HraBox.Controls.Add(bstatistiky, 1, 7);
        form.HraBox.SetColumnSpan(bstatistiky, 2);

        Button bhrat = new RoundedButton
        {
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            Text = @"Hrát"
        };
        bhrat.Click += (_, _) => SpustiHru();
        form.HraBox.Controls.Add(bhrat, 1, 8);
        form.HraBox.SetColumnSpan(bhrat, 2);
    }
}