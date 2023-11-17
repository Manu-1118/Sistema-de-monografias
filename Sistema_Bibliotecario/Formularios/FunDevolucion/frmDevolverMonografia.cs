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

namespace Sistema_Bibliotecario.Formularios.FunDevolucion
{
    public partial class frmDevolverMonografia : Form
    {
        public frmDevolverMonografia()
        {
            InitializeComponent();
        }

        PrestamosMCN metodosPrestamos = new PrestamosMCN();
        CRUD_AMR metodosMono = new CRUD_AMR();

        private void RellenarCombo()
        {
            cbPrestamo.DataSource = metodosMono.ListarMonografias();
            cbPrestamo.DisplayMember = "Titulo";
            cbPrestamo.ValueMember = "Id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmDevolverMonografia_Load(object sender, EventArgs e)
        {
            RellenarCombo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgElemento.DataSource = null;
            dgElemento.DataSource = metodosPrestamos.BuscarPorIdMono(int.Parse(cbPrestamo.SelectedValue.ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgElemento.Rows.Count != 0 && !string.IsNullOrEmpty(txtNota.Text))
            {
                PrestamosDto devolucion = new PrestamosDto()
                {
                    FechaEntrega = dtFechaEntrega.Value,
                    Nota = txtNota.Text,
                };

                bool resultado = metodosPrestamos.InsertarDevolucion(devolucion, int.Parse(cbPrestamo.SelectedValue.ToString()));

                if (resultado)
                {
                    MessageBox.Show("La devolucíon se completo sin problemas.");
                }
                else
                {
                    MessageBox.Show("La devolucíon no se pudo completar.");
                }
            }
            else
            {
                MessageBox.Show("Favor busque un préstamo válido.");
            }
        }
    }
}
