using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class Nuevo_Usuario : Form
    {
        public string nombre_usuario { get; private set; }
        public string contrasena { get; private set; }
        public Nuevo_Usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "" || txt_usuario.Text == String.Empty)
            {
                MessageBox.Show("El usuario no puede estar vacios.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_error_usuario.Visible = true;
            }
            else {
                if (txt_contrasena.Text == "" || txt_contrasena.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese una contraseña", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbl_error_contrasena.Visible = true;
                }
                else
                {
                    if (txt_contrasena_conf.Text == "" || txt_contrasena_conf.Text == String.Empty)
                    {
                        MessageBox.Show("Confirme contraseña", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lbl_error_confirmacion.Visible = true;
                    }
                    else {
                        if (txt_contrasena.Text != txt_contrasena_conf.Text)
                        {
                            MessageBox.Show("Las contraseñas no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            lbl_error_confirmacion.Visible = true;
                            lbl_error_contrasena.Visible = true;
                        }
                        else {
                            this.nombre_usuario = txt_usuario.Text;
                            this.contrasena = txt_contrasena.Text;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    
                    }
                }
            }
            


        }


        private void txt_contrasena_Enter(object sender, EventArgs e)
        {
           
            lbl_error_contrasena.Visible = false;
        }

        private void txt_contrasena_conf_Enter(object sender, EventArgs e)
        {
            lbl_error_confirmacion.Visible = false;
        }

        private void txt_usuario_Enter(object sender, EventArgs e)
        {
            lbl_error_usuario.Visible = false;
        }
    }
}
