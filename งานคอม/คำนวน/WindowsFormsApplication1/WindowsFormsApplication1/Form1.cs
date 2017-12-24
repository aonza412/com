using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txt_num1.Text), num2 = Convert.ToInt32(txt_num2.Text);
            int sum = num1 + num2;
            txt_sum.Text = sum.ToString();
        }

        private void de_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txt_num1.Text), num2 = Convert.ToInt32(txt_num2.Text);
            int sum = num1 - num2;
            txt_sum.Text = sum.ToString();
        }

        private void mu_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txt_num1.Text), num2 = Convert.ToInt32(txt_num2.Text);
            int sum = num1 * num2;
            txt_sum.Text = sum.ToString();
        }

        private void di_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txt_num1.Text), num2 = Convert.ToDouble(txt_num2.Text);
            double sum = num1 / num2;
            txt_sum.Text = sum.ToString();
        }
    }
}
