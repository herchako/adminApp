using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class LoginForm : Form
    {
        private Nuevo_Usuario nuevo_usuario;


        public LoginForm()
        {
            InitializeComponent();
        }



        private void validar_usuario()
        {
            DataTable dt = traer_datos_usuario();
            string contrasena_ingresada;
            if (dt != null)
            {
                contrasena_ingresada = dt.Rows[0][2].ToString() ;
                if (contrasena_ingresada != EncryptText(txt_contrasena.Text))
                {
                    MessageBox.Show("Contraseña incorrecta, vuelva a intentarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }

            }
        }

        private DataTable traer_datos_usuario()
        {
            DataSet ds = new DataSet();
            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.Clear();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "[SP_TRAER_USUARIO_POR_NOMBRE]";
            sqlCommand.Parameters.AddWithValue("@nombre", txt_usuario.Text);
            DataTable dt_cliente = baseDeDatos.consulta_parametrizada(sqlCommand);
            if ((dt_cliente != null) && (dt_cliente.Rows.Count != 0))
            {
                sqlCommand.Parameters.Clear();
                return dt_cliente;
            }
            else
            {
                sqlCommand.Parameters.Clear();
                MessageBox.Show("Usuario Inexistente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public static string EncryptText(string strText)
        {
            return Encrypt(strText, "&%#@?,:*");
        }

        // Decrypt the text 
        public static string DecryptText(string strText)
        {
            return Decrypt(strText, "&%#@?,:*");
        }



        // The function used to encrypt a string
        private static string Encrypt(string strText, string strEncrKey)
        {
            byte[] byKey;
            byte[] IV = { 18, 52, 86, 120, 144, 171, 205, 239 };

            try
            {
                byKey = System.Text.Encoding.UTF8.GetBytes(strEncrKey.Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray = Encoding.UTF8.GetBytes(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Convert.ToBase64String(ms.ToArray());
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // The function used to decrypt the string
        private static string Decrypt(string strText, string sDecrKey)
        {
            byte[] byKey;
            byte[] IV = { 18, 52, 86, 120, 144, 171, 205, 239 };

            byte[] inputByteArray;
            // inputByteArray.Length = strText.Length;

            try
            {
                byKey = System.Text.Encoding.UTF8.GetBytes(sDecrKey.Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                inputByteArray = Convert.FromBase64String(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                System.Text.Encoding encoding = System.Text.Encoding.UTF8;
                return encoding.GetString(ms.ToArray());
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private void lnk_nuevo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (nuevo_usuario = new Nuevo_Usuario())
            {
                var result = nuevo_usuario.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Usuario usuario_nuevo = new Usuario();
                    usuario_nuevo.nombre = nuevo_usuario.nombre_usuario;
                    usuario_nuevo.contrasena = nuevo_usuario.contrasena;
                    insertar_nuevo_usuario(usuario_nuevo);
                }

            }
        }

        private void insertar_nuevo_usuario(Usuario usuario_nuevo)
        {

            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SP_INSERTAR_USUARIO";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nombre", usuario_nuevo.nombre);
            sqlCommand.Parameters.AddWithValue("@contrasena ", EncryptText(usuario_nuevo.contrasena));
            baseDeDatos.ejecuta(sqlCommand);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "" || txt_contrasena.Text == "")
            {
                lbl_ingrese_usuario_contrasena.Visible = true;
                MessageBox.Show("El usuario y contraseña no pueden estar vacios.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                validar_usuario();
                
            }


        }
    }
}

