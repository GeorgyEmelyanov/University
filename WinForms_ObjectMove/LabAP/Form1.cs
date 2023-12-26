using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabAP
{
    public partial class Form1 : Form
    {
        Pen pen = new Pen(Color.Black, 2);
        Point[] points = { new Point(50, 50), new Point(100, 50), new Point(100, 100), new Point(300, 100), new Point(300, 150), new Point(50, 150) };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics l = e.Graphics;
            DrawFigure(l);
        }

        private void DrawFigure(Graphics g)
        {
            g.Clear(BackColor);
            g.DrawPolygon(pen, points);
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            float.TryParse(moveX.Text, out float dx);
            float.TryParse(moveY.Text, out float dy);

            float.TryParse(rotation.Text, out float dr);

            if (!float.TryParse(sizeX.Text, out float sx))
                sx = 1;
            if (!float.TryParse(sizeY.Text, out float sy))
                sy = 1;

            int midX;
            int midY;
            int maxX = 0;
            int maxY = 0;
            int minY = 1000000;
            int minX = 1000000;
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i].X >= maxX)
                    maxX = points[i].X;
                if (points[i].Y >= maxY)
                    maxY = points[i].Y;
                if (points[i].X <= minX)
                    minX = points[i].X;
                if (points[i].Y <= minY)
                    minY = points[i].Y;
            }
            midX = (maxX + minX) / 2;
            midY = (maxY + minY) / 2;
            dr = (float)(dr * Math.PI / 180f);
            for (int i = 0; i < points.Length; i++)
            {
                Point p = points[i];
                p.X -= midX;
                
                p.Y -= midY;
                float x = (float)(p.X * Math.Cos(dr) - p.Y * Math.Sin(dr));
                float y = (float)((points[i].X - midX) * Math.Sin(dr) + p.Y * Math.Cos(dr));
                p.X = (int)(x * sx + dx + midX);
                p.Y = (int)(y * sy + dy + midY);
                points[i] = p;

                
            }
            this.Invalidate();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            moveX.Text = "";
            moveY.Text = "";
            sizeX.Text = "";
            sizeY.Text = "";
            rotation.Text = "";
        }
    }
}
