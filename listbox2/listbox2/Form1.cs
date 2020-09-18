using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listbox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sum = 0;
        int min = int.MaxValue;
        int max = int.MinValue;
        private void button1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox1.Text);
            Random r = new Random();
            
            
            for (int i = 0; i < count; i++)
            {
                int n = r.Next(0, 100);
                if (n < min)
                {
                    min = n;
                }
                if (n > max)
                {
                    max = n;
                }
                sum += n;
                listBox1.Items.Add($"{n}");
                //listBox1.Text += Environment.NewLine;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Sum = {sum}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Min = {min}  Max = {max}");
        }
    }
}
