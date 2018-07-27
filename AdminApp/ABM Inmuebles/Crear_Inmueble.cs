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
        public Crear_Inmueble()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar_1_Click(object sender, EventArgs e)
        {
            using (seleccionar_Persona = new Seleccionar_Cliente())
            {
                var result = seleccionar_Persona.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show(seleccionar_Persona.cliente_seleccionado, "Exito");
                }
            }


        }
    }
}
