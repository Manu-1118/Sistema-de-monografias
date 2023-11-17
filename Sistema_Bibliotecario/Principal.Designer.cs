namespace Sistema_Bibliotecario
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnTrans = new System.Windows.Forms.Button();
            this.btnLector = new System.Windows.Forms.Button();
            this.btnMonografia = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.WindowP = new System.Windows.Forms.Panel();
            this.PanelMenuTrans = new System.Windows.Forms.Panel();
            this.btnDevolucion = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.WindowP.SuspendLayout();
            this.PanelMenuTrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 89);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Sistema_Bibliotecario.Properties.Resources.eliminar__1_;
            this.button2.Location = new System.Drawing.Point(803, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 31);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Sistema_Bibliotecario.Properties.Resources.cerca__1_;
            this.button1.Location = new System.Drawing.Point(852, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 31);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Agency FB", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(203, 6);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(513, 77);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Registro de Monografías";
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.SkyBlue;
            this.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMenu.Controls.Add(this.btnTrans);
            this.PanelMenu.Controls.Add(this.btnLector);
            this.PanelMenu.Controls.Add(this.btnMonografia);
            this.PanelMenu.Controls.Add(this.btnInicio);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 89);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(900, 50);
            this.PanelMenu.TabIndex = 1;
            // 
            // btnTrans
            // 
            this.btnTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrans.FlatAppearance.BorderSize = 0;
            this.btnTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrans.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrans.Image = ((System.Drawing.Image)(resources.GetObject("btnTrans.Image")));
            this.btnTrans.Location = new System.Drawing.Point(468, 0);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(199, 45);
            this.btnTrans.TabIndex = 3;
            this.btnTrans.Text = "Transacciones   ▼";
            this.btnTrans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            this.btnTrans.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnTrans.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnLector
            // 
            this.btnLector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLector.FlatAppearance.BorderSize = 0;
            this.btnLector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLector.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLector.Image = ((System.Drawing.Image)(resources.GetObject("btnLector.Image")));
            this.btnLector.Location = new System.Drawing.Point(309, 0);
            this.btnLector.Name = "btnLector";
            this.btnLector.Size = new System.Drawing.Size(157, 45);
            this.btnLector.TabIndex = 2;
            this.btnLector.Text = "Lectores";
            this.btnLector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLector.UseVisualStyleBackColor = true;
            this.btnLector.Click += new System.EventHandler(this.btnLector_Click);
            this.btnLector.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnLector.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnMonografia
            // 
            this.btnMonografia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonografia.FlatAppearance.BorderSize = 0;
            this.btnMonografia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonografia.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonografia.Image = ((System.Drawing.Image)(resources.GetObject("btnMonografia.Image")));
            this.btnMonografia.Location = new System.Drawing.Point(130, 0);
            this.btnMonografia.Name = "btnMonografia";
            this.btnMonografia.Size = new System.Drawing.Size(175, 45);
            this.btnMonografia.TabIndex = 1;
            this.btnMonografia.Text = "Monografías";
            this.btnMonografia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonografia.UseVisualStyleBackColor = true;
            this.btnMonografia.Click += new System.EventHandler(this.btnMonografia_Click);
            this.btnMonografia.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnMonografia.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(130, 45);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            this.btnInicio.MouseEnter += new System.EventHandler(this.btnMouseEnter);
            this.btnInicio.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            // 
            // WindowP
            // 
            this.WindowP.Controls.Add(this.PanelMenuTrans);
            this.WindowP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowP.Location = new System.Drawing.Point(0, 139);
            this.WindowP.Name = "WindowP";
            this.WindowP.Size = new System.Drawing.Size(900, 461);
            this.WindowP.TabIndex = 2;
            // 
            // PanelMenuTrans
            // 
            this.PanelMenuTrans.BackColor = System.Drawing.Color.SkyBlue;
            this.PanelMenuTrans.Controls.Add(this.btnDevolucion);
            this.PanelMenuTrans.Controls.Add(this.btnPrestamos);
            this.PanelMenuTrans.Location = new System.Drawing.Point(469, 0);
            this.PanelMenuTrans.Name = "PanelMenuTrans";
            this.PanelMenuTrans.Size = new System.Drawing.Size(199, 82);
            this.PanelMenuTrans.TabIndex = 0;
            this.PanelMenuTrans.Visible = false;
            // 
            // btnDevolucion
            // 
            this.btnDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolucion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDevolucion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDevolucion.FlatAppearance.BorderSize = 0;
            this.btnDevolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucion.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucion.Image = ((System.Drawing.Image)(resources.GetObject("btnDevolucion.Image")));
            this.btnDevolucion.Location = new System.Drawing.Point(0, 40);
            this.btnDevolucion.Name = "btnDevolucion";
            this.btnDevolucion.Size = new System.Drawing.Size(199, 40);
            this.btnDevolucion.TabIndex = 5;
            this.btnDevolucion.Text = "Devolución";
            this.btnDevolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDevolucion.UseVisualStyleBackColor = true;
            this.btnDevolucion.Click += new System.EventHandler(this.btnDevolucion_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrestamos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrestamos.FlatAppearance.BorderSize = 0;
            this.btnPrestamos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestamos.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.Image = ((System.Drawing.Image)(resources.GetObject("btnPrestamos.Image")));
            this.btnPrestamos.Location = new System.Drawing.Point(0, 0);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(199, 40);
            this.btnPrestamos.TabIndex = 4;
            this.btnPrestamos.Text = "Préstamo";
            this.btnPrestamos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.WindowP);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.WindowP.ResumeLayout(false);
            this.PanelMenuTrans.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel WindowP;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnMonografia;
        private System.Windows.Forms.Button btnLector;
        private System.Windows.Forms.Panel PanelMenuTrans;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Button btnDevolucion;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

