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
    public partial class Form2 : Form
    {
        double sum1,sum2; //ประกาศตัวแปร
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "ข้าวไข่เจียวหมูสับ")//เงื่อนไขถ้ากล่องข้อความตรงคำว่า ข้าวไข่เจียวหมูสับ จะคําสั่งด้านในปีกกา
            {
                bool a = double.TryParse(textBox2.Text,out sum1);//เช็คเออเร่อและแปลงค่าจาก string เป็น double ไปเก็บใน sum1
                sum2 = sum1 * 650;//นำ sum1 คูณ 650 แล้วอาไปเก็บใน sum2
                sum.Text = sum2.ToString() + " แคลอรี่";//แสดงค่าของ sum2 ในช่อง sum.text
            }
            else if (textBox1.Text == "ข้าวเหนียวหมูปิ้ง")//เงื่อนไขถ้ากล่องข้อความตรงคำว่า ข้าวเหนียวหมูปิ้ง จะคําสั่งด้านในปีกกา
            {
                bool a = double.TryParse(textBox2.Text, out sum1);//เช็คเออเร่อและแปลงค่าจาก string เป็น double ไปเก็บใน sum1
                sum2 = sum1 * 350;//นำ sum1 คูณ 350 แล้วอาไปเก็บใน sum2
                sum.Text = sum2.ToString() + " แคลอรี่";//แสดงค่าของ sum2 ในช่อง sum.text
            }
            else { sum.Text = "ผิดพลาด"; }//หากไม่ตรงกับคำใดเลยจะแสดงข้อความ ผิดพลาด

        }

        private void sum_Click(object sender, EventArgs e)
        {
                        
        }

        private void tex2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
