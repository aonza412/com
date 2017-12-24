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
    public partial class Form3 : Form
    {
        double sum,num1, num2;//ประกาศตัวแปร
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool a = double.TryParse(textBox1.Text, out num1);//ดักเออเร่อและแปลงค่าแล้วนำไปเก็บใน num1
            bool b = double.TryParse(textBox2.Text, out num2);//ดักเออเร่อและแปลงค่าแล้วนำไปเก็บใน num2
            sum = num1 - num2; //นำ num1 และ num2 มาลบกันแล้วนำไปเก็บใน sum
            MessageBox.Show(sum.ToString());//กล่องข้องความแสดงค่าของ sum
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool a = double.TryParse(textBox1.Text, out num1);//ดักเออเร่อและแปลงค่าแล้วนำไปเก็บใน num1
            bool b = double.TryParse(textBox2.Text, out num2);//ดักเออเร่อและแปลงค่าแล้วนำไปเก็บใน num2
            sum = num1 * num2;//นำ num1 และ num2 มาคูณกันแล้วนำไปเก็บใน sum
            MessageBox.Show(sum.ToString());//กล่องข้องความแสดงค่าของ sum
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool a = double.TryParse(textBox1.Text, out num1);//ดักเออเร่อและแปลงค่าแล้วนำไปเก็บใน num1
            bool b = double.TryParse(textBox2.Text, out num2);//ดักเออเร่อและแปลงค่าแล้วนำไปเก็บใน num2
            sum = num1 / num2;//นำ num1 และ num2 มาหารกันแล้วนำไปเก็บใน sum
            MessageBox.Show(sum.ToString());//กล่องข้องความแสดงค่าของ sum
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();//ปิดโปรแกรม
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a = double.TryParse(textBox1.Text, out num1);//ดักเออเร่อและแปลงค่าแล้วนำไปเก็บใน num1
            bool b = double.TryParse(textBox2.Text, out num2);//ดักเออเร่อและแปลงค่าแล้วนำไปเก็บใน num2
            sum = num1 + num2;//นำ num1 และ num2 มาบวกกันแล้วนำไปเก็บใน sum
            MessageBox.Show(sum.ToString()); //กล่องข้องความแสดงค่าของ sum
        }
    }
}
