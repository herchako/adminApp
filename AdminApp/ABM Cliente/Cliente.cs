using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;



namespace AdminApp
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(ConfigurationManager.ConnectionStrings["InmobiliariaContext"].ConnectionString);
            cargarComboBox(cmb_tipo_cliente, "SP_TRAER_TIPO_CLIENTES", "DESCRIPCION", "ID_TIPO_CLIENTE");
            cargarComboBox(cmb_tipo_cuil_cuit, "SP_TRAER_TIPO_CUIL_CUIT", "DESCRIPCION", "ID_TIPO_CUIL_CUIT");
            cargarComboBox(cmb_provincia, "SP_TRAER_PROVINCIAS", "NOMBRE", "ID_PROVINCIA");
            actualizarComboBox(cmb_partido, "SP_TRAER_DEPARTAMENTOS_POR_PROVINCIA", "NOMBRE", "ID_DEPARTAMENTO", "1","@id_provincia");
            actualizarComboBox(cmb_localidad, "SP_TRAER_LOCALIDAD_POR_DEPARTAMENTO", "NOMBRE", "ID_LOCALIDAD","65", "@id_departamento");
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

        private void actualizarComboBox(ComboBox comboBox, string storedProcedure, string displayMember, string valueMember, string selectedIndex, string paramName)
        {
            DataSet ds = new DataSet();
            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandText = storedProcedure;
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue(paramName, selectedIndex);
            
            DataTable dt_tipo = baseDeDatos.consulta_parametrizada(sqlCommand);
            comboBox.DataSource = dt_tipo;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            sqlCommand.Parameters.Clear();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (verificar_campos_obligatorios())
            {
                guardarCliente();
                MessageBox.Show("Guardado!", "Exito");
                limpiarGroupBox();
            }
            else
            {
                MessageBox.Show("No puedes dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool verificar_campos_obligatorios()
        {
            var camposObligatorios = new List<Control>();
            camposObligatorios.Add(txt_nombre);
            camposObligatorios.Add(txt_apellido);

            pintarCamposIncompletos(camposObligatorios);

            if (camposObligatorios.All<Control>(campos => campos.Text != "")&&cmb_tipo_cliente.SelectedIndex!=0)
                return true;
            else
                return false;
        }


        private void pintarCamposIncompletos(List<Control> camposObligatorios)
        {
            var camposIncompletos = camposObligatorios.FindAll(campos => campos.Text == "");
            camposIncompletos.ForEach(campos => campos.BackColor = Color.Red);
            if (cmb_tipo_cliente.SelectedIndex == 0) {
                cmb_tipo_cliente.BackColor = Color.Red;
            }
            var camposCompletos = camposObligatorios.FindAll(campos => campos.Text != "");
            camposCompletos.ForEach(campos => campos.BackColor = Color.White);
            if (cmb_tipo_cliente.SelectedIndex != 0)
            {
                cmb_tipo_cliente.BackColor = Color.White;
            }
        }

        private void guardarCliente()
        {
            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SP_INSERTAR_CLIENTE";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nombre", txt_nombre.Text);
            sqlCommand.Parameters.AddWithValue("@apellido", txt_apellido.Text);
            sqlCommand.Parameters.AddWithValue("@telefono", msktxt_telefono.Text);
            sqlCommand.Parameters.AddWithValue("@celular", msktxt_celular.Text);
            sqlCommand.Parameters.AddWithValue("@otro_tel", txt_otro_tel.Text);
            sqlCommand.Parameters.AddWithValue("@id_tipo_cliente", cmb_tipo_cliente.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@id_tipo_cuil_cuit", cmb_tipo_cuil_cuit.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@dni", msk_dni.Text);
            sqlCommand.Parameters.AddWithValue("@fecha_nacimiento", dtp_nacimiento.Text);
            sqlCommand.Parameters.AddWithValue("@domicilio_calle", txt_calle.Text);
            sqlCommand.Parameters.AddWithValue("@domicilio_altura", txt_altura.Text);
            sqlCommand.Parameters.AddWithValue("@domicilio_piso", txt_piso.Text);
            sqlCommand.Parameters.AddWithValue("@domicilio_dpto", txt_dpto.Text);
            sqlCommand.Parameters.AddWithValue("@domicilio_provincia", cmb_provincia.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@domicilio_partido", cmb_partido.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@domicilio_localidad", cmb_localidad.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@observaciones", rtb_observaciones.Text);
            baseDeDatos.ejecuta(sqlCommand);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarGroupBox();

        }

        private void limpiarGroupBox()
        {
            this.Controls.OfType<GroupBox>().ToList().ForEach(groupBox => groupBox.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Text = String.Empty));
            this.Controls.OfType<GroupBox>().ToList().ForEach(groupBox => groupBox.Controls.OfType<MaskedTextBox>().ToList().ForEach(maskedTextBox => maskedTextBox.Text = String.Empty));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + txt_email.Text);
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            txt_nombre.BackColor = Color.White;
        }

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {
            txt_apellido.BackColor = Color.White;
        }

        private void cmb_tipo_cliente_Enter(object sender, EventArgs e)
        {
            cmb_tipo_cliente.BackColor = Color.White;
        }

        private void cmb_provincia_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_provincia.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                actualizarComboBox(cmb_partido, "SP_TRAER_DEPARTAMENTOS_POR_PROVINCIA", "NOMBRE", "ID_DEPARTAMENTO", "1" , "@id_provincia");
            }
            else {
                actualizarComboBox(cmb_partido, "SP_TRAER_DEPARTAMENTOS_POR_PROVINCIA", "NOMBRE", "ID_DEPARTAMENTO", cmb_provincia.SelectedValue.ToString(), "@id_provincia");

            }
        }

        private void cmb_partido_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (cmb_partido.SelectedValue.ToString().Equals("System.Data.DataRowView"))
            {
                actualizarComboBox(cmb_localidad, "SP_TRAER_LOCALIDAD_POR_DEPARTAMENTO", "NOMBRE", "ID_LOCALIDAD", "65", "@id_departamento");
            }
            else
            {
                actualizarComboBox(cmb_localidad, "SP_TRAER_LOCALIDAD_POR_DEPARTAMENTO", "NOMBRE", "ID_LOCALIDAD", cmb_partido.SelectedValue.ToString(), "@id_departamento");
            }
        }
    }
}

