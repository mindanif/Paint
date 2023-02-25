using Paint.Models;

namespace Paint
{
    public partial class Form1 : Form
    {
        private readonly List<Figure> gfs = new List<Figure>();
        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;
        private readonly Painter p; 
        Color phoneColor;
        Color selectedColor;
        private Point? downOn = null;
        //private ArrayPoints arrayPoints = new ArrayPoints(2);
        public Form1()
        {
            InitializeComponent();
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map); phoneColor = Color.White;
            p = new Painter(gfs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedColor = ((Button)sender).BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //на нажатие кнопки мыши (любой) будет создаваться фигура
            Figure? gf = CreateFigure();
            
            if (gf != null)
            {//сразу при создании добавим ей первую точку, зададим цвет и добавим фигуру в пулл русуемых фигур(gfs)
                gf.AddPoint(e.Location);
                gf.Color1 = selectedColor;
                gfs.Add(gf);
                downOn = e.Location;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            downOn = null;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {//при движении мышм добавляем точку для карандаша или обновляем точку у круга или прямоугольника, затем перерисовываем фигуры из пулла
            if (downOn is { } point)
            {
                gfs[^1].AddPoint(e.Location);
                panel1.Refresh();
            }
        }

        private void phonecolorselect_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Устанавливаем цвет фона PictureBox в выбранный цвет
                    pictureBox1.BackColor = dialog.Color;

                    // Сохраняем выбранный цвет в переменную
                    phoneColor = dialog.Color;
                }
            }
        }
        private void LoadImage(string fileName)
        {
            try
            {
                // Загружаем изображение из файла
                Image image = Image.FromFile(fileName);

                // Отображаем изображение в PictureBox
                pictureBox1.Image = image;

                // Обновляем текущий Bitmap для рисования поверх загруженного изображения
                map = new Bitmap(image);

                // Обновляем Graphics объект для нового Bitmap
                graphics = Graphics.FromImage(map);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "JPEG files (*.jpeg;*.jpg)|*.jpeg;";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Создаем новое изображение с выбранным фоном
                    Bitmap bmp = new Bitmap(map.Width, map.Height);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.Clear(phoneColor);
                        g.DrawImage(map, 0, 0);
                    }

                    // Сохраняем новое изображение в формате JPEG
                    bmp.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "JPEG files (*.jpeg;*.jpg)|*.jpeg;";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Загружаем изображение из файла
                    LoadImage(dialog.FileName);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Figure CreateFigure()//создана с целью централизации генерации объектов
        {
            if (radioButton1.Checked)
            {
                var pen = new CustomPen();
                pen.width = trackBar1.Value;
                return pen;
            }

            if (radioButton2.Checked)
            {
                return new CustomEllipse();
            }

            return new CustomRectangle();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            p.Paint(e.Graphics);
        }
    }
}