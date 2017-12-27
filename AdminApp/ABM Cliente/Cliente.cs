using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            DataSet ds = new DataSet();
            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "select ID_USUARIO, NOMBRE from dbo.CLIENTES";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            ds = baseDeDatos.consulta(sqlCommand);

            dgv_clientes.DataSource = ds.Tables[0];

         


        }
    }
}
