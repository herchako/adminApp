using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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

        private object GuardarPendiente(int id_pendiente, int cod_pendiente, string concepto, string peridodo, string fecha, string direccion, string importe, bool pagado, string observaciones)
        {
            DataSet ds = new DataSet();
            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandText = "SP_ACTUALIZAR_PENDIENTE_POR_ID_PENDIENTE";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@id_pendiente", id_pendiente);
            sqlCommand.Parameters.AddWithValue("@concepto", concepto);
            sqlCommand.Parameters.AddWithValue("@fecha", fecha);
            sqlCommand.Parameters.AddWithValue("@importe", float.Parse(importe, CultureInfo.InvariantCulture));
            sqlCommand.Parameters.AddWithValue("@pagado", pagado);
            sqlCommand.Parameters.AddWithValue("@observaciones", observaciones);


            DataTable dt_pendientes = baseDeDatos.consulta_parametrizada(sqlCommand);
            sqlCommand.Parameters.Clear();

            return dt_pendientes;
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
            if (chk_box_mostrar_todos.Checked == true)
                sqlCommand.Parameters.AddWithValue("@pagado", null);
            else
                sqlCommand.Parameters.AddWithValue("@pagado", false);
            DataTable dt_pendientes = baseDeDatos.consulta_parametrizada(sqlCommand);
            sqlCommand.Parameters.Clear();

            return dt_pendientes;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_box_mostrar_todos_CheckedChanged(object sender, EventArgs e)
        {
            dtgv_pendientes_cliente.DataSource = TraerListaPendientes();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtgv_pendientes_cliente.Rows.Count; i++)
            {
                GuardarPendiente(Int32.Parse(dtgv_pendientes_cliente.Rows[i].Cells["ID_PENDIENTE"].Value.ToString()),
                                 Int32.Parse(dtgv_pendientes_cliente.Rows[i].Cells["COD_PENDIENTE"].Value.ToString()),
                                 dtgv_pendientes_cliente.Rows[i].Cells["CONCEPTO"].Value.ToString(),
                                 dtgv_pendientes_cliente.Rows[i].Cells["PERIODO"].Value.ToString(),
                                 dtgv_pendientes_cliente.Rows[i].Cells["FECHA"].Value.ToString(),
                                 dtgv_pendientes_cliente.Rows[i].Cells["DIRECCION"].Value.ToString(),
                                 dtgv_pendientes_cliente.Rows[i].Cells["IMPORTE"].Value.ToString(),
                                 bool.Parse(dtgv_pendientes_cliente.Rows[i].Cells["PAGADO"].Value.ToString()),
                                 dtgv_pendientes_cliente.Rows[i].Cells["OBSERVACIONES"].Value.ToString()
                                 );
            }
            MessageBox.Show("Guardado!", "Exito");
            this.Close();
        }


    }
}
