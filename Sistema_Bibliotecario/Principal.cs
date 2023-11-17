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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            ShowSubPanel(new frmInicio());
        }
        private Form form;
        Panel line = new Panel();

        private void ShowSubPanel(Form child)
        {
            if(form != null)
            {
                form.Close();
            }
            form = child;
            child.TopLevel = false;
            child.Dock = DockStyle.Fill;
            WindowP.Controls.Add(child);
            WindowP.BringToFront();
            child.Show();
        }

        private void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn  = sender as Button;
            PanelMenu.Controls.Add(line);
            line.BackColor = Color.Navy;
            line.Size = new Size(btn.Width, 5);
            line.Location = new Point(btn.Location.X, btn.Location.Y + 45);
        }

        private void btnMouseLeave(object sender, EventArgs e)
        {
            PanelMenu.Controls.Remove(line);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            if(!(PanelMenuTrans.Visible))
                PanelMenuTrans.Visible = true;
            else
                PanelMenuTrans.Visible = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ShowSubPanel(new frmInicio());
            if ((PanelMenuTrans.Visible))
                PanelMenuTrans.Visible = false;
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            btnTrans_Click(sender, e);
            ShowSubPanel(new frmPrestamo());
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            btnTrans_Click(sender,e);
            ShowSubPanel(new frmDevolucion());
        }

        private void btnLector_Click(object sender, EventArgs e)
        {
            ShowSubPanel(new frmLectores());
            if ((PanelMenuTrans.Visible))
                PanelMenuTrans.Visible = false;
        }

        private void btnMonografia_Click(object sender, EventArgs e)
        {
            ShowSubPanel(new frmMonografias());
            PanelMenuTrans.Visible = false;
        }
    }
}
