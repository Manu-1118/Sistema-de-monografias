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
    public partial class Preloader : Form
    {
        public Preloader()
        {
            InitializeComponent();
        }

        Principal IniciarPrograma = new Principal();

        private void Preloader_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barraCarga.Width += 50;
            if (barraCarga.Width >= 599)
            {
                LoadingTime.Stop();
                IniciarPrograma.Show();
                this.Hide();
            }
        }
    }
}
