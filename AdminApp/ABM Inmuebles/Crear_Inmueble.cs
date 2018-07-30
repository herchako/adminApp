using AdminApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            txt_propietario2.Text = "";
        }
    }
}
