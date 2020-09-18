using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurkiMigurki2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Triangle")
            {
                label6.Visible = true;
                textBox3.Visible = true;
            }
            else
            {
                label6.Visible = false;
                textBox3.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x1 = int.Parse(textBox1.Text);
            int x2 = int.Parse(textBox2.Text);
            if (comboBox1.Text == "Line")
            {
                Graphics gr = CreateGraphics();
                Pen p = new Pen(Color.FromName(comboBox2.Text), 3);
                gr.DrawLine(p, x1, x2, 30, 50);
                p.Dispose();
            }
            else if (comboBox1.Text == "Rectangle")
            {
                Graphics gr = CreateGraphics();
                Pen p = new Pen(Color.FromName(comboBox2.Text), 8);
                gr.DrawRectangle(p, x1, x2, 50, 80);
                SolidBrush br = new SolidBrush(Color.FromName(comboBox3.Text));
                gr.FillRectangle(br, x1, x2, 50, 80);
                p.Dispose();
            }
            else if (comboBox1.Text == "Square")
            {
                Graphics gr = CreateGraphics();
                Pen p = new Pen(Color.FromName(comboBox2.Text), 8);
                gr.DrawRectangle(p, x1, x2, 80, 80);
                SolidBrush br = new SolidBrush(Color.FromName(comboBox3.Text));
                gr.FillRectangle(br, x1, x2, 80, 80);
                p.Dispose();
            }
            else if (comboBox1.Text == "Triangle")
            {
                int z = int.Parse(textBox3.Text);
                
                Graphics gr = CreateGraphics();
                Pen p = new Pen(Color.FromName(comboBox2.Text), 3);
                Point[] MyPoint = { new Point(x1, 200), new Point(x2, 10), new Point(z, 200) };
                gr.DrawPolygon(p, MyPoint);

                p.Dispose();

            }
            else if (comboBox1.Text == "Circle")
            {
                Graphics gr = CreateGraphics();
                Pen p = new Pen(Color.FromName(comboBox2.Text), 3);
                gr.DrawEllipse(p, x1, x2, 50, 80);
                SolidBrush br = new SolidBrush(Color.FromName(comboBox3.Text));
                gr.FillEllipse(br, x1, x2, 50, 80);
                p.Dispose();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
