using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurkiMigurki1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x1, x2, y1, y2;

        private void button1_Click(object sender, EventArgs e)
        {
            //Random r = new Random();
            //int r1, g, b;
            //r1 = r.Next(255);
            //g = r.Next(255);
            //b = r.Next(255);
            //int n, i, x = 200, y = 200, w = 20; int d = 1;
            //Graphics gr = CreateGraphics();
            //Color c = Color.FromArgb(r1, g, b);
            //n = int.Parse(textBox1.Text);
            //for (i = 0; i < n; i++)
            //{
            //    Pen p = new Pen(c, d);

            //    gr.DrawRectangle(p, x, y, w, w);

            //    w = w + 40;
            //    x = x - 20;
            //    y = y - 20;
            //    SolidBrush br = new SolidBrush(Color.FromArgb(r1, g, b));
            //    gr.FillRectangle(br, x, y, w, w);
            //    r1 = r.Next(255);
            //    g = r.Next(255);
            //    b = r.Next(255);
            //    c = Color.FromArgb(r1, g, b);
            //}

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //int x = 40;
            //int w = 200;
            //int n = int.Parse(textBox1.Text);
            //Graphics gr = CreateGraphics();
            //int r1 = 0;
            //int g = 0;
            //int b = 0;
            //Random r = new Random();

            //for (int i = 0; i < n; i++)
            //{
            //    x += 5;
            //    w -= 10;
            //    SolidBrush S = new SolidBrush(Color.FromArgb(r1, g, b));
            //    gr.FillRectangle(S, x, x, w, w);
            //    r1 = r.Next(255);
            //    g = r.Next(255);
            //    b = r.Next(255);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            x1 = int.Parse(textBox1.Text);
            x2 = int.Parse(textBox2.Text);
            y1 = int.Parse(textBox3.Text);
            y2 = int.Parse(textBox4.Text);
            Graphics gr = CreateGraphics();
            Pen p = new Pen(Color.Red, 3);
            gr.DrawLine(p, x1, x2, y1, y2);
	        p.Dispose();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Distance: {Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))}");
        }
    }
}
