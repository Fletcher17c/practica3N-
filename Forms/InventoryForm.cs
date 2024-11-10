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
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("ProductName", "Nombre");
            dataGridView1.Columns.Add("Quantity", "Cantidad");
            dataGridView1.Columns.Add("Price", "Precio");
            dataGridView1.Columns.Add("TotalValue", "Total");
            dataGridView1.Columns.Add("EntryDate", "Fecha de ingreso");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = textBox1.Text;
            int quantity;
            decimal price;

            if (string.IsNullOrWhiteSpace(productName) || !int.TryParse(textBox2.Text, out quantity) || !decimal.TryParse(textBox3.Text, out price))
            {
                MessageBox.Show("Datos Invalidos");
                return;
            }

            
            decimal total = quantity * price;
            string entryDate = DateTime.Now.ToString("g");

            dataGridView1.Rows.Add(productName, quantity, price, total, entryDate);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
