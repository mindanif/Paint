namespace Paint.Models
{
    // Абстрактный класс, общий для всех других фигур
    public abstract class Figure
    {
        private int? _x1 = null, _x2 = null, _y1 = null, _y2 = null;
        public bool IsExists => _x1 != null && _x2 != null && _y1 != null && _y2 != null;
        public int X => _x1 != null && _x2 != null ? Math.Min(_x1??0, _x2??0) : -1;
        public int Y => _y1 != null && _y2 != null ? Math.Min(_y1??0, _y2??0) : -1;
        public int Width => _x1 != null && _x2 != null ? Math.Abs((_x1 ?? 0) - (_x2 ?? 0)) : 1;
        public int Height => _y1 != null && _y2 != null ? Math.Abs((_y1 ?? 0) - (_y2 ?? 0)) : 1;
        public Color Color1 { get; set; }

        //Прямоугольная область, где рисуется фигура
        public Rectangle Rectangle => new (X, Y, Width, Height);
        
        // Метод рисования
        public abstract void Paint(Graphics g);

        // Метод для добавления точки
        public virtual void AddPoint(Point p)
        {
            if (_x1 == null)
            {
                _x1 = p.X;
                _y1 = p.Y;
            }
            else
            {
                // Если мы попали в первую точку, то второй нет
                if (p.X == _x1 && p.Y == _y1)
                {
                    _x2 = null;
                    _y2 = null;
                }
                else
                {
                    _x2 = p.X;
                    _y2 = p.Y;
                }
            }
        } 
    }
}
