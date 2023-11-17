using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos1;
using CapaNegocios;
using CapaNegocios.DTO;
using CapaNegocios.MCN;
using Sistema_Bibliotecario.Formularios.FunMonografia;

namespace Sistema_Bibliotecario.Formularios.FunMonografia
{
    public partial class frmAnadirMono1 : Form
    {
        public frmAnadirMono1()
        {
            InitializeComponent();
        }
        AutorDto autor;
        frmAnadirMono2 Amono2 = new frmAnadirMono2();
        CRUD_AMR metodosMono = new CRUD_AMR();
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Amono2.ShowDialog();
            btnSiguiente.Enabled = false;
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtId.Focus();
        }

        private void RellenarComboBox()
        {
            cbRol.Items.Clear();
            cbRol.Items.Add("Docente");
            cbRol.Items.Add("Estudiante");
        }
        private void GuardarDatos()
        {
            autor = new AutorDto()
            {
                Id = int.Parse(txtId.Text),
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Rol = cbRol.Text
            };
            Estaticas.listaAutoresTemp.Add(autor);
            dgAutores.DataSource = null;
            dgAutores.DataSource = Estaticas.listaAutoresTemp;
        }

        private bool BuscarAutorID(int ID)
        {
            bool verificacion = false;
            AutorDto auBus = metodosMono.BuscarAutor(ID);
            if (auBus != null)
            {
                verificacion = true;
            }
            else
            {
                verificacion = false;
            }
            return Estaticas.listaIdTemp.Any(x => x == ID) || verificacion;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtId.Text = (metodosMono.ListarAutores().Count + 1 +
                Estaticas.ContadorEstudiante + Estaticas.ContadorProfesor).ToString();
            txtNombres.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtNombres.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(cbRol.Text))
            {
                MessageBox.Show("Favor rellene todas las casillas en blanco");
            }
            else
            {

                if (cbRol.Text == "Docente" && Estaticas.ContadorProfesor == 0)
                {
                    if (!BuscarAutorID(int.Parse(txtId.Text)))
                    {
                        Estaticas.ContadorProfesor++;
                        Estaticas.listaIdTemp.Add(int.Parse(txtId.Text));
                        GuardarDatos();
                    }
                    else
                    {
                        MessageBox.Show($"Ya existe un Autor con el ID: {txtId.Text}. Favor cambiarlo.");
                        return;
                    }
                }
                else if (cbRol.Text == "Estudiante" && Estaticas.ContadorEstudiante <= 1)
                {
                    if (!BuscarAutorID(int.Parse(txtId.Text)))
                    {
                        Estaticas.ContadorEstudiante++;
                        Estaticas.listaIdTemp.Add(int.Parse(txtId.Text));
                        GuardarDatos();
                    }
                    else
                    {
                        MessageBox.Show($"Ya existe un Autor con el ID: {txtId.Text}. Favor cambiarlo.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No se puede ingresar más usuarios de ese rol.");
                    return;
                }

                if ((Estaticas.ContadorEstudiante == 1 && Estaticas.ContadorProfesor == 1) || (Estaticas.ContadorEstudiante == 2 && Estaticas.ContadorProfesor == 1))
                {
                    btnSiguiente.Enabled = true;
                }
                Limpiar();
            }
        }

        private void frmAnadirMono1_Load(object sender, EventArgs e)
        {
            RellenarComboBox();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            metodosMono.ReiniciarClase();
            btnSiguiente.Enabled = false;
            dgAutores.DataSource = null;
            Limpiar();
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
                e.Handled= true;
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
