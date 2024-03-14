
using LogickeHry.Properties;

namespace LogickeHry;

internal class Miny : Hra
{
    private readonly List<Bitmap> _obrazky;
    private const int HodnotaBomby = 1000;
    private int[,] _mapka;
    private NumericUpDown? _nvyska, _nsirka, _npocmin;
    private RadioButton? _lehke, _stredni, _tezke, _vlastni;
    private Label? _lmin, _lpolicek;
    private Button? _hint;
    private int _hintu = 3;
    private List<Button>? _tlacitka;
    private int _sirka, _vyska, _pocmin, _pocetVlajek, _pocetpolicek;
    private double _multiplikator, _ziskLevel;
    private double _skoredesetine;
    public Miny(GameForm form) : base(form)
    {
        nazev = "Miny";
        _obrazky = NactiIkonky(Resources.miny);
        navod = "Pole je poseto minami, které musí hráč najít a neodkrýt, nebo je označit pravým tlačítkem myši (vlajkou). \r\nKliknutím na poličko se hráč doví jestli políčko obsahuje minu nebo nikoliv. Pokud jo, hra je ukončena prohrou, pokud ne, na políčku se objeví číslo s počtem bomb v jejím nejbližším okolí (na všech osmi políčkách s ním sousedících). \r\nPokud je zřejmé, že některé neodkryté políčko obsahuje minu, hráč může pro přehlednost označit políčko vlaječkou. Tímto se stává políčko neaktivní pro další neúmyslné odkrytí.\r\nHráč může také použít 3 hinty, kdy je odhaleno náhodné bezpečné políčko.\r\nTlačítko „Nová hra“ vygeneruje nové hrací pole.\r\nStisknutím tlačítka „Ukončit hru“ se hráč dostane zpět na úvodní stránku hry.\r\nPo odkrytí všech polí bez min hráč vyhrává.\r\nObtížnost: \r\nLehká: pole o velikosti 9x9, počet min 10\r\nStřední: pole o velikosti 16x16, počet min 40\r\nTěžká: pole o velikosti 30x16, počet min 99\r\nVlastní: pole o velikosti 9x9 – 30x24, počet min 10–667, maximálně (x − 1) × (y − 1); x, y = rozměry hracího pole\r\n";
    }

    //reset do uvodniho stavu
    protected override void Reset()
    {
        _hintu = 3;
        _vyska = 0;
        _sirka = 0;
        _pocmin = 0;
        _pocetVlajek = 0;
        _pocetpolicek = 0;
        uplynulycas = 0;
        ziskaneskore = 0;
        _skoredesetine = 0;
        stopky?.Dispose();

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
        for (var i = 0; i < 9; i++)
        {
            form.HraBox.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
        }

        //vlevo obrazek
        var obrazek = new PictureBox
        {
            Dock = DockStyle.Fill,
            SizeMode = PictureBoxSizeMode.CenterImage,
            Image = Resources.miny_uvod
        };
        form.HraBox.Controls.Add(obrazek, 0, 0);
        form.HraBox.SetRowSpan(obrazek, 9);

        //groupbox obtiznostGB
        var obtiznostGb = new GroupBox
        {
            Dock = DockStyle.Fill,
            Text = @"Obtížnost",
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        };
        form.HraBox.Controls.Add(obtiznostGb, 1, 0);
        form.HraBox.SetRowSpan(obtiznostGb, 3);
        form.HraBox.SetColumnSpan(obtiznostGb, 2);
        //rozlozeni obtiznosti
        var obtiznostpanel = new TableLayoutPanel
        {
            ColumnCount = 2,
            RowCount = 2,
            Dock = DockStyle.Fill
        };
        obtiznostpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
        obtiznostpanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
        obtiznostpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
        obtiznostpanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
        obtiznostGb.Controls.Add(obtiznostpanel);

        var lvyska = new Label
        {
            Text = @"Výška:",
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lvyska, 1, 3);

        var lsirka = new Label
        {
            Text = @"Šířka:",
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lsirka, 1, 4);

        var lpocmin = new Label
        {
            Text = @"Počet min:",
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lpocmin, 1, 5);

        if (_nvyska == null || _nsirka == null || _npocmin == null || _lehke == null || _stredni == null || _tezke == null || _vlastni == null)
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
                NastavRozmery(9, 9, 10);
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
                NastavRozmery(16, 16, 40);
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
                NastavRozmery(30, 16, 99);
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
                PrepniNaVlastni(_vlastni.Checked);
                if (_vlastni.Checked)
                {
                    obtiznost = Obtiznost.Vlastni;
                }
            };


