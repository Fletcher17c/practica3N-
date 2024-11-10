using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjersClase.Forms;

namespace EjersClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TemperatureConverterForm temperatureConverterForm = new TemperatureConverterForm();
            temperatureConverterForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataEntryForm dataEntryForm = new DataEntryForm();
            dataEntryForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();  
            inventoryForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AgeCalculatorForm geCalculatorForm = new AgeCalculatorForm();
            geCalculatorForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SurveyForm textEditorForm = new SurveyForm();
            textEditorForm.Show();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BMIForm bMIForm = new BMIForm();
            bMIForm.Show();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            TextEditorForm textEditorForm = new TextEditorForm();
            textEditorForm.Show();
        }
    }
}
