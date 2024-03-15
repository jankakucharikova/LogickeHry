using System.Drawing.Drawing2D;

namespace LogickeHry
{
    // Třída pro vykreslení tlačítka s kulatými rohy. 
    internal class RoundedButton : Button
    {
        private const int Rdus = 30; 

        // Metoda grafické cesty s kulatými rohy.
        private static GraphicsPath GetRoundPath(RectangleF rect, int radius)
        {
            var r2 = radius / 2f; 
            var graphPath = new GraphicsPath(); 

            // Přidání oblouku pro levý horní roh.
            graphPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            // Přidání úsečky k pravému hornímu rohu.
            graphPath.AddLine(rect.X + r2, rect.Y, rect.Width - r2, rect.Y);
            // Přidání oblouku pro pravý horní roh.
            graphPath.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            // Přidání úsečky k pravému dolnímu rohu.
            graphPath.AddLine(rect.Width, rect.Y + r2, rect.Width, rect.Height - r2);
            // Přidání oblouku pro pravý dolní roh.
            graphPath.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            // Přidání úsečky k levému dolnímu rohu.
            graphPath.AddLine(rect.Width - r2, rect.Height, rect.X + r2, rect.Height);
            // Přidání oblouku pro levý dolní roh.
            graphPath.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            // Přidání úsečky k levému hornímu rohu.
            graphPath.AddLine(rect.X, rect.Height - r2, rect.X, rect.Y + r2);

            graphPath.CloseFigure(); 
            return graphPath; 
        }

        // Přepisuje metodu OnPaint pro vlastní vykreslování tlačítka.
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var rect = new RectangleF(0, 0, Width, Height); // Vytvoří obdélník pro tlačítko.
            using var graphPath = GetRoundPath(rect, Rdus); // Vytvoří tlačítko s kulatými rohy.
            Region = new Region(graphPath); 
            using var pen = new Pen(Color.CadetBlue, 1.75f); 
            pen.Alignment = PenAlignment.Inset;
            e.Graphics.DrawPath(pen, graphPath); // Vykreslí tlačítko.
        }
    }
}