using Microsoft.EntityFrameworkCore;

namespace LogickeHry;

internal class Statistika
{
    private GameForm _form;
    private TableLayoutPanel _panel;
    private readonly List<Label> _nadpisy = new();
    internal static readonly Statistika Vysledky = new();
    private Statistika()
    {

    }

    public void Nastav(GameForm form)
    {
        _form = form;
        if (form.dostupnaDatabaze)
        {
            _panel = new TableLayoutPanel
            {
                GrowStyle = TableLayoutPanelGrowStyle.AddRows,
                ColumnCount = 6,
                AutoScroll = true,
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble,
                ColumnStyles = { new ColumnStyle(SizeType.Percent, 20), new ColumnStyle(SizeType.Percent, 20), new ColumnStyle(SizeType.Percent, 20), new ColumnStyle(SizeType.Percent, 20), new ColumnStyle(SizeType.Percent, 20), new ColumnStyle(SizeType.Percent, 20) }
            };
            form.StatistikaBox.Controls.Add(_panel, 0, 1);
            form.StatistikaBox.SetColumnSpan(_panel, 6);
            form.StatistikaBox.VisibleChanged += Aktualizace;
            _nadpisy.Add(new Label { Text = @"Jméno" });
            _nadpisy.Add(new Label { Text = @"Hra" });
            _nadpisy.Add(new Label { Text = @"Obtížnost" });
            _nadpisy.Add(new Label { Text = @"Čas (s)" });
            _nadpisy.Add(new Label { Text = @"Skóre" });
            _nadpisy.Add(new Label { Text = @"Datum" });
            foreach (var t in _nadpisy)
                t.Font = new Font(t.Font, FontStyle.Bold);
        }
        else
        {
            var text = new Label
            {
                Dock = DockStyle.Fill,
                Text = @"Statistiky nejsou k dispozici, protože se nelze připojit k databázi. Zkuste se ujistit, že máte připojení k internetu a restartovat aplikaci.",
                TextAlign = ContentAlignment.MiddleCenter
            };
            form.StatistikaBox.Controls.Add(text, 0, 1);
            form.StatistikaBox.SetColumnSpan(text, 6);
        }
    }
    public void Aktualizace(object sender, EventArgs e)
    {
        if (_form.aktualniuzivatel == null)
        {
            _form.StatistikyCBMoje.Checked = false;
            _form.StatistikyCBMoje.Enabled = false;
        }
        if (!_form.dostupnaDatabaze)
        {
            return;
        }
        var s = NactiStatistiky(_form.StatistikyCBMoje.Checked ? _form.aktualniuzivatel : null, _form.StatistikyCBHra.Text, _form.StatistikaCBObtiznost.Text);
        _panel.SuspendLayout();
        _panel.Controls.Clear();
        _panel.RowStyles.Clear();
        _panel.RowCount = s.Count + 2;
        _panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        for (var i = 0; i < _nadpisy.Count; i++)
            _panel.Controls.Add(_nadpisy[i], i, 0);
        for (var i = 0; i < s.Count; i++)
        {
            _panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            _panel.Controls.Add(new Label { Text = s[i].uzivatel.jmeno, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 0, i + 1);
            _panel.Controls.Add(new Label { Text = s[i].hra, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 1, i + 1);
            _panel.Controls.Add(new Label { Text = s[i].obtiznost, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 2, i + 1);
            _panel.Controls.Add(new Label { Text = s[i].cas.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 3, i + 1);
            _panel.Controls.Add(new Label { Text = s[i].obtiznost != Obtiznost.Vlastni.ToString() ? s[i].skore.ToString() : "Nelze unifikovat", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 4, i + 1);
            _panel.Controls.Add(new Label { Text = s[i].datum.ToString("g"), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 5, i + 1);
        }
        _panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _panel.ResumeLayout(true);
    }

    private List<VysledekHry> NactiStatistiky(Uzivatel? u, string? hra, string? obtiznost)
    {
        if (!_form.dostupnaDatabaze)
        {
            return new List<VysledekHry>();
        }
        IQueryable<VysledekHry> x = _form.databaze.Statistiky.Include(d => d.uzivatel);
        if (u != null)
            x = x.Where(e => e.uzivatel == u);
        if (!string.IsNullOrEmpty(hra) && hra != "Všechny hry")
            x = x.Where(e => e.hra == hra);
        if (!string.IsNullOrEmpty(obtiznost) && obtiznost != "Všechny obtížnosti")
            x = x.Where(e => e.obtiznost == obtiznost);
        return x.OrderByDescending(s => s.skore).ThenBy(s => s.cas).ToList();
    }

}