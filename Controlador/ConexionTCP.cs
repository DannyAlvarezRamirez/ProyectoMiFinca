using System;
using System.Collections.Generic;
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
     * esta clase se encarga de manejar las conexiones entre cliente y
     * servidor: recibir, decodificar, codificar y enviar mensajes o paquetes
     */
    class ConexionTCP
    {
        //atributos, referencias, instancias necesarias
        TcpListener miTcpListener;
        Thread miThreadSubprocesoEscuchaCliente;
        public bool miServidorEstaEscuchando;
        public string identificacionDeCliente;
        public string paquete;

        /*
         * constructor
         */
        public ConexionTCP()
        {
            this.miServidorEstaEscuchando = false;
            this.identificacionDeCliente = "";
            this.paquete = "";
    }//fin constructor

        //metodos

        /*
         * este metodo devuelve el valor del paquete enviado por el Cliente
         * decodificado.
         */
        public string ObtenerPaqueteDecodificado()
        {
            return this.paquete;
        }//fin ObtenerPaqueteDecodificado

        /*
         * este metodo se encarga de establecer la conexion con el Cliente.
         * Recibe el paquete enviado por el Cliente y lo decodifica.
         */
        public void ComunicacionConCliente(Object paqueteCliente)
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
                    MessageBox.Show("Ha ocurrido un error en el Servidor." +
                        "/nDetalle del error: " + ex.Message);
                }//fin catch

                if (cantidadDeBytes == 0)
                {
                    MessageBox.Show("No hay paquetes.");
                }//fin if

                //decodificacion del paquete
                this.paquete = miASCIIEncodingCodificacion.GetString(miBuffer, 0, cantidadDeBytes);
                MessageBox.Show("Contenido del paquete enviado por el Cliente: " + this.paquete);
                miTcpCliente.Close();
            }//fin while

        }//fin ComunicacionConCliente

        /*
         * este metodo se encarga de escuchar al cliente
         */
        public void EscucharCliente()
        {
            miTcpListener.Start();
            //verificar que servidor esta iniciado
            while (miServidorEstaEscuchando)
            {
                TcpClient tcpClient = miTcpListener.AcceptTcpClient();
                Thread miThreadCliente = new Thread(new ParameterizedThreadStart(ComunicacionConCliente));
                miThreadCliente.Start(tcpClient);
            }//fin while
        }//fin EscucharCliente

        /*
         * este metodo se encarga de iniciar el servidor
         */
        public void IniciarServidor()
        {
            IPAddress miIPAddress = IPAddress.Parse("127.0.0.1");
            //IPAddress miIPAddress = IPAddress.Any;
            miTcpListener = new TcpListener(miIPAddress, 25000);
            miThreadSubprocesoEscuchaCliente = new Thread(new ThreadStart(EscucharCliente));
            miThreadSubprocesoEscuchaCliente.Start();
            miThreadSubprocesoEscuchaCliente.IsBackground = true;
        }//fin IniciarServidor

        /*
         * este metodo se encarga de apagar el servidor
         */
        public void ApagarServidor()
        {
            miServidorEstaEscuchando = false;
            miTcpListener.Stop();
            miThreadSubprocesoEscuchaCliente.Abort();
        }//fin ApagarServidor

        /*
         * este metodo devuelve el valor de la variable miServidorEscuchando
         */
        public bool MiServidorEscuchando()
        {
            return this.miServidorEstaEscuchando;
        }//fin MiServidorEscuchando

        /*
         * este metodo se encarga de devolver la cantidad
         * de clientes conectados
         */
        public string CantidadClientesConectados()
        {
            string salidaParaInterfaz = "Se ha conectado el Cliente: " + ObtenerPaqueteDecodificado();
            return salidaParaInterfaz;
        }//fin CantidadClientesConectados

    }//fin clase ConexionTCP
}
