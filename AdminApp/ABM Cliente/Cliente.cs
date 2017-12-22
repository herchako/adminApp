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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT USERNAME, PASSWORD FROM KOTINFO.CLIENTES " +
                                     "WHERE ID_USUARIO=2";
            sqlCommand.CommandType = CommandType.Text;



        }
    }
}
