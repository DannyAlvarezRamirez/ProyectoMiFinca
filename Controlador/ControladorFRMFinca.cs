using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoMiFinca
{
    /*
     * esta clase se encarga de controlar las funciones entre la vista y los formularios
     * de finca
     */
    class ControladorFRMFinca
    {
        //atributos y referencias
        public ObjetoFinca miObjetoFinca;
        public static List<ObjetoFinca> miListaFinca;
        public ConexionServidorBBDD cadenaConexion = new ConexionServidorBBDD();

        //constructor
        public ControladorFRMFinca()
        {
            miListaFinca = new List<ObjetoFinca>();
        }//fin constructor

        //metodos
        /*
         * este metodo se encarga de registrar objeto finca
         */
        public string RegistrarFinca(ObjetoFinca miObjetoFinca)
        {
            string salida = "";
            if (BuscarNumeroFinca(miObjetoFinca.NumeroFinca))
            {
                salida = "Ya existe un registro con ese mismo numero de finca. Por favor" +
                    " vuelva a intentarlo.";
            }//fin if
            else
            {
                SqlCommand comando = new SqlCommand();
                string sentencia = " Insert	Into	Finca (Id_Finca, Nombre, Tamanno, Direccion, Telefono)" +
                            " Values (@Id_Finca, @Nombre, @Tamanno,	@Direccion,	@Telefono)";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = cadenaConexion.conexion;
                comando.Parameters.AddWithValue("@Id_Finca", miObjetoFinca.NumeroFinca);
                comando.Parameters.AddWithValue("@Nombre", miObjetoFinca.NombreFinca);
                comando.Parameters.AddWithValue("@Tamanno", miObjetoFinca.TamanoFinca);
                comando.Parameters.AddWithValue("@Direccion", miObjetoFinca.DireccionFinca);
                comando.Parameters.AddWithValue("@Telefono", miObjetoFinca.TelefonoFinca);

                //abrir conexion
                cadenaConexion.abrir();
                comando.ExecuteNonQuery();
                //cerrar conexion
                cadenaConexion.cerrar();
                salida = "Se agrego la finca correctamente";
            }//fin else

            return salida;
        }//fin RegistrarFinca

        /*
         * este metodo se encarga de devolver una lista de fincas
         */
        public List<ObjetoFinca> ObtenerMiLista()
        {
            //cargar miListaFinca desde base de datos
            SqlCommand comando = new SqlCommand();
            string sentencia = " Select Id_Finca, Nombre, Tamanno, Direccion, Telefono From	Finca ";
            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = cadenaConexion.conexion;
            //abrir conexion
            cadenaConexion.abrir();
            SqlDataReader lectorDatos = comando.ExecuteReader();
            if (lectorDatos.HasRows == true)
            {
                while (lectorDatos.Read())
                {
                    miListaFinca.Add(new ObjetoFinca
                    {
                        NumeroFinca = Convert.ToInt32(lectorDatos["Id_Finca"].ToString()),
                        NombreFinca = lectorDatos["Nombre"].ToString(),
                        DireccionFinca = lectorDatos["Direccion"].ToString(),
                        TelefonoFinca = Convert.ToInt32(lectorDatos["Telefono"].ToString()),
                        TamanoFinca = Convert.ToInt32(lectorDatos["Tamanno"].ToString())
                    });
                }//fin while
            }//fin if
            //cerrar conexion
            cadenaConexion.cerrar();

            return miListaFinca;

        }//fin ObtenerMiLista

        /*
         * BuscarNumeroFinca = se encarga de verificar si existe o no un objeto finca en 
         * el registro
         */
        public bool BuscarNumeroFinca(int numeroFinca)
        {

            bool encontrado = false;
            //recorro la lista llena
            for (int i = 0; i < miListaFinca.Count; i++)
            {
                if (miListaFinca.ElementAt(i).NumeroFinca.Equals(numeroFinca))
                {
                        encontrado = true;
                }//fin if verdad
            }//fin

            return encontrado;

        }//fin BuscarNumeroFinca
        /*
         * GetObjetoFinca = devuelve un objeto Finca con sus valores respectivos
         */
        public ObjetoFinca GetObjetoFinca(int numeroFinca, string nombreFinca, string direccionFinca, int telefonoFinca, double tamanoFinca)
        {
            miObjetoFinca = new ObjetoFinca(numeroFinca, nombreFinca, direccionFinca, telefonoFinca, tamanoFinca);
            return miObjetoFinca;
        }//fin GetLlenarObjetoFinca

        /*
         * este metodo se encarga de buscar un objeto finca en especifico y devolverlo
         */
        public ObjetoFinca BuscarFinca(int numeroFinca)
        {
            ObjetoFinca miObjetoFinca = null;
            for (int i = 0; i < miListaFinca.Count; i++)
            {
                if (miListaFinca.ElementAt(i).Equals(numeroFinca))
                {
                    miObjetoFinca = miListaFinca.ElementAt(i);
                }//fin if
            }//fin for

            return miObjetoFinca;

        }//fin BuscarFinca

    }//fin clase ControladorFRMFinca
}
