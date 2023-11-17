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
    public partial class frmEliminarLector : Form
    {
        public frmEliminarLector()
        {
            InitializeComponent();
        }

        LectorMCN metodosLector = new LectorMCN();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                int Id = int.Parse(txtId.Text);
                LectorDto lector = metodosLector.BuscarLector(Id);

                if (lector is null)
                {
                    MessageBox.Show($"El Lector con ID: {Id} no se encuentra registrado");
                    return;
                }
                else
                {
                    txtNombres.Text = lector.Nombres;
                    txtApellidos.Text = lector.Apellidos;
                }
            }
            else
            {
                MessageBox.Show("Favor digite un Id para realizar la busqueda.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtNombres.Text) && !string.IsNullOrEmpty(txtApellidos.Text))
            {
                bool resultado = metodosLector.EliminarLector(int.Parse(txtId.Text));
                if (resultado)
                {
                    MessageBox.Show("¡El lector se elimino correctamente!");
                    txtId.Clear();
                    txtNombres.Clear();
                    txtApellidos.Clear();
                    txtId.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el Lector");
                }
            }
            else
            {
                MessageBox.Show("Favor haga búsqueda del lector que desea borrar");
            }
        }

        private void frmEliminarLector_Load(object sender, EventArgs e)
        {

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
