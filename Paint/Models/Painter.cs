namespace Paint.Models
{
    public class Painter
    {
        private readonly List<Figure> figures;
        public Painter(List<Figure> f)
        {
            figures = f;
        }
        // Для всех прямоугольников из списка рисуем их
        public void Paint(Graphics g)
        {
            foreach (var r in figures)
            {
                r.Paint(g);
            }
        }
    }
}
