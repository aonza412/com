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
        string[] ans = { "A", "B", "C", "D", "F" };
    public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            grade(a);
        } 
        void grade(int a)
        {
           
            if (a < 50) label1.Text = ans[4];
            if (a >= 50) label1.Text = ans[3];
            if (a >= 60) label1.Text = ans[2];
            if (a >= 70) label1.Text = ans[1];
            if (a >= 80) label1.Text = ans[0];
        }
    }
}
