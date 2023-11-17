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

namespace Sistema_Bibliotecario
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        CRUD_AMR metodosMono = new CRUD_AMR();
        LectorMCN metodosLector = new LectorMCN();
        PrestamosMCN metodosTransacciones = new PrestamosMCN();

        private void CalcularRegistros()
        {
            cantRegistros.Text = (metodosLector.ListaLectores().Count
                + metodosMono.ListarMonografias().Count
                + metodosMono.ListarAutores().Count
                + metodosTransacciones.ListarPrestamos().Count).ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            CalcularRegistros();
        }
    }
}
