using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjersClase.Forms
{
    public partial class TextEditorForm : Form
    {
        string currentFilePath;
        bool filechanged;
        bool fileopen;
        string localcopy;
        public TextEditorForm()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\ruta\al\archivo.txt";
            textBox1.Text = "";


            try
            {

                string fileContent = OpenFile();
                textBox1.Text = fileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
        }

       

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileopen = false;
            if (filechanged)
            {
                DialogResult result = MessageBox.Show("Guardar los cambios antes de cerrar?", "Guardar cambios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SaveFile();

                }
                else if (result == DialogResult.No)
                {
                    currentFilePath = null;
                    filechanged = false;
                    textBox1.Clear();
                }
            }
           
           
        }

        private void txb_TextChanged(object sender, EventArgs e)
        {
            filechanged = true;
        }
        public string OpenFile()
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                currentFilePath = filePath;

                try
                {
                    string fileContent = File.ReadAllText(filePath);
                    fileopen = true;
                    return fileContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return ex.Message;
                }
            }

            return "Error Opening File XI";
        }
        private void SaveFile()
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                try
                {
                    File.WriteAllText(currentFilePath, textBox1.Text);
                    MessageBox.Show("Archivo guardado con éxito");
                    filechanged = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay archivo abierto pa guardar");
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            localcopy = textBox1.Text; 
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileopen)
            {
                textBox1.Text = textBox1.Text+localcopy;
            }
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            localcopy = textBox1.Text;
            textBox1.Clear();
        }

    }
}
