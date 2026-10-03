namespace LOGIN
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.PbLogin = new System.Windows.Forms.PictureBox();
            this.BtnIniciarSesion = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESO AL SISTEMA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "CONTRASEÑA:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(172, 143);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(281, 20);
            this.TxtUsuario.TabIndex = 3;
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(172, 200);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.Size = new System.Drawing.Size(281, 20);
            this.TxtClave.TabIndex = 4;
            // 
            // PbLogin
            // 
            this.PbLogin.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PbLogin.ErrorImage")));
            this.PbLogin.Image = global::LOGIN.Properties.Resources.UDB_LOGO;
            this.PbLogin.InitialImage = ((System.Drawing.Image)(resources.GetObject("PbLogin.InitialImage")));
            this.PbLogin.Location = new System.Drawing.Point(514, 129);
            this.PbLogin.Margin = new System.Windows.Forms.Padding(0);
            this.PbLogin.Name = "PbLogin";
            this.PbLogin.Size = new System.Drawing.Size(227, 232);
            this.PbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLogin.TabIndex = 5;
            this.PbLogin.TabStop = false;
            this.PbLogin.Click += new System.EventHandler(this.PbLogin_Click);
            // 
            // BtnIniciarSesion
            // 
            this.BtnIniciarSesion.Location = new System.Drawing.Point(172, 298);
            this.BtnIniciarSesion.Name = "BtnIniciarSesion";
            this.BtnIniciarSesion.Size = new System.Drawing.Size(103, 32);
            this.BtnIniciarSesion.TabIndex = 6;
            this.BtnIniciarSesion.Text = "INICIAR SESION";
            this.BtnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(331, 298);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(95, 32);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnIniciarSesion);
            this.Controls.Add(this.PbLogin);
            this.Controls.Add(this.TxtClave);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.PictureBox PbLogin;
        private System.Windows.Forms.Button BtnIniciarSesion;
        private System.Windows.Forms.Button BtnCancelar;
    }
}

