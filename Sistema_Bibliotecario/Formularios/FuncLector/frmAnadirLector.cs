using CapaNegocios.DTO;
using CapaNegocios.MCN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bibliotecario.Formularios.FuncLector
{
    public partial class frmAnadirLector : Form
    {
        public frmAnadirLector()
        {
            InitializeComponent();
        }
        LectorMCN metodosLector = new LectorMCN();

        private void Limpiar()
        {
            txtId.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtId.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text))
            {
                MessageBox.Show("Favor rellene todas las casillas en blanco");
            }
            else
            {
                LectorDto lector = metodosLector.BuscarLector(int.Parse(txtId.Text));

                if (lector != null)
                {
                    MessageBox.Show($"Ya existe un lector con el ID: {txtId.Text}. Utilice otro ID.");
                    return;
                }

                lector = new LectorDto()
                {
                    Id = int.Parse(txtId.Text),
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text
                };
                bool resultado = metodosLector.InsertarLector(lector);

                if (resultado)
                {
                    MessageBox.Show("¡Si Agregó el Lector con éxito!");

                }
                else
                {
                    MessageBox.Show("No se ha podido agregar al lector");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAnadirLector_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtId.Text = (metodosLector.ListaLectores().Count + 1).ToString();
            txtNombres.Focus();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13 && !string.IsNullOrEmpty(txtId.Text))
            {
                txtNombres.Focus();
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90 && e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13 && !string.IsNullOrEmpty(txtNombres.Text))
            {
                txtApellidos.Focus();
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90 && e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }
    }
}
