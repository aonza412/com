using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Group(); //เรียกใช้เมทตอดที่ชื่อ Group
        }
        public string[] name; //ประกาศตัวแปรอิสระที่เป็น string
        public void Group() //เมทตอด Group
        {
            name = System.IO.File.ReadAllLines(Application.StartupPath + @"\name.txt");

                    textBox1.Text = name[0] + "\r" + "\n" + name[1] + "\r" + "\n" + name[2] + "\r" + "\n" + name[3] + "\r" + "\n" + name[4] + "\r" + "\n" + name[5];
                    //จะแสดงชื่อนักศึกษา6คนตามตำแหน่งที่กำหนด
                    textBox2.Text = name[6] + "\r" + "\n" + name[7] + "\r" + "\n" + name[8] + "\r" + "\n" + name[9] + "\r" + "\n" + name[10] + "\r" + "\n" + name[11];
                    //จะแสดงชื่อนักศึกษา6คนตามตำแหน่งที่กำหนด
                    textBox3.Text = name[12] + "\r" + "\n" + name[13] + "\r" + "\n" + name[14] + "\r" + "\n" + name[15] + "\r" + "\n" + name[16] + "\r" + "\n" + name[17]; 
                    //จะแสดงชื่อนักศึกษา6คนตามตำแหน่งที่กำหนด
                    textBox4.Text = name[18] + "\r" + "\n" + name[19] + "\r" + "\n" + name[20] + "\r" + "\n" + name[21] + "\r" + "\n" + name[22] + "\r" + "\n" + name[23]; 
                    //จะแสดงชื่อนักศึกษา6คนตามตำแหน่งที่กำหนด
                    textBox5.Text = name[24] + "\r" + "\n" + name[25] + "\r" + "\n" + name[26] + "\r" + "\n" + name[27] + "\r" + "\n" + name[28] + "\r" + "\n" + name[29]; 
                    //จะแสดงชื่อนักศึกษา6คนตามตำแหน่งที่กำหนด
                    textBox6.Text = name[30] + "\r" + "\n" + name[31] + "\r" + "\n" + name[32] + "\r" + "\n" + name[33] + "\r" + "\n" + name[34] + "\r" + "\n" + name[35];
                    //จะแสดงชื่อนักศึกษา6คนตามตำแหน่งที่กำหนด
                    textBox7.Text = name[36] + "\r" + "\n" + name[37] + "\r" + "\n" + name[38] + "\r" + "\n" + name[39] + "\r" + "\n" + name[40] + "\r" + "\n" + name[41]; 
                    //จะแสดงชื่อนักศึกษา6คนตามตำแหน่งที่กำหนด
                    textBox8.Text = name[42] + "\r" + "\n" + name[43] + "\r" + "\n" + name[44] + "\r" + "\n" + name[45] + "\r" + "\n" + name[46] + "\r" + "\n" + name[47]; 
                    //จะแสดงชื่อนักศึกษา6คนตามตำแหน่งที่กำหนด
                    textBox9.Text = name[48] + "\r" + "\n" + name[49] + "\r" + "\n" + name[50] + "\r" + "\n" + name[51] + "\r" + "\n" + name[52]; 
                    //จะแสดงชื่อนักศึกษา5คนตามตำแหน่งที่กำหนด

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
