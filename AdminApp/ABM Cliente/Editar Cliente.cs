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

namespace AdminApp.ABM_Cliente
{
    public partial class Editar_Cliente : Form
    {
        public Editar_Cliente()
        {
            InitializeComponent();
        }

        private void Editar_Load(object sender, EventArgs e)
        {
            cargarComboBox(cmb_buscar_apellido, "SP_TRAER_CLIENTES_APELLIDO_Y_NOMBRE", "APELLIDO", "ID_CLIENTE");
            cargarComboBox(cmb_tipo_cliente, "SP_TRAER_TIPO_CLIENTES", "DESCRIPCION", "ID_TIPO_CLIENTE");
            cargarComboBox(cmb_tipo_cuil_cuit, "SP_TRAER_TIPO_CUIL_CUIT", "DESCRIPCION", "ID_TIPO_CUIL_CUIT");
            cargarComboBox(cmb_provincia, "SP_TRAER_PROVINCIAS", "NOMBRE", "ID_PROVINCIA");
            actualizarComboBox(cmb_partido, "SP_TRAER_DEPARTAMENTOS_POR_PROVINCIA", "NOMBRE", "ID_DEPARTAMENTO", "1", "@id_provincia");
            actualizarComboBox(cmb_localidad, "SP_TRAER_LOCALIDAD_POR_DEPARTAMENTO", "NOMBRE", "ID_LOCALIDAD", "65", "@id_departamento");
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

        private void cmb_buscar_apellido_SelectionChangeCommitted(object sender, EventArgs e)
        {
            buscarDatosClientePorId(cmb_buscar_apellido.SelectedValue);

        }

        private void buscarDatosClientePorId(Object idCliente)
        {
            DataSet ds = new DataSet();
            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "SP_TRAER_CLIENTE_POR_ID";
            sqlCommand.Parameters.AddWithValue("@id_cliente", idCliente);
            DataTable dt_cliente = baseDeDatos.consulta_parametrizada(sqlCommand);
            if ((dt_cliente != null) && (dt_cliente.Rows.Count != 0))
            {
                llenarDatosCliente(dt_cliente);
            }
            else
            {
                MessageBox.Show("Cliente inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlCommand.Parameters.Clear();
        }

        private void buscarDatosClientePorCod(Object CodCliente)
        {
            DataSet ds = new DataSet();
            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "SP_TRAER_CLIENTE_POR_COD";
            sqlCommand.Parameters.AddWithValue("@cod_cliente", CodCliente);
            DataTable dt_cliente = baseDeDatos.consulta_parametrizada(sqlCommand);
            if ((dt_cliente != null) && (dt_cliente.Rows.Count != 0))
            {
                llenarDatosCliente(dt_cliente);
            }
            else
            {
                MessageBox.Show("Cliente inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlCommand.Parameters.Clear();
        }

        private void llenarDatosCliente(DataTable dt_cliente)
        {
            lnk_id_cliente.Text = dt_cliente.Rows[0][0].ToString();
            txt_buscar_cod.Text = dt_cliente.Rows[0][1].ToString();
            cmb_tipo_cliente.SelectedValue = dt_cliente.Rows[0][2].ToString();
            txt_nombre.Text = dt_cliente.Rows[0][3].ToString();
            txt_apellido.Text = dt_cliente.Rows[0][4].ToString();
            txt_email.Text = dt_cliente.Rows[0][5].ToString();
            msktxt_telefono.Text = dt_cliente.Rows[0][6].ToString();
            msktxt_celular.Text = dt_cliente.Rows[0][7].ToString();
            txt_otro_tel.Text = dt_cliente.Rows[0][8].ToString();
            msk_dni.Text = dt_cliente.Rows[0][9].ToString();
            cmb_tipo_cuil_cuit.SelectedValue = dt_cliente.Rows[0][10].ToString();
            dtp_nacimiento.Text = dt_cliente.Rows[0][11].ToString();
            txt_calle.Text = dt_cliente.Rows[0][12].ToString();
            txt_altura.Text = dt_cliente.Rows[0][13].ToString();
            txt_piso.Text = dt_cliente.Rows[0][14].ToString();
            txt_dpto.Text = dt_cliente.Rows[0][15].ToString();
            cmb_provincia.SelectedValue = dt_cliente.Rows[0][16].ToString();
            cmb_partido.SelectedValue = dt_cliente.Rows[0][17].ToString();
            cmb_localidad.SelectedValue = dt_cliente.Rows[0][18].ToString();
            rtb_observaciones.Text = dt_cliente.Rows[0][19].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int cod_cliente = string.IsNullOrEmpty(txt_buscar_cod.Text) ? -1 : int.Parse(txt_buscar_cod.Text);//que mierda pasa!?
                buscarDatosClientePorCod(cod_cliente);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("El #ID debe ser un número " + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void cmb_partido_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (cmb_partido.SelectedValue != null)
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

        private bool verificar_campos_obligatorios()
        {
            var camposObligatorios = new List<Control>();
            camposObligatorios.Add(txt_nombre);
            camposObligatorios.Add(txt_apellido);

            pintarCamposIncompletos(camposObligatorios);

            if (camposObligatorios.All<Control>(campos => campos.Text != "") && cmb_tipo_cliente.SelectedIndex != 0)
                return true;
            else
                return false;
        }


        private void pintarCamposIncompletos(List<Control> camposObligatorios)
        {
            var camposIncompletos = camposObligatorios.FindAll(campos => campos.Text == "");
            camposIncompletos.ForEach(campos => campos.BackColor = Color.Red);
            if (cmb_tipo_cliente.SelectedIndex == 0)
            {
                cmb_tipo_cliente.BackColor = Color.Red;
            }
            var camposCompletos = camposObligatorios.FindAll(campos => campos.Text != "");
            camposCompletos.ForEach(campos => campos.BackColor = Color.White);
            if (cmb_tipo_cliente.SelectedIndex != 0)
            {
                cmb_tipo_cliente.BackColor = Color.White;
            }
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

        private void cmb_provincia_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (cmb_provincia.SelectedValue != null)
            {
                if (cmb_provincia.SelectedValue.ToString().Equals("System.Data.DataRowView"))
                {
                    actualizarComboBox(cmb_partido, "SP_TRAER_DEPARTAMENTOS_POR_PROVINCIA", "NOMBRE", "ID_DEPARTAMENTO", "1", "@id_provincia");
                }
                else
                {
                    actualizarComboBox(cmb_partido, "SP_TRAER_DEPARTAMENTOS_POR_PROVINCIA", "NOMBRE", "ID_DEPARTAMENTO", cmb_provincia.SelectedValue.ToString(), "@id_provincia");

                }
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (verificar_campos_obligatorios())
            {
                guardarCambios();
                MessageBox.Show("Guardado!", "Exito");
                limpiarGroupBox();
            }
            else
            {
                MessageBox.Show("No puedes dejar el campo vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void guardarCambios()
        {
            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SP_ACTUALIZAR_CLIENTE_POR_ID";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@id_cliente", lnk_id_cliente.Text);
            sqlCommand.Parameters.AddWithValue("@nombre", txt_nombre.Text);
            sqlCommand.Parameters.AddWithValue("@apellido", txt_apellido.Text);
            sqlCommand.Parameters.AddWithValue("@email", txt_email.Text);
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

        private void limpiarGroupBox()
        {
            this.Controls.OfType<GroupBox>().ToList().ForEach(groupBox => groupBox.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Text = String.Empty));
            this.Controls.OfType<GroupBox>().ToList().ForEach(groupBox => groupBox.Controls.OfType<RichTextBox>().ToList().ForEach(richTextBox => richTextBox.Text = String.Empty));
            this.Controls.OfType<GroupBox>().ToList().ForEach(groupBox => groupBox.Controls.OfType<MaskedTextBox>().ToList().ForEach(maskedTextBox => maskedTextBox.Text = String.Empty));
            this.txt_buscar_cod.Text = null;
        }
    }
}
