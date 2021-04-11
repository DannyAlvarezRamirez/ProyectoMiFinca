using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Principal
{
    /*
     * este form contiene dos botones con su accion respectiva. Uno servidor: despliega 
     * el proyecto Servidor; y dos, cliente: despliega el proyecto Cliente.
     */
    public partial class FRM_PrincipalAplicacion : Form
    {
        public FRM_PrincipalAplicacion()
        {
            InitializeComponent();
        }//fin constructor

        /*
         * este metodo se encarga cerrar o no la aplicacion
         */
        private void FRM_PrincipalAplicacion_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(cerrarFormulario);
        }//fin FRM_PrincipalAplicacion_Load

        /*
         * este metodo se encarga de cerrar o no el formulario actual 
         */
        private void cerrarFormulario(object sender, FormClosingEventArgs e)
        {
            //preguntar a usuario si desea cerrar la aplicacion
            DialogResult respuesta = MessageBox.Show("Desea Salir de la Aplicacion", "Agroganadera Mi Finca",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (respuesta == DialogResult.OK)
            {
                System.Environment.Exit(0);
            }//fin if cerrar
            else
            {
                e.Cancel = true;
            }//fin else cerrar
        }//fin cerrarFormulario

        /*
         * este metodo se encarga de desplegar el proyecto Servidor con su modulo 
         * principal
         */
        private void buttonServidor_Click(object sender, EventArgs e)
        {
            ProyectoMiFinca.FRMMenuPrincipal fRMMenuPrincipal = new ProyectoMiFinca.FRMMenuPrincipal();
            fRMMenuPrincipal.Show();
        }//fin buttonServidor_Click

        /*
         * este metodo se encarga de desplegar el proyecto Cliente con su modulo 
         * principal
         */
        private void buttonCliente_Click(object sender, EventArgs e)
        {
            Cliente.FRM_PrincipalCliente fRM_PrincipalCliente = new Cliente.FRM_PrincipalCliente();
            fRM_PrincipalCliente.Show();
        }//fin buttonCliente_Click

    }//fin clase FRM_PrincipalAplicacion
}
