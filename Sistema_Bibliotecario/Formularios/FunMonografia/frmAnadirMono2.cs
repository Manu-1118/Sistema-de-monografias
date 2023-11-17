using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using CapaNegocios.DTO;
using CapaNegocios.MCN;
using Sistema_Bibliotecario.Formularios.FunMonografia;

namespace Sistema_Bibliotecario.Formularios.FunMonografia
{
    public partial class frmAnadirMono2 : Form
    {
        public frmAnadirMono2()
        {
            InitializeComponent();
        }
        CRUD_AMR metodosMono = new CRUD_AMR();

        private void Limpiar()
        {
            txtId.Clear();
            txtTitulo.Clear();
            txtUniversidad.Clear();
            txtId.Focus();
        }
        private void AgregarAutores()
        {
            if(Estaticas.ContadorEstudiante == 1 && Estaticas.ContadorProfesor == 1)
            {
                metodosMono.InsertarAutor(Estaticas.listaAutoresTemp.ElementAt(0));
                metodosMono.InsertarAutor(Estaticas.listaAutoresTemp.ElementAt(1));
            }
            else if(Estaticas.ContadorEstudiante == 2 && Estaticas.ContadorProfesor == 1)
            {
                metodosMono.InsertarAutor(Estaticas.listaAutoresTemp.ElementAt(0));
                metodosMono.InsertarAutor(Estaticas.listaAutoresTemp.ElementAt(1));
                metodosMono.InsertarAutor(Estaticas.listaAutoresTemp.ElementAt(2));
            }
        }
        private void MostrarAutoresRegistrados2()
        {
            string[] nombres = Estaticas.listaAutoresTemp.Select(Nombres => Nombres.Nombres).ToArray();
            string[] roles = Estaticas.listaAutoresTemp.Select(Roles => Roles.Rol).ToArray();
            lbNombreAutor1.Text = nombres[0];
            lbNombreAutor2.Text = nombres[1];
            lbNombreAutor3.Text = "";
            lbRol1.Text = roles[0];
            lbRol2.Text = roles[1];
            lbRol3.Text = "";
        }
        private void MostrarAutoresRegistrados3()
        {
            string[] nombres = Estaticas.listaAutoresTemp.Select(Nombres => Nombres.Nombres).ToArray();
            string[] roles = Estaticas.listaAutoresTemp.Select(Roles => Roles.Rol).ToArray();
            lbNombreAutor1.Text = nombres[0];
            lbNombreAutor2.Text = nombres[1];
            lbNombreAutor3.Text = nombres[2];
            lbRol1.Text = roles[0];
            lbRol2.Text = roles[1];
            lbRol3.Text = roles[2];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //metodosMono.ReiniciarClase();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text) && !string.IsNullOrEmpty(txtTitulo.Text) && !string.IsNullOrEmpty(txtUniversidad.Text))
            {
                MonografiaDto Mono = metodosMono.BuscarMonografia(int.Parse(txtId.Text));

                if (Mono != null)
                {
                    MessageBox.Show($"Ya hay una monografía registrada con el ID: {txtId.Text}");
                    return;
                }

                Mono = new MonografiaDto()
                {
                    Id = int.Parse(txtId.Text),
                    Titulo = txtTitulo.Text,
                    Univesidad = txtUniversidad.Text
                };

                bool resultado = metodosMono.InsertarMonografia(Mono);

                if (resultado)
                {
                    AgregarAutores();
                    foreach (var autores in Estaticas.listaAutoresTemp)
                    {
                        metodosMono.InsertarLlaves(autores.Id, Mono.Id);
                    }
                    MessageBox.Show("La monografía se ha registrado con éxito.");
                    metodosMono.ReiniciarClase();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error, no se pudo registrar la monografía.");
                    metodosMono.ReiniciarClase();
                }
                Limpiar();
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor rellene las casillas que estan en blanco.");
            }
        }

        private void frmAnadirMono2_Load(object sender, EventArgs e)
        {
            if (Estaticas.ContadorEstudiante == 1 && Estaticas.ContadorProfesor == 1)     
                MostrarAutoresRegistrados2();
            else
                MostrarAutoresRegistrados3();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtId.Text = (metodosMono.ListarMonografias().Count + 1).ToString();
            txtTitulo.Focus();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13 && !string.IsNullOrEmpty(txtId.Text))
            {
                txtTitulo.Focus();
            }
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90 && e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13 && !string.IsNullOrEmpty(txtTitulo.Text))
            {
                txtUniversidad.Focus();
            }
        }

        private void txtUniversidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90 && e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13 && !string.IsNullOrEmpty(txtTitulo.Text))
            {
                button4_Click(sender, e);
            }
        }
    }
}