using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prostotii1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 50;
        int y = 50;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x+=10;
            y+=10;
            Graphics g = CreateGraphics();
            g.Clear(BackColor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            Pen p = new Pen(Color.Red, 3);
            gr.DrawEllipse(p, Form1.ActiveForm.Width / 2, Form1.ActiveForm.Height / 2, x, y);
            p.Dispose();
        }
    }
}
