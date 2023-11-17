using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios.DTO;
using CapaNegocios.MCN;

namespace Sistema_Bibliotecario
{
    public partial class frmPrestamo : Form
    {
        public frmPrestamo()
        {
            InitializeComponent();
        }
        CRUD_AMR metodosMono = new CRUD_AMR();
        PrestamosMCN metodoPrestamos = new PrestamosMCN();
        LectorMCN metodosLector = new LectorMCN();

        private void RellenarCombo()
        {
            cbLectores.DataSource = metodosLector.ListaLectores();
            cbLectores.DisplayMember = "Nombres";
            cbLectores.ValueMember = "Id";
        }

        private void frmPrestamo_Load(object sender, EventArgs e)
        {
            dgListas.DataSource = null;
            dgListas.DataSource = metodosMono.ListarMonografias();
            RellenarCombo();
            CalcularFechaDevolucion(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgListas.DataSource = null;
            dgListas.DataSource = metodosMono.ListarMonografias();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgListas.DataSource = null;
            dgListas.DataSource = metodoPrestamos.ListarPrestamos();
        }
        private void CalcularFechaDevolucion(object sender, EventArgs e)
        {
            dtpFechaLimite.Value = dtpFechaPrestamo.Value.AddDays(7);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMonografia.Text))
            {
                PrestamosDto presta = new PrestamosDto()
                {
                    FechaPrestamo = dtpFechaPrestamo.Value,
                    FechaDevolucion = dtpFechaLimite.Value
                };
                
                bool Resultado = metodoPrestamos.InsertarPrestamo(presta, int.Parse(txtMonografia.Text), int.Parse(cbLectores.SelectedValue.ToString()));

                if (Resultado)
                {
                    MessageBox.Show("El prestamo se efectuo con exito.");
                }
                else
                {
                    MessageBox.Show("El prestamo no se pudo registrar.");
                }
            }
            else
            {
                MessageBox.Show("Favor rellene las casillas faltantes.");
            }
        }

        private void txtMonografia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
