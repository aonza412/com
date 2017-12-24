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
    
    public partial class Form6 : Form
    {
        int num, i; string sum; //ประกาศตัวแปร
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool a = int.TryParse(textBox1.Text, out num); //ดักเออเร่อ
            for ( i = 1; i <= 12; i++) //ลูปในการวนซํ้าโดยจะวนจนกว่า i จะเท่ากับ 12
            {
                sum = string.Format("{0} * {1} = {2} ",num, i, num * i );//เป็นการนําข้อมูลในวงเล็ปไปเก็บใน sum โดยเป็นข้อมมูล string
                MessageBox.Show(sum); //กล่องข้อความแสดงค่าของ sum
            }

        }
        
    }
}
