namespace AdminApp
{
    partial class MenuPrincipal
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
            this.btn_crearCliente = new System.Windows.Forms.Button();
            this.btn_pendientes = new System.Windows.Forms.Button();
            this.btn_buscarEditarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_crearCliente
            // 
            this.btn_crearCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_crearCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crearCliente.Image = global::AdminApp.Properties.Resources.if_user_profile_edit_103781;
            this.btn_crearCliente.Location = new System.Drawing.Point(112, 12);
            this.btn_crearCliente.Name = "btn_crearCliente";
            this.btn_crearCliente.Size = new System.Drawing.Size(84, 110);
            this.btn_crearCliente.TabIndex = 2;
            this.btn_crearCliente.Text = "Crear Cliente";
            this.btn_crearCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_crearCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_crearCliente.UseVisualStyleBackColor = true;
            this.btn_crearCliente.Click += new System.EventHandler(this.btn_crearCliente_Click);
            // 
            // btn_pendientes
            // 
            this.btn_pendientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_pendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pendientes.Image = global::AdminApp.Properties.Resources.if_line_chart_1608449;
            this.btn_pendientes.Location = new System.Drawing.Point(202, 12);
            this.btn_pendientes.Name = "btn_pendientes";
            this.btn_pendientes.Size = new System.Drawing.Size(84, 110);
            this.btn_pendientes.TabIndex = 1;
            this.btn_pendientes.Text = "Pendientes";
            this.btn_pendientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_pendientes.UseVisualStyleBackColor = true;
            this.btn_pendientes.Click += new System.EventHandler(this.btn_pendientes_Click);
            // 
            // btn_buscarEditarCliente
            // 
            this.btn_buscarEditarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarEditarCliente.Image = global::AdminApp.Properties.Resources.if_Searchicons_search_people2_825453;
            this.btn_buscarEditarCliente.Location = new System.Drawing.Point(22, 12);
            this.btn_buscarEditarCliente.Name = "btn_buscarEditarCliente";
            this.btn_buscarEditarCliente.Size = new System.Drawing.Size(84, 110);
            this.btn_buscarEditarCliente.TabIndex = 0;
            this.btn_buscarEditarCliente.Text = "Buscar Cliente";
            this.btn_buscarEditarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_buscarEditarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_buscarEditarCliente.UseVisualStyleBackColor = true;
            this.btn_buscarEditarCliente.Click += new System.EventHandler(this.btn_buscarEditarCliente_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 353);
            this.Controls.Add(this.btn_crearCliente);
            this.Controls.Add(this.btn_pendientes);
            this.Controls.Add(this.btn_buscarEditarCliente);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_buscarEditarCliente;
        private System.Windows.Forms.Button btn_pendientes;
        private System.Windows.Forms.Button btn_crearCliente;
    }
}