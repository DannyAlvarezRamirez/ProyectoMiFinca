using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    /*
     * esta clase es la principal de toda la aplicacio: se encarga de desplegar una ventana
     * o interfaz donde el usuario puede tener acceso a la ventana para abrir el proyecto Servidor
     * o el ptoyecto Cliente
     */
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
            Application.Run(new FRM_PrincipalAplicacion());
        }//fin main
    }//fin clase Program
}
