using CapaDatos1;
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
    public partial class frmEditarLector : Form
    {
        public frmEditarLector()
        {
            InitializeComponent();
        }
 
        LectorMCN metodosLector = new LectorMCN();
        LectorDto lector;

        private void Limpiar()
        {
            txtId.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtId.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtNombres.Text) && !string.IsNullOrEmpty(txtApellidos.Text))
            {
                int Id = int.Parse(txtId.Text);
                lector = metodosLector.BuscarLector(Id);

                if (lector is null)
                {
                    MessageBox.Show($"El Lector con ID: {Id} no se encuentra registrado");
                    return;
                }

                lector = new LectorDto()
                {
                    Id = int.Parse(txtId.Text),
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text
                };

                bool resultado = metodosLector.ActualizarLector(lector);
                if (resultado)
                {
                    MessageBox.Show("¡El lector se modificó correctamente!");
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el Lector");
                }
                Limpiar();
            }
            else
            {
                MessageBox.Show("Favor rellene los espacios faltantes.");
            }
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
            else if (e.KeyChar == 13 && !string.IsNullOrEmpty(txtApellidos.Text))
            {
                button1_Click(sender, e);
            }
        }

        private void frmEditarLector_Load(object sender, EventArgs e)
        {
            txtId.Focus();
        }
    }
}
