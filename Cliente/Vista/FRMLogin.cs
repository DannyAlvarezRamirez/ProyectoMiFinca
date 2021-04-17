using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    /*
     * esta clase se encarga de dar acceso o no a un usuario, despliega una interfaz
     * para identificarse dentro del sistema
     */
    public partial class FRMLogin : Form
    {
        //atributos y referencias, instancias necesarias
        ControladorFRMLogin miControladorFRMLogin;
        public static bool clienteLogeado;
        FRMEmpleado miFRMEmpleado;

        //constructor
        public FRMLogin()
        {
            InitializeComponent();
            this.labelIngresarYNoIngresar.ForeColor = Color.Red;
            miControladorFRMLogin = new ControladorFRMLogin();
            clienteLogeado = false;
        }//fin constructor

        /*
         * este metodo devuelve el valor de la variable clienteLogeado
         */
        public bool ClienteLogeado()
        {
            return clienteLogeado;
        }//fin ClienteLogeado

        /*
         * este metodo se encarga de esconder el formulario Registrar principal
         */
        private void buttonIrAlMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }//fin buttonIrAlMenuPrincipal_Click

        /*
         * este metodo se encarga de esconder el formulario actual
         */
        private void FRMLogin_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }//fin FRMLogin_Load

        /*
         * este metodo se encarga de esconder el formulario actual  
         */
        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }//fin cerrarFormulario

        /*
         * este metodo se encarga de verificar los datos escritos por
         * el usuario y darle acceso o no al modulo Cliente
         */
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if(miControladorFRMLogin.verificarDatosAcceso(this.textBoxUsuario.Text, this.textBoxContrasena.Text).Equals("Bienvenido"))
            {
                MessageBox.Show("Bienvenido al sistema.");
                clienteLogeado = true;
            }//fin if
            else
            {
                MessageBox.Show(miControladorFRMLogin.verificarDatosAcceso(this.textBoxUsuario.Text, this.textBoxContrasena.Text));
            }//fin else
            
        }//fin buttonIngresar_Click

        /*
         * este metodo se encarga de desplegar un formulario
         * para que el usuario se registre en el sistema
         */
        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            miFRMEmpleado = new FRMEmpleado();
            miFRMEmpleado.Show();
            this.Hide();
        }//buttonRegistrarse_Click

    }//fin clase FRMLogin
}
