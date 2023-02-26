using System.Drawing.Drawing2D;

namespace Paint.Models
{
    public class CustomRectangle : Figure
    {//убрала лишние скобки, оставив только это
        public override void Paint(Graphics g)
        {
            var p = new Pen(Color1);
            g.DrawRectangle(p, Rectangle);
        }
    }
}
