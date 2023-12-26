using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LavWF4
{
    public partial class MainForm : Form
    {
        ItemForDrawing object_;
        Bitmap bitmap;
        Brush brush_for_draw_rect;
        Color color;
        int weightOfLine;
        Font font = new Font("Courier New", 12);

        public MainForm()
        {
            InitializeComponent();

            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = (Image)bitmap;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;

            brush_for_draw_rect = Brushes.Black;
            color = Color.Black;
            weightOfLine = 10;
        }

        private void updateBitmap()
        {
            if (object_ != null)
            {
                Pen pen = new Pen(brush_for_draw_rect, weightOfLine);

                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    switch (object_.typeOfObject)
                    {
                        case (int)ItemForDrawing.TypeOfObject.Point:
                            {
                                bitmap.SetPixel(object_.start_coord.X,object_.start_coord.Y,color);
                                break;  
                            }
                        case (int)ItemForDrawing.TypeOfObject.Line:
                            {
                                g.DrawLine(pen, object_.start_coord, object_.end_coord);
                                break;
                            }
                        case (int)ItemForDrawing.TypeOfObject.Rectangle:
                            {
                                Rectangle rect = new Rectangle(object_.start_coord, object_.size);
                                g.DrawRectangle(pen, rect);
                                break;
                            }
                        case (int)ItemForDrawing.TypeOfObject.Ellipse:
                            {
                                Rectangle rect = new Rectangle(object_.start_coord, object_.size);
                                g.DrawEllipse(pen, rect);
                                break;
                            }
                        case (int)ItemForDrawing.TypeOfObject.String:
                            {
                                g.DrawString(object_.text, font, brush_for_draw_rect, object_.start_coord);
                                break;
                            }
                    }
                    g.Flush();
                }
            }
            pictureBox1.Invalidate();
        }

        private void объектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObjectCreater form = new ObjectCreater();
            form.ShowDialog();
            object_ = form.object_;
            updateBitmap();
        }
    }
}
