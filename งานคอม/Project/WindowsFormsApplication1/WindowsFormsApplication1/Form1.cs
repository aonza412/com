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
            monney(); //เรียกใช้เมทตอด monney
              
        }
        public double wat, bath, day, Week, month; //ประกาศตัวแปล double เป็นตัวแปรสาธารณะ

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void monney() //เมทตอด monney
        {
            bool a = double.TryParse(textBox1.Text, out wat); //ดักเออเร่อกรณีใส่ตัวอักษรในช่องวัตต์ไฟ
            bool b = double.TryParse(textBox2.Text, out bath);//ดักเออเร่อกรณีใส่ตัวอักษรในช่องค่าไฟต่อหน่วย
            double[] num = { wat, bath };//อาเรย์ double ที่เก็บค่าของตัวแปร wat และ bath
            month = Math.Round(num[0] * num[1], 2); //สูตรคำนวนค่าไฟต่อเดือน
            day = Math.Round(month / 30, 2);//สูตรคำนวนค่าไฟต่อวัน
            Week = Math.Round(day * 7, 2);//สูตรคำนวนค่าไฟต่อสัปดาห์
            double[,] sum = { { month }, { Week}, { day} };//อาเรย์ double 2มิติ ที่เก็บค่าของตัวแปร month day และ Week
            label5.Text = sum[2, 0].ToString();//แสดงค่าไฟในตำแหน่งจากอาเรย์
            label6.Text = sum[1, 0].ToString();//แสดงค่าไฟในตำแหน่งจากอาเรย์
            label7.Text = sum[0, 0].ToString();//แสดงค่าไฟในตำแหน่งจากอาเรย์
        }
    }
}
