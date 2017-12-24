using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        List<Class1> studen_list = new List<Class1>();
        public Form1()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            string id = this.textBox2.Text;
            string score = this.textBox3.Text;
            double dscore = double.Parse(score);
            double a = 0;
            Class1 studen = new Class1();
            studen.Name = name;
            studen.Id = id;
            studen.Score = dscore;
            studen_list.Add(studen);
            this.textBox4.Text = studen_list.Count.ToString();
            foreach (Class1 istu in studen_list)
            {
                a += istu.Score;
            }
            this.textBox5.Text = (a/studen_list.Count).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.studen_list.Count > 0)
            {
                string path = ""; string contents = "";
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "cis file (*.cis)|*.cis";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    path = sfd.FileName;
                }
                foreach (Class1 s in this.studen_list)
                {
                    contents += s.Name + "," + s.Id + "," + s.Score + "\r\n";
                }
                File.WriteAllText(path, contents);
            }
            else
            {
                MessageBox.Show("wtf");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "cis file | *.cis|cisx file|*.cisx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                string data = File.ReadAllText(path);
                if(data.Length > 0)
                {
                    string[] row = System.Text.RegularExpressions.Regex.Split(data, "\r\n");
                    studen_list.Clear();
                    foreach (string colum in row)
                    {
                        string[] field = colum.Split(',');
                        Class1 st = new Class1();
                        st.Name = field[0];
                        st.Id = field[1];
                        st.Score = double.Parse(field[2]);
                        studen_list.Add(st);
                    }
                }
            }
        }
    }
}
