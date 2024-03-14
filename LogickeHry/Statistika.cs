using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogickeHry
{
    internal class Statistika
    {
        GameForm form;
        TableLayoutPanel panel;
        List<Label> nadpisy=new List<Label>();
        internal static Statistika vysledky=new Statistika();
        private Statistika() { 

        }
        
        public void Nastav(GameForm form)
        {
            this.form = form;
            if (form.DostupnaDatabaze)
            {
                panel = new TableLayoutPanel()
                {
                    GrowStyle = TableLayoutPanelGrowStyle.AddRows,
                    ColumnCount = 6,
                    AutoScroll = true,
                    Dock = DockStyle.Fill,
                    CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble,
                    ColumnStyles = { new ColumnStyle(SizeType.Percent, 20), new ColumnStyle(SizeType.Percent, 20), new ColumnStyle(SizeType.Percent, 20), new ColumnStyle(SizeType.Percent, 20), new ColumnStyle(SizeType.Percent, 20), new ColumnStyle(SizeType.Percent, 20) }
                };
                form.StatistikaBox.Controls.Add(panel, 0, 1);
                form.StatistikaBox.SetColumnSpan(panel, 6);
                form.StatistikaBox.VisibleChanged += Aktualizace;
                nadpisy.Add(new Label() { Text = "Jméno", });
                nadpisy.Add(new Label() { Text = "Hra" });
                nadpisy.Add(new Label() { Text = "Obtížnost" });
                nadpisy.Add(new Label() { Text = "Čas (s)" });
                nadpisy.Add(new Label() { Text = "Skóre" });
                nadpisy.Add(new Label() { Text = "Datum" });
                for (int i = 0;i<nadpisy.Count;i++)
                    nadpisy[i].Font=new Font(nadpisy[i].Font, FontStyle.Bold);
            }
            else
            {
                Label text = new Label()
                {
                    Dock = DockStyle.Fill,
                    Text = "Statistiky nejsou k dispozici, protože se nelze připojit k databázi. Zkuste se ujistit, že máte připojení k internetu a restartovat aplikaci.",
                    TextAlign = ContentAlignment.MiddleCenter
                };
                form.StatistikaBox.Controls.Add(text, 0, 1);
                form.StatistikaBox.SetColumnSpan(text, 6);
            }
        }
        public void Aktualizace(object sender, EventArgs e)
        {
            if (form.aktualniuzivatel == null)
            {
                form.StatistikyCBMoje.Checked= false;
                form.StatistikyCBMoje.Enabled= false;
            }
            if (!form.DostupnaDatabaze)
            {
                return;
            }
            List<VysledekHry> s = NactiStatistiky(form.StatistikyCBMoje.Checked ? form.aktualniuzivatel : null, form.StatistikyCBHra.Text, form.StatistikaCBObtiznost.Text);
            panel.SuspendLayout();
            panel.Controls.Clear();
            panel.RowStyles.Clear();
            panel.RowCount = s.Count()+2;
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            for (int i=0; i<nadpisy.Count(); i++)
                panel.Controls.Add(nadpisy[i],i,0);
            for (int i=0;i<s.Count();i++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                panel.Controls.Add(new Label() { Text = s[i].uzivatel.Jmeno, Dock=DockStyle.Fill,TextAlign=ContentAlignment.MiddleCenter }, 0, i+1);
                panel.Controls.Add(new Label() { Text = s[i].hra, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 1, i+1);
                panel.Controls.Add(new Label() { Text = s[i].obtiznost, Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 2, i+1);
                panel.Controls.Add(new Label() { Text = s[i].cas.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 3, i+1);
                panel.Controls.Add(new Label() { Text = s[i].skore.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 4, i + 1);
                panel.Controls.Add(new Label() { Text = s[i].datum.ToString(), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter }, 5, i + 1);
            }
            panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            panel.ResumeLayout(true);
        }
        public List<VysledekHry> NactiStatistiky(Uzivatel u, String hra, String obtiznost)
        {
            if (!form.DostupnaDatabaze)
            {
                return new();
            }
            IQueryable<VysledekHry> x= form.databaze.statistiky.Include(u=>u.uzivatel);
            if(u!=null)
                x=x.Where(e=>e.uzivatel==u);
            if(hra!=null && hra!="" && hra!="Všechny hry")
                x=x.Where(x=>x.hra==hra);
            if(obtiznost!=null && obtiznost!="" && obtiznost!= "Všechny obtížnosti")
                x=x.Where(x=>x.obtiznost==obtiznost);
            return x.OrderByDescending(s=>s.skore).ThenBy(s=>s.cas).ToList();
        }

    }
}
