using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminApp.ABM_Cliente;
using AdminApp.ABM_Pendientes;
using AdminApp.ABM_Inmuebles;

namespace AdminApp
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_buscarEditarCliente_Click(object sender, EventArgs e)
        {
            Editar_Cliente editar_cliente = new Editar_Cliente();
            editar_cliente.Show();
        }

        private void btn_crearCliente_Click(object sender, EventArgs e)
        {
            Crear_Cliente crear_cliente = new Crear_Cliente();
            crear_cliente.Show();
        }

        private void btn_pendientes_Click(object sender, EventArgs e)
        {
            Crear_Pendiente crear_pendiente = new Crear_Pendiente();
            crear_pendiente.Show();
        }

        private void btn_inmuebles_Click(object sender, EventArgs e)
        {
            Crear_Inmueble crear_inmueble = new Crear_Inmueble();
            crear_inmueble.Show();
        }
    }
    
}
