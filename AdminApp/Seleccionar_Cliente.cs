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

namespace AdminApp
{
    public partial class Seleccionar_Cliente : Form
    {
        

        DataTable dt_lista_clientes = new DataTable();
        public Seleccionar_Cliente()
        {
            InitializeComponent();
        }

        public string cliente_seleccionado { get; private set; }

        private void Seleccionar_Persona_Load(object sender, EventArgs e)
        {
            this.cliente_seleccionado = "Something";
            //this.DialogResult = DialogResult.OK;
            dtgv_lista_clientes.DataSource = TraerListaClientes();
        }

        private object TraerListaClientes()
        {
            DataSet ds = new DataSet();
            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Clear();

            sqlCommand.CommandText = "SP_TRAER_CLIENTES_CODIGO_APELLIDO_Y_NOMBRE";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            dt_lista_clientes = baseDeDatos.consulta_parametrizada(sqlCommand);
            sqlCommand.Parameters.Clear();

            return dt_lista_clientes;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgv_lista_clientes.DataSource = TraerListaClientes();
        }

        private void txt_buscar_cliente_TextChanged(object sender, EventArgs e)
        {
            (dtgv_lista_clientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("APELLIDO = '{3}'", txt_buscar_cliente.Text);
        }
    }
}
