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

namespace Izpitvane2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void averageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double average = (a + b) / 2;
            textBox3.Text = average.ToString();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string line;
                StreamReader sr = new
                               StreamReader(openFileDialog1.FileName);
                while ((line = sr.ReadLine()) != null)
                    listBox1.Items.Add(line);
                listBox1.Visible = true;
                sr.Close();
            }

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string line;
                StreamReader sr = new
                               StreamReader(openFileDialog1.FileName);
                while ((line = sr.ReadLine()) != null)
                    listBox1.Items.Add(line);
                listBox1.Visible = true;
                sr.Close();
            }

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int i;
            string line;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                for (i = 0; i < listBox1.Items.Count; i++)
                {
                    line = listBox1.Items[i].ToString();
                    sw.WriteLine(line);
                }
                sw.Close();
                MessageBox.Show("Saved!");
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) > int.Parse(textBox2.Text))
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox3.Font = fontDialog1.Font;

                }
            }
            else
            {
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Font = fontDialog1.Font;

                }
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) > int.Parse(textBox2.Text))
            {
                colorDialog1.ShowDialog();
                textBox3.BackColor = colorDialog1.Color;
            }
            else
            {
                colorDialog1.ShowDialog();
                listBox1.BackColor = colorDialog1.Color;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                contextMenuStrip1.Enabled = false;
            }
            else
            {
                contextMenuStrip1.Enabled = true;
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i;
            string line;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                for (i = 0; i < listBox1.Items.Count; i++)
                {
                    line = listBox1.Items[i].ToString();
                    sw.WriteLine(line);
                }
                sw.Close();
                MessageBox.Show("Saved!");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
