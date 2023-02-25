namespace Paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button5 = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            trackBar1 = new TrackBar();
            colorDialog1 = new ColorDialog();
            button14 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 510);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(938, 511);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 2, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 3, 0);
            tableLayoutPanel1.Controls.Add(button14, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(942, 118);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Controls.Add(button10);
            flowLayoutPanel1.Controls.Add(button11);
            flowLayoutPanel1.Controls.Add(button12);
            flowLayoutPanel1.Controls.Add(button13);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Location = new Point(473, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(229, 112);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(39, 3);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 255);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(75, 3);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(111, 3);
            button4.Name = "button4";
            button4.Size = new Size(30, 30);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Blue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(147, 3);
            button6.Name = "button6";
            button6.Size = new Size(30, 30);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button1_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(64, 0, 64);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(183, 3);
            button7.Name = "button7";
            button7.Size = new Size(30, 30);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button1_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(3, 39);
            button8.Name = "button8";
            button8.Size = new Size(30, 30);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button1_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Lime;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(39, 39);
            button9.Name = "button9";
            button9.Size = new Size(30, 30);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button1_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Yellow;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Location = new Point(75, 39);
            button10.Name = "button10";
            button10.Size = new Size(30, 30);
            button10.TabIndex = 9;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button1_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(0, 0, 64);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(111, 39);
            button11.Name = "button11";
            button11.Size = new Size(30, 30);
            button11.TabIndex = 10;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button1_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(192, 64, 0);
            button12.FlatStyle = FlatStyle.Flat;
            button12.Location = new Point(147, 39);
            button12.Name = "button12";
            button12.Size = new Size(30, 30);
            button12.TabIndex = 11;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button1_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.Gray;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Location = new Point(183, 39);
            button13.Name = "button13";
            button13.Size = new Size(30, 30);
            button13.TabIndex = 12;
            button13.UseVisualStyleBackColor = false;
            button13.Click += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(3, 75);
            button5.Name = "button5";
            button5.Size = new Size(60, 30);
            button5.TabIndex = 13;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(trackBar1);
            flowLayoutPanel2.Location = new Point(708, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(231, 112);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 21);
            label1.TabIndex = 0;
            label1.Text = "Изменить размер кисти";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(3, 24);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(228, 56);
            trackBar1.TabIndex = 1;
            trackBar1.Scroll += trackBar1_ValueChanged;
            // 
            // button14
            // 
            button14.Location = new Point(3, 3);
            button14.Name = "button14";
            button14.Size = new Size(94, 29);
            button14.TabIndex = 2;
            button14.Text = "button14";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 658);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button5;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private TrackBar trackBar1;
        private ColorDialog colorDialog1;
        private PictureBox pictureBox1;
        private Button button14;
    }
}