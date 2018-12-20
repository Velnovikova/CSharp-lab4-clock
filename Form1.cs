using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;



namespace лаба4сишарп
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 400;
            Height = 400;

        }
        private void Form_Paint(object sender, PaintEventArgs e)
        {
            int w = Width, h = Height;
            Pen cir_pen = new Pen(Color.Black, 5);
            Brush brush = new SolidBrush(Color.Black);
            Graphics g = e.Graphics;
            GraphicsState gs1,gs2,gs3;
            DateTime dt = DateTime.Now;
            g.TranslateTransform(w / 2, h / 2);
            g.ScaleTransform(w / 300, h / 300);
            g.DrawEllipse(cir_pen, -120, -120, 240, 240);
            g.FillEllipse(brush, -10, -10,20, 20);
            gs1 = g.Save();
            g.RotateTransform(6 * dt.Second);
            g.DrawLine(new Pen(new SolidBrush(Color.BlueViolet), 4), 0, 0, 0, -90);
            g.Restore(gs1);


            gs2 = g.Save();
            g.RotateTransform(6 * (dt.Minute + (float)dt.Second / 60));
            g.DrawLine(new Pen(new SolidBrush(Color.Violet), 4), 0, 0, 0, -80);
            g.Restore(gs2);

            gs3 = g.Save();
            g.RotateTransform(30 * (dt.Hour + (float)dt.Minute/60 ));
            g.DrawLine(new Pen(new SolidBrush(Color.Pink), 4), 0, 0, 0, -70);
            g.Restore(gs3);

            g.DrawString("12",new Font("Arial",12), Brushes.Black, new PointF(-10,-110));
            //g.DrawString("10", new Font("Arial", 12), Brushes.Black, new PointF(-110, -55));
           // g.DrawString("11", new Font("Arial", 12), Brushes.Black, new PointF(-110, -55));
            g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(-110, -0));
            g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(-10, 95));
            g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(100, 0));


        }
        private void timer2_Tick(object sender, EventArgs e)
        {
        
            this.Invalidate();
        }
    }
}
