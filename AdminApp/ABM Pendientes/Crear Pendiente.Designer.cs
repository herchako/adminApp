namespace AdminApp.ABM_Pendientes
{
    partial class Crear_Pendiente
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
            this.grpbx_BuscarPendiente = new System.Windows.Forms.GroupBox();
            this.txt_buscar_cod = new System.Windows.Forms.TextBox();
            this.lbl_buscar_id = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_buscar_apellido = new System.Windows.Forms.Label();
            this.cmb_buscar_apellido = new System.Windows.Forms.ComboBox();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.lbl_periodo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_concepto = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.grp_pendiente = new System.Windows.Forms.GroupBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.chkbox_pagado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_cargar_apellido = new System.Windows.Forms.ComboBox();
            this.rtb_observaciones = new System.Windows.Forms.RichTextBox();
            this.lbl_observaciones = new System.Windows.Forms.Label();
            this.txt_importe = new System.Windows.Forms.TextBox();
            this.lbl_importe = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_periodo = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.grpbx_BuscarPendiente.SuspendLayout();
            this.grp_pendiente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbx_BuscarPendiente
            // 
            this.grpbx_BuscarPendiente.Controls.Add(this.txt_buscar_cod);
            this.grpbx_BuscarPendiente.Controls.Add(this.lbl_buscar_id);
            this.grpbx_BuscarPendiente.Controls.Add(this.btn_buscar);
            this.grpbx_BuscarPendiente.Controls.Add(this.lbl_buscar_apellido);
            this.grpbx_BuscarPendiente.Controls.Add(this.cmb_buscar_apellido);
            this.grpbx_BuscarPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_BuscarPendiente.Location = new System.Drawing.Point(8, 10);
            this.grpbx_BuscarPendiente.Name = "grpbx_BuscarPendiente";
            this.grpbx_BuscarPendiente.Size = new System.Drawing.Size(460, 74);
            this.grpbx_BuscarPendiente.TabIndex = 19;
            this.grpbx_BuscarPendiente.TabStop = false;
            this.grpbx_BuscarPendiente.Text = "Buscar Pendiente";
            // 
            // txt_buscar_cod
            // 
            this.txt_buscar_cod.AcceptsReturn = true;
            this.txt_buscar_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_buscar_cod.Location = new System.Drawing.Point(338, 21);
            this.txt_buscar_cod.Name = "txt_buscar_cod";
            this.txt_buscar_cod.Size = new System.Drawing.Size(59, 35);
            this.txt_buscar_cod.TabIndex = 4;
            // 
            // lbl_buscar_id
            // 
            this.lbl_buscar_id.AutoSize = true;
            this.lbl_buscar_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_buscar_id.Location = new System.Drawing.Point(295, 27);
            this.lbl_buscar_id.Name = "lbl_buscar_id";
            this.lbl_buscar_id.Size = new System.Drawing.Size(46, 24);
            this.lbl_buscar_id.TabIndex = 3;
            this.lbl_buscar_id.Text = "#ID:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = global::AdminApp.Properties.Resources.search_button_without_text_md;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_buscar.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_buscar.Location = new System.Drawing.Point(403, 16);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(44, 45);
            this.btn_buscar.TabIndex = 2;
            this.btn_buscar.Text = " ";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // lbl_buscar_apellido
            // 
            this.lbl_buscar_apellido.AutoSize = true;
            this.lbl_buscar_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_buscar_apellido.Location = new System.Drawing.Point(5, 31);
            this.lbl_buscar_apellido.Name = "lbl_buscar_apellido";
            this.lbl_buscar_apellido.Size = new System.Drawing.Size(73, 20);
            this.lbl_buscar_apellido.TabIndex = 1;
            this.lbl_buscar_apellido.Text = "Apellido";
            // 
            // cmb_buscar_apellido
            // 
            this.cmb_buscar_apellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_buscar_apellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_buscar_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmb_buscar_apellido.FormattingEnabled = true;
            this.cmb_buscar_apellido.Location = new System.Drawing.Point(81, 24);
            this.cmb_buscar_apellido.Name = "cmb_buscar_apellido";
            this.cmb_buscar_apellido.Size = new System.Drawing.Size(209, 32);
            this.cmb_buscar_apellido.TabIndex = 0;
            this.cmb_buscar_apellido.SelectionChangeCommitted += new System.EventHandler(this.cmb_buscar_apellido_SelectionChangeCommitted);
            // 
            // txt_concepto
            // 
            this.txt_concepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_concepto.Location = new System.Drawing.Point(81, 59);
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(366, 26);
            this.txt_concepto.TabIndex = 13;
            // 
            // lbl_periodo
            // 
            this.lbl_periodo.AutoSize = true;
            this.lbl_periodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_periodo.Location = new System.Drawing.Point(6, 96);
            this.lbl_periodo.Name = "lbl_periodo";
            this.lbl_periodo.Size = new System.Drawing.Size(60, 18);
            this.lbl_periodo.TabIndex = 6;
            this.lbl_periodo.Text = "Periodo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido";
            // 
            // lbl_concepto
            // 
            this.lbl_concepto.AutoSize = true;
            this.lbl_concepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_concepto.Location = new System.Drawing.Point(6, 63);
            this.lbl_concepto.Name = "lbl_concepto";
            this.lbl_concepto.Size = new System.Drawing.Size(73, 18);
            this.lbl_concepto.TabIndex = 18;
            this.lbl_concepto.Text = "Concepto";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_direccion.Location = new System.Drawing.Point(6, 128);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(71, 18);
            this.lbl_direccion.TabIndex = 23;
            this.lbl_direccion.Text = "Dirección";
            // 
            // grp_pendiente
            // 
            this.grp_pendiente.Controls.Add(this.dtp_fecha);
            this.grp_pendiente.Controls.Add(this.lbl_fecha);
            this.grp_pendiente.Controls.Add(this.chkbox_pagado);
            this.grp_pendiente.Controls.Add(this.label2);
            this.grp_pendiente.Controls.Add(this.cmb_cargar_apellido);
            this.grp_pendiente.Controls.Add(this.rtb_observaciones);
            this.grp_pendiente.Controls.Add(this.lbl_observaciones);
            this.grp_pendiente.Controls.Add(this.txt_importe);
            this.grp_pendiente.Controls.Add(this.lbl_importe);
            this.grp_pendiente.Controls.Add(this.txt_direccion);
            this.grp_pendiente.Controls.Add(this.txt_periodo);
            this.grp_pendiente.Controls.Add(this.lbl_direccion);
            this.grp_pendiente.Controls.Add(this.lbl_concepto);
            this.grp_pendiente.Controls.Add(this.label1);
            this.grp_pendiente.Controls.Add(this.lbl_periodo);
            this.grp_pendiente.Controls.Add(this.txt_concepto);
            this.grp_pendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grp_pendiente.Location = new System.Drawing.Point(8, 90);
            this.grp_pendiente.Name = "grp_pendiente";
            this.grp_pendiente.Size = new System.Drawing.Size(460, 268);
            this.grp_pendiente.TabIndex = 20;
            this.grp_pendiente.TabStop = false;
            this.grp_pendiente.Text = "Informacion";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(322, 90);
            this.dtp_fecha.MinDate = new System.DateTime(1923, 1, 1, 0, 0, 0, 0);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(125, 26);
            this.dtp_fecha.TabIndex = 51;
            this.dtp_fecha.Value = new System.DateTime(2018, 3, 15, 0, 0, 0, 0);
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(262, 94);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(54, 20);
            this.lbl_fecha.TabIndex = 50;
            this.lbl_fecha.Text = "Fecha";
            // 
            // chkbox_pagado
            // 
            this.chkbox_pagado.AutoSize = true;
            this.chkbox_pagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbox_pagado.Location = new System.Drawing.Point(430, 28);
            this.chkbox_pagado.Name = "chkbox_pagado";
            this.chkbox_pagado.Size = new System.Drawing.Size(15, 14);
            this.chkbox_pagado.TabIndex = 49;
            this.chkbox_pagado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 48;
            this.label2.Text = "Pagado: ";
            // 
            // cmb_cargar_apellido
            // 
            this.cmb_cargar_apellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_cargar_apellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_cargar_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmb_cargar_apellido.FormattingEnabled = true;
            this.cmb_cargar_apellido.Location = new System.Drawing.Point(81, 18);
            this.cmb_cargar_apellido.Name = "cmb_cargar_apellido";
            this.cmb_cargar_apellido.Size = new System.Drawing.Size(209, 32);
            this.cmb_cargar_apellido.TabIndex = 47;
            // 
            // rtb_observaciones
            // 
            this.rtb_observaciones.Location = new System.Drawing.Point(81, 188);
            this.rtb_observaciones.Name = "rtb_observaciones";
            this.rtb_observaciones.Size = new System.Drawing.Size(366, 64);
            this.rtb_observaciones.TabIndex = 46;
            this.rtb_observaciones.Text = "";
            // 
            // lbl_observaciones
            // 
            this.lbl_observaciones.AutoSize = true;
            this.lbl_observaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_observaciones.Location = new System.Drawing.Point(7, 192);
            this.lbl_observaciones.Name = "lbl_observaciones";
            this.lbl_observaciones.Size = new System.Drawing.Size(40, 18);
            this.lbl_observaciones.TabIndex = 28;
            this.lbl_observaciones.Text = "Obs.";
            // 
            // txt_importe
            // 
            this.txt_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_importe.Location = new System.Drawing.Point(81, 152);
            this.txt_importe.Name = "txt_importe";
            this.txt_importe.Size = new System.Drawing.Size(366, 26);
            this.txt_importe.TabIndex = 27;
            // 
            // lbl_importe
            // 
            this.lbl_importe.AutoSize = true;
            this.lbl_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_importe.Location = new System.Drawing.Point(6, 160);
            this.lbl_importe.Name = "lbl_importe";
            this.lbl_importe.Size = new System.Drawing.Size(58, 18);
            this.lbl_importe.TabIndex = 26;
            this.lbl_importe.Text = "Importe";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_direccion.Location = new System.Drawing.Point(81, 120);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(366, 26);
            this.txt_direccion.TabIndex = 25;
            // 
            // txt_periodo
            // 
            this.txt_periodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_periodo.Location = new System.Drawing.Point(81, 88);
            this.txt_periodo.Name = "txt_periodo";
            this.txt_periodo.Size = new System.Drawing.Size(156, 26);
            this.txt_periodo.TabIndex = 24;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_guardar.Location = new System.Drawing.Point(270, 373);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(96, 34);
            this.btn_guardar.TabIndex = 22;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(372, 373);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(96, 34);
            this.btn_cerrar.TabIndex = 21;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Crear_Pendiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 419);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.grp_pendiente);
            this.Controls.Add(this.grpbx_BuscarPendiente);
            this.Name = "Crear_Pendiente";
            this.Text = "Crear_Pendiente";
            this.Load += new System.EventHandler(this.Crear_Pendiente_Load);
            this.grpbx_BuscarPendiente.ResumeLayout(false);
            this.grpbx_BuscarPendiente.PerformLayout();
            this.grp_pendiente.ResumeLayout(false);
            this.grp_pendiente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpbx_BuscarPendiente;
        private System.Windows.Forms.TextBox txt_buscar_cod;
        private System.Windows.Forms.Label lbl_buscar_id;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_buscar_apellido;
        private System.Windows.Forms.ComboBox cmb_buscar_apellido;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.Label lbl_periodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_concepto;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.GroupBox grp_pendiente;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_periodo;
        private System.Windows.Forms.Label lbl_observaciones;
        private System.Windows.Forms.TextBox txt_importe;
        private System.Windows.Forms.Label lbl_importe;
        private System.Windows.Forms.RichTextBox rtb_observaciones;
        private System.Windows.Forms.ComboBox cmb_cargar_apellido;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.CheckBox chkbox_pagado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label lbl_fecha;
    }
}