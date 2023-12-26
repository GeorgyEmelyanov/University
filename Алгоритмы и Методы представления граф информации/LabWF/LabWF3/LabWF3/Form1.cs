using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWF3
{
    public partial class Form1 : Form
    {   
        enum WeightOfLine: int { Five = 5 , Ten = 10 , Fiftin = 15 };
        int weightOfLine;
        Point start_coordinats;
        Point previos_coordinats;
        Size size_object;
        bool move_object;
        Color color_brush;
        Color color_pen;

        Pen pen = new Pen(Color.Black, 14);
        Brush brush = new SolidBrush(Color.Blue);

        public Form1()
        {
            InitializeComponent();

            weightOfLine = (int)WeightOfLine.Five;

            start_coordinats= new Point(100,100);
            size_object= new Size(200,400);
            move_object= false;
            previos_coordinats= start_coordinats;

            color_brush = Color.Gray;
            color_pen = Color.Green;
        }

       
        private void непрерывнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pictureBox1.Refresh();  

        }

        private void пунктирнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pictureBox1.Refresh();
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cd_for_brush.ShowDialog() == DialogResult.OK) 
            {
                color_brush = cd_for_brush.Color;
                pictureBox1.Refresh();
            }
        }

        private void цветЛинииОбводкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cd_for_pen.ShowDialog() == DialogResult.OK)
            {
                color_pen = cd_for_pen.Color;
                pictureBox1.Refresh();
 
            }
        }

        private void wol_5_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            weightOfLine = (int)WeightOfLine.Five;
            pictureBox1.Refresh();
        }

        private void wol_10_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            weightOfLine = (int)WeightOfLine.Ten;
            pictureBox1.Refresh();
        }

        private void wol_15_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            weightOfLine = (int)WeightOfLine.Fiftin;
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pen.Color = color_pen;
            pen.Width = weightOfLine;
            brush = new SolidBrush(color_brush);

            e.Graphics.DrawRectangle(pen, start_coordinats.X, start_coordinats.Y, size_object.Width, size_object.Height);
            e.Graphics.FillRectangle(brush, start_coordinats.X, start_coordinats.Y, size_object.Width, size_object.Height);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            move_object = true;
            previos_coordinats = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (move_object)
            {
                start_coordinats.X = previos_coordinats.X - (previos_coordinats.X - e.Location.X);
                start_coordinats.Y = previos_coordinats.Y - (previos_coordinats.Y - e.Location.Y);
                pictureBox1.Refresh();
                previos_coordinats = e.Location;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            move_object = false;
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
                this.pictureBox1.Size = new System.Drawing.Size(this.Width - 35, this.Height - 35);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
