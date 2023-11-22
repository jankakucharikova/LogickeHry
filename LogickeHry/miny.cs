using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogickeHry
{
    internal class miny
    {
        static int hodnota_bomby = 1000;
        int[,] mapka;
        GameForm form;
        int sirka, vyska, pocmin,pocet_vlajek;
        public miny(GameForm form)
        {
            this.form = form;
            sirka = (int)form.MinyUvodNSirka.Value;
            vyska = (int)form.MinyUvodNVyska.Value;
            pocmin = (int)form.MinyUvodNPocMin.Value;
            mapka = new int[sirka, vyska];
            generuj();
            vytvor_tlacitka();
            //spusti_hru();
        }

        private void spusti_hru()
        {
            throw new NotImplementedException();
        }

        private void vytvor_tlacitka()
        {
            form.MinyHraTPlocha.RowCount = vyska;
            form.MinyHraTPlocha.ColumnCount = sirka;
            form.MinyHraTPlocha.RowStyles.Clear();
            for (int i = 0; i < vyska; i++)
            {
                form.MinyHraTPlocha.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / vyska));
            }
            form.MinyHraTPlocha.ColumnStyles.Clear();
            for (int i = 0; i < vyska; i++)
            {
                form.MinyHraTPlocha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / vyska));
            }
            for (int i = 0; i < sirka; i++)
            {
                for (int j = 0; j < vyska; j++)
                {
                    Button b=new Button();
                    b.Name = $"{i} {j}";
                    b.Text = "";
                    b.Dock = DockStyle.Fill;
                    b.Font = new Font("Segoe UI", b.Size.Height, FontStyle.Bold, GraphicsUnit.Point);
                    b.MouseDown += (s, e) => vyhodnot_kliknuti(s, e) ;
                    form.MinyHraTPlocha.Controls.Add(b,i,j);
                }
            }
        }
        internal void vyhodnot_kliknuti(object s, MouseEventArgs e)
        {
            Button b=(Button)s;
            String[] x=b.Name.Split(' ');
            int i = int.Parse(x[0]);
            int j = int.Parse(x[1]);
            switch (e.Button)
            {
                case MouseButtons.Left:
                    levy_klik(b, i, j);
                    break;

                case MouseButtons.Right:
                    pravy_klik(b);
                    break;
}
        }
        public void levy_klik(Button b, int i, int j)
        {
            if (!b.Text.Equals("\U0001F6A9"))
            {
                b.Text = mapka[i, j].ToString();
                b.Enabled = false;
            }
        }

        public void pravy_klik(Button b)
        {
            if (!b.Text.Equals("\U0001F6A9"))
            {
                b.Text = "\U0001F6A9";
                pocet_vlajek++;
            }
            else
            {
                b.Text = "";
                pocet_vlajek--;
            }
        }

        private void generuj()
        {
            List<int> vyber = new List<int>();
            for(int i=0;i<vyska*sirka;i++)
            {
                vyber.Add(i<pocmin?hodnota_bomby:0);
            }
            Random rnd= new Random();
            for(int i=0; i<sirka;i++)
            {
                for(int j=0; j<vyska;j++)
                {
                    int r = rnd.Next() % vyber.Count;
                    mapka[i, j] = vyber[r];
                    vyber.RemoveAt(r);
                }
            }
            for (int i = 0; i < sirka; i++)
            {
                for (int j = 0; j < vyska; j++)
                {
                    if(mapka[i, j] != hodnota_bomby)
                    {
                        for (int k = Math.Max(0, i - 1); k < Math.Min(i + 2, sirka); k++)
                            for (int l = Math.Max(0, j - 1); l < Math.Min(j + 2, vyska); l++)
                                if(k!=i || l!=j)
                                    mapka[i, j] += mapka[k, l];
                        mapka[i, j] /= hodnota_bomby;
                    }
                }
            }
            
        }
    }
}
