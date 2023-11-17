using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios.MCN;
using Sistema_Bibliotecario.Formularios.FunMonografia;

namespace Sistema_Bibliotecario
{
    public partial class frmMonografias : Form
    {
        public frmMonografias()
        {
            InitializeComponent();
        }

        frmAnadirMono1 Amono1 = new frmAnadirMono1();
        frmAnadirMono2 Amono2 = new frmAnadirMono2();
        frmEliminarMono EliminarMono = new frmEliminarMono();
        CRUD_AMR metodosMonografia = new CRUD_AMR();

        private void CerrarFormularios()
        {
            Amono1.Hide();
            Amono2.Hide();
        }

        private void Imprimir()
        {
            LbCantidad.Text = metodosMonografia.ListarMonografias().Count.ToString();
            dgMonografia.DataSource = null;
            dgMonografia.DataSource = metodosMonografia.ListarMonografias();
        }

        private void IniciarComboBox()
        {
            cbCategorias.Items.Add("Id");
            cbCategorias.Items.Add("Título");
            cbCategorias.Items.Add("Universidad");
            cbCategorias.Items.Add("Autor");
        }
        private void frmMonografias_Load(object sender, EventArgs e)
        {
            IniciarComboBox();
            Imprimir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
            Amono1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarMono.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgMonografia.DataSource = null;
            if (cbCategorias.Text == "Id")
            {

                dgMonografia.DataSource = metodosMonografia.BuscarMonografiaPorID(int.Parse(txtBuscar.Text));
            }
            else if (cbCategorias.Text == "Título")
            {
                dgMonografia.DataSource = metodosMonografia.BuscarMonografiaPorTitulo(txtBuscar.Text);
            }
            else if (cbCategorias.Text == "Universidad")
            {
                dgMonografia.DataSource = metodosMonografia.BuscarMonografiaPorUniver(txtBuscar.Text);
            }
            else if (cbCategorias.Text == "Autor")
            {
                dgMonografia.DataSource = metodosMonografia.BuscarMonografiaPorAutor(txtBuscar.Text);
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbCategorias.Text == "Id")
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13)
                {
                    e.Handled = true;
                }
                else if(e.KeyChar == 13 && !string.IsNullOrEmpty(txtBuscar.Text))
                {
                    button4_Click(sender, e);
                }
            }
            else if (e.KeyChar == 13)
            {
                button4_Click(sender, e);
            }
            //else
            //{
            //    button4_Click(sender, e);
            //}
        }
    }
}
