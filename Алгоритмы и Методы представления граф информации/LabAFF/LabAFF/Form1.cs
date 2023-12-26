using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace LabAFF
{
    public partial class Form1 : Form
    {
        Pen p = new Pen(Color.Black, 3);
        PointF[] a = { new Point(100, 100), new Point(300, 100), new Point(100, 300), new Point(300, 300) };
        PointF[] zero = { new Point(100, 100), new Point(300, 100), new Point(100, 300), new Point(300, 300) };
        float rot = 0;
        float scaleX = 1;
        float scaleY = 1;
        float moveX = 0;
        float moveY = 0;
        Graphics l;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            l = e.Graphics;
            l.Clear(BackColor);// Очистка поверхности
            l.FillPolygon(Brushes.Yellow, a);
            l.DrawPolygon(p, a);
            /*
            using (Matrix m = new Matrix()) // Создание матрицы аффинных преобразований
            {
                m.RotateAt(rot, new Point(sX, sY));//Поворот на rot° вокруг центра фигуры
                m.Translate(moveX, moveY);//Перенос на moveX и moveY пикселов по-горизонтали и вертикали соответственно
                m.Scale(scaleX, scaleY);//Сжатие/Растяжение по горизонтали и вертикали в scaleX и scaleY соответственно

                m.TransformPoints(a);//Применение матрицы преобразований к массиву точек 

                l.Clear(BackColor);// Очистка поверхности
                l.FillPolygon(Brushes.Yellow, a); 
                l.DrawPolygon(p, a);
                
                m.Reset();//Сброс матрицы

                rot = 0;
                scaleX = 1;
                scaleY = 1;
                moveX = 0;
                moveY = 0;
            }
            */
            
            rot = 0;
            scaleX = 1;
            scaleY = 1;
            moveX = 0;
            moveY = 0;
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

            this.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zero.CopyTo(a, 0);
            this.Invalidate();
        }
    }
}
