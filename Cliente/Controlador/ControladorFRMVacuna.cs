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
     * de vacuna
     */
    class ControladorFRMVacuna
    {
        //atributos y referencias
        public int posicion;
        public ObjetoVacunas miObjetoVacunas;
        public static List<ObjetoVacunas> miListaVacunas;
        TcpClient miTcpClient;

        //constructor
        public ControladorFRMVacuna()
        {
            miListaVacunas = new List<ObjetoVacunas>();
        }//fin constructor

        //metodos

        /*
         * este metodo envia una cadena de string con una consulta 
         * para la base de datos
         */
        public void EnviarConsulta(ObjetoVacunas miObjetoVacunas)
        {
            string mensaje = "Insert into Vacunas " +
                "values(" + miObjetoVacunas.IdentificacionVacuna + ", '" +
                miObjetoVacunas.DescripcionVacuna + "')";

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
         * este metodo se encarga de registrar objeto vacunas
         */
        public string RegistrarVacuna(ObjetoVacunas miObjetoVacunas)
        {
            string salida = "";
            if (BuscarIdentificacionVacuna(miObjetoVacunas.IdentificacionVacuna))
            {
                salida = "Ya existe un registro con ese mismo numero de identificacion. Por favor" +
                    " vuelva a intentarlo.";
            }//fin if 
            else
            {
                miListaVacunas.Add(miObjetoVacunas);
                EnviarConsulta(miObjetoVacunas);
                salida = "Se agrego la vacuna correctamente";

            }//fin else 
            return salida;
        }//fin RegistrarVacuna

        /*
         * este metodo se encarga de devolver una lista de vacunas
         */
        public List<ObjetoVacunas> ObtenerMiLista()
        {
            //enviar solicitud al servidor con consulta para llenar el gridview vacunas
            string mensaje = "Select Id_vacuna, Descripcion from Vacunas";
            miListaVacunas = ObtenerListaDeBaseDatos(mensaje);

            return miListaVacunas;
        }//fin ObtenerMiLista

        /*
         * este metodo se encarga de devolver una lista vacunas
         */
        private List<ObjetoVacunas> ObtenerListaDeBaseDatos(string consulta)
        {
            List<ObjetoVacunas> miLista = null;
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
        }//fin ObtenerListaDeBaseDatos

        /*
         * BuscarIdentificacionVacuna = se encarga de verificar si existe o no un objeto vacuna en 
         * el registro
         */
        public bool BuscarIdentificacionVacuna(int identificacionVacuna)
        {

            bool encontrado = false;

            for (int i = 0; i < miListaVacunas.Count; i++)
            {
                if (miListaVacunas.ElementAt(i).IdentificacionVacuna.Equals(identificacionVacuna))
                {
                    encontrado = true;
                    miObjetoVacunas = miListaVacunas.ElementAt(index: identificacionVacuna);//objetoVacuna
                    posicion = i;
                }//fin if verdad
            }//fin

            return encontrado;

        }//fin BuscarIdentificacionVacuna
        /*
         * GetObjetoVacuna = devuelve un objeto Vacuna con sus valores respectivos
         */
        public ObjetoVacunas GetObjetoVacuna(int identificacionVacuna, string descripcionVacuna)
        {
            miObjetoVacunas = new ObjetoVacunas(identificacionVacuna, descripcionVacuna);
            return miObjetoVacunas;
        }//fin GetObjetoVacuna

        /*
         * este metodo se encarga de buscar un objeto vacuna en especifico y devolverlo
         */
        public ObjetoVacunas BuscarVacuna(int identificacion)
        {
            ObjetoVacunas miObjetoVacunas = null;
            for (int i = 0; i < ControladorFRMVacuna.miListaVacunas.Count; i++)
            {
                if (ControladorFRMVacuna.miListaVacunas.ElementAt(i).Equals(identificacion))
                {
                    miObjetoVacunas = ControladorFRMVacuna.miListaVacunas.ElementAt(i);
                }//fin if
            }//fin for

            return miObjetoVacunas;

        }//fin BuscarVacuna
    }//fin clase ControladorFRMVacuna
}
