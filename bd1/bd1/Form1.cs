using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet11.Хора1' table. You can move, or remove it, as needed.
           // this.хора1TableAdapter.Fill(this.dataSet11.Хора1);
            // TODO: This line of code loads data into the 'dataSet1.Хора' table. You can move, or remove it, as needed.
            //   this.хораTableAdapter1.Fill(this.dataSet1.Хора);
            // TODO: This line of code loads data into the 'koli1DataSet.Коли' table. You can move, or remove it, as needed.
            this.колиTableAdapter.Fill(this.koli1DataSet.Коли);
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);
            // TODO: This line of code loads data into the 'koli1DataSet.Хора' table. You can move, or remove it, as needed.
            this.хораTableAdapter.Fill(this.koli1DataSet.Хора);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
                label3.Text = comboBox1.SelectedValue.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.хора1TableAdapter.Fill(this.dataSet11.Хора1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            хора1TableAdapter.Update(dataSet11);
        }
    }
}
