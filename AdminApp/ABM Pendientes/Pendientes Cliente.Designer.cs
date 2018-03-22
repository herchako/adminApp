namespace AdminApp.ABM_Pendientes
{
    partial class Pendientes_Cliente
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
            this.dtgv_pendientes_cliente = new System.Windows.Forms.DataGridView();
            this.lnk_id_cliente = new System.Windows.Forms.LinkLabel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_pendientes_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_pendientes_cliente
            // 
            this.dtgv_pendientes_cliente.AllowUserToAddRows = false;
            this.dtgv_pendientes_cliente.AllowUserToDeleteRows = false;
            this.dtgv_pendientes_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_pendientes_cliente.Location = new System.Drawing.Point(12, 12);
            this.dtgv_pendientes_cliente.Name = "dtgv_pendientes_cliente";
            this.dtgv_pendientes_cliente.Size = new System.Drawing.Size(747, 337);
            this.dtgv_pendientes_cliente.TabIndex = 0;
            // 
            // lnk_id_cliente
            // 
            this.lnk_id_cliente.AutoSize = true;
            this.lnk_id_cliente.Location = new System.Drawing.Point(9, 358);
            this.lnk_id_cliente.Name = "lnk_id_cliente";
            this.lnk_id_cliente.Size = new System.Drawing.Size(22, 13);
            this.lnk_id_cliente.TabIndex = 22;
            this.lnk_id_cliente.TabStop = true;
            this.lnk_id_cliente.Text = "#id";
            this.lnk_id_cliente.Visible = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(663, 358);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(96, 34);
            this.btn_cerrar.TabIndex = 23;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Pendientes_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 403);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.lnk_id_cliente);
            this.Controls.Add(this.dtgv_pendientes_cliente);
            this.Name = "Pendientes_Cliente";
            this.Text = "Pendientes_Cliente";
            this.Load += new System.EventHandler(this.Pendientes_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_pendientes_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_pendientes_cliente;
        private System.Windows.Forms.LinkLabel lnk_id_cliente;
        private System.Windows.Forms.Button btn_cerrar;
    }
}