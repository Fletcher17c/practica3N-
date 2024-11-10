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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbUser.Text) || string.IsNullOrEmpty(txbUser.Text))
            {
                MessageBox.Show("Usuario o Contraseña vacio");
            }

        }

        private void CheckAdmin()
        {
            if(txbUser.Text == "admin" && txbPassword.Text == "1234")
            {
                MessageBox.Show("Bienvenido admin");
            }
        }
    }
}
