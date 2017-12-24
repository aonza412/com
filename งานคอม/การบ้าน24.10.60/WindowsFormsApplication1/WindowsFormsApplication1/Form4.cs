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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "เกาหลีใต้") //เงื่อนไขถ้าในกล่องข้อความตรงกับคำว่า เกาหลีใต้ จะทำคำสั่งในปีกกา
            {
                MessageBox.Show("Sarang Heyo");//กลอ่งแสดงข้อความว่า Sarang Heyo
            }
            else if (textBox1.Text == "อินโดนีเซีย")//เงื่อนไขถ้าในกล่องข้อความตรงกับคำว่า อินโดนีเซีย จะทำคำสั่งในปีกกา
            {
                MessageBox.Show("Saya cinta padamu");//กลอ่งแสดงข้อความว่า Saya cinta padamu
            }
            else if (textBox1.Text == "ไทย")//เงื่อนไขถ้าในกล่องข้อความตรงกับคำว่า ไทย จะทำคำสั่งในปีกกา
            {
                MessageBox.Show("Chan rak khun");//กลอ่งแสดงข้อความว่า Chan rak khun
            }
            else if (textBox1.Text == "อังกฤษ")//เงื่อนไขถ้าในกล่องข้อความตรงกับคำว่า อังกฤษ จะทำคำสั่งในปีกกา
            {
                MessageBox.Show("I love you");//กลอ่งแสดงข้อความว่า I love you
            }
            else if (textBox1.Text == "ญี่ปุ่น")//เงื่อนไขถ้าในกล่องข้อความตรงกับคำว่า ญี่ปุ่น จะทำคำสั่งในปีกกา
            {
                MessageBox.Show("Kimi o ai eru");//กลอ่งแสดงข้อความว่า Kimi o ai eru
            }
            else { MessageBox.Show("ไม่มีภาษานี้"); }//ถ้าไม่ตรงกับคำใดเลยจะแสดงข้อความ ไม่มีภาษานี้
        }
    }
}
