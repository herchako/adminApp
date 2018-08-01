using AdminApp.ABM_Cliente;
using AdminApp.ABM_Pendientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AdminApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            DialogResult result;
            using (var loginForm = new LoginForm())
                result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // login was successful
                Application.Run(new MenuPrincipal());
            }
        }
    }
}
