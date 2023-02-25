using System.Drawing.Drawing2D;

namespace Paint.Models
{
    public class CustomEllipse : Figure
    {
        public override void Paint(Graphics g) => g.DrawEllipse(new Pen(Color1), Rectangle);
    }
}
