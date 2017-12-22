using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApp
{
    public class BaseDeDatos
    {
        public int idUsuario { get; set; }
        public int idRol { get; set; }

        //---Singleton---//
        private static BaseDeDatos instance;

        private BaseDeDatos()
        {

        }

        public static BaseDeDatos Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaseDeDatos();

                return instance;
            }
        }
        //---Singleton---//

        public DataTable consulta(SqlCommand sqlCommand)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Properties.Settings.Default.CadenaDeConexion;
            sqlCommand.Connection = sqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

        public int ejecuta(SqlCommand sqlCommand)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = Properties.Settings.Default.CadenaDeConexion;
            sqlCommand.Connection = sqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            int valor = Convert.ToInt32(sqlDataAdapter.SelectCommand.ExecuteScalar()); //Revisar
            sqlConnection.Close();

            return valor;
        }
    }
}
