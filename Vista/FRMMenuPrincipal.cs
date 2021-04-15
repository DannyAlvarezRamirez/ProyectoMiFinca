using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

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
        FRMVacuna miFRMVacuna;
        FRMListaVacunas miFRMListaVacunas;
        //////////////////////////////////////
        //variables de comunicacion TCP del servidor
        TcpListener miTcpListener;
        Thread miThreadSubprocesoEscuchaCliente;
        bool miServidorEstaEscuchando;
        //variable delegado
        private delegate void cantidadClientesConectados(string salida);
        cantidadClientesConectados miCantidadClientesConectados;

        //constructor
        public FRMMenuPrincipal()
        {
            InitializeComponent();
            this.labelIniciarApagarServidor.ForeColor = Color.Red;
            this.miCantidadClientesConectados = new cantidadClientesConectados(CantidadClientesConectados);
        }//fin constructor
        
        /*
         * este metodo se encarga de establecer la conexion con el Cliente
         */
        private void ComunicacionConCliente(Object paqueteCliente)
        {
            TcpClient miTcpCliente = (TcpClient)paqueteCliente;//paquete que envia el Cliente
            NetworkStream miNetworkStreamCliente = miTcpCliente.GetStream();
            ASCIIEncoding miASCIIEncodingCodificacion = new ASCIIEncoding();//para codificar los datos que entran por parametro
            byte[] miBuffer = new byte[4096];
            int cantidadDeBytes = 0;

            //ciclo para determinar si hay clientes haciendo consultas
            while (miServidorEstaEscuchando)
            {
                try
                {
                    cantidadDeBytes = miNetworkStreamCliente.Read(miBuffer, 0, miBuffer.Length);
                }//fin try
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error en la conexion con el Servidor." +
                        "/nDetalle del error: " + ex.Message);
                }//fin catch

                if (cantidadDeBytes == 0)
                {
                    MessageBox.Show("No hay paquetes.");
                }//fin if
            }//fin while

            //formateo del paquete
            string mensaje = miASCIIEncodingCodificacion.GetString(miBuffer, 0, cantidadDeBytes);
            string mensajeFormateado = string.Format("El cliente {0} se ha conectado.", mensaje);
            MessageBox.Show(mensajeFormateado);

            //modificacion del textbox mediante el delegado
            this.textBoxCantidadClientesConectados.Invoke(this.miCantidadClientesConectados, new object[] { "Se ha conectado: " + mensaje});
            miTcpCliente.Close();
        }//fin 

        /*
         * este metodo se encarga de escuchar al cliente
         */
        private void EscucharCliente()
        {
            miTcpListener.Start();
            //verificar que servidor esta iniciado
            while (miServidorEstaEscuchando)
            {
                TcpClient tcpClient = miTcpListener.AcceptTcpClient();//genera error
                Thread miThreadCliente = new Thread(new ParameterizedThreadStart(ComunicacionConCliente));
                miThreadCliente.Start(tcpClient);
            }//fin while
        }//fin EscucharCliente

        /*
         * este metodo se encarga de deplegar en el modulo Servidor la cantidad
         * de clientes conectados
         */
        private void CantidadClientesConectados(string salida)
        {
            this.textBoxCantidadClientesConectados.Text = salida;
        }//fin CantidadClientesConectados

        /*
         * este metodo se encarga de iniciar el servidor
         */
        private void buttonIniciarServidor_Click(object sender, EventArgs e)
        {
            //IPAddress miIPAddress = IPAddress.Parse("127.0.0.1");
            IPAddress miIPAddress = IPAddress.Any;
            miTcpListener = new TcpListener(miIPAddress, 25000);
            miThreadSubprocesoEscuchaCliente = new Thread(new ThreadStart(EscucharCliente));
            miThreadSubprocesoEscuchaCliente.Start();
            miThreadSubprocesoEscuchaCliente.IsBackground = true;
            miServidorEstaEscuchando = true;
            labelIniciarApagarServidor.Text = "Escendido: IP = ANY / Puerto = 25000";
            labelIniciarApagarServidor.ForeColor = Color.Green;
            buttonIniciarServidor.Enabled = false;
            buttonApagarServidor.Enabled = true;
        }//fin buttonIniciarServidor_Click

        /*
         * este metodo se encarga de apagar el servidor
         */
        private void buttonApagarServidor_Click(object sender, EventArgs e)
        {
            miServidorEstaEscuchando = false;
            labelIniciarApagarServidor.Text = "Apagado";
            labelIniciarApagarServidor.ForeColor = Color.Red;
            buttonIniciarServidor.Enabled = true;
            buttonApagarServidor.Enabled = false;
            miTcpListener.Stop();
        }//fin buttonApagarServidor_Click

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

        /*
         * este metodo se acciona al dar click y despliega un nuevo formulario = Registrar Vacuna
         */
        private void vacunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instancia de formulario Registrar Vacuna
            this.miFRMVacuna = new FRMVacuna();
            this.miFRMVacuna.Show();
        }//fin vacunaToolStripMenuItem_Click
        /*
         * este metodo se acciona al dar click sobre el menu strip mostrar vacunas
         * y se encarga de desplegar en una tabla la informacion de los registros
         * Vacunas
         */
        private void vacunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.miFRMListaVacunas = new FRMListaVacunas();
            this.miFRMListaVacunas.Show();
        }//fin vacunasToolStripMenuItem_Click

    }//fin clase parcial MenuPrincipal
}
