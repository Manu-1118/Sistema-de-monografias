using CapaNegocios.DTO;
using CapaNegocios.MCN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Sistema_Bibliotecario.Formularios.FunMonografia
{
    public partial class frmEliminarMono : Form
    {
        public frmEliminarMono()
        {
            InitializeComponent();
        }

        CRUD_AMR metodosMono = new CRUD_AMR();
        private int CantidadAutores;
        private List<AutorDto> autores = new List<AutorDto>();
        private void RellenarCombo()
        {
            cbMonografias.DataSource = metodosMono.ListarMonografias();
            cbMonografias.DisplayMember = "Titulo";
            cbMonografias.ValueMember = "Id";
        }

        private void frmEliminarMono_Load(object sender, EventArgs e)
        {
            RellenarCombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbMonografias.Text) || !string.IsNullOrEmpty(cbMonografias.Text))
            {
                if(autores.Count > 0)
                    autores.Clear();
                autores = metodosMono.AutoresDeUnaMonografia(int.Parse(cbMonografias.SelectedValue.ToString()));
                dgAutores.DataSource = null;
                dgMono.DataSource = null;
                dgMono.DataSource = metodosMono.BuscarMonografiaPorId(int.Parse(cbMonografias.SelectedValue.ToString()));
                dgAutores.DataSource = autores;
                CantidadAutores = autores.Count;
            }
            else
            {
                MessageBox.Show("Por favor rellene los espacios vacios.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (CantidadAutores == 2)
            //{
            //    metodosMono.EliminarAutores(autores.ElementAt(0).Id);
            //    metodosMono.EliminarAutores(autores.ElementAt(1).Id);
            //}
            //else
            //{
            //    metodosMono.EliminarAutores(autores.ElementAt(0).Id);
            //    metodosMono.EliminarAutores(autores.ElementAt(1).Id);
            //    metodosMono.EliminarAutores(autores.ElementAt(2).Id);
            //}
            foreach (var values in autores)
            {
                metodosMono.EliminarAutores(values.Id);
            }
            metodosMono.EliminarMonografia(int.Parse(cbMonografias.SelectedValue.ToString()));
            metodosMono.EliminarLlaves(int.Parse(cbMonografias.SelectedValue.ToString()));
            MessageBox.Show("La monografía se ha eliminado con éxito.");           
        }
    }
}
