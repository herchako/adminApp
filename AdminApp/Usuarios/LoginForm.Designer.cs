namespace AdminApp
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contrasena = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.lbl_usuario_contrasena_incorrecto = new System.Windows.Forms.Label();
            this.lbl_ingrese_usuario_contrasena = new System.Windows.Forms.Label();
            this.lnk_nuevo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.Location = new System.Drawing.Point(91, 102);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(116, 39);
            this.btn_ingresar.TabIndex = 0;
            this.btn_ingresar.Text = "INGRESAR";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_usuario.Location = new System.Drawing.Point(46, 15);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(79, 24);
            this.lbl_usuario.TabIndex = 2;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // lbl_contrasena
            // 
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_contrasena.Location = new System.Drawing.Point(14, 45);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(111, 24);
            this.lbl_contrasena.TabIndex = 3;
            this.lbl_contrasena.Text = "Contraseña:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_usuario.Location = new System.Drawing.Point(126, 12);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(154, 29);
            this.txt_usuario.TabIndex = 4;
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txt_contrasena.Location = new System.Drawing.Point(126, 42);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.PasswordChar = '·';
            this.txt_contrasena.Size = new System.Drawing.Size(154, 29);
            this.txt_contrasena.TabIndex = 5;
            // 
            // lbl_usuario_contrasena_incorrecto
            // 
            this.lbl_usuario_contrasena_incorrecto.AutoSize = true;
            this.lbl_usuario_contrasena_incorrecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_usuario_contrasena_incorrecto.ForeColor = System.Drawing.Color.Red;
            this.lbl_usuario_contrasena_incorrecto.Location = new System.Drawing.Point(63, 74);
            this.lbl_usuario_contrasena_incorrecto.Name = "lbl_usuario_contrasena_incorrecto";
            this.lbl_usuario_contrasena_incorrecto.Size = new System.Drawing.Size(217, 15);
            this.lbl_usuario_contrasena_incorrecto.TabIndex = 6;
            this.lbl_usuario_contrasena_incorrecto.Text = "error: usuario o contraseña incorrectos";
            this.lbl_usuario_contrasena_incorrecto.Visible = false;
            // 
            // lbl_ingrese_usuario_contrasena
            // 
            this.lbl_ingrese_usuario_contrasena.AutoSize = true;
            this.lbl_ingrese_usuario_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_ingrese_usuario_contrasena.ForeColor = System.Drawing.Color.Red;
            this.lbl_ingrese_usuario_contrasena.Location = new System.Drawing.Point(63, 74);
            this.lbl_ingrese_usuario_contrasena.Name = "lbl_ingrese_usuario_contrasena";
            this.lbl_ingrese_usuario_contrasena.Size = new System.Drawing.Size(164, 15);
            this.lbl_ingrese_usuario_contrasena.TabIndex = 7;
            this.lbl_ingrese_usuario_contrasena.Text = "ingrese usuario y contraseña";
            this.lbl_ingrese_usuario_contrasena.Visible = false;
            // 
            // lnk_nuevo
            // 
            this.lnk_nuevo.AutoSize = true;
            this.lnk_nuevo.Location = new System.Drawing.Point(243, 142);
            this.lnk_nuevo.Name = "lnk_nuevo";
            this.lnk_nuevo.Size = new System.Drawing.Size(37, 13);
            this.lnk_nuevo.TabIndex = 8;
            this.lnk_nuevo.TabStop = true;
            this.lnk_nuevo.Text = "nuevo";
            this.lnk_nuevo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_nuevo_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 164);
            this.Controls.Add(this.lnk_nuevo);
            this.Controls.Add(this.lbl_ingrese_usuario_contrasena);
            this.Controls.Add(this.lbl_usuario_contrasena_incorrecto);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_contrasena);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.btn_ingresar);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_contrasena;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.Label lbl_usuario_contrasena_incorrecto;
        private System.Windows.Forms.Label lbl_ingrese_usuario_contrasena;
        private System.Windows.Forms.LinkLabel lnk_nuevo;
    }
}