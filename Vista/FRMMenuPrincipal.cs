using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMiFinca
{
    /*
     * Este esta clase despliega la interfaz de usuario que contiene 
     * el menu principal de la aplicacion que donde existen
     * varias opciones con las que el usuario interactua, ademas la opcion de salir del sistema.
     */
    public partial class FRMMenuPrincipal : Form
    {
        //atributos y referencias
        FRMFinca miFRMFinca;
        FRMListaFincas miFRMListaFincas;
        FRMDueno miFRMDueno;
        FRMListaDuenos miFRMListaDuenos;
        FRMEmpleado miFRMEmpleado;
        FRMListaEmpleados miFRMListaEmpleados;
        FRMRaza miFRMRaza;
        FRMListaRazas miFRMListaRazas;
        FRMAnimal miFRMAnimal;
        FRMListaAnimales miFRMListaAnimales;
        public FRMMenuPrincipal()
        {
            InitializeComponent();
        }//fin constructor

        /*
         * este metodo se encarga cerrar o no la aplicacion
         */
        private void FRMMenuPrincipal_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(cerrarFormulario);

        }//fin FRMMenuPrincipal_Load

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
                this.Hide();
            }//fin if cerrar
            else
            {
                e.Cancel = true;
            }//fin else cerrar
        }//fin cerrarFormulario

        /*
         * este metodo se acciona al dar click y despliega un nuevo formulario = Registrar Finca
         */
        private void fincaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instancia de formulario Registrar Finca
            this.miFRMFinca = new FRMFinca();
            this.miFRMFinca.Show();
        }//fincaToolStripMenuItem_Click
        /*
         * este metodo se acciona al dar click sobre el menu strip mostrar fincas
         * y se encarga de desplegar en una tabla la informacion de los registros
         * Fincas
         */
        private void fincasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.miFRMListaFincas = new FRMListaFincas();
            this.miFRMListaFincas.Show();
        }//fin fincasToolStripMenuItem_Click

        /*
         * este metodo se acciona al dar click y despliega un nuevo formulario = Registrar Dueno
         */
        private void duenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instancia de formulario Registrar Dueno
            this.miFRMDueno = new FRMDueno();
            this.miFRMDueno.Show();
        }//fin duenoToolStripMenuItem_Click

        /*
         * este metodo se acciona al dar click sobre el menu strip mostrar duenos
         * y se encarga de desplegar en una tabla la informacion de los registros
         * Duenos
         */
        private void duenosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.miFRMListaDuenos = new FRMListaDuenos();
            this.miFRMListaDuenos.Show();
        }//duenosToolStripMenuItem_Click

        /*
         * este metodo se acciona al dar click y despliega un nuevo formulario = Registrar Empleado
         */
        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instancia de formulario Registrar Empleado
            this.miFRMEmpleado = new FRMEmpleado();
            this.miFRMEmpleado.Show();
        }//empleadoToolStripMenuItem_Click

        /*
         * este metodo se acciona al dar click sobre el menu strip mostrar empleados
         * y se encarga de desplegar en una tabla la informacion de los registros
         * Empleados
         */
        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.miFRMListaEmpleados = new FRMListaEmpleados();
            this.miFRMListaEmpleados.Show();
        }//fin empleadosToolStripMenuItem1_Click

        /*
         * este metodo se acciona al dar click y despliega un nuevo formulario = Registrar Raza de Animal
         */
        private void razaDeAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instancia de formulario Registrar Raza
            this.miFRMRaza = new FRMRaza();
            this.miFRMRaza.Show();
        }//fin razaDeAnimalToolStripMenuItem_Click

        /*
         * este metodo se acciona al dar click sobre el menu strip mostrar razas
         * y se encarga de desplegar en una tabla la informacion de los registros
         * Razas
         */
        private void razasDeAnimalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.miFRMListaRazas = new FRMListaRazas();
            this.miFRMListaRazas.Show();
        }//fin razasDeAnimalesToolStripMenuItem1_Click

        /*
         * este metodo se acciona al dar click y despliega un nuevo formulario = Registrar Animal
         */
        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instancia de formulario Registrar Animal
            this.miFRMAnimal = new FRMAnimal();
            this.miFRMAnimal.Show();
        }//animalToolStripMenuItem_Click

        /*
         * este metodo se acciona al dar click sobre el menu strip mostrar animales
         * y se encarga de desplegar en una tabla la informacion de los registros
         * Animales
         */
        private void animalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.miFRMListaAnimales = new FRMListaAnimales();
            this.miFRMListaAnimales.Show();
        }//fin animalesToolStripMenuItem_Click
    }//fin clase parcial MenuPrincipal
}
