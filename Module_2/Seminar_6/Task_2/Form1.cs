using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form1 : Form
    {
        int[] pelle = { 0, 1 };
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int result = checked(pelle[0] + 2 * pelle[1]);
                pelle[0] = pelle[1];
                pelle[1] = result;
                label1.Text = result.ToString();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Возникло переполнение");
                pelle[0] = 0;
                pelle[1] = 1;
                return;
            }
            

        }
    }
}
