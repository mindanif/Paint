namespace Paint.Models
{
    internal class CustomPen : Figure
    {
        public int width = 1;
        readonly List<Point> points= new();
        //переопределила метод, который вызывается при движении мыши. просто добавляю в список точек новую
        public override void AddPoint(Point p)
        {
            points.Add(p);
        }
        
        public override void Paint(Graphics g)
        {          
            g.DrawLines(new Pen(Color1, width), points.ToArray());
        }
    }
}
