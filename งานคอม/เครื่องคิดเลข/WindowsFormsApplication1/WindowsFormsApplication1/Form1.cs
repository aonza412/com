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
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }
        double num1, equal, plus_to_minus; string op;
        private void button19_Click(object sender, EventArgs e)
        {
            if (tex.Text == "0") tex.Text = string.Empty;
            tex.Text = tex.Text + "1";
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (tex.Text == "0") tex.Text = string.Empty;
            tex.Text = tex.Text + "2";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (tex.Text == "0") tex.Text = string.Empty;
            tex.Text = tex.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (tex.Text == "0") tex.Text = string.Empty;
            tex.Text = tex.Text + "4";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (tex.Text == "0") tex.Text = string.Empty;
            tex.Text = tex.Text + "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (tex.Text == "0") tex.Text = string.Empty;
            tex.Text = tex.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tex.Text == "0") tex.Text = string.Empty;
            tex.Text = tex.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tex.Text == "0") tex.Text = string.Empty;
            tex.Text = tex.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (tex.Text == "0") tex.Text = string.Empty;
            tex.Text = tex.Text + "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (tex.Text == "0") tex.Text = string.Empty;
            tex.Text = tex.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bool a = double.TryParse(tex.Text, out num1);
            op = "+";
            tex.Text = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (tex.Text == "0")
            {
                tex.Text = string.Empty;
                tex.Text = tex.Text + "-";
            }
            else if (tex.Text == string.Empty) tex.Text = tex.Text + "-";
            else
            {
                bool a = double.TryParse(tex.Text, out num1);
                op = "-";
                tex.Text = string.Empty;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool a = double.TryParse(tex.Text, out num1);
            op = "*";
            tex.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool a = double.TryParse(tex.Text, out num1);
            op = "/";
            tex.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool a = double.TryParse(tex.Text, out num1);
            op = "%";
            tex.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tex.Text = "0";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (tex.Text == string.Empty ) tex.Text = "0.";
            else if (num.Text == ".")
            {
                if (!tex.Text.Contains("."))
                    tex.Text = tex.Text + num.Text;
            }
            else tex.Text = tex.Text + num.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculator_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool a = double.TryParse(tex.Text, out num1);
            plus_to_minus = num1 * (-1);
            tex.Text = plus_to_minus.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    if (tex.Text == string.Empty | tex.Text == "-")
                    {
                        tex.Text = num1.ToString();
                    }
                    else
                    {
                        equal = num1 + double.Parse(tex.Text); 
                        tex.Text = equal.ToString();
                    }
                    break;
                    
                case "-":
                    if (tex.Text == string.Empty | tex.Text == "-")
                    {
                        tex.Text = num1.ToString();
                    }
                    else
                    {
                        equal = num1 - double.Parse(tex.Text);
                        tex.Text = equal.ToString();
                    }
                    break;
                case "*":
                    if (tex.Text == string.Empty | tex.Text == "-")
                    {
                        tex.Text = num1.ToString();
                    }
                    else
                    {
                        equal = num1 * double.Parse(tex.Text);
                        tex.Text = equal.ToString();
                    }
                    break;
                case "/":
                    if (tex.Text == string.Empty | tex.Text == "-")
                    {
                        tex.Text = num1.ToString();
                    }
                    else
                    {
                        equal = num1 / double.Parse(tex.Text);
                        tex.Text = equal.ToString();
                    }
                    break;
                case "%":
                    if (tex.Text == string.Empty | tex.Text == "-")
                    {
                        tex.Text = num1.ToString();
                    }
                    else
                    {
                        equal = num1 * (double.Parse(tex.Text) / 100);
                        tex.Text = equal.ToString(); break;
                    }
                    break;                   
            }
        }
        
    }
}
