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
        public object id_cliente_seleccionado { get; private set; }

        private void Seleccionar_Persona_Load(object sender, EventArgs e)
        {

            dtgv_lista_clientes.DataSource = TraerListaClientes();
            this.dtgv_lista_clientes.Columns["ID_CLIENTE"].Visible = false;

            //Estilo
            this.dtgv_lista_clientes.RowsDefaultCellStyle.BackColor = Color.White;
            this.dtgv_lista_clientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            this.dtgv_lista_clientes.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            this.dtgv_lista_clientes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12);
            this.dtgv_lista_clientes.EnableHeadersVisualStyles = false;
            this.dtgv_lista_clientes.Font = new Font("Arial", 11);
            
            this.dtgv_lista_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_lista_clientes.Columns[1].Width = 90;


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
            (dtgv_lista_clientes.DataSource as DataTable).DefaultView.RowFilter = string.Format("APELLIDO LIKE '%{0}%'", txt_buscar_cliente.Text);
        }

        private void dtgv_lista_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cliente_seleccionado = dtgv_lista_clientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.id_cliente_seleccionado = dtgv_lista_clientes.Rows[e.RowIndex].Cells[0].Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
