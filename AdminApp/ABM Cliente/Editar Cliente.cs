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
            cargarComboBox(cmb_buscar_apellido, "SP_TRAER_CLIENTES", "APELLIDO", "ID_CLIENTE");
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
            DataSet ds = new DataSet();
            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "SP_TRAER_CLIENTE_POR_ID";
            sqlCommand.Parameters.AddWithValue("@id_cliente", cmb_buscar_apellido.SelectedValue);
            DataTable dt_tipo = baseDeDatos.consulta_parametrizada(sqlCommand);
            txt_nombre.Text = dt_tipo.Rows[0][3].ToString();
            sqlCommand.Parameters.Clear();

        }
    }
}
