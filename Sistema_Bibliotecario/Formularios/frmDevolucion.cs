using CapaNegocios.MCN;
using Sistema_Bibliotecario.Formularios.FunDevolucion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bibliotecario
{
    public partial class frmDevolucion : Form
    {
        public frmDevolucion()
        {
            InitializeComponent();
        }
        frmDevolverMonografia devolverMono = new frmDevolverMonografia();
        PrestamosMCN metodosPrestamo = new PrestamosMCN();

        private void RellenarCombo()
        {
            cbCategoria.Items.Add("Id Prestamo");
            cbCategoria.Items.Add("Id Monografía");
            cbCategoria.Items.Add("Id lector");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgLectores.DataSource = null;
            if (cbCategoria.Text == "Id Prestamo")
            {
                dgLectores.DataSource = metodosPrestamo.BuscarPrestamoPorID(int.Parse(txtBuscar.Text));
            }
            else if (cbCategoria.Text == "Id Monografía")
            {
                dgLectores.DataSource = metodosPrestamo.BuscarPorIdMono(int.Parse(txtBuscar.Text));
            }
            else if (cbCategoria.Text == "Id lector")
            {
                dgLectores.DataSource = metodosPrestamo.BuscarPrestamoPorIdLector(int.Parse(txtBuscar.Text));
            }
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            RellenarCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbCantMP.Text = metodosPrestamo.ListarPrestamos().Count.ToString();
            dgLectores.DataSource = null;
            dgLectores.DataSource = metodosPrestamo.ListarPrestamos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            devolverMono.ShowDialog();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13 && !string.IsNullOrEmpty(txtBuscar.Text))
            {
                button4_Click(sender, e);
            }            
        }
    }
}
