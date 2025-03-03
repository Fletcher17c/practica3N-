﻿using System;
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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbuser.Text) || string.IsNullOrEmpty(txbapellido.Text) || string.IsNullOrEmpty(txbcorreo.Text) || string.IsNullOrEmpty(txbpassword.Text)) 
            {
                MessageBox.Show("Datos Invalidos o Vacios");
                clear();
                return;
            } 
            else
            {
                if (!txbcorreo.Text.Contains("@"))
                {
                    MessageBox.Show("Correo Invalido");
                    clear();
                    return;
                }

                if (!(txbpassword.Text == txbconfirm.Text))
                {
                    MessageBox.Show("Contraseñas no coinciden");
                    clear();
                    return;
                }

                MessageBox.Show("Yay");
                
            }
        }

        public void clear()
        {
            txbapellido.Clear();
            txbuser.Clear();
            txbpassword.Clear();
            txbcorreo.Clear();
            txbconfirm.Clear();
        }
    }
}
