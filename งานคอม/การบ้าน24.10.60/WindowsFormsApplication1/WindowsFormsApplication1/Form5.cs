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
    public partial class Form5 : Form
    {
        double point; //ประกาศตัวแปร
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a = double.TryParse(textBox1.Text, out point);//ดักเออเร่อและแปลงค่าไปเก็บใน point
            if (point < 0 | point > 100)//เงื่อนไขหากค่าของ point น้อยกว่า 0 หรือมากว่า 100 จะทำตามคำสั่งในปีกกา
            {
                textBox1.Text = "ไม่มีเกรด";//แสดงกล่องข้อความว่า ไม่มีเกรด
            }
            else if (point <= 49)//เงื่อนไขหากค่าของ point น้อยกว่าหรือเท่ากับ 49 จะทำตามคำสั่งในปีกกา
            {
                textBox1.Text = "เกรดของคุณคือ 0"; //แสดงกล่องข้อความว่า เกรดของคุณคือ 0
            }
            else if (point <= 59)//เงื่อนไขหากค่าของ point น้อยกว่าหรือเท่ากับ 59 จะทำตามคำสั่งในปีกกา
            {
                textBox1.Text = "เกรดของคุณคือ 1"; //แสดงกล่องข้อความว่า เกรดของคุณคือ 1
            }
            else if (point <= 69)//เงื่อนไขหากค่าของ point น้อยกว่าหรือเท่ากับ 69 จะทำตามคำสั่งในปีกกา
            {
                textBox1.Text = "เกรดของคุณคือ 2"; //แสดงกล่องข้อความว่า เกรดของคุณคือ 2
            }
            else if (point <= 79)//เงื่อนไขหากค่าของ point น้อยกว่าหรือเท่ากับ 69 จะทำตามคำสั่งในปีกกา
            {
                textBox1.Text = "เกรดของคุณคือ 3"; //แสดงกล่องข้อความว่า เกรดของคุณคือ 3
            }
            else if (point >= 80)//เงื่อนไขหากค่าของ point มากกว่าหรือเท่ากับ คจ จะทำตามคำสั่งในปีกกา
            {
                textBox1.Text = "เกรดของคุณคือ 4"; //แสดงกล่องข้อความว่า เกรดของคุณคือ 4
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();//ปุ่มล้างค่าในช่องรับข้อมูล
        }
    }
}
