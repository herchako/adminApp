namespace AdminApp
{
    partial class Nuevo_Usuario
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
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_contrasena = new System.Windows.Forms.Label();
            this.lbl_confirmacion = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.txt_contrasena_conf = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_error_usuario = new System.Windows.Forms.Label();
            this.lbl_error_contrasena = new System.Windows.Forms.Label();
            this.lbl_error_confirmacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_usuario.Location = new System.Drawing.Point(108, 14);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(61, 17);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuario:";
            // 
            // lbl_contrasena
            // 
            this.lbl_contrasena.AutoSize = true;
            this.lbl_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_contrasena.Location = new System.Drawing.Point(84, 46);
            this.lbl_contrasena.Name = "lbl_contrasena";
            this.lbl_contrasena.Size = new System.Drawing.Size(85, 17);
            this.lbl_contrasena.TabIndex = 1;
            this.lbl_contrasena.Text = "Contraseña:";
            // 
            // lbl_confirmacion
            // 
            this.lbl_confirmacion.AutoSize = true;
            this.lbl_confirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_confirmacion.Location = new System.Drawing.Point(0, 75);
            this.lbl_confirmacion.Name = "lbl_confirmacion";
            this.lbl_confirmacion.Size = new System.Drawing.Size(169, 17);
            this.lbl_confirmacion.TabIndex = 2;
            this.lbl_confirmacion.Text = "Confirmación contraseña:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_usuario.Location = new System.Drawing.Point(175, 11);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(100, 23);
            this.txt_usuario.TabIndex = 3;
            this.txt_usuario.Enter += new System.EventHandler(this.txt_usuario_Enter);
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_contrasena.Location = new System.Drawing.Point(175, 43);
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.PasswordChar = '·';
            this.txt_contrasena.Size = new System.Drawing.Size(100, 23);
            this.txt_contrasena.TabIndex = 4;
            this.txt_contrasena.Enter += new System.EventHandler(this.txt_contrasena_Enter);
            // 
            // txt_contrasena_conf
            // 
            this.txt_contrasena_conf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_contrasena_conf.Location = new System.Drawing.Point(175, 72);
            this.txt_contrasena_conf.Name = "txt_contrasena_conf";
            this.txt_contrasena_conf.PasswordChar = '·';
            this.txt_contrasena_conf.Size = new System.Drawing.Size(100, 23);
            this.txt_contrasena_conf.TabIndex = 5;
            this.txt_contrasena_conf.Enter += new System.EventHandler(this.txt_contrasena_conf_Enter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(175, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_error_usuario
            // 
            this.lbl_error_usuario.AutoSize = true;
            this.lbl_error_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_usuario.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_usuario.Location = new System.Drawing.Point(281, 12);
            this.lbl_error_usuario.Name = "lbl_error_usuario";
            this.lbl_error_usuario.Size = new System.Drawing.Size(27, 18);
            this.lbl_error_usuario.TabIndex = 7;
            this.lbl_error_usuario.Text = "(*)";
            this.lbl_error_usuario.Visible = false;
            // 
            // lbl_error_contrasena
            // 
            this.lbl_error_contrasena.AutoSize = true;
            this.lbl_error_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_contrasena.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_contrasena.Location = new System.Drawing.Point(281, 45);
            this.lbl_error_contrasena.Name = "lbl_error_contrasena";
            this.lbl_error_contrasena.Size = new System.Drawing.Size(27, 18);
            this.lbl_error_contrasena.TabIndex = 8;
            this.lbl_error_contrasena.Text = "(*)";
            this.lbl_error_contrasena.Visible = false;
            // 
            // lbl_error_confirmacion
            // 
            this.lbl_error_confirmacion.AutoSize = true;
            this.lbl_error_confirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_confirmacion.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_confirmacion.Location = new System.Drawing.Point(281, 74);
            this.lbl_error_confirmacion.Name = "lbl_error_confirmacion";
            this.lbl_error_confirmacion.Size = new System.Drawing.Size(27, 18);
            this.lbl_error_confirmacion.TabIndex = 9;
            this.lbl_error_confirmacion.Text = "(*)";
            this.lbl_error_confirmacion.Visible = false;
            // 
            // Nuevo_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 144);
            this.Controls.Add(this.lbl_error_confirmacion);
            this.Controls.Add(this.lbl_error_contrasena);
            this.Controls.Add(this.lbl_error_usuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_contrasena_conf);
            this.Controls.Add(this.txt_contrasena);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_confirmacion);
            this.Controls.Add(this.lbl_contrasena);
            this.Controls.Add(this.lbl_usuario);
            this.Name = "Nuevo_Usuario";
            this.Text = "Nuevo Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_contrasena;
        private System.Windows.Forms.Label lbl_confirmacion;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contrasena;
        private System.Windows.Forms.TextBox txt_contrasena_conf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_error_usuario;
        private System.Windows.Forms.Label lbl_error_contrasena;
        private System.Windows.Forms.Label lbl_error_confirmacion;
    }
}