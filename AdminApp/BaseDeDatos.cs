using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;


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


        public DataSet consulta(SqlCommand sqlCommand)
        {
            SqlConnection sqlConnection = new SqlConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sqlConnection.ConnectionString = Properties.Settings.Default.CadenaDeConexion;
            sqlCommand.Connection = sqlConnection;
            try
            {
                sqlConnection.Open();
                adapter.SelectCommand = new SqlCommand(sqlCommand.CommandText, sqlConnection);
                adapter.Fill(ds);
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return ds;
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
