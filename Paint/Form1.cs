namespace Paint
{
    public partial class Form1 : Form
    {
        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 3f);
        Color phoneColor;
        private bool isMouse = false;
        private ArrayPoints arrayPoints = new ArrayPoints(2);
        public Form1()
        {
            InitializeComponent();
            SetSize();
            phoneColor = Color.White;
        }


        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
            arrayPoints = new ArrayPoints(2);


        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse) { return; }
            arrayPoints.SetPoint(e.X, e.Y);
            if (arrayPoints.GetCountPoints() >= 2)
            {
                graphics.DrawLines(pen, arrayPoints.GetPoints());
                pictureBox1.Image = map;
                arrayPoints.SetPoint(e.X, e.Y);
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
    }
}