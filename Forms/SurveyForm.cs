using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjersClase.Forms
{
    public partial class SurveyForm : Form
    {
        public SurveyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fac = "ninguna";
            if (checkBox1.Checked)
            {
                fac = "FIA";
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }

            if (checkBox2.Checked)
            {
                fac = "Humanidades";
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }

            if (checkBox3.Checked)
            {
                fac = "Medicina";
                checkBox2.Checked = false;
                checkBox1.Checked = false;
            }

            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "Rosado";
            }
            string nose = $"Su color es {textBox1.Text} y su facultad favorida es {fac}";
            MessageBox.Show(nose);
            WriteToFile(nose);
        }

        public void WriteToFile(string content)
        { 
            try
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                using (StreamWriter writer = new StreamWriter("../../log.txt", true))
                {
                    writer.WriteLine($"{timestamp} - {content}");
                }
                
            }
            catch (Exception ex)
            {
               MessageBox.Show($"error: {ex.Message}");
            }
        }
    }
}
