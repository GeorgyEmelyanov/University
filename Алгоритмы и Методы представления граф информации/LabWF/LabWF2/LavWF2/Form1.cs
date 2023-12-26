using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LavWF2
{
    public partial class Form1 : Form
    {
        string type_of_line = "";
        string type_of_object = "";
       
        public Form1()
        {
            InitializeComponent();
            var items = new string[] { "Пунктирная", "Штрихпунктирная", "Сплошная" };
            comboBox1.Items.AddRange(items);
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                type_of_line = comboBox1.SelectedItem.ToString();
            }
            if (listBox1.SelectedItem != null)
            {
                type_of_object = listBox1.SelectedItem.ToString();
            }

            if ((type_of_line != "") && (type_of_object != ""))
            {
                textBox2.Text = string.Format(
                "Тип линии: {0}" + Environment.NewLine + "Вид геометрической фигуры: {1}",
                type_of_line,
                type_of_object);
            }
        }

    }
}
