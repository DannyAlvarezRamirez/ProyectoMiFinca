using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Cliente
{
    /*
     * esta clase se encarga de controlar las funciones entre la vista y los formularios
     * de login
     */
    class ControladorFRMLogin
    {
        //atributos y referencias, instancias necesarias
        FRM_PrincipalCliente miFRM_PrincipalCliente;
        TcpClient miTcpClient;

        //constructor
        public ControladorFRMLogin()
        {
            miFRM_PrincipalCliente = new FRM_PrincipalCliente();
        }//fin constructor

        //metodos
        /*
         * este metodo se encarga de verificar que los datos de la interfaz
         * del modulo Login digitados por el usuario estan o no registrados en el sistema
         * de la base de datos
         */
        public string verificarDatosAcceso(string usuario, string contrasena)
        {
            string salida = "";
            string miUsuario = "";
            string miContrasena = "";

            if (usuario != "" && contrasena != "")
            {
                if (miUsuario.Equals(usuario) && miContrasena.Equals(contrasena))
                {
                    salida = "Bienvenido";
                }//fin if
                else
                {
                    salida = "Uno o ambos datos estan incorrectos o no esta registrado en el sistema.";
                }//fin else
            }//fin if
            else
            {
                salida = "Por favor ingrese ambos datos.";
            }//fin else

            return salida;

        }//fin verificarDatosAcceso

        /*
         * este metodo se encarga de solicitar datos al servidor
         */
        public void SolicitarDatosAlServidor(string usuario, string contrasena)
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
                byte[] miBuffer = miCodificador.GetBytes(
                    "Select Identificacion from Empleado where" +
                    "Usuario = " + usuario + " and Contrasena = " + contrasena);
                //solicitud al servidor
                miNetworkStreamClient.Write(miBuffer, 0, miBuffer.Length);
                miNetworkStreamClient.Flush();
                //informacion en la interfaz
            }//fin try
            catch (SocketException ex)
            {
                MessageBox.Show("Cliente: Ha ocurrido un error en la conexion con el servidor." +
                    "\nDetalle del error: " + ex.Message);
            }//fin catch
        }//fin SolicitarDatosAlServidor
    }//fin clase ControladorFRMLogin
}
