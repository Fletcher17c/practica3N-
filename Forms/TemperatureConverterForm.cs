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
    public partial class TemperatureConverterForm : Form
    {
        double C, F,temp3;
        public TemperatureConverterForm()
        {
            InitializeComponent();
        }

        private void btnconvert1_Click(object sender, EventArgs e)
        {
            Parser();
            temp3 = (F - 32) *5 / 9;
            lblresult.Text = $"{F} grados Farenheit  son {temp3} grados Celsius";
            
            
        }

        private void btnconvert2_Click(object sender, EventArgs e)
        {
            Parser();
            temp3 = (C * 9/5) + 32;
            lblresult.Text = $"{C} grados Celsius son {temp3} grados Farenheit";
        }

        public void Parser()
        {
            try
            {
                C = double.Parse(textBox1.Text);
                F = double.Parse(textBox2.Text);
            }
            catch { }
        }
    }
}
