using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace splain
{
    public partial class Form1 : Form
    {
        List<PointF> cPoints = new List<PointF>();
        List<PointF> points = new List<PointF>();
        Point click,clickdel;
        Graphics g;
        Bitmap bmp = new Bitmap(100, 100);
        Pen pen = new Pen(Color.Black, 3);
        Brush brush = new SolidBrush(Color.Red);
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)bmp;
            Draw();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = e.Location;
                cPoints.Add(click);
            }
            else if(e.Button==MouseButtons.Right)
            {
                clickdel = e.Location;
                bool flag = false;
                if (cPoints.Count > 0)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (flag)
                            break;
                        else
                            for (int j = 0; j < 10; j++)
                            {
                                Point del = clickdel;
                                del.X = clickdel.X + i;
                                del.Y = clickdel.Y + j;
                                if (flag)
                                    break;
                                if (cPoints.Contains(del))
                                {
                                    cPoints.Remove(del);
                                    flag = true;
                                }
                            }
                    }
                }
            }
            Draw();
        }

        public void Draw()
        {
            bmp = (Bitmap)pictureBox1.Image;
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            
            for (int i = 0; i < points.Count-1; i++)
            {
                g.DrawLine(pen, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
            }

            for (int i = 0; i< cPoints.Count; i++)
            {
                g.FillEllipse(brush, cPoints[i].X, cPoints[i].Y, 3, 3);
            }

            pictureBox1.Image = (Image)bmp;
        }

        public void de_casteljau()
        {
            points.Clear(); 
            if (cPoints.Count > 0)
            {
                double t = 0;
                while (t <= 1)
                {
                    PointF p = de_casteljau_calc(cPoints, t);
                    points.Add(p);
                    t += 0.001;
                }
            }
            else
                MessageBox.Show("Не задано точек");
        }

        public PointF de_casteljau_calc(List<PointF> sp, double t)
        {
            if (sp.Count == 1)
                return sp[0];
            List<PointF> np = new List<PointF>();
            for (int i = 0; i < sp.Count - 1; i++) 
            {
                PointF pt = new PointF(0, 0);
                pt.X = (float)((1 - t) * sp[i].X + t * sp[i + 1].X);
                pt.Y = (float)((1 - t) * sp[i].Y + t * sp[i + 1].Y);
                np.Add(pt);
            }
            return de_casteljau_calc(np, t);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            de_casteljau();
            Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cPoints.Clear();
            points.Clear();
            Draw();
        }

       
    }
}
