namespace WindowsFormsApp1
{
    partial class ventanaPerfilpersona
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
            this.perfil = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.chkBoxChocolate = new System.Windows.Forms.CheckBox();
            this.lblColorFavorito = new System.Windows.Forms.Label();
            this.rbtPizza = new System.Windows.Forms.RadioButton();
            this.rbtEmpeanadas = new System.Windows.Forms.RadioButton();
            this.rbtHamburguesa = new System.Windows.Forms.RadioButton();
            this.gboxTeam = new System.Windows.Forms.GroupBox();
            this.comboBoxColorFavorito = new System.Windows.Forms.ComboBox();
            this.lblNumeroFavorito = new System.Windows.Forms.Label();
            this.numeroFavorito = new System.Windows.Forms.NumericUpDown();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.gboxTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroFavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // perfil
            // 
            this.perfil.AutoSize = true;
            this.perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perfil.Location = new System.Drawing.Point(48, 9);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(179, 29);
            this.perfil.TabIndex = 0;
            this.perfil.Text = "Perfil Persona";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(111, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre   :";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(174, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(50, 110);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(118, 13);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento   :";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.Location = new System.Drawing.Point(174, 110);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // chkBoxChocolate
            // 
            this.chkBoxChocolate.AutoSize = true;
            this.chkBoxChocolate.Location = new System.Drawing.Point(174, 154);
            this.chkBoxChocolate.Name = "chkBoxChocolate";
            this.chkBoxChocolate.Size = new System.Drawing.Size(138, 17);
            this.chkBoxChocolate.TabIndex = 6;
            this.chkBoxChocolate.Text = "Te gusta el chocolate ?";
            this.chkBoxChocolate.UseVisualStyleBackColor = true;
            // 
            // lblColorFavorito
            // 
            this.lblColorFavorito.AutoSize = true;
            this.lblColorFavorito.Location = new System.Drawing.Point(87, 305);
            this.lblColorFavorito.Name = "lblColorFavorito";
            this.lblColorFavorito.Size = new System.Drawing.Size(81, 13);
            this.lblColorFavorito.TabIndex = 7;
            this.lblColorFavorito.Text = "Color favorito   :";
            // 
            // rbtPizza
            // 
            this.rbtPizza.AutoSize = true;
            this.rbtPizza.Location = new System.Drawing.Point(207, 38);
            this.rbtPizza.Name = "rbtPizza";
            this.rbtPizza.Size = new System.Drawing.Size(50, 17);
            this.rbtPizza.TabIndex = 8;
            this.rbtPizza.TabStop = true;
            this.rbtPizza.Text = "Pizza";
            this.rbtPizza.UseVisualStyleBackColor = true;
            // 
            // rbtEmpeanadas
            // 
            this.rbtEmpeanadas.AutoSize = true;
            this.rbtEmpeanadas.Location = new System.Drawing.Point(355, 38);
            this.rbtEmpeanadas.Name = "rbtEmpeanadas";
            this.rbtEmpeanadas.Size = new System.Drawing.Size(81, 17);
            this.rbtEmpeanadas.TabIndex = 9;
            this.rbtEmpeanadas.TabStop = true;
            this.rbtEmpeanadas.Text = "Empanadas";
            this.rbtEmpeanadas.UseVisualStyleBackColor = true;
            // 
            // rbtHamburguesa
            // 
            this.rbtHamburguesa.AutoSize = true;
            this.rbtHamburguesa.Location = new System.Drawing.Point(6, 38);
            this.rbtHamburguesa.Name = "rbtHamburguesa";
            this.rbtHamburguesa.Size = new System.Drawing.Size(91, 17);
            this.rbtHamburguesa.TabIndex = 10;
            this.rbtHamburguesa.TabStop = true;
            this.rbtHamburguesa.Text = "Hamburguesa";
            this.rbtHamburguesa.UseVisualStyleBackColor = true;
            // 
            // gboxTeam
            // 
            this.gboxTeam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gboxTeam.Controls.Add(this.rbtEmpeanadas);
            this.gboxTeam.Controls.Add(this.rbtHamburguesa);
            this.gboxTeam.Controls.Add(this.rbtPizza);
            this.gboxTeam.Location = new System.Drawing.Point(90, 187);
            this.gboxTeam.Name = "gboxTeam";
            this.gboxTeam.Size = new System.Drawing.Size(442, 83);
            this.gboxTeam.TabIndex = 12;
            this.gboxTeam.TabStop = false;
            this.gboxTeam.Text = "Team";
            // 
            // comboBoxColorFavorito
            // 
            this.comboBoxColorFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxColorFavorito.FormattingEnabled = true;
            this.comboBoxColorFavorito.Location = new System.Drawing.Point(175, 302);
            this.comboBoxColorFavorito.Name = "comboBoxColorFavorito";
            this.comboBoxColorFavorito.Size = new System.Drawing.Size(199, 21);
            this.comboBoxColorFavorito.TabIndex = 13;
            // 
            // lblNumeroFavorito
            // 
            this.lblNumeroFavorito.AutoSize = true;
            this.lblNumeroFavorito.Location = new System.Drawing.Point(73, 348);
            this.lblNumeroFavorito.Name = "lblNumeroFavorito";
            this.lblNumeroFavorito.Size = new System.Drawing.Size(94, 13);
            this.lblNumeroFavorito.TabIndex = 14;
            this.lblNumeroFavorito.Text = "Numero favorito   :";
            // 
            // numeroFavorito
            // 
            this.numeroFavorito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numeroFavorito.Location = new System.Drawing.Point(175, 346);
            this.numeroFavorito.Name = "numeroFavorito";
            this.numeroFavorito.Size = new System.Drawing.Size(199, 20);
            this.numeroFavorito.TabIndex = 15;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMostrar.Location = new System.Drawing.Point(228, 530);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(114, 402);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(318, 109);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ventanaPerfilpersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 580);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.numeroFavorito);
            this.Controls.Add(this.lblNumeroFavorito);
            this.Controls.Add(this.comboBoxColorFavorito);
            this.Controls.Add(this.gboxTeam);
            this.Controls.Add(this.lblColorFavorito);
            this.Controls.Add(this.chkBoxChocolate);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.perfil);
            this.MinimumSize = new System.Drawing.Size(578, 619);
            this.Name = "ventanaPerfilpersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxTeam.ResumeLayout(false);
            this.gboxTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroFavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label perfil;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.CheckBox chkBoxChocolate;
        private System.Windows.Forms.Label lblColorFavorito;
        private System.Windows.Forms.RadioButton rbtPizza;
        private System.Windows.Forms.RadioButton rbtEmpeanadas;
        private System.Windows.Forms.RadioButton rbtHamburguesa;
        private System.Windows.Forms.GroupBox gboxTeam;
        private System.Windows.Forms.ComboBox comboBoxColorFavorito;
        private System.Windows.Forms.Label lblNumeroFavorito;
        private System.Windows.Forms.NumericUpDown numeroFavorito;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListView listView1;
    }
}

