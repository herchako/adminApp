using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp.ABM_Pendientes
{
    public partial class Crear_Pendiente : Form
    {
        public Crear_Pendiente()
        {
            InitializeComponent();
        }

        private void Crear_Pendiente_Load(object sender, EventArgs e)
        {
            cargarComboBox(cmb_buscar_apellido, "SP_TRAER_CLIENTES_APELLIDO_Y_NOMBRE", "APELLIDO", "ID_CLIENTE");
            cargarComboBox(cmb_cargar_apellido, "SP_TRAER_CLIENTES_APELLIDO_Y_NOMBRE", "APELLIDO", "ID_CLIENTE");
        }

        private void cargarComboBox(ComboBox comboBox, string storedProcedure, string displayMember, string valueMember)
        {
            DataSet ds = new DataSet();
            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = storedProcedure;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt_tipo = baseDeDatos.consulta(sqlCommand).Tables[0];
            comboBox.DataSource = dt_tipo;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            sqlCommand.Parameters.Clear();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validar_campos())
            {
                guardarPendiente();
                MessageBox.Show("Guardado!", "Exito");
                limpiarGroupBox();
            }
        }

        private bool validar_campos()
        {
            var camposObligatorios = new List<Control>();
            camposObligatorios.Add(txt_concepto);
            camposObligatorios.Add(txt_importe);


            pintarCamposIncompletos(camposObligatorios);

            if (camposObligatorios.All<Control>(campos => campos.Text != "")
                && cmb_cargar_apellido.SelectedIndex != 0
                && es_numero(txt_importe.Text))
                return true;
            else
                return false;
        }

        private bool es_numero(string text)
        {
            float n;
            bool isNumeric = float.TryParse(text, out n);
            return isNumeric;
        }

        private void pintarCamposIncompletos(List<Control> camposObligatorios)
        {
            var camposIncompletos = camposObligatorios.FindAll(campos => campos.Text == "");
            camposIncompletos.ForEach(campos => campos.BackColor = Color.Red);
            if (cmb_cargar_apellido.SelectedIndex == 0)
            {
                cmb_cargar_apellido.BackColor = Color.Red;
            }
            if (!es_numero(txt_importe.Text))
            {
                lbl_error_importe.Visible = true;
                txt_importe.BackColor = Color.Red;
            }
            else
            {
                lbl_error_importe.Visible = false;
                txt_importe.BackColor = Color.White;
            }
            var camposCompletos = camposObligatorios.FindAll(campos => campos.Text != "");
            camposCompletos.ForEach(campos => campos.BackColor = Color.White);
            if (cmb_cargar_apellido.SelectedIndex != 0)
            {
                cmb_cargar_apellido.BackColor = Color.White;
            }
        }

        private void limpiarGroupBox()
        {
            this.Controls.OfType<GroupBox>().ToList().ForEach(groupBox => groupBox.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Text = String.Empty));
            this.Controls.OfType<GroupBox>().ToList().ForEach(groupBox => groupBox.Controls.OfType<RichTextBox>().ToList().ForEach(richTextBox => richTextBox.Text = String.Empty));
            this.Controls.OfType<GroupBox>().ToList().ForEach(groupBox => groupBox.Controls.OfType<MaskedTextBox>().ToList().ForEach(maskedTextBox => maskedTextBox.Text = String.Empty));
            this.txt_buscar_cod.Text = null;
        }

        private void guardarPendiente()
        {
            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SP_INSERTAR_PENDIENTE";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@id_cliente", Int32.Parse(cmb_cargar_apellido.SelectedValue.ToString()));
            sqlCommand.Parameters.AddWithValue("@concepto", txt_concepto.Text);
            sqlCommand.Parameters.AddWithValue("@periodo", txt_periodo.Text);
            sqlCommand.Parameters.AddWithValue("@fecha", dtp_fecha.Text);
            sqlCommand.Parameters.AddWithValue("@direccion", txt_direccion.Text);
            sqlCommand.Parameters.AddWithValue("@importe", txt_importe.Text);
            sqlCommand.Parameters.AddWithValue("@pagado", chkbox_pagado.Checked ? 1 : 0);
            sqlCommand.Parameters.AddWithValue("@observaciones", rtb_observaciones.Text);
            baseDeDatos.ejecuta(sqlCommand);
        }

        private void cmb_buscar_apellido_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Pendientes_Cliente pendientes_cliente = new Pendientes_Cliente(Int32.Parse(cmb_buscar_apellido.SelectedValue.ToString()));
            pendientes_cliente.Show();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

        }
    }
}

