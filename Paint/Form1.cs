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
            //íà íàæàòèå êíîïêè ìûøè (ëþáîé) áóäåò ñîçäàâàòüñÿ ôèãóðà
            Figure? gf = CreateFigure();
            
            if (gf != null)
            {//ñðàçó ïðè ñîçäàíèè äîáàâèì åé ïåðâóþ òî÷êó, çàäàäèì öâåò è äîáàâèì ôèãóðó â ïóëë ðóñóåìûõ ôèãóð(gfs)
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
        {//ïðè äâèæåíèè ìûøì äîáàâëÿåì òî÷êó äëÿ êàðàíäàøà èëè îáíîâëÿåì òî÷êó ó êðóãà èëè ïðÿìîóãîëüíèêà, çàòåì ïåðåðèñîâûâàåì ôèãóðû èç ïóëëà
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
                    // Óñòàíàâëèâàåì öâåò ôîíà PictureBox â âûáðàííûé öâåò
                    pictureBox1.BackColor = dialog.Color;

                    // Ñîõðàíÿåì âûáðàííûé öâåò â ïåðåìåííóþ
                    phoneColor = dialog.Color;
                }
            }
        }
        private void LoadImage(string fileName)
        {
            try
            {
                // Çàãðóæàåì èçîáðàæåíèå èç ôàéëà
                Image image = Image.FromFile(fileName);

                // Îòîáðàæàåì èçîáðàæåíèå â PictureBox
                pictureBox1.Image = image;

                // Îáíîâëÿåì òåêóùèé Bitmap äëÿ ðèñîâàíèÿ ïîâåðõ çàãðóæåííîãî èçîáðàæåíèÿ
                map = new Bitmap(image);

                // Îáíîâëÿåì Graphics îáúåêò äëÿ íîâîãî Bitmap
                graphics = Graphics.FromImage(map);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ñîõðàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "JPEG files (*.jpeg;*.jpg)|*.jpeg;";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Ñîçäàåì íîâîå èçîáðàæåíèå ñ âûáðàííûì ôîíîì
                    Bitmap bmp = new Bitmap(map.Width, map.Height);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.Clear(phoneColor);
                        g.DrawImage(map, 0, 0);
                    }

                    // Ñîõðàíÿåì íîâîå èçîáðàæåíèå â ôîðìàòå JPEG
                    bmp.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void çàãðóçèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "JPEG files (*.jpeg;*.jpg)|*.jpeg;";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Çàãðóæàåì èçîáðàæåíèå èç ôàéëà
                    LoadImage(dialog.FileName);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Figure CreateFigure()//ñîçäàíà ñ öåëüþ öåíòðàëèçàöèè ãåíåðàöèè îáúåêòîâ
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

        private void phonecolorselect_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Óñòàíàâëèâàåì öâåò ôîíà PictureBox â âûáðàííûé öâåò
                    pictureBox1.BackColor = dialog.Color;

                    // Ñîõðàíÿåì âûáðàííûé öâåò â ïåðåìåííóþ
                    phoneColor = dialog.Color;
                }
            }
        }
        private void LoadImage(string fileName)
        {
            try
            {
                // Çàãðóæàåì èçîáðàæåíèå èç ôàéëà
                Image image = Image.FromFile(fileName);

                // Îòîáðàæàåì èçîáðàæåíèå â PictureBox
                pictureBox1.Image = image;

                // Îáíîâëÿåì òåêóùèé Bitmap äëÿ ðèñîâàíèÿ ïîâåðõ çàãðóæåííîãî èçîáðàæåíèÿ
                map = new Bitmap(image);

                // Îáíîâëÿåì Graphics îáúåêò äëÿ íîâîãî Bitmap
                graphics = Graphics.FromImage(map);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ñîõðàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "JPEG files (*.jpeg;*.jpg)|*.jpeg;";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Ñîçäàåì íîâîå èçîáðàæåíèå ñ âûáðàííûì ôîíîì
                    Bitmap bmp = new Bitmap(map.Width, map.Height);
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.Clear(phoneColor);
                        g.DrawImage(map, 0, 0);
                    }

                    // Ñîõðàíÿåì íîâîå èçîáðàæåíèå â ôîðìàòå JPEG
                    bmp.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        private void çàãðóçèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "JPEG files (*.jpeg;*.jpg)|*.jpeg;";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Çàãðóæàåì èçîáðàæåíèå èç ôàéëà
                    LoadImage(dialog.FileName);
                }
            }
        }
    }
}