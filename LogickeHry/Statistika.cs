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
        internal static Statistika vysledky=new Statistika();
        private Statistika() { 

        }
        
        public void Nastav(GameForm form)
        {
            this.form = form;
            panel = new TableLayoutPanel()
            {
                GrowStyle = TableLayoutPanelGrowStyle.AddRows,
                ColumnCount = 4,
                AutoScroll = true,
                Dock = DockStyle.Fill,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetDouble,
                ColumnStyles = { new ColumnStyle(SizeType.Percent,25), new ColumnStyle(SizeType.Percent,25), new ColumnStyle(SizeType.Percent,25), new ColumnStyle(SizeType.Percent,25)}
            };
            form.StatistikaBox.Controls.Add(panel,0,1);
            form.StatistikaBox.SetColumnSpan(panel, 6);
            form.StatistikaBox.VisibleChanged += Aktualizace;
        }
        public void Aktualizace(object sender, EventArgs e)
        {
            List<vysledek_hry> s = NactiStatistiky(form.StatistikyCBMoje.Checked ? form.aktualniuzivatel : null, form.StatistikyCBHra.Text, form.StatistikaCBObtiznost.Text);
            panel.Controls.Clear();
            panel.RowStyles.Clear();
            panel.RowCount = s.Count;
            for(int i=0;i<s.Count();i++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                panel.Controls.Add(new Label() { Text = s[i].uzivatel.Jmeno }, 0, i);
                panel.Controls.Add(new Label() { Text = s[i].hra }, 1, i);
                panel.Controls.Add(new Label() { Text = s[i].obtiznost }, 2, i);
                panel.Controls.Add(new Label() { Text = s[i].cas.ToString() }, 3, i);

            }
        }
        public List<vysledek_hry> NactiStatistiky(Uzivatel u, String hra, String obtiznost)
        {
            IQueryable<vysledek_hry> x= form.databaze.statistiky;
            if(u!=null)
                x=x.Where(e=>e.uzivatel==u);
            if(hra!=null && hra!="")
                x=x.Where(x=>x.hra==hra);
            if(obtiznost!=null && obtiznost!="")
                x=x.Where(x=>x.obtiznost==obtiznost);
            List<vysledek_hry> s=x.ToList();
            s.Sort((x, y) => x.cas.CompareTo(y.cas));
            return s;
        }

    }
}