            _nvyska = new NumericUpDown
            {
                Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
                Value = 9,
                Minimum = 9,
                Maximum = 30,
                Increment = 1,
                DecimalPlaces = 0,
                Dock = DockStyle.Fill,
                Enabled = false
            };
            _nvyska.ValueChanged += (_, _) => _npocmin.Maximum = (_nvyska.Value - 1) * (_nsirka.Value - 1);


            _nsirka = new NumericUpDown
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
            _nsirka.ValueChanged += (_, _) => _npocmin.Maximum = (_nvyska.Value - 1) * (_nsirka.Value - 1);


            _npocmin = new NumericUpDown
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
        obtiznostpanel.Controls.Add(_lehke, 0, 0);
        obtiznostpanel.Controls.Add(_stredni, 1, 0);
        obtiznostpanel.Controls.Add(_tezke, 0, 1);
        obtiznostpanel.Controls.Add(_vlastni, 1, 1);
        form.HraBox.Controls.Add(_nvyska, 2, 3);
        form.HraBox.Controls.Add(_nsirka, 2, 4);
        form.HraBox.Controls.Add(_npocmin, 2, 5);

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

    //Pouzij nastaveni
    protected override void PouzijNastaveni()
    {
        _sirka = (int)_nsirka.Value;
        _vyska = (int)_nvyska.Value;
        _pocmin = (int)_npocmin.Value;
        _mapka = new int[_sirka, _vyska];
        Generuj();
    }
    private void Generuj()
    {
        _pocetpolicek = _vyska * _sirka - _pocmin;
        var vyber = new List<int>();
        for (var i = 0; i < _vyska * _sirka; i++)
        {
            vyber.Add(i < _pocmin ? HodnotaBomby : 0);
        }
        var rnd = new Random();
        for (var i = 0; i < _sirka; i++)
        {
            for (var j = 0; j < _vyska; j++)
            {
                var r = rnd.Next() % vyber.Count;
                _mapka[i, j] = vyber[r];
                vyber.RemoveAt(r);
            }
        }
        for (var i = 0; i < _sirka; i++)
        {
            for (var j = 0; j < _vyska; j++)
            {
                if (_mapka[i, j] == HodnotaBomby) continue;
                for (var k = Math.Max(0, i - 1); k < Math.Min(i + 2, _sirka); k++)
                {
                    for (var l = Math.Max(0, j - 1); l < Math.Min(j + 2, _vyska); l++)
                    {
                        if (k != i || l != j)
                            _mapka[i, j] += _mapka[k, l];
                    }
                }
                _mapka[i, j] /= HodnotaBomby;
            }
        }

    }

