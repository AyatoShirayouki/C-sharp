using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
            }
         }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = "Hello";
            }
            else if (radioButton2.Checked == true)
            {
                label1.Text = "Good Bye";
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label1.ForeColor = Color.Red;
            }
            else if (radioButton4.Checked == true)
            {
                label1.ForeColor = Color.Green;
            }
            if (radioButton5.Checked == true)
            {
                label1.ForeColor = Color.Blue;
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                label1.Font = new Font(label1.Font.Name, 12F, label1.Font.Style);
            }
            if (radioButton7.Checked == true)
            {
                label1.Font = new Font(label1.Font.Name, 17F, label1.Font.Style);
            }
            if (radioButton8.Checked == true)
            {
                label1.Font = new Font(label1.Font.Name, 20F, label1.Font.Style);
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked == true)
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.Size, FontStyle.Bold);
            }
            if (radioButton10.Checked == true)
            {
                label1.Font = new Font(label1.Font.Name, label1.Font.Size, FontStyle.Italic);
            }
        }
    }
}
