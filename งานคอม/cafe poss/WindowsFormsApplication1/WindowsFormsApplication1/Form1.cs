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
        int i=0,sum=0;
        string[] num = new string[1000];
        string[] name = new string[1000];
        string[] monney = new string[1000];
        public Form1()
        {
            InitializeComponent();
           
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        private void button30_Click(object sender, EventArgs e)
        {
            string total = label12.Text;
            save += "\n";
            save += "Totle Price : " + total;
            System.IO.File.WriteAllText(Application.StartupPath + @"\slip\slip"+j+".txt", save);
            total = string.Empty;
            j++;
        }
        public int j = 1;
        public string save;
        public void infomation()
        {
            ListViewItem list = new ListViewItem();
            list.Text = num[i];
            list.SubItems.Add(name[i]);
            list.SubItems.Add(monney[i]);
            listView1.Items.Add(list);
            label12.Text = (sum += Convert.ToInt32(monney[i])).ToString()+" บาท";
            save += Environment.NewLine + name[i] + "  " + monney[i]+Environment.NewLine;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            name[i] = "Esspresso(ร้อน)";
            monney[i] = "35";
            num[i] = (i + 1).ToString();        
            infomation();
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            name[i] = "Esspresso(เย็น)";
            monney[i] = "45";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            name[i] = "Americano(ร้อน)";
            monney[i] = "35";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            name[i] = "Americano(เย็น)";
            monney[i] = "45";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            name[i] = "Latte(ร้อน)";
            monney[i] = "35";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            name[i] = "Latte(เย็น)";
            monney[i] = "45";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            name[i] = "Latte(ปั่น)";
            monney[i] = "50";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            name[i] = "Cappuccino(ร้อน)";
            monney[i] = "35";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            name[i] = "Mocha(ร้อน)";
            monney[i] = "35";
            num[i] = (i + 1).ToString();
            infomation();
            i++; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            name[i] = "Mocha(เย็น)";
            monney[i] = "45";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            name[i] = "Mocha(ปั่น)";
            monney[i] = "50";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            name[i] = "Cappuccino(เย็น)";
            monney[i] = "45";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            name[i] = "Cappuccino(ปั่น)";
            monney[i] = "50";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            name[i] = "Green Tea(ร้อน)";
            monney[i] = "20";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            name[i] = "Green Tea(เย็น)";
            monney[i] = "25";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            name[i] = "Green Tea(ปั่น)";
            monney[i] = "30";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            name[i] = "Cocoa(ร้อน)";
            monney[i] = "20";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            name[i] = "Cocoa(เย็น)";
            monney[i] = "25";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            name[i] = "Cocoa(ปั่น)";
            monney[i] = "30";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            name[i] = "Thai Tea(ร้อน)";
            monney[i] = "20";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            name[i] = "Thai Tea(เย็น)";
            monney[i] = "25";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            name[i] = "Thai Tea(ปั่น)";
            monney[i] = "35";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            name[i] = "Milk(ร้อน)";
            monney[i] = "20";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            name[i] = "Milk(เย็น)";
            monney[i] = "25";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            name[i] = "Milk(ปั่น)";
            monney[i] = "30";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            name[i] = "Milk Tea(เย็น)";
            monney[i] = "25";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            name[i] = "Milk Tea(ปั่น)";
            monney[i] = "30";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            name[i] = "Lemon Tea(เย็น)";
            monney[i] = "25";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            name[i] = "Lemon Tea(ปั่น)";
            monney[i] = "30";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            name[i] = "Milo(ร้อน)";
            monney[i] = "20";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            name[i] = "Milo(เย็น)";
            monney[i] = "25";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            name[i] = "Milo(ปั่น)";
            monney[i] = "30";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            name[i] = "Nescafe(ร้อน)";
            monney[i] = "20";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            name[i] = "Nescafe(เย็น)";
            monney[i] = "25";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button46_Click(object sender, EventArgs e)
        {
            name[i] = "Nescafe(ปั่น)";
            monney[i] = "30";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            name[i] = "Nescafe Tea(ร้อน)";
            monney[i] = "20";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            name[i] = "Nescafe Tea(เย็น)";
            monney[i] = "25";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            name[i] = "Nescafe Tea(ปั่น)";
            monney[i] = "30";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            name[i] = "Italian Soda(เย็น)";
            monney[i] = "25";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            name[i] = "Red lime Soda(เย็น)";
            monney[i] = "25";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            name[i] = "Honey lime Soda(เย็น)";
            monney[i] = "25";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }
        private void button31_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            label12.Text = "0 บาท";
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            name[i] = "Esspresso(ปั่น)";
            monney[i] = "50";
            num[i] = (i + 1).ToString();
            infomation();
            i++;
        }
    }
}
