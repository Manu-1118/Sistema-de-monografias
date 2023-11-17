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
using Sistema_Bibliotecario.Formularios.FuncLector;

namespace Sistema_Bibliotecario
{
    public partial class frmLectores : Form
    {
        public frmLectores()
        {
            InitializeComponent();
        }

        frmEliminarLector Elector = new frmEliminarLector();
        frmAnadirLector Alector = new frmAnadirLector();
        frmEditarLector Mlector = new frmEditarLector();
        LectorMCN metodosLector = new LectorMCN();

        private void CerrarFormularios()
        {
            Alector.Hide();
            Elector.Hide();
            Mlector.Hide();
        }

        private void Imprimir()
        {
            LbCantidad.Text = metodosLector.ListaLectores().Count.ToString();
            dgLectores.DataSource = null;
            dgLectores.DataSource = metodosLector.ListaLectores();
        }

        private void frmLectores_Load(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
            Alector.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
            Elector.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CerrarFormularios();
            Mlector.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
    }
}