using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LabAFF
{
    public partial class Form1 : Form
    {
        Pen p = new Pen(Color.Black);
        PointF[] a = { new Point(100, 100), new Point(300, 100), new Point(100, 300), new Point(300, 300) };
        PointF[] zero = { new Point(100, 100), new Point(300, 100), new Point(100, 300), new Point(300, 300) };
        float rot = 0;
        float scaleX = 1;
        float scaleY = 1;
        float moveX = 0;
        float moveY = 0;
        public Color color = Color.Red;
        Graphics l;
        Bitmap bmp = new Bitmap(100,100);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbRotate.Text != "")
                rot = float.Parse(tbRotate.Text);
            if (tbScaleX.Text != "") 
                scaleX= float.Parse(tbScaleX.Text);
            if (tbScaleY.Text != "")
                scaleY = float.Parse(tbScaleY.Text);
            if (tbMoveX.Text != "")
                moveX = float.Parse(tbMoveX.Text);
            if (tbMoveY.Text != "")
                moveY = float.Parse(tbMoveY.Text);

            tbRotate.Text = "";
            tbScaleX.Text = "";
            tbScaleY.Text = "";
            tbMoveX.Text = "";
            tbMoveY.Text = "";
            float sX = 200;
            float sY = 200;
            float maxX = 0;
            float maxY = 0;
            float minY = 99999;
            float minX = 99999;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].X >= maxX)
                    maxX = a[i].X;
                if (a[i].Y >= maxY)
                    maxY = a[i].Y;
                if (a[i].X <= minX)
                    minX = a[i].X;
                if (a[i].Y <= minY)
                    minY = a[i].Y;
            }
            sX = (maxX + minX) / 2;
            sY = (maxY + minY) / 2;

            var rotrad = rot * Math.PI / 180;

            for (int i = 0; i < a.Length; i++)
            {
                float x = a[i].X - sX;
                float y = a[i].Y - sY;
                float x1 = (float)(x * Math.Cos(rotrad) - y * Math.Sin(rotrad));
                float y1 = (float)(x * Math.Sin(rotrad) + y * Math.Cos(rotrad));
                x = (sX + moveX + x1 * scaleX);
                y = (sY + moveY + y1 * scaleY);
                a[i].X = x;
                a[i].Y = y;
            }
            Draw();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zero.CopyTo(a, 0);
            color = Color.White;
            Draw();
        }
       

        private void CCButton_Click(object sender, EventArgs e)
        {
            if (ChooseColor.ShowDialog() == DialogResult.OK)
            {
                color = ChooseColor.Color;
                Draw();
                pictureBox1.Invalidate();
            }
        }
        public bool IsNotColored(Color main)
        {
            return (main.ToArgb() != color.ToArgb())&&(main.ToArgb() != p.Color.ToArgb());
        }
        Color GetPixelColor(int x, int y, Bitmap b)
        {
            Color color = BackColor;
            if ((x > 1) && (x <= b.Width - 1) && (y > 1) && (y <= b.Height - 1))
            {
                color = b.GetPixel(x, y);
            }
            return color;
        }
        public void FillZ(int x, int y, Bitmap b)
        {
            Stack<Point> q = new Stack<Point>();
            
            q.Push(new Point(x, y));

            
            while (q.Count > 0)
            {
                Point cur = q.Pop();
                if (cur.X < 1 || cur.Y < 1 || cur.X >= bmp.Width - 1 || cur.Y >= bmp.Height - 1)
                    continue;

                if ((bmp.GetPixel(cur.X, cur.Y).ToArgb()==color.ToArgb())|| (bmp.GetPixel(cur.X, cur.Y).ToArgb() == p.Color.ToArgb()))
                    continue;

                b.SetPixel(cur.X, cur.Y, color);
                
                if ((IsNotColored(bmp.GetPixel(cur.X + 1, cur.Y))) && (!q.Contains(new Point(cur.X + 1, cur.Y)))) 
                    q.Push(new Point(cur.X + 1, cur.Y));
                if ((IsNotColored(bmp.GetPixel(cur.X - 1, cur.Y))) && (!q.Contains(new Point(cur.X - 1, cur.Y)))) 
                    q.Push(new Point(cur.X - 1, cur.Y));
                if ((IsNotColored(bmp.GetPixel(cur.X, cur.Y + 1))) && (!q.Contains(new Point(cur.X, cur.Y + 1))))  
                    q.Push(new Point(cur.X, cur.Y + 1));
                if ((IsNotColored(bmp.GetPixel(cur.X, cur.Y - 1))) && (!q.Contains(new Point(cur.X, cur.Y - 1)))) 
                    q.Push(new Point(cur.X, cur.Y - 1));
            }
        }
        
        void FillS(Bitmap bmp,int p1,int p2)
        {
            PointF mid = new PointF((a[0].X + a[3].X) / 2, (a[0].Y + a[3].Y) / 2);
            int x1m = -1;
            int x2m = -1;
            for (int i=0; i<bmp.Height; i++)
            {
                if (GetPixelColor((int)mid.X, i, bmp).ToArgb() == p.Color.ToArgb())
                {
                    x1m = i;
                    break;
                }
            }
            for (int i = bmp.Height-1; i > 0; i--)
            {
                if (GetPixelColor((int)mid.X, i, bmp).ToArgb() == p.Color.ToArgb())
                {
                    x2m = i;
                    break;
                }
            }
            l.DrawLine(new Pen(p.Color), mid.X, x1m+1, mid.X, x2m-1);
            

            if (p1 > 0)
                p1 -= 1;
            if (p2 + 1 <= bmp.Width)
                p2 += 1;
            for (int i = 0; i < bmp.Height; i++)
            {
                int x1 = -1;
                int x2 = -1;


                for (int j = p1; j <= p2; j++)
                {
                    if (GetPixelColor(j, i, bmp).ToArgb() == p.Color.ToArgb())
                    {
                        x1 = j;
                        break;
                    }   
                }
                for (int j = p2; j >= p1; j--)
                {
                    if (GetPixelColor(j, i, bmp).ToArgb() == p.Color.ToArgb())
                    {
                        x2 = j;
                        break;
                    }
                }

                if ((x1 != -1) && (x2 != -1) && (x2 - x1 > 0))
                    l.DrawLine(new Pen(color), x1+1, i, x2-1, i);

            }
            if(p1> 0)
                l.DrawLine(new Pen(color), mid.X, x1m + 1, mid.X, x2m - 1);
        }

        PointF FindDot(PointF p1,PointF p2, PointF p3)
        {
            float x = (p1.X + p2.X + p3.X) / 3;
            float y = (p1.Y + p2.Y + p3.Y) / 3;
            PointF p = new PointF(x, y);
            return p;
        }
       

        public void Draw()
        {
            PointF mid = new PointF((int)((a[0].X + a[3].X) / 2), (int)((a[0].Y + a[3].Y) / 2));
            bmp = (Bitmap)pictureBox1.Image;
            l = Graphics.FromImage(bmp);
            l.Clear(Color.White);
            l.DrawPolygon(p, a);
            FillS((Bitmap)pictureBox1.Image, 0, (int)mid.X);
            FillS((Bitmap)pictureBox1.Image, (int)mid.X, bmp.Width);
            /*
            
            PointF p1 = FindDot(a[0], a[1], mid);
            PointF p2 = FindDot(a[2], a[3], mid);
            FillZ((int)p1.X, (int)p1.Y, (Bitmap)pictureBox1.Image);
            FillZ((int)p2.X, (int)p2.Y, (Bitmap)pictureBox1.Image);
            */
            l.DrawPolygon(p, a);
            pictureBox1.Image = (Image)bmp;

            rot = 0;
            scaleX = 1;
            scaleY = 1;
            moveX = 0;
            moveY = 0;
        }

    }
}
