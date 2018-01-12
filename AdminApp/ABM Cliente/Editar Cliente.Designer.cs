﻿namespace AdminApp.ABM_Cliente
{
    partial class Editar_Cliente
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
            this.cmb_buscar_apellido = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_buscar_apellido = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_buscar_id = new System.Windows.Forms.Label();
            this.txt_buscar_id = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_buscar_apellido
            // 
            this.cmb_buscar_apellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_buscar_apellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_buscar_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_buscar_apellido.FormattingEnabled = true;
            this.cmb_buscar_apellido.Location = new System.Drawing.Point(77, 25);
            this.cmb_buscar_apellido.Name = "cmb_buscar_apellido";
            this.cmb_buscar_apellido.Size = new System.Drawing.Size(115, 28);
            this.cmb_buscar_apellido.TabIndex = 0;
            this.cmb_buscar_apellido.SelectionChangeCommitted += new System.EventHandler(this.cmb_buscar_apellido_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_buscar_id);
            this.groupBox1.Controls.Add(this.lbl_buscar_id);
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.lbl_buscar_apellido);
            this.groupBox1.Controls.Add(this.cmb_buscar_apellido);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar cliente";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::AdminApp.Properties.Resources.search_button_without_text_md;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_buscar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_buscar.Location = new System.Drawing.Point(476, 16);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(44, 44);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = " ";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_buscar_apellido
            // 
            this.lbl_buscar_apellido.AutoSize = true;
            this.lbl_buscar_apellido.Location = new System.Drawing.Point(6, 28);
            this.lbl_buscar_apellido.Name = "lbl_buscar_apellido";
            this.lbl_buscar_apellido.Size = new System.Drawing.Size(65, 20);
            this.lbl_buscar_apellido.TabIndex = 1;
            this.lbl_buscar_apellido.Text = "Apellido";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_nombre.Location = new System.Drawing.Point(90, 114);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 24);
            this.txt_nombre.TabIndex = 2;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(22, 117);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(62, 18);
            this.lbl_nombre.TabIndex = 3;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_buscar_id
            // 
            this.lbl_buscar_id.AutoSize = true;
            this.lbl_buscar_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_buscar_id.Location = new System.Drawing.Point(331, 28);
            this.lbl_buscar_id.Name = "lbl_buscar_id";
            this.lbl_buscar_id.Size = new System.Drawing.Size(46, 24);
            this.lbl_buscar_id.TabIndex = 3;
            this.lbl_buscar_id.Text = "#ID:";
            // 
            // txt_buscar_id
            // 
            this.txt_buscar_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_buscar_id.Location = new System.Drawing.Point(383, 21);
            this.txt_buscar_id.Name = "txt_buscar_id";
            this.txt_buscar_id.Size = new System.Drawing.Size(87, 35);
            this.txt_buscar_id.TabIndex = 4;
            // 
            // Editar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 411);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.groupBox1);
            this.Name = "Editar_Cliente";
            this.Text = "Editar Cliente";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_buscar_apellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_buscar_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar_id;
        private System.Windows.Forms.Label lbl_buscar_id;
    }
}