using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figurkiMigurki3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x1 = 30;
        int x2 = 50;

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            Pen p = new Pen(Color.Red, 3);
            gr.DrawEllipse(p, x1, x2, 50, 80);
            SolidBrush br = new SolidBrush(Color.Red);
            gr.FillEllipse(br, x1, x2, 50, 80);
            p.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            x1 -= 10;
            Graphics g = CreateGraphics();
            g.Clear(BackColor);
            Graphics gr = CreateGraphics();
            Pen p = new Pen(Color.Red, 3);
            gr.DrawEllipse(p, x1, x2, 50, 80);
            SolidBrush br = new SolidBrush(Color.Red);
            gr.FillEllipse(br, x1, x2, 50, 80);
            p.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            x1 += 10;
            Graphics g = CreateGraphics();
            g.Clear(BackColor);
            Graphics gr = CreateGraphics();
            Pen p = new Pen(Color.Red, 3);
            gr.DrawEllipse(p, x1, x2, 50, 80);
            SolidBrush br = new SolidBrush(Color.Red);
            gr.FillEllipse(br, x1, x2, 50, 80);
            p.Dispose();
        }
    }
}
