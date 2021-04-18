using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Cliente
{
    /*
     * esta clase se encarga de controlar las funciones entre la vista y los formularios
     * de empleado
     */
    class ControladorFRMEmpleado
    {
        //atributos y referencias
        int posicion;
        public ObjetoEmpleado miObjetoEmpleado;
        public static List<ObjetoEmpleado> miListaEmpleado;
        TcpClient miTcpClient;

        //constructor
        public ControladorFRMEmpleado()
        {
            miListaEmpleado = new List<ObjetoEmpleado>();
        }//fin constructor
        //metodos

        /*
         * este metodo envia una cadena de string con una consulta 
         * para la base de datos
         */
        public void EnviarConsulta(ObjetoEmpleado miObjetoEmpleado)
        {
            string mensaje = "Insert into Empleado " +
                "values(" + miObjetoEmpleado.IdentificacionPersona + ", '" +
                miObjetoEmpleado.NombrePersona + "', '" +
                miObjetoEmpleado.PrimerApellidoPersona + "', '" +
                miObjetoEmpleado.SegunoApellidoPersona + "', " +
                miObjetoEmpleado.SalarioEmpleado + ", '" +
                miObjetoEmpleado.UsuarioEmpleado + "', '" +
                miObjetoEmpleado.UsuarioContrasena + "', " + 
                miObjetoEmpleado.EstadoUsuario + ")";

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
                byte[] miBuffer = miCodificador.GetBytes(mensaje);
                //solicitud al servidor
                miNetworkStreamClient.Write(miBuffer, 0, miBuffer.Length);
                miNetworkStreamClient.Flush();
                miTcpClient.Close();
            }//fin try
            catch (SocketException ex)
            {
                MessageBox.Show("Cliente: Ha ocurrido un error en la conexion con el servidor." +
                    "\nDetalle del error: " + ex.Message);
            }//fin catch

        }//fin EnviarConsulta

        /*
         * este metodo se encarga de registrar objeto empleado
         */
        public string RegistrarEmpleado(ObjetoEmpleado objetoEmpleado)
        {
            string salida = "";
            if (BuscarIdentificacionPersona(miObjetoEmpleado.IdentificacionPersona))
            {
                salida = "Ya existe un registro con ese mismo numero de identificacion. Por favor" +
                    " vuelva a intentarlo.";
            }//fin if 
            else
            {
                miListaEmpleado.Add(miObjetoEmpleado);
                EnviarConsulta(miObjetoEmpleado);
                salida = "Se agrego el empleado correctamente";

            }//fin else 
            return salida;
        }//fin RegistrarEmpleado

        /*
         * este metodo se encarga de devolver una lista de empleados
         */
        public List<ObjetoEmpleado> ObtenerMiLista()
        {
            //enviar solicitud al servidor con consulta para llenar el gridview empleados
            string mensaje = "Select Identificacion, Nombre, Primer_Apellido, Segundo_Apellido, " +
                "Salario, Usuario, Contrasena, Estado from Empleado";
            miListaEmpleado = ObtenerListaDeBaseDatos(mensaje);

            return miListaEmpleado;
        }//fin ObtenerMiLista

        /*
         * este metodo se encarga de devolver una lista empleado
         */
        private List<ObjetoEmpleado> ObtenerListaDeBaseDatos(string consulta)
        {
            List<ObjetoEmpleado> miLista = null;
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
                byte[] miBuffer = miCodificador.GetBytes(consulta);
                //solicitud al servidor
                miNetworkStreamClient.Write(miBuffer, 0, miBuffer.Length);
                miNetworkStreamClient.Flush();

                //miLista = ObtenerListaDeBaseDatos(consulta);
                miTcpClient.Close();
            }//fin try
            catch (SocketException ex)
            {
                MessageBox.Show("Cliente: Ha ocurrido un error en la conexion con el servidor." +
                    "\nDetalle del error: " + ex.Message);
            }//fin catch
            return miLista;
        }//fin 

        /*
         * BuscarIdentificacionPersona = se encarga de verificar si existe o no un objeto empleado en 
         * el registro
         */
        public bool BuscarIdentificacionPersona(int identificacionEmpleado)
        {

            bool encontrado = false;

            for (int i = 0; i < miListaEmpleado.Count; i++)
            {
                if (miListaEmpleado.ElementAt(i).IdentificacionPersona.Equals(identificacionEmpleado))
                {
                    encontrado = true;
                    miObjetoEmpleado = miListaEmpleado.ElementAt(index: identificacionEmpleado);//objetoEmpleado
                    posicion = i;
                }//fin if verdad
            }//fin

            return encontrado;

        }//fin BuscarIdentificacionPersona
        /*
         * GetObjetoEmpleado = devuelve un objeto Empleado con sus valores respectivos
         */
        public ObjetoEmpleado GetObjetoEmpleado(int identificacionPersona, string nombrePersona, string primerApellido, string segundoApellido,
            double salarioEmpleado, string usuario, string contrasena, int estado)
        {
            miObjetoEmpleado = new ObjetoEmpleado(identificacionPersona, nombrePersona, primerApellido, segundoApellido,
                salarioEmpleado, usuario, contrasena, estado);
            return miObjetoEmpleado;
        }//fin GetLlenarObjetoEmpleado

    }//fin clase ControladorFRMEmpleado
}
