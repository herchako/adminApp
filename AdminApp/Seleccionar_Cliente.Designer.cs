namespace AdminApp
{
    partial class Seleccionar_Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar_cliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgv_lista_clientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_lista_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // txt_buscar_cliente
            // 
            this.txt_buscar_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_buscar_cliente.Location = new System.Drawing.Point(81, 7);
            this.txt_buscar_cliente.Name = "txt_buscar_cliente";
            this.txt_buscar_cliente.Size = new System.Drawing.Size(174, 26);
            this.txt_buscar_cliente.TabIndex = 1;
            this.txt_buscar_cliente.TextChanged += new System.EventHandler(this.txt_buscar_cliente_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(261, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nuevo +";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgv_lista_clientes
            // 
            this.dtgv_lista_clientes.AllowUserToAddRows = false;
            this.dtgv_lista_clientes.AllowUserToDeleteRows = false;
            this.dtgv_lista_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_lista_clientes.Location = new System.Drawing.Point(1, 42);
            this.dtgv_lista_clientes.Name = "dtgv_lista_clientes";
            this.dtgv_lista_clientes.ReadOnly = true;
            this.dtgv_lista_clientes.Size = new System.Drawing.Size(347, 208);
            this.dtgv_lista_clientes.TabIndex = 3;
            // 
            // Seleccionar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 337);
            this.Controls.Add(this.dtgv_lista_clientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_buscar_cliente);
            this.Controls.Add(this.label1);
            this.Name = "Seleccionar_Cliente";
            this.Text = "Seleccionar_Persona";
            this.Load += new System.EventHandler(this.Seleccionar_Persona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_lista_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar_cliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgv_lista_clientes;
    }
}