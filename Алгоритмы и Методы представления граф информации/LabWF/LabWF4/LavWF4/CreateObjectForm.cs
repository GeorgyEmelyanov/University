using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace LavWF4
{
    public partial class ObjectCreater : Form
    {
        public ItemForDrawing object_;
        
        public ObjectCreater()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            objectCoord.Visible = false;
            objectSize.Visible = false;
        }

        private bool CheckInputFields()
        {
            int typeOfObject = objectChoose.SelectedIndex;
            string coord = objectCoord.Text;
            string size = objectSize.Text;
            if(typeOfObject==-1)
            {
                MessageBox.Show("Выберите тип объекта", "Ошибка");
                return false;
            }
            else
            {
                if (coord == "")
                {
                    MessageBox.Show("Введите координаты объекта", "Ошибка");
                    return false;
                }
                else if (typeOfObject > 1 && size == "" && typeOfObject < 4)
                {
                    MessageBox.Show("Введите размер объекта", "Ошибка");
                    return false;
                }
                else if (typeOfObject == 4 && size == "")
                {
                    MessageBox.Show("Введите содержимое строки", "Ошибка");
                    return false;
                }
                else if (typeOfObject == 1 && size == "")
                {
                    MessageBox.Show("Введите координаты конца линии", "Ошибка");
                    return false;
                }
            }
            return true;

        }
        private void buttnoCreate_Click(object sender, EventArgs e)
        {
            if (!CheckInputFields())
                return;
            int typeOfObject = objectChoose.SelectedIndex;
            string[] coord = objectCoord.Text.Split(',');
            string[] size_ = objectSize.Text.Split(',');
            
            Point start_coord, end_coord;

            switch (typeOfObject)
            {
                case (int)ItemForDrawing.TypeOfObject.Point:
                    {
                        start_coord = new Point(int.Parse(coord[0]), int.Parse(coord[1]));
                        object_ = new ItemForDrawing(start_coord);
                        break;
                    }
                case (int)ItemForDrawing.TypeOfObject.Line:
                    {
                        start_coord = new Point(int.Parse(coord[0]), int.Parse(coord[1]));
                        end_coord = new Point(int.Parse(size_[0]), int.Parse(size_[1]));
                        object_ = new ItemForDrawing(start_coord, end_coord);
                        break;
                    }
                case (int)ItemForDrawing.TypeOfObject.Ellipse:
                case (int)ItemForDrawing.TypeOfObject.Rectangle:
                    {
                        start_coord = new Point(int.Parse(coord[0]), int.Parse(coord[1]));
                        Size size = new Size(int.Parse(size_[0]), int.Parse(size_[1]));
                        object_ = new ItemForDrawing(typeOfObject, start_coord, size);
                        break;
                    }
                case (int)ItemForDrawing.TypeOfObject.String:
                    {
                        start_coord = new Point(int.Parse(coord[0]), int.Parse(coord[1]));
                        string text = String.Join("", size_);
                        object_ = new ItemForDrawing(start_coord, text);
                        break;
                    }
                default:
                    break;
            }
            this.Close();

        }

        private void objectChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            int typeOfObject = objectChoose.SelectedIndex;
            switch (typeOfObject)
            {
                case (int)ItemForDrawing.TypeOfObject.Point:
                    {
                        label1.Text = "Координаты объекта";
                        label1.Visible=true;
                        label2.Visible=false;
                        objectCoord.Visible=true;
                        objectSize.Visible=false;
                    }
                    break;
                case (int)ItemForDrawing.TypeOfObject.Line:
                    {
                        label1.Text = "Координаты начала линии";
                        label2.Text = "Координаты конца линии";
                        label1.Visible = true;
                        label2.Visible = true;
                        objectCoord.Visible = true;
                        objectSize.Visible = true;
                    }
                    break;
                case (int)ItemForDrawing.TypeOfObject.Rectangle:
                    {
                        label1.Text = "Координаты объекта";
                        label2.Text = "Размеры объекта";
                        label1.Visible = true;
                        label2.Visible = true;
                        objectCoord.Visible = true;
                        objectSize.Visible = true;
                    }
                    break;
                case (int)ItemForDrawing.TypeOfObject.Ellipse:
                    {
                        label1.Text = "Координаты объекта";
                        label2.Text = "Размеры объекта";
                        label1.Visible = true;
                        label2.Visible = true;
                        objectCoord.Visible = true;
                        objectSize.Visible = true;
                    }
                    break;
                case (int)ItemForDrawing.TypeOfObject.String:
                    {
                        label1.Text = "Координаты строки";
                        label2.Text = "Содержимое строки";
                        label1.Visible = true;
                        label2.Visible = true;
                        objectCoord.Visible = true;
                        objectSize.Visible = true;
                    }
                    break;
            }
        }
    }
}
