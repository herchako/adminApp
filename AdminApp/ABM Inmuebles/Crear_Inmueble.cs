using AdminApp;
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


namespace AdminApp.ABM_Inmuebles
{
    public partial class Crear_Inmueble : Form
    {

        private Seleccionar_Cliente seleccionar_Persona;

        public Cliente cliente1 { get; set; }
        public Cliente cliente2 { get; set; }

        public Crear_Inmueble()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validar_campos())
            {
                guardarPendiente();
                MessageBox.Show("Guardado!", "Exito");
                //limpiarGroupBox();
            }
        }

        private void guardarPendiente()
        {
            BaseDeDatos baseDeDatos = BaseDeDatos.Instance;
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SP_INSERTAR_INMUEBLE";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Clear();
            sqlCommand.Parameters.AddWithValue("@id_cliente_1", cliente1.id);
            if (txt_propietario2.Text != "")
                sqlCommand.Parameters.AddWithValue("@id_cliente_2", cliente2.id);
            sqlCommand.Parameters.AddWithValue("@tipo", txt_tipo_inmueble.Text);
            sqlCommand.Parameters.AddWithValue("@calle", txt_calle.Text);
            sqlCommand.Parameters.AddWithValue("@altura", txt_nro.Text);
            sqlCommand.Parameters.AddWithValue("@piso", txt_piso.Text);
            sqlCommand.Parameters.AddWithValue("@dpto", txt_dept.Text);
            sqlCommand.Parameters.AddWithValue("@localidad", txt_localidad.Text);
            sqlCommand.Parameters.AddWithValue("@codigo_postal", txt_cp.Text);
            sqlCommand.Parameters.AddWithValue("@observaciones", txt_obs.Text);
            sqlCommand.Parameters.AddWithValue("@administracion_nombre", txt_admin_nombre.Text);
            sqlCommand.Parameters.AddWithValue("@administracion_telefono", txt_admin_telefono.Text);
            sqlCommand.Parameters.AddWithValue("@administracion_obs", txt_admin_obs.Text);
            sqlCommand.Parameters.AddWithValue("@encargado_nombre", txt_enc_nombre.Text);
            sqlCommand.Parameters.AddWithValue("@encargado_telefono", txt_enc_telefono.Text);
            sqlCommand.Parameters.AddWithValue("@encargado_obs", txt_enc_obs.Text);


            baseDeDatos.ejecuta(sqlCommand);
        }

        private bool validar_campos()
        {
            var camposObligatorios = new List<Control>();
            camposObligatorios.Add(txt_propietario1);
            camposObligatorios.Add(txt_tipo_inmueble);
            camposObligatorios.Add(txt_localidad);
            camposObligatorios.Add(txt_calle);
            camposObligatorios.Add(txt_nro);


            pintarCamposIncompletos(camposObligatorios);

            if (camposObligatorios.All<Control>(campos => campos.Text != ""))
                return true;
            else
                return false;
        }

        private void pintarCamposIncompletos(List<Control> camposObligatorios)
        {
            var camposIncompletos = camposObligatorios.FindAll(campos => campos.Text == "");
            camposIncompletos.ForEach(campos => campos.BackColor = Color.Red);
            var camposCompletos = camposObligatorios.FindAll(campos => campos.Text != "");
            camposCompletos.ForEach(campos => campos.BackColor = Color.White);
        }

        private void btn_buscar_1_Click(object sender, EventArgs e)
        {
            cliente1 = buscar_persona();
            txt_propietario1.Text = cliente1.nombre;
        }

        private void btn_buscar_2_Click(object sender, EventArgs e)
        {
            cliente2 = buscar_persona();
            txt_propietario2.Text = cliente2.nombre;
        }

        private Cliente buscar_persona()
        {
            Cliente cliente = new Cliente();
            using (seleccionar_Persona = new Seleccionar_Cliente())
            {
                var result = seleccionar_Persona.ShowDialog();
                if (result == DialogResult.OK)
                {
                    cliente.id = int.Parse(seleccionar_Persona.id_cliente_seleccionado.ToString());
                    cliente.nombre = seleccionar_Persona.cliente_seleccionado.ToString();
                }

            }
            return cliente;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cliente2 = new Cliente();
            txt_propietario2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente1 = new Cliente();
            txt_propietario1.Text = "";
        }
    }
}
