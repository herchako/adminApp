namespace AdminApp
{
    partial class Cliente
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
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(88, 29);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(88, 65);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.Size = new System.Drawing.Size(240, 150);
            this.dgv_clientes.TabIndex = 1;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 487);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.txt_nombre);
            this.Name = "Cliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.DataGridView dgv_clientes;
    }
}

