using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
            //sqlCommand.CommandText = "SELECT ID_USUARIO, NOMBRE FROM dbo.CLIENTES";
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            //ds = baseDeDatos.consulta(sqlCommand);

            sqlCommand.CommandText = "SP_TRAER_TIPO_CLIENTES";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt_tipo_clientes = baseDeDatos.consulta(sqlCommand).Tables[0];
            cmb_tipo_cliente.DataSource = dt_tipo_clientes;
            cmb_tipo_cliente.DisplayMember = "DESCRIPCION";
            cmb_tipo_cliente.ValueMember = "ID_TIPO_CLIENTE";

            //dgv_clientes.DataSource = ds.Tables[0];

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            guardarCliente();
            MessageBox.Show("Guardado!", "Exito");
            limpiarGroupBox();
        }

        private void guardarCliente()
        {
            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SP_INSERTAR_CLIENTE";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@nombre", txt_nombre.Text);
            sqlCommand.Parameters.AddWithValue("@apellido", txt_apellido.Text);
            sqlCommand.Parameters.AddWithValue("@telefono", txt_telefono.Text);
            sqlCommand.Parameters.AddWithValue("@celular", txt_celular.Text);
            sqlCommand.Parameters.AddWithValue("@otro_tel", txt_otro_tel.Text);
            sqlCommand.Parameters.AddWithValue("@id_tipo_cliente", cmb_tipo_cliente.SelectedValue);
            baseDeDatos.ejecuta(sqlCommand);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarGroupBox();

        }

        private void limpiarGroupBox()
        {
            this.Controls.OfType<GroupBox>().ToList().ForEach(groupBox => groupBox.Controls.OfType<TextBox>().ToList().ForEach(textBox => textBox.Text = String.Empty));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + txt_email.Text);
        }

    }
}

