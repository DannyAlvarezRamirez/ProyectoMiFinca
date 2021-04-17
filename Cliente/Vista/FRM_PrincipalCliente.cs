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

namespace Cliente
{
    public partial class FRM_PrincipalCliente : Form
    {
        //atributos, referencias, instancias
        FRMEmpleado miFRMEmpleado;
        FRMListaEmpleados miFRMListaEmpleados;
        FRMVacuna miFRMVacuna;
        FRMListaVacunas miFRMListaVacunas;
        FRMVacunaAnimal miFRMVacunaAnimal;
        FRMListaVacunasAnimales miFRMListaVacunasAnimales;
        bool clienteConectado;
        TcpClient miTcpClient;

        //constructor
        public FRM_PrincipalCliente()
        {
            InitializeComponent();
            this.labelEstadoConectadoDesconectado.ForeColor = Color.Red;
            this.buttonDesconectarDelServidor.Enabled = false;
        }//fin constructor

        //metodos
        /*
         * este metodo se encarga de conectar el proyecto Cliente con
         * el Servidor
         */
        private void buttonConectarAlServidor_Click(object sender, EventArgs e)
        {
            //verificar que el identificador del cliente no este vacio
            if (!string.IsNullOrEmpty(this.textBoxIdentificadorDelCliente.Text))
            {
                try
                {
                    //establecer conexion con el servidor
                    IPAddress miIPAddressServidor = IPAddress.Parse("127.0.0.1");
                    //IPAddress miIPAddressServidor = IPAddress.Any;
                    miTcpClient = new TcpClient();
                    IPEndPoint miIPEndPoint = new IPEndPoint(miIPAddressServidor, 25000);
                    miTcpClient.Connect(miIPEndPoint);

                    //mensaje que se va a enviar al servidor
                    NetworkStream miNetworkStreamClient = miTcpClient.GetStream();
                    ASCIIEncoding miCodificador = new ASCIIEncoding();
                    byte[] miBuffer = miCodificador.GetBytes(textBoxIdentificadorDelCliente.Text);
                    //solicitud al servidor
                    miNetworkStreamClient.Write(miBuffer, 0, miBuffer.Length);
                    miNetworkStreamClient.Flush();
                    //informacion en la interfaz
                    labelEstadoConectadoDesconectado.Text = "Conectado al servidor";
                    labelEstadoConectadoDesconectado.ForeColor = Color.Green;
                    clienteConectado = true;
                    buttonConectarAlServidor.Enabled = false;
                    buttonDesconectarDelServidor.Enabled = true;
                    textBoxIdentificadorDelCliente.ReadOnly = true;
                }//fin try
                catch(SocketException ex)
                {
                    MessageBox.Show("Cliente: Ha ocurrido un error en la conexion con el servidor." +
                        "\nDetalle del error: " + ex.Message);
                }//fin catch

            }//fin if
            else
            {
                MessageBox.Show("No se puede conectar al servidor sin identificacion.");
            }//fin else
        }//fin buttonConectarAlServidor_Click

        /*
         * este metodo se encarga de desconectar el proyecto Cliente del Servidor
         */
        private void buttonDesconectarDelServidor_Click(object sender, EventArgs e)
        {
            //informacion en la interfaz luego de cerrar la conexion con el servidor
            labelEstadoConectadoDesconectado.Text = "Desconectado";
            labelEstadoConectadoDesconectado.ForeColor = Color.Red;
            clienteConectado = false;
            buttonConectarAlServidor.Enabled = true;
            buttonDesconectarDelServidor.Enabled = false;
            textBoxIdentificadorDelCliente.ReadOnly = false;
            miTcpClient.Close();
        }//fin buttonDesconectarDelServidor_Click

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

        /*
         * este metodo se acciona al dar click y despliega un nuevo formulario = Registrar Vacuna Animal
         */
        private void vacunaAnimaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instancia de formulario Registrar Vacuna
            this.miFRMVacunaAnimal = new FRMVacunaAnimal();
            this.miFRMVacunaAnimal.Show();
        }//fin vacunaAnimaleToolStripMenuItem_Click

        /*
         * este metodo se acciona al dar click sobre el menu strip mostrar vacunas de animales
         * y se encarga de desplegar en una tabla la informacion de los registros
         * Vacunas de Animales
         */
        private void vacunasAnimalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.miFRMListaVacunasAnimales = new FRMListaVacunasAnimales();
            this.miFRMListaVacunasAnimales.Show();
        }//fin vacunasAnimalesToolStripMenuItem_Click
    }//fin clase FRM_PrincipalCliente
}
