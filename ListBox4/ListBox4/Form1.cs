using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count1 = 0;
        int count2 = 0;
        List<int> list = new List<int>();
        List<int> list2 = new List<int>();
        int n1 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            count1 = n;
            n1 = n;
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                int x = r.Next(0, 100);
                //listBox1.Items.Add($"{x}");
                list2.Add(x);
                if (x % 7 == 0)
                {
                    list.Add(x);
                    list2.Remove(x);
                }
            }
            for (int i = 0; i < list2.Count; i++)
            {
                listBox1.Items.Add(list2[i]);
            }
            textBox2.Text = $"Count = {count1}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count; i++)
            {
                listBox2.Items.Add($"{list[i]}");
                
            }
            count2 = listBox2.Items.Count;
            textBox3.Text = $"Count = {count2}";
            textBox2.Text = $"Count = {listBox1.Items.Count}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Text = "";
        }
    }
}
