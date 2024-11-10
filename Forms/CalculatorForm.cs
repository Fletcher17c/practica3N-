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
    public partial class CalculatorForm : Form
    {
        double total;
        double temp1;
        double temp2;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            Parser();
            result.Text = $"result: {temp1 + temp2}";
        }

        private void restar_Click(object sender, EventArgs e)
        {
            Parser();
            result.Text = $"result: {temp1 - temp2}";
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            Parser();
            result.Text = $"result:  {temp1 * temp2}";
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            if (txba.Text == "0" || txbb.Text == "0")
            {
                MessageBox.Show("No se puede divir entre 0");
                result.Text = $"result:";
                return;
            }
            Parser();
            result.Text = $"result:  {temp1/temp2}";
        }

        public void Parser()
        {
            try
            {
                temp1 = double.Parse(txba.Text);
                temp2 = double.Parse(txbb.Text);
            } catch { }
        }
        public void Clear()
        {
            txba.Clear();
            txbb.Clear();
        }
    }
}
