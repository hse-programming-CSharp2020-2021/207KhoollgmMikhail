using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listBox1.Visible = false;
            button2.Visible = false;
        }

        string[] oldLines = new string[] { "один", "два", "три", "четыре", "пять", "шесть", "семь" };

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(oldLines);
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex; 
            if (n == -1)
            {
                MessageBox.Show("Список пуст или \nнет выделенного элемента!");
                return;
            }

            listBox1.Items.RemoveAt(n);
        }
    }
}
