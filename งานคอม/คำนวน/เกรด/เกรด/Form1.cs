using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace เกรด
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int p;
            bool a = int.TryParse(txt_point.Text, out p);
            if (a)
            {
                if (p >= 80 & p <= 100) grade.Text = "A";
                if (p >= 70 & p <= 79) grade.Text = "B";
                if (p >= 60 & p <= 69) grade.Text = "C";
                if (p >= 50 & p <= 59) grade.Text = "D";
                if (p < 49) grade.Text = "F";
                if (p < 0 | p > 100) grade.Text = "EROR";
            }
            else grade.Text = "EROR";
        }
    }
}
