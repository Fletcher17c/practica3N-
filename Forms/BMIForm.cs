using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjersClase.Forms
{
    public partial class BMIForm : Form
    {
        public BMIForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (double h,double w )= Parse();
            double bmi = w / (h * h);
            label3.Text = $"BMI: {bmi}";
            if (bmi < 18.5) 
            {
                MessageBox.Show("Come mas");
            }

            if (30 < bmi)
            {
                MessageBox.Show("Come menos");
            }
        }

        public (double,double) Parse()
        {
            double h = 0;
            double w = 0;

            string hs = textBox1.Text;
            string ws = textBox2.Text;

            try
            {
                h = double.Parse(hs);
                w = double.Parse(ws);

            } catch { }

            return (h,w);
        }
    }
}
