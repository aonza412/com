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
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.BackColor = this.button1.BackColor == Color.Black ? Color.White : Color.Black;
            this.button2.BackColor = this.button2.BackColor == Color.Black ? Color.White : Color.Black;
            this.button6.BackColor = this.button6.BackColor == Color.Black ? Color.White : Color.Black;
            check();
            a += 1;
            label2.Text = a.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.BackColor = this.button2.BackColor == Color.Black ? Color.White : Color.Black;
            this.button1.BackColor = this.button1.BackColor == Color.Black ? Color.White : Color.Black;
            this.button5.BackColor = this.button5.BackColor == Color.Black ? Color.White : Color.Black;
            this.button3.BackColor = this.button3.BackColor == Color.Black ? Color.White : Color.Black;
            check();
            a += 1;
            label2.Text = a.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.BackColor = this.button3.BackColor == Color.Black ? Color.White : Color.Black;
            this.button2.BackColor = this.button2.BackColor == Color.Black ? Color.White : Color.Black;
            this.button4.BackColor = this.button4.BackColor == Color.Black ? Color.White : Color.Black;
            check();
            a += 1;
            label2.Text = a.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button6.BackColor = this.button6.BackColor == Color.Black ? Color.White : Color.Black;
            this.button1.BackColor = this.button1.BackColor == Color.Black ? Color.White : Color.Black;
            this.button5.BackColor = this.button5.BackColor == Color.Black ? Color.White : Color.Black;
            this.button9.BackColor = this.button9.BackColor == Color.Black ? Color.White : Color.Black;
            check();
            a += 1;
            label2.Text = a.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button5.BackColor = this.button5.BackColor == Color.Black ? Color.White : Color.Black;
            this.button2.BackColor = this.button2.BackColor == Color.Black ? Color.White : Color.Black;
            this.button6.BackColor = this.button6.BackColor == Color.Black ? Color.White : Color.Black;
            this.button8.BackColor = this.button8.BackColor == Color.Black ? Color.White : Color.Black;
            this.button4.BackColor = this.button4.BackColor == Color.Black ? Color.White : Color.Black;
            check();
            a += 1;
            label2.Text = a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button4.BackColor = this.button4.BackColor == Color.Black ? Color.White : Color.Black;
            this.button5.BackColor = this.button5.BackColor == Color.Black ? Color.White : Color.Black;
            this.button3.BackColor = this.button3.BackColor == Color.Black ? Color.White : Color.Black;
            this.button7.BackColor = this.button7.BackColor == Color.Black ? Color.White : Color.Black;
            check();
            a += 1;
            label2.Text = a.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.button9.BackColor = this.button9.BackColor == Color.Black ? Color.White : Color.Black;
            this.button8.BackColor = this.button8.BackColor == Color.Black ? Color.White : Color.Black;
            this.button6.BackColor = this.button6.BackColor == Color.Black ? Color.White : Color.Black;
            check();
            a += 1;
            label2.Text = a.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.button8.BackColor = this.button8.BackColor == Color.Black ? Color.White : Color.Black;
            this.button5.BackColor = this.button5.BackColor == Color.Black ? Color.White : Color.Black;
            this.button9.BackColor = this.button9.BackColor == Color.Black ? Color.White : Color.Black;
            this.button7.BackColor = this.button7.BackColor == Color.Black ? Color.White : Color.Black;
            check();
            a += 1;
            label2.Text = a.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.button7.BackColor = this.button7.BackColor == Color.Black ? Color.White : Color.Black;
            this.button8.BackColor = this.button8.BackColor == Color.Black ? Color.White : Color.Black;
            this.button4.BackColor = this.button4.BackColor == Color.Black ? Color.White : Color.Black;
            check();
            a += 1;
            label2.Text = a.ToString();
        }
        void check()
        {
            if (this.button1.BackColor == Color.Black &
                this.button2.BackColor == Color.Black &
                this.button3.BackColor == Color.Black &
                this.button4.BackColor == Color.Black &
                this.button5.BackColor == Color.Black &
                this.button6.BackColor == Color.Black &
                this.button7.BackColor == Color.Black &
                this.button8.BackColor == Color.Black &
                this.button9.BackColor == Color.Black)
            {
                a += 1;
                label2.Text = a.ToString();
                MessageBox.Show("Your Score : " + a + " Hit");
                this.button1.BackColor = Color.White;
                this.button2.BackColor = Color.White;
                this.button3.BackColor = Color.White;
                this.button4.BackColor = Color.White;
                this.button5.BackColor = Color.White;
                this.button6.BackColor = Color.White;
                this.button7.BackColor = Color.White;
                this.button8.BackColor = Color.White;
                this.button9.BackColor = Color.White;
                a = -1;
            }      
        }
    }
}
