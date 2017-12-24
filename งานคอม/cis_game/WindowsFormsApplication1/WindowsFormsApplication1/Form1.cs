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
        int sum2 = 0,sum=0; //ประกาศตัวแปร
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            start.Show(); //คำสั่งแสดงปุ่ม start
            Stop.Hide(); //คำสั่งซ่อนปุ่ม stop
            b1.Enabled = false; //คำสั่งล็อกปุ่ม
            b2.Enabled = false;//คำสั่งล็อกปุ่ม
            b3.Enabled = false;//คำสั่งล็อกปุ่ม
            b4.Enabled = false;//คำสั่งล็อกปุ่ม
            b5.Enabled = false;//คำสั่งล็อกปุ่ม
            b6.Enabled = false;//คำสั่งล็อกปุ่ม
            b7.Enabled = false;//คำสั่งล็อกปุ่ม
            b8.Enabled = false;//คำสั่งล็อกปุ่ม
            b9.Enabled = false;//คำสั่งล็อกปุ่ม
            b10.Enabled = false;//คำสั่งล็อกปุ่ม
            b11.Enabled = false;//คำสั่งล็อกปุ่ม
            b12.Enabled = false;//คำสั่งล็อกปุ่ม
            b13.Enabled = false;//คำสั่งล็อกปุ่ม
            b14.Enabled = false;//คำสั่งล็อกปุ่ม
            b15.Enabled = false;//คำสั่งล็อกปุ่ม
            b16.Enabled = false;//คำสั่งล็อกปุ่ม
            b17.Enabled = false;//คำสั่งล็อกปุ่ม
            b18.Enabled = false;//คำสั่งล็อกปุ่ม
            b19.Enabled = false;//คำสั่งล็อกปุ่ม
            end.Enabled = false;//คำสั่งล็อกปุ่ม
            ranbom.Enabled = false;//คำสั่งล็อกปุ่ม
        }

        private void button1_Click(object sender, EventArgs e)
        {
            end.BackColor = Color.Gainsboro; //เปลี่ยนสีปุ่ม
            sum2 = 0; //กำหนดให้ sum2 = 0
            label.Text = ""; //ให้ label แสดงช่องว่าง
            start.Hide(); //ซ่อนปุ่ม start
            Stop.Show();//แสดงปุ่ม stop
            b1.Enabled = true; //คำสั่งปลดล็อกปุ่ม
            b2.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b3.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b4.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b5.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b6.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b7.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b8.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b9.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b10.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b11.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b12.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b13.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b14.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b15.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b16.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b17.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b18.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            b19.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            end.Enabled = true;//คำสั่งปลดล็อกปุ่ม
            ranbom.Enabled = true;//คำสั่งปลดล็อกปุ่ม
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button[] number = { start, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14, b15, b16, b17, b18, b19, end }; //ประกาศอาเรที่เป็นปุ่ม
            for (int i = 1; i <= 20; i++) //คำสั่งลูป
            {
                number[i].BackColor = Color.Gainsboro;//เปลี่ยนสีปุ่มในตำแหน่งของ number[i]
            }
            Random random = new Random(); //คำสั่งสุ่ม
            sum = random.Next(1, 7);//สุ่มเลข 1-6 แล้วนำไปเก็บใน sum
            sum2 += sum; //กำหนดให้ sum2 มีค่าเท่ากับการนำค่าของ sum บวกเข้าไปเรื่อยๆ
            label.Text = sum.ToString();//ให้ label แสดงค่าของ sum
            if (sum2 < 20)//เช็คค่าว่าน้อยกว่าหรือเท่ากับ20มั้ย
            {
                number[sum2].BackColor = Color.Red;//ถ้าน้อยกว่าหรือเท่ากับ20ให้เปลี่ยนสีปุ่มในตำแหน่งของ number[sum2] เป็นสีแดง
            }
            else
            {
                number[20].BackColor = Color.Red; //ถ้าไม่ตรงเงื่อนไขข้างบนเปลี่ยนสีปุ่มตำแหน่งที่ number[20]
            }

            if (end.BackColor == Color.Red)//เช็คค่าว่าปุ่ม end เป็นสีแดงมั้ยถ้าเป็นทำคำสั่งในปีกกา
            {
                sum2 = 0;//ให้ sum2 = 0
                label.Text = ""; //ให้ label แสดงช่องว่าง
                start.Show(); //คำสั่งแสดงปุ่ม start
                Stop.Hide(); //คำสั่งซ่อนปุ่ม stop
                b1.Enabled = false; //คำสั่งล็อกปุ่ม
                b2.Enabled = false;//คำสั่งล็อกปุ่ม
                b3.Enabled = false;//คำสั่งล็อกปุ่ม
                b4.Enabled = false;//คำสั่งล็อกปุ่ม
                b5.Enabled = false;//คำสั่งล็อกปุ่ม
                b6.Enabled = false;//คำสั่งล็อกปุ่ม
                b7.Enabled = false;//คำสั่งล็อกปุ่ม
                b8.Enabled = false;//คำสั่งล็อกปุ่ม
                b9.Enabled = false;//คำสั่งล็อกปุ่ม
                b10.Enabled = false;//คำสั่งล็อกปุ่ม
                b11.Enabled = false;//คำสั่งล็อกปุ่ม
                b12.Enabled = false;//คำสั่งล็อกปุ่ม
                b13.Enabled = false;//คำสั่งล็อกปุ่ม
                b14.Enabled = false;//คำสั่งล็อกปุ่ม
                b15.Enabled = false;//คำสั่งล็อกปุ่ม
                b16.Enabled = false;//คำสั่งล็อกปุ่ม
                b17.Enabled = false;//คำสั่งล็อกปุ่ม
                b18.Enabled = false;//คำสั่งล็อกปุ่ม
                b19.Enabled = false;//คำสั่งล็อกปุ่ม
                end.Enabled = false;//คำสั่งล็อกปุ่ม
                ranbom.Enabled = false;//คำสั่งล็อกปุ่ม
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Close();//คำสั่งปิดโปรแกรม
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void start1_Click(object sender, EventArgs e)
        {
            Button[] number2 = { start, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14, b15, b16, b17, b18, b19, end };//ประกาศอาเรที่เป็นปุ่ม
            for (int i = 1; i <= 20; i++)//คำสั่งลูป
            {
                number2[i].BackColor = Color.Gainsboro;//เปลี่ยนสีปุ่มในตำแหน่งของ number[i]
            }
            sum2 = 0;//ให้ sum2 = 0
            label.Text = "";//ให้ label แสดงช่องว่าง
        }
    }
}
