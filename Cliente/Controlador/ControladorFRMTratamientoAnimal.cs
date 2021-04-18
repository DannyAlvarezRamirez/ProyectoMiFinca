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
     * de control de vacunas animal
     */
    class ControladorTratamientoAnimal
    {

        //atributos y referencias
        public int posicion;
        public ObjetoTratamientoAnimal miObjetoTratamientoAnimal;
        public static List<ObjetoTratamientoAnimal> miListaTratamientoAnimal;
        TcpClient miTcpClient;

        /*
         * constructor
         */
        public ControladorTratamientoAnimal()
        {
            miListaTratamientoAnimal = new List<ObjetoTratamientoAnimal>();
        }//fin constructor

        //metodos
        /*
         * este metodo envia una cadena de string con una consulta 
         * para la base de datos
         */
        public void EnviarConsulta(ObjetoTratamientoAnimal objetoTratamientoAnimal)
        {
            string mensaje = "Insert into Tramientos " +
                "values(" +  objetoTratamientoAnimal.IdentificacionAnimal + ", '" +
                objetoTratamientoAnimal.Fecha + "', '" +
                objetoTratamientoAnimal.DiagnosticoAnimal + "', '" +
                objetoTratamientoAnimal.MedicamentoAnimal + "', " +
                objetoTratamientoAnimal.DiasTratamiento + ", '" +
                objetoTratamientoAnimal.ObservacionesAnimal + "')";

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
         * este metodo se encarga de registrar objeto tratamiento animal
         */
        public string RegistrarTratamientoAnimal(ObjetoTratamientoAnimal miObjetoTratamientoAnimal)
        {
            string salida = "";
            if (BuscarIdentificacionTratamientoAnimal(miObjetoTratamientoAnimal.IdentificacionAnimal))
            {
                salida = "Ya existe un registro con ese mismo numero de identificacion. Por favor" +
                    " vuelva a intentarlo.";
            }//fin if 
            else
            {
                miListaTratamientoAnimal.Add(miObjetoTratamientoAnimal);
                EnviarConsulta(miObjetoTratamientoAnimal);
                salida = "Se agrego el tratamiento animal correctamente";

            }//fin else 
            return salida;
        }//fin RegistrarVacuna

        /*
         * este metodo se encarga de devolver una lista de tratamiento animal
         */
        public List<ObjetoTratamientoAnimal> ObtenerMiLista()
        {
            //enviar solicitud al servidor con consulta para llenar el gridview tratamientos
            string mensaje = "Select Id_animal, Fec_tratamiento, Diagnostico, Medicamento, " +
                "Dias_tratamiento, Observaciones from Tramientos";
            miListaTratamientoAnimal = ObtenerListaDeBaseDatos(mensaje);

            return miListaTratamientoAnimal;
        }//fin ObtenerMiLista

        /*
         * este metodo se encarga de devolver una lista tratamiento animal
         */
        private List<ObjetoTratamientoAnimal> ObtenerListaDeBaseDatos(string consulta)
        {
            List<ObjetoTratamientoAnimal> miLista = null;
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

                miLista = ObtenerListaDeBaseDatos(consulta);
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
         * BuscarIdentificacionTratamientoAnimal = se encarga de verificar si existe o no un objeto tratamiento animal en 
         * el registro
         */
        public bool BuscarIdentificacionTratamientoAnimal(int identificacionAnimal)
        {

            bool encontrado = false;

            for (int i = 0; i < miListaTratamientoAnimal.Count; i++)
            {
                if (miListaTratamientoAnimal.ElementAt(i).IdentificacionAnimal.Equals(identificacionAnimal))
                {
                    encontrado = true;
                    miObjetoTratamientoAnimal = miListaTratamientoAnimal.ElementAt(index: identificacionAnimal);//objetoVacunaAnimal
                    posicion = i;
                }//fin if verdad
            }//fin

            return encontrado;

        }//fin BuscarIdentificacionTratamientoAnimal

        /*
         * GetObjetoTratamientoAnimal = devuelve un objeto tratamiento animal con sus valores respectivos
         */
        public ObjetoTratamientoAnimal GetObjetoTratamientoAnimal(int identificacionAnimal, int diasTratamiento,
            string fecha, string diagnosticoAnimal, string observacionesAnimal, string medicamentoAnimal)
        {
            miObjetoTratamientoAnimal = new ObjetoTratamientoAnimal(identificacionAnimal, diasTratamiento,
                fecha, diagnosticoAnimal, observacionesAnimal, medicamentoAnimal);
            return miObjetoTratamientoAnimal;
        }//fin GetObjetoTratamientoAnimal

        /*
         * este metodo se encarga de buscar un objeto tratamiento animal en especifico y devolverlo
         */
        public ObjetoTratamientoAnimal BuscarTratamientoAnimal(int identificacion)
        {
            ObjetoTratamientoAnimal miObjetoTratamientoAnimal = null;
            for (int i = 0; i < miListaTratamientoAnimal.Count; i++)
            {
                if (miListaTratamientoAnimal.ElementAt(i).Equals(identificacion))
                {
                    miObjetoTratamientoAnimal = miListaTratamientoAnimal.ElementAt(i);
                }//fin if
            }//fin for

            return miObjetoTratamientoAnimal;

        }//fin BuscarTratamientoAnimal

    }//fin clase ControladorVacunaAnimal
}