    protected override void VytvorBocniPanel()
    {
        form.HraBox.ColumnCount = 3;
        form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
        form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));
        form.HraBox.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150));

        form.HraBox.RowCount = 7;
        for (var i = 0; i < 7; i++)
        {
            form.HraBox.RowStyles.Add(new RowStyle(SizeType.Percent, (float)100 / 6));
        }


        lcas = new Label
        {
            Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point),
            Text = @"0:00",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lcas, 1, 0);
        form.HraBox.SetColumnSpan(lcas, 2);
        var lskoretext = new Label
        {
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Text = @"Skóre:",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lskoretext, 1, 1);
        lskore = new Label
        {
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Text = @"0",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lskore, 2, 1);
        var lm = new Label
        {
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Text = @"Zbývá min:",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lm, 1, 2);

        _lmin = new Label
        {
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Text = _pocmin.ToString(),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(_lmin, 2, 2);

        var lp = new Label
        {
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Text = @"Zbývá volných políček:",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(lp, 1, 3);

        _lpolicek = new Label
        {
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            Text = _pocetpolicek.ToString(),
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter
        };
        form.HraBox.Controls.Add(_lpolicek, 2, 3);

        _hint = new RoundedButton
        {
            Text = $@"Hint({_hintu})",
            Dock = DockStyle.Fill,
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            TextAlign = ContentAlignment.MiddleCenter
        };
        _hint.Click += Hint_Click;

        form.HraBox.Controls.Add(_hint, 1, 4);
        form.HraBox.SetColumnSpan(_hint, 2);

        Button restart = new RoundedButton
        {
            Text = @"Nová hra",
            Dock = DockStyle.Fill,
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            TextAlign = ContentAlignment.MiddleCenter
        };
        restart.Click += (_, _) => { SpustiHru(); };
        form.HraBox.Controls.Add(restart, 1, 5);
        form.HraBox.SetColumnSpan(restart, 2);

        Button ukoncit = new RoundedButton
        {
            Text = @"Ukončit hru",
            Dock = DockStyle.Fill,
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point),
            TextAlign = ContentAlignment.MiddleCenter
        };
        ukoncit.Click += (_, _) => { SpustiUvod(); };
        form.HraBox.Controls.Add(ukoncit, 1, 6);
        form.HraBox.SetColumnSpan(ukoncit, 2);

    }

    private void Hint_Click(object? sender, EventArgs e)
    {
        if (stav != StavHry.Bezi)
            return;
        if (_hintu < 1)
            return;
        _hintu--;
        _hint.Text = $@"Hint({_hintu})";
        var rnd = new Random();
        var kliknutelne = from b in _tlacitka where JeKliknutelne(b) select b;
        var enumerable = kliknutelne as Button[] ?? kliknutelne.ToArray();
        var k = enumerable.ElementAt(rnd.Next() % enumerable.Length);
        var pred = _pocetpolicek;
        levy_klik(k);
        var odekryto = pred - _pocetpolicek;
        _skoredesetine -= _multiplikator * _ziskLevel * odekryto * 2;
        ziskaneskore = (int)_skoredesetine;
        lskore.Text = ziskaneskore.ToString();
        Obnoveni();
    }
    private bool JeKliknutelne(Button b)
    {
        var parametry = b.Name.Split(" ");
        var i = int.Parse(parametry[0]);
        var j = int.Parse(parametry[1]);
        if (parametry[2].Equals("true"))
            return false;
        if (parametry[3].Equals("false"))
            return false;
        return _mapka[i, j] != HodnotaBomby;
    }

    protected override void VytvorHerniPlochu()
    {
        stopky.Tick += (_, _) =>
        {
            if (uplynulycas % 15 != 14) return;
            if (_multiplikator > 0)
                _multiplikator--;
        };
        switch (obtiznost)
        {
            case Obtiznost.Lehke:
                _multiplikator = 20;
                _ziskLevel = 4;
                break;
            case Obtiznost.Stredni:
                _multiplikator = 40;
                _ziskLevel = 1.9;
                break;
            case Obtiznost.Tezke:
                _multiplikator = 60;
                _ziskLevel = 1.9;
                break;
            case Obtiznost.Vlastni:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        _tlacitka = new List<Button>();
        plocha = new TableLayoutPanel
        {
            Anchor = AnchorStyles.None,
            AutoScroll = true,
            AutoSize = true
        };
        form.HraBox.Controls.Add(plocha, 0, 0);
        form.HraBox.SetRowSpan(plocha, 7);
        plocha.Visible = false;
        var rozmerbuttonu = new Size(50, 50);
        plocha.RowCount = _vyska;
        plocha.ColumnCount = _sirka;
        plocha.RowStyles.Clear();
        for (var i = 0; i < _vyska; i++)
        {
            plocha.RowStyles.Add(new RowStyle(SizeType.Absolute, rozmerbuttonu.Height));
        }
        plocha.ColumnStyles.Clear();
        for (var i = 0; i < _sirka; i++)
        {
            plocha.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, rozmerbuttonu.Width));
        }
        for (var i = 0; i < _sirka; i++)
        {
            for (var j = 0; j < _vyska; j++)
            {
                var b = new Button();
                b.Name = $"{i} {j} false true";
                b.Image = _obrazky[11];
                b.Size = rozmerbuttonu;
                b.Anchor = AnchorStyles.None;
                b.Font = new Font("Segoe UI", 14, FontStyle.Bold, GraphicsUnit.Point);
                b.MouseDown += vyhodnot_kliknuti;
                b.Margin = new Padding(0);
                b.Padding = new Padding(0);
                _tlacitka.Add(b);
                plocha.Controls.Add(b, i, j);
            }
        }
        plocha.Visible = true;
    }

    //Procedury vyvolavane eventy
    private void vyhodnot_kliknuti(object s, MouseEventArgs e)
    {
        if (stav != StavHry.Bezi)
            return;
        var b = (Button)s;
        var x = b.Name.Split(' ');
        var enabled = x[3];
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

    private void levy_klik(Button b, bool konec = false)
    {
        lock (b)
        {
            var parametry = b.Name.Split(' ');
            var enabled = parametry[3];
            var i = int.Parse(parametry[0]);
            var j = int.Parse(parametry[1]);
            if (!enabled.Equals("true"))
                return;

            var vlajka = parametry[2];

            if (vlajka.Equals("false"))
            {
                b.Name = $"{i} {j} {vlajka} false";
                if (_mapka[i, j] != HodnotaBomby)
                {
                    b.Image = _obrazky[_mapka[i, j]];
                    _pocetpolicek--;
                    if (konec) return;
                    _skoredesetine += _multiplikator * _ziskLevel;
                    ziskaneskore = (int)_skoredesetine;
                    lskore.Text = ziskaneskore.ToString();
                    if (_mapka[i, j] != 0) return;
                    foreach (var t in from t in _tlacitka let s = t.Name.Split(' ') let x = int.Parse(s[0]) let y = int.Parse(s[1]) where Math.Abs(i - x) <= 1 && Math.Abs(j - y) <= 1 select t)
                    {
                        levy_klik(t);
                    }
                }
                else
                {
                    b.Image = _obrazky[9];

                    if (stav != StavHry.Bezi) return;
                    b.BackColor = Color.Red;
                    Prohra();
                }

            }
            else if (konec)
            {
                if (_mapka[i, j] != HodnotaBomby)
                    b.Image = _obrazky[12];
            }
        }
    }

    private void pravy_klik(Button b)
    {
        var x = b.Name.Split(' ');
        var i = int.Parse(x[0]);
        var j = int.Parse(x[1]);
        var vlajka = x[2];
        var enabled = x[3];
        if (!enabled.Equals("true"))
            return;
        if (vlajka.Equals("false"))
        {
            b.Image = _obrazky[10];
            _pocetVlajek++;
            b.Name = $"{i} {j} true {enabled}";
        }
        else
        {
            b.Image = _obrazky[11];
            _pocetVlajek--;
            b.Name = $"{i} {j} false {enabled}";
        }
    }


    private void NastavRozmery(int vyska, int sirka, int pocbomb)
    {
        _nvyska.Value = vyska;
        _nsirka.Value = sirka;
        _npocmin.Value = pocbomb;
    }
    private void PrepniNaVlastni(bool zap)
    {
        _nvyska.Enabled = zap;
        _nsirka.Enabled = zap;
        _npocmin.Enabled = zap;

    }


    private void Obnoveni()
    {
        _lmin.Text = (_pocmin - _pocetVlajek).ToString();
        _lpolicek.Text = _pocetpolicek.ToString();
        if (_pocetpolicek == 0 && stav == StavHry.Bezi)
            Vyhra();
    }

    protected override void KonecHry()
    {
        stopky.Stop();
    }

    protected override void ProhraVlastni()
    {
        foreach (var b in _tlacitka)
        {
            levy_klik(b, true);
        }
    }

    protected override void VyhraVlastni()
    {
        if (_multiplikator > 0)
        {
            _skoredesetine += _multiplikator * 15 * 2;
            _skoredesetine += (15 - uplynulycas % 15) * 2;
        }
        ziskaneskore = (int)_skoredesetine;
        lskore.Text = ziskaneskore.ToString();
    }


}