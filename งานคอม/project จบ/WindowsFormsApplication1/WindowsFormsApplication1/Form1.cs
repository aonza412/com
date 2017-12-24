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

        private void button1_Click(object sender, EventArgs e)
        {
            Sheck();
            Formular();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            label12.Text = string.Empty;
        }
        public double n, e, v, a, i, sum_n, sum_e, sum_v, sum_a, sum_i;
        public int pn, pe, pv, pa, pi,sum_p, sum_pi;

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tex[4] + "\n" + tex[5] + "\n" + tex[6] + "\n" + tex[7] + "\n" + tex[8] + "\n" + tex[9]);
        }

        public string[] tex = System.IO.File.ReadAllLines(Application.StartupPath + @"\สูตร.txt");
        private void button3_Click(object sender, EventArgs e)
        {
            var exite = MessageBox.Show("ต้องการออกหรือไม่"," ", MessageBoxButtons.YesNo);
            if (exite == DialogResult.Yes)
            {
                Close();
            }
        }

        public void Formular()
        {
            sum_n = Math.Round(i / (e * v * a), 3);
            sum_e = Math.Round(i / (n * v * a), 3);
            sum_v = Math.Round(i / (n * e * a), 3);
            sum_a = Math.Round(i / (n * e * v), 3);
            sum_i = Math.Round(n * (e * v * a), 3);
            sum_p = pi - (pn + pe + pv + pa);
            sum_pi = pn + pe + pv + pa;

            if (n == 0 | pn == 0|textBox1.Text == string.Empty | textBox2.Text == string.Empty)
            {
                n_();
            }
            if (e == 0 | pe == 0 | textBox3.Text == string.Empty | textBox4.Text == string.Empty)
            {
                e_();
            }
            if (v == 0 | pv == 0 | textBox6.Text == string.Empty | textBox7.Text == string.Empty)
            {
                v_();
            }
            if (a == 0 | pa == 0 | textBox5.Text == string.Empty | textBox10.Text == string.Empty)
            {
                a_();
            }
            if (i == 0 | pi == 0 | textBox9.Text == string.Empty | textBox8.Text == string.Empty)
            {
                i_();
            }
        }

        public void Sheck()
        {
            bool a_ = double.TryParse(textBox1.Text, out n);
            bool b_ = int.TryParse(textBox2.Text, out pn);
            bool c_ = double.TryParse(textBox3.Text, out e);
            bool d_ = int.TryParse(textBox4.Text, out pe);
            bool e_ = double.TryParse(textBox6.Text, out v);
            bool f_ = int.TryParse(textBox7.Text, out pv);
            bool g_ = double.TryParse(textBox5.Text, out a);
            bool h_ = int.TryParse(textBox10.Text, out pa);
            bool i_ = double.TryParse(textBox9.Text, out i);
            bool j_ = int.TryParse(textBox8.Text, out pi);
        }
        public void n_()
        {
            label12.Text = "n = I ÷ e x V x A " + "\n" + "n = " + "( " + i + tex[1] + pi + " )" + tex[3] + "( " + e + tex[1] + pe + " )" + " x " + "( " + v + tex[1] + pv + " )" + " x " + "( " + a + tex[1] + pa + " )" + "\n" + "n = " + "( " + i + tex[1] + pi + " )" + tex[3] + "( " + e * v * a + tex[1] + (pe + pv + pa) + " )" + "\n" + "n" + tex[0] + sum_n + tex[1] + sum_p;
        }
        public void e_()
        {
            label12.Text = "e = I ÷ n x V x A " + "\n" + "e = " + "( " + i + tex[1] + pi + " )" + tex[3] + "( " + n + tex[1] + pn + " )" + " x " + "( " + v + tex[1] + pv + " )" + " x " + "( " + a + tex[1] + pa + " )" + "\n" + "e = " + "( " + i + tex[1] + pi + " )" + tex[3] + "( " + n * v * a + tex[1] + (pn + pv + pa) + " )" + "\n" + "e" + tex[0] + sum_e + tex[1] + sum_p;
        }
        public void v_()
        {
            label12.Text = "V = I ÷ n x e x A " + "\n" + "V = " + "( " + i + tex[1] + pi + " )" + tex[3] + "( " + n + tex[1] + pn + " )" + " x " + "( " + e + tex[1] + pe + " )" + " x " + "( " + a + tex[1] + pa + " )" + "\n" + "V = " + "( " + i + tex[1] + pi + " )" + tex[3] + "( " + n * e * a + tex[1] + (pn + pe + pa) + " )" + "\n" + "V" + tex[0] + sum_v + tex[1] + sum_p;
        }
        public void a_()
        {
            label12.Text = "A = I ÷ n x V x e " + "\n" + "A = " + "( " + i + tex[1] + pi + " )" + tex[3] + "( " + n + tex[1] + pn + " )" + " x " + "( " + v + tex[1] + pv + " )" + " x " + "( " + e + tex[1] + pe + " )" + "\n" + "A = " + "( " + i + tex[1] + pi + " )" + tex[3] + "( " + n * v * e + tex[1] + (pn + pv + pe) + " )" + "\n" + "A" + tex[0] + sum_a + tex[1] + sum_p;
        }
        public void i_()
        {
            label12.Text = "I = n x e x V x A " + "\n" + "I = " + "( " + n + tex[1] + pn + " )" + " x " + "( " + e + tex[1] + " )"+ pe + " )" + " x " + "( " + v + tex[1] + pv + " )" + " x " + "( " + a + tex[1] + pa + " )" + "\n" + "I" + tex[0] + sum_i + tex[1] + sum_pi;
        }
    }
}
