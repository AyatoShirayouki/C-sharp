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

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string message;

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string line;
                StreamReader sr = new
                        StreamReader(openFileDialog1.FileName);
                while ((line = sr.ReadLine()) != null)
                    listBox1.Items.Add(line);
                sr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string line;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);

                line = listBox1.SelectedItem.ToString();
                sw.WriteLine(line);
                message += line;
                message += Environment.NewLine;

                if (radioButton1.Checked == true)
                {
                    sw.WriteLine("8 klas");
                    message += "8 klas";
                }
                if (radioButton2.Checked == true)
                {
                    sw.WriteLine("9 klas");
                    message += "9 klas";
                }
                if (radioButton3.Checked == true)
                {
                    sw.WriteLine("10 klas");
                    message += "10 klas";
                }
                if (radioButton4.Checked == true)
                {
                    sw.WriteLine("11 klas");
                    message += "11 klas";
                }
                if (radioButton5.Checked == true)
                {
                    sw.WriteLine("12 klas");
                    message += "12 klas";
                }
                message += Environment.NewLine;
                sw.WriteLine("Personal info :" + textBox1.Text);
                message += "Personal info :";
                message += Environment.NewLine;
                message += textBox1.Text;
                sw.Close();
                MessageBox.Show("Saved!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
