﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;


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
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["InmobiliariaContext"].ConnectionString;
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

        public DataTable consulta_parametrizada(SqlCommand sqlCommand)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["InmobiliariaContext"].ConnectionString;
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
            sqlCommand.Parameters.AddWithValue("@modificado_por", LoginInfo.UserID);
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["InmobiliariaContext"].ConnectionString;
            sqlCommand.Connection = sqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            int valor = Convert.ToInt32(sqlDataAdapter.SelectCommand.ExecuteScalar());
            sqlConnection.Close();

            return valor;
        }

        public int ejecuta_sin_auditar(SqlCommand sqlCommand)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["InmobiliariaContext"].ConnectionString;
            sqlCommand.Connection = sqlConnection;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlConnection.Open();
            int valor = Convert.ToInt32(sqlDataAdapter.SelectCommand.ExecuteScalar());
            sqlConnection.Close();

            return valor;
        }
    }
}
