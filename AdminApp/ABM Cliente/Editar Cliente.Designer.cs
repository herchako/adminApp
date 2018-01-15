namespace AdminApp.ABM_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Cliente));
            this.cmb_buscar_apellido = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_buscar_id = new System.Windows.Forms.TextBox();
            this.lbl_buscar_id = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_buscar_apellido = new System.Windows.Forms.Label();
            this.grp_cliente = new System.Windows.Forms.GroupBox();
            this.rtb_observaciones = new System.Windows.Forms.RichTextBox();
            this.lbl_observaciones = new System.Windows.Forms.Label();
            this.lbl_dpto = new System.Windows.Forms.Label();
            this.txt_dpto = new System.Windows.Forms.TextBox();
            this.lbl_piso = new System.Windows.Forms.Label();
            this.txt_piso = new System.Windows.Forms.TextBox();
            this.lbl_calle = new System.Windows.Forms.Label();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.lbl_domicilio = new System.Windows.Forms.Label();
            this.lbl_localidad = new System.Windows.Forms.Label();
            this.cmb_localidad = new System.Windows.Forms.ComboBox();
            this.lbl_partido = new System.Windows.Forms.Label();
            this.cmb_partido = new System.Windows.Forms.ComboBox();
            this.lbl_provincia = new System.Windows.Forms.Label();
            this.cmb_provincia = new System.Windows.Forms.ComboBox();
            this.dtp_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.lbl_nacimiento = new System.Windows.Forms.Label();
            this.cmb_tipo_cuil_cuit = new System.Windows.Forms.ComboBox();
            this.msk_dni = new System.Windows.Forms.MaskedTextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_divisor = new System.Windows.Forms.Label();
            this.msktxt_celular = new System.Windows.Forms.MaskedTextBox();
            this.msktxt_telefono = new System.Windows.Forms.MaskedTextBox();
            this.pb_email = new System.Windows.Forms.PictureBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.cmb_tipo_cliente = new System.Windows.Forms.ComboBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_otro_tel = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_otro_tel = new System.Windows.Forms.TextBox();
            this.lbl_celular = new System.Windows.Forms.Label();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grp_cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_email)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_buscar_apellido
            // 
            this.cmb_buscar_apellido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_buscar_apellido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_buscar_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmb_buscar_apellido.FormattingEnabled = true;
            this.cmb_buscar_apellido.Location = new System.Drawing.Point(74, 25);
            this.cmb_buscar_apellido.Name = "cmb_buscar_apellido";
            this.cmb_buscar_apellido.Size = new System.Drawing.Size(169, 32);
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
            this.groupBox1.Size = new System.Drawing.Size(460, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar cliente";
            // 
            // txt_buscar_id
            // 
            this.txt_buscar_id.AcceptsReturn = true;
            this.txt_buscar_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_buscar_id.Location = new System.Drawing.Point(310, 21);
            this.txt_buscar_id.Name = "txt_buscar_id";
            this.txt_buscar_id.Size = new System.Drawing.Size(87, 35);
            this.txt_buscar_id.TabIndex = 4;
            // 
            // lbl_buscar_id
            // 
            this.lbl_buscar_id.AutoSize = true;
            this.lbl_buscar_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_buscar_id.Location = new System.Drawing.Point(258, 28);
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
            this.btn_buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_buscar_apellido
            // 
            this.lbl_buscar_apellido.AutoSize = true;
            this.lbl_buscar_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_buscar_apellido.Location = new System.Drawing.Point(10, 31);
            this.lbl_buscar_apellido.Name = "lbl_buscar_apellido";
            this.lbl_buscar_apellido.Size = new System.Drawing.Size(65, 20);
            this.lbl_buscar_apellido.TabIndex = 1;
            this.lbl_buscar_apellido.Text = "Apellido";
            // 
            // grp_cliente
            // 
            this.grp_cliente.Controls.Add(this.rtb_observaciones);
            this.grp_cliente.Controls.Add(this.lbl_observaciones);
            this.grp_cliente.Controls.Add(this.lbl_dpto);
            this.grp_cliente.Controls.Add(this.txt_dpto);
            this.grp_cliente.Controls.Add(this.lbl_piso);
            this.grp_cliente.Controls.Add(this.txt_piso);
            this.grp_cliente.Controls.Add(this.lbl_calle);
            this.grp_cliente.Controls.Add(this.txt_calle);
            this.grp_cliente.Controls.Add(this.lbl_altura);
            this.grp_cliente.Controls.Add(this.txt_altura);
            this.grp_cliente.Controls.Add(this.lbl_domicilio);
            this.grp_cliente.Controls.Add(this.lbl_localidad);
            this.grp_cliente.Controls.Add(this.cmb_localidad);
            this.grp_cliente.Controls.Add(this.lbl_partido);
            this.grp_cliente.Controls.Add(this.cmb_partido);
            this.grp_cliente.Controls.Add(this.lbl_provincia);
            this.grp_cliente.Controls.Add(this.cmb_provincia);
            this.grp_cliente.Controls.Add(this.dtp_nacimiento);
            this.grp_cliente.Controls.Add(this.lbl_nacimiento);
            this.grp_cliente.Controls.Add(this.cmb_tipo_cuil_cuit);
            this.grp_cliente.Controls.Add(this.msk_dni);
            this.grp_cliente.Controls.Add(this.lbl_dni);
            this.grp_cliente.Controls.Add(this.lbl_divisor);
            this.grp_cliente.Controls.Add(this.msktxt_celular);
            this.grp_cliente.Controls.Add(this.msktxt_telefono);
            this.grp_cliente.Controls.Add(this.pb_email);
            this.grp_cliente.Controls.Add(this.lbl_tipo);
            this.grp_cliente.Controls.Add(this.cmb_tipo_cliente);
            this.grp_cliente.Controls.Add(this.lbl_mail);
            this.grp_cliente.Controls.Add(this.txt_email);
            this.grp_cliente.Controls.Add(this.label1);
            this.grp_cliente.Controls.Add(this.txt_nombre);
            this.grp_cliente.Controls.Add(this.lbl_apellido);
            this.grp_cliente.Controls.Add(this.lbl_otro_tel);
            this.grp_cliente.Controls.Add(this.lbl_telefono);
            this.grp_cliente.Controls.Add(this.txt_otro_tel);
            this.grp_cliente.Controls.Add(this.lbl_celular);
            this.grp_cliente.Controls.Add(this.txt_apellido);
            this.grp_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grp_cliente.Location = new System.Drawing.Point(12, 92);
            this.grp_cliente.Name = "grp_cliente";
            this.grp_cliente.Size = new System.Drawing.Size(460, 422);
            this.grp_cliente.TabIndex = 18;
            this.grp_cliente.TabStop = false;
            this.grp_cliente.Text = "Datos Cliente";
            // 
            // rtb_observaciones
            // 
            this.rtb_observaciones.Location = new System.Drawing.Point(6, 320);
            this.rtb_observaciones.Name = "rtb_observaciones";
            this.rtb_observaciones.Size = new System.Drawing.Size(448, 96);
            this.rtb_observaciones.TabIndex = 45;
            this.rtb_observaciones.Text = "";
            // 
            // lbl_observaciones
            // 
            this.lbl_observaciones.AutoSize = true;
            this.lbl_observaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_observaciones.Location = new System.Drawing.Point(7, 299);
            this.lbl_observaciones.Name = "lbl_observaciones";
            this.lbl_observaciones.Size = new System.Drawing.Size(112, 18);
            this.lbl_observaciones.TabIndex = 44;
            this.lbl_observaciones.Text = "Observaciones:";
            // 
            // lbl_dpto
            // 
            this.lbl_dpto.AutoSize = true;
            this.lbl_dpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dpto.Location = new System.Drawing.Point(374, 196);
            this.lbl_dpto.Name = "lbl_dpto";
            this.lbl_dpto.Size = new System.Drawing.Size(41, 18);
            this.lbl_dpto.TabIndex = 42;
            this.lbl_dpto.Text = "dpto.";
            // 
            // txt_dpto
            // 
            this.txt_dpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_dpto.Location = new System.Drawing.Point(417, 193);
            this.txt_dpto.Name = "txt_dpto";
            this.txt_dpto.Size = new System.Drawing.Size(30, 24);
            this.txt_dpto.TabIndex = 43;
            // 
            // lbl_piso
            // 
            this.lbl_piso.AutoSize = true;
            this.lbl_piso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_piso.Location = new System.Drawing.Point(296, 196);
            this.lbl_piso.Name = "lbl_piso";
            this.lbl_piso.Size = new System.Drawing.Size(36, 18);
            this.lbl_piso.TabIndex = 40;
            this.lbl_piso.Text = "piso";
            // 
            // txt_piso
            // 
            this.txt_piso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_piso.Location = new System.Drawing.Point(338, 193);
            this.txt_piso.Name = "txt_piso";
            this.txt_piso.Size = new System.Drawing.Size(30, 24);
            this.txt_piso.TabIndex = 41;
            // 
            // lbl_calle
            // 
            this.lbl_calle.AutoSize = true;
            this.lbl_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calle.Location = new System.Drawing.Point(6, 196);
            this.lbl_calle.Name = "lbl_calle";
            this.lbl_calle.Size = new System.Drawing.Size(41, 18);
            this.lbl_calle.TabIndex = 37;
            this.lbl_calle.Text = "Calle";
            // 
            // txt_calle
            // 
            this.txt_calle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_calle.Location = new System.Drawing.Point(53, 193);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(151, 24);
            this.txt_calle.TabIndex = 36;
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_altura.Location = new System.Drawing.Point(210, 196);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(44, 18);
            this.lbl_altura.TabIndex = 38;
            this.lbl_altura.Text = "altura";
            // 
            // txt_altura
            // 
            this.txt_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_altura.Location = new System.Drawing.Point(260, 193);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(30, 24);
            this.txt_altura.TabIndex = 39;
            // 
            // lbl_domicilio
            // 
            this.lbl_domicilio.AutoSize = true;
            this.lbl_domicilio.Location = new System.Drawing.Point(9, 164);
            this.lbl_domicilio.Name = "lbl_domicilio";
            this.lbl_domicilio.Size = new System.Drawing.Size(72, 20);
            this.lbl_domicilio.TabIndex = 35;
            this.lbl_domicilio.Text = "Domicilio";
            // 
            // lbl_localidad
            // 
            this.lbl_localidad.AutoSize = true;
            this.lbl_localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_localidad.Location = new System.Drawing.Point(7, 268);
            this.lbl_localidad.Name = "lbl_localidad";
            this.lbl_localidad.Size = new System.Drawing.Size(68, 16);
            this.lbl_localidad.TabIndex = 34;
            this.lbl_localidad.Text = "Localidad";
            // 
            // cmb_localidad
            // 
            this.cmb_localidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_localidad.FormattingEnabled = true;
            this.cmb_localidad.Location = new System.Drawing.Point(84, 265);
            this.cmb_localidad.Name = "cmb_localidad";
            this.cmb_localidad.Size = new System.Drawing.Size(120, 24);
            this.cmb_localidad.TabIndex = 33;
            // 
            // lbl_partido
            // 
            this.lbl_partido.AutoSize = true;
            this.lbl_partido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_partido.Location = new System.Drawing.Point(210, 232);
            this.lbl_partido.Name = "lbl_partido";
            this.lbl_partido.Size = new System.Drawing.Size(51, 16);
            this.lbl_partido.TabIndex = 32;
            this.lbl_partido.Text = "Partido";
            // 
            // cmb_partido
            // 
            this.cmb_partido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_partido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_partido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_partido.FormattingEnabled = true;
            this.cmb_partido.Location = new System.Drawing.Point(269, 228);
            this.cmb_partido.Name = "cmb_partido";
            this.cmb_partido.Size = new System.Drawing.Size(178, 24);
            this.cmb_partido.TabIndex = 31;
            this.cmb_partido.SelectedValueChanged += new System.EventHandler(this.cmb_partido_SelectedValueChanged_1);
            // 
            // lbl_provincia
            // 
            this.lbl_provincia.AutoSize = true;
            this.lbl_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_provincia.Location = new System.Drawing.Point(7, 231);
            this.lbl_provincia.Name = "lbl_provincia";
            this.lbl_provincia.Size = new System.Drawing.Size(57, 16);
            this.lbl_provincia.TabIndex = 30;
            this.lbl_provincia.Text = "Provicia";
            // 
            // cmb_provincia
            // 
            this.cmb_provincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_provincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_provincia.FormattingEnabled = true;
            this.cmb_provincia.Location = new System.Drawing.Point(70, 228);
            this.cmb_provincia.Name = "cmb_provincia";
            this.cmb_provincia.Size = new System.Drawing.Size(134, 24);
            this.cmb_provincia.TabIndex = 29;
            this.cmb_provincia.SelectedValueChanged += new System.EventHandler(this.cmb_provincia_SelectedValueChanged_1);
            // 
            // dtp_nacimiento
            // 
            this.dtp_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nacimiento.Location = new System.Drawing.Point(327, 117);
            this.dtp_nacimiento.MinDate = new System.DateTime(1923, 1, 1, 0, 0, 0, 0);
            this.dtp_nacimiento.Name = "dtp_nacimiento";
            this.dtp_nacimiento.Size = new System.Drawing.Size(120, 26);
            this.dtp_nacimiento.TabIndex = 28;
            this.dtp_nacimiento.Value = new System.DateTime(2017, 12, 29, 15, 56, 15, 0);
            // 
            // lbl_nacimiento
            // 
            this.lbl_nacimiento.AutoSize = true;
            this.lbl_nacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nacimiento.Location = new System.Drawing.Point(246, 121);
            this.lbl_nacimiento.Name = "lbl_nacimiento";
            this.lbl_nacimiento.Size = new System.Drawing.Size(83, 18);
            this.lbl_nacimiento.TabIndex = 27;
            this.lbl_nacimiento.Text = "Nacimiento";
            // 
            // cmb_tipo_cuil_cuit
            // 
            this.cmb_tipo_cuil_cuit.FormattingEnabled = true;
            this.cmb_tipo_cuil_cuit.Location = new System.Drawing.Point(140, 115);
            this.cmb_tipo_cuil_cuit.Name = "cmb_tipo_cuil_cuit";
            this.cmb_tipo_cuil_cuit.Size = new System.Drawing.Size(100, 28);
            this.cmb_tipo_cuil_cuit.TabIndex = 26;
            this.cmb_tipo_cuil_cuit.Text = "CUIL/CUIT";
            // 
            // msk_dni
            // 
            this.msk_dni.Location = new System.Drawing.Point(44, 117);
            this.msk_dni.Mask = "99,999,999";
            this.msk_dni.Name = "msk_dni";
            this.msk_dni.Size = new System.Drawing.Size(88, 26);
            this.msk_dni.TabIndex = 24;
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dni.Location = new System.Drawing.Point(6, 120);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(37, 18);
            this.lbl_dni.TabIndex = 23;
            this.lbl_dni.Text = "DNI.";
            // 
            // lbl_divisor
            // 
            this.lbl_divisor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_divisor.Location = new System.Drawing.Point(6, 158);
            this.lbl_divisor.Name = "lbl_divisor";
            this.lbl_divisor.Size = new System.Drawing.Size(451, 2);
            this.lbl_divisor.TabIndex = 22;
            // 
            // msktxt_celular
            // 
            this.msktxt_celular.Location = new System.Drawing.Point(178, 84);
            this.msktxt_celular.Mask = "(99)0000-0000";
            this.msktxt_celular.Name = "msktxt_celular";
            this.msktxt_celular.Size = new System.Drawing.Size(100, 26);
            this.msktxt_celular.TabIndex = 21;
            // 
            // msktxt_telefono
            // 
            this.msktxt_telefono.Location = new System.Drawing.Point(44, 85);
            this.msktxt_telefono.Mask = "0000-0000";
            this.msktxt_telefono.Name = "msktxt_telefono";
            this.msktxt_telefono.Size = new System.Drawing.Size(88, 26);
            this.msktxt_telefono.TabIndex = 20;
            // 
            // pb_email
            // 
            this.pb_email.Image = global::AdminApp.Properties.Resources.email;
            this.pb_email.InitialImage = ((System.Drawing.Image)(resources.GetObject("pb_email.InitialImage")));
            this.pb_email.Location = new System.Drawing.Point(425, 55);
            this.pb_email.Name = "pb_email";
            this.pb_email.Size = new System.Drawing.Size(22, 21);
            this.pb_email.TabIndex = 19;
            this.pb_email.TabStop = false;
            this.pb_email.Visible = false;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo.Location = new System.Drawing.Point(6, 55);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(37, 18);
            this.lbl_tipo.TabIndex = 18;
            this.lbl_tipo.Text = "Tipo";
            // 
            // cmb_tipo_cliente
            // 
            this.cmb_tipo_cliente.FormattingEnabled = true;
            this.cmb_tipo_cliente.Location = new System.Drawing.Point(44, 52);
            this.cmb_tipo_cliente.Name = "cmb_tipo_cliente";
            this.cmb_tipo_cliente.Size = new System.Drawing.Size(181, 28);
            this.cmb_tipo_cliente.TabIndex = 17;
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mail.Location = new System.Drawing.Point(231, 56);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(48, 18);
            this.lbl_mail.TabIndex = 16;
            this.lbl_mail.Text = "e-Mail";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_email.Location = new System.Drawing.Point(287, 52);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(160, 24);
            this.txt_email.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_nombre.Location = new System.Drawing.Point(74, 22);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(151, 24);
            this.txt_nombre.TabIndex = 0;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido.Location = new System.Drawing.Point(231, 25);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(59, 18);
            this.lbl_apellido.TabIndex = 4;
            this.lbl_apellido.Text = "Apellido";
            // 
            // lbl_otro_tel
            // 
            this.lbl_otro_tel.AutoSize = true;
            this.lbl_otro_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_otro_tel.Location = new System.Drawing.Point(284, 88);
            this.lbl_otro_tel.Name = "lbl_otro_tel";
            this.lbl_otro_tel.Size = new System.Drawing.Size(66, 18);
            this.lbl_otro_tel.TabIndex = 14;
            this.lbl_otro_tel.Text = "Otro Tel.";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefono.Location = new System.Drawing.Point(6, 88);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(32, 18);
            this.lbl_telefono.TabIndex = 6;
            this.lbl_telefono.Text = "Tel.";
            // 
            // txt_otro_tel
            // 
            this.txt_otro_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_otro_tel.Location = new System.Drawing.Point(350, 82);
            this.txt_otro_tel.Name = "txt_otro_tel";
            this.txt_otro_tel.Size = new System.Drawing.Size(97, 26);
            this.txt_otro_tel.TabIndex = 13;
            // 
            // lbl_celular
            // 
            this.lbl_celular.AutoSize = true;
            this.lbl_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_celular.Location = new System.Drawing.Point(138, 88);
            this.lbl_celular.Name = "lbl_celular";
            this.lbl_celular.Size = new System.Drawing.Size(34, 18);
            this.lbl_celular.TabIndex = 8;
            this.lbl_celular.Text = "Cel.";
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txt_apellido.Location = new System.Drawing.Point(290, 22);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(157, 24);
            this.txt_apellido.TabIndex = 9;
            // 
            // Editar_Cliente
            // 
            this.AcceptButton = this.btn_buscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 569);
            this.Controls.Add(this.grp_cliente);
            this.Controls.Add(this.groupBox1);
            this.Name = "Editar_Cliente";
            this.Text = "Editar Cliente";
            this.Load += new System.EventHandler(this.Editar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_cliente.ResumeLayout(false);
            this.grp_cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_email)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_buscar_apellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_buscar_apellido;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar_id;
        private System.Windows.Forms.Label lbl_buscar_id;
        private System.Windows.Forms.GroupBox grp_cliente;
        private System.Windows.Forms.RichTextBox rtb_observaciones;
        private System.Windows.Forms.Label lbl_observaciones;
        private System.Windows.Forms.Label lbl_dpto;
        private System.Windows.Forms.TextBox txt_dpto;
        private System.Windows.Forms.Label lbl_piso;
        private System.Windows.Forms.TextBox txt_piso;
        private System.Windows.Forms.Label lbl_calle;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.Label lbl_domicilio;
        private System.Windows.Forms.Label lbl_localidad;
        private System.Windows.Forms.ComboBox cmb_localidad;
        private System.Windows.Forms.Label lbl_partido;
        private System.Windows.Forms.ComboBox cmb_partido;
        private System.Windows.Forms.Label lbl_provincia;
        private System.Windows.Forms.ComboBox cmb_provincia;
        private System.Windows.Forms.DateTimePicker dtp_nacimiento;
        private System.Windows.Forms.Label lbl_nacimiento;
        private System.Windows.Forms.ComboBox cmb_tipo_cuil_cuit;
        private System.Windows.Forms.MaskedTextBox msk_dni;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_divisor;
        private System.Windows.Forms.MaskedTextBox msktxt_celular;
        private System.Windows.Forms.MaskedTextBox msktxt_telefono;
        private System.Windows.Forms.PictureBox pb_email;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.ComboBox cmb_tipo_cliente;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_otro_tel;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_otro_tel;
        private System.Windows.Forms.Label lbl_celular;
        private System.Windows.Forms.TextBox txt_apellido;
    }
}