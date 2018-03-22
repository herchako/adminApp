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
    public partial class Pendientes_Cliente : Form
    {
        public static Int32 id_cliente;
        public Pendientes_Cliente(int id_cliente_seleccionado)
        {
            id_cliente = id_cliente_seleccionado; 
            InitializeComponent();
        }

        private void Pendientes_Cliente_Load(object sender, EventArgs e)
        {
            dtgv_pendientes_cliente.DataSource = TraerListaPendientes();
        }

        private object TraerListaPendientes()
        {
            DataSet ds = new DataSet();
            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Clear();
            
            sqlCommand.CommandText = "SP_TRAER_PENDIENTES_POR_CLIENTE_ID";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@id_cliente", id_cliente);
            DataTable dt_pendientes = baseDeDatos.consulta_parametrizada(sqlCommand);
            sqlCommand.Parameters.Clear();

            return dt_pendientes;

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
