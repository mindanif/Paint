namespace Paint
{
    public partial class Form1 : Form
    {
        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 3f);
        private bool isMouse = false;
        private ArrayPoints arrayPoints = new ArrayPoints(2);
        public Form1()
        {
            InitializeComponent();
            SetSize();
        }
        
        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
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
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse) { return; }
            arrayPoints.SetPoint(e.X, e.Y);
            if(arrayPoints.GetCountPoints() >= 2)
            {
                graphics.DrawLines(pen, arrayPoints.GetPoints());
                pictureBox1.Image = map;
                arrayPoints.SetPoint(e.X, e.Y);
            }
        }
    }
}