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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgv_pendientes_cliente = new System.Windows.Forms.DataGridView();
            this.lnk_id_cliente = new System.Windows.Forms.LinkLabel();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.chk_box_mostrar_todos = new System.Windows.Forms.CheckBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_pendientes_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_pendientes_cliente
            // 
            this.dtgv_pendientes_cliente.AllowUserToAddRows = false;
            this.dtgv_pendientes_cliente.AllowUserToDeleteRows = false;
            this.dtgv_pendientes_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_pendientes_cliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_pendientes_cliente.Location = new System.Drawing.Point(12, 48);
            this.dtgv_pendientes_cliente.Name = "dtgv_pendientes_cliente";
            this.dtgv_pendientes_cliente.Size = new System.Drawing.Size(971, 301);
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
            this.btn_cerrar.Location = new System.Drawing.Point(887, 358);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(96, 34);
            this.btn_cerrar.TabIndex = 23;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // chk_box_mostrar_todos
            // 
            this.chk_box_mostrar_todos.AutoSize = true;
            this.chk_box_mostrar_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_box_mostrar_todos.Location = new System.Drawing.Point(833, 14);
            this.chk_box_mostrar_todos.Name = "chk_box_mostrar_todos";
            this.chk_box_mostrar_todos.Size = new System.Drawing.Size(150, 28);
            this.chk_box_mostrar_todos.TabIndex = 24;
            this.chk_box_mostrar_todos.Text = "Mostrar Todos";
            this.chk_box_mostrar_todos.UseVisualStyleBackColor = true;
            this.chk_box_mostrar_todos.CheckedChanged += new System.EventHandler(this.chk_box_mostrar_todos_CheckedChanged);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(785, 358);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(96, 34);
            this.btn_guardar.TabIndex = 25;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Pendientes_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 403);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.chk_box_mostrar_todos);
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
        private System.Windows.Forms.CheckBox chk_box_mostrar_todos;
        private System.Windows.Forms.Button btn_guardar;
    }
}