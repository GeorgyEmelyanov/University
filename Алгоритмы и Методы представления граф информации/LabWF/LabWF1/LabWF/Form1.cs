using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWF
{
    public partial class Form1 : Form
    {
        string author_name = "";

        public Form1()
        {
            InitializeComponent();
            if (author_name == "")
            {
                авторПрограммыToolStripMenuItem.Enabled = false;
                label1.Visible = false;
                textBox1.Visible = false;
                Button_Save.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                author_name = textBox1.Text;
                авторПрограммыToolStripMenuItem.Enabled = true;
                label1.Visible = !label1.Visible;
                textBox1.Visible = !textBox1.Visible;
                Button_Save.Visible = !Button_Save.Visible;
            }
            else
            {
                author_name = "";
                авторПрограммыToolStripMenuItem.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void редактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = !label1.Visible;
            textBox1.Visible = !textBox1.Visible;
            Button_Save.Visible = !Button_Save.Visible;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void авторПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Имя автора: " + author_name, "Сведения об авторе");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Лабораторная работа №1" + Environment.NewLine + "Версия 1.0.0", "Сведения о программе");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
