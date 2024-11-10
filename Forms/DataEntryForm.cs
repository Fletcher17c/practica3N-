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
    public partial class DataEntryForm : Form
    {
        public DataEntryForm()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(!(string.IsNullOrEmpty(textBox1.Text)&& string.IsNullOrEmpty(textBox1.Text)&&string.IsNullOrEmpty(textBox1.Text)))
            {
                listBox1.Items.Add($"{textBox1.Text} - {textBox2.Text} - {textBox3.Text}");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("No empty values");
            }
            
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
        }
    }
}
