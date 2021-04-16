using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ProyectoMiFinca
{
    /*
     * esta clase se encarga de controlar las funciones entre la vista y los formularios
     * de animal
     */
    class ControladorFRMAnimal
    {
        //atributos y referencias
        static int posicion;
        public ObjetoAnimal miObjetoAnimal;
        public ObjetoFinca miObjetoFinca;
        public ObjetoRaza miObjetoRaza;
        public static List<ObjetoAnimal> miListaAnimal;
        public ConexionServidorBBDD cadenaConexion = new ConexionServidorBBDD();
        ControladorFRMFinca miControladorFRMFinca;
        ControladorFRMRaza miControladorFRMRaza;

        //constructor
        public ControladorFRMAnimal()
        {
            miListaAnimal = new List<ObjetoAnimal>();
            miControladorFRMFinca = new ControladorFRMFinca();
            miControladorFRMRaza = new ControladorFRMRaza();
        }//fin constructor

        //metodos
        /*
         * este metodo se encarga de registrar objeto animal
         */
        public string RegistrarAnimal(ObjetoAnimal miObjetoAnimal)
        {
            string salida = "";
            if (BuscarIdentificacionAnimal(miObjetoAnimal.IdentificacionAnimal))
            {
                salida = "Ya existe un registro con esa misma identificacion. Por favor" +
                    " vuelva a intentarlo.";
            }//fin if
            else
            {
                SqlCommand comando = new SqlCommand();
                string sentencia = " Insert	Into Animales (Id_animal, Nombre, Id_Finca, Id_Raza, " +
                    "Fecha_Nacimiento, Sexo, Id_Madre, Id_Padre)" +
                    " Values (@Id_animal, @Nombre, @Id_Finca, @Id_Raza, @Fecha_Nacimiento, @Sexo" +
                    "@Id_Madre, @Id_Padre)";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = cadenaConexion.conexion;
                comando.Parameters.AddWithValue("@Id_animal", miObjetoAnimal.IdentificacionAnimal);
                comando.Parameters.AddWithValue("@Nombre", miObjetoAnimal.NombreAnimal);
                comando.Parameters.AddWithValue("@Id_Finca", miObjetoAnimal.ObjetoFincaAnimal.NumeroFinca);
                comando.Parameters.AddWithValue("@Id_Raza", miObjetoAnimal.ObjetoRazaAnimal.CodigoRaza);
                comando.Parameters.AddWithValue("@Fecha_Nacimiento", miObjetoAnimal.FechaNacimientoAnimal);
                comando.Parameters.AddWithValue("@Sexo", miObjetoAnimal.SexoAnimal);
                comando.Parameters.AddWithValue("@Id_Madre", miObjetoAnimal.MadreAnimal);
                comando.Parameters.AddWithValue("@Id_Padre", miObjetoAnimal.PadreAnimal);

                //abrir conexion
                cadenaConexion.abrir();
                comando.ExecuteNonQuery();
                //cerrar conexion
                cadenaConexion.cerrar();
                salida = "Se agrego el animal correctamente";
            }//fin else

            return salida;
        }//fin RegistrarAnimal

        /*
         * BuscarIdentificacionAnimal = se encarga de verificar si existe o no un objeto animal en 
         * el registro
         */
        public bool BuscarIdentificacionAnimal(int identificacionAnimal)
        {

            bool encontrado = false;

            for (int i = 0; i < miListaAnimal.Count; i++)
            {
                if (miListaAnimal.ElementAt(i).IdentificacionAnimal.Equals(identificacionAnimal))
                {
                    encontrado = true;
                    miObjetoAnimal = miListaAnimal.ElementAt(index: identificacionAnimal);//objetoAnimal
                    posicion = i;
                }//fin if verdad
            }//fin

            return encontrado;

        }//fin BuscarIdentificacionAnimal

        /*
         * este metodo se encarga de devolver una lista de animales
         */
        public List<ObjetoAnimal> ObtenerMiLista()
        {
            //cargar miListaFinca desde base de datos
            SqlCommand comando = new SqlCommand();
            string sentencia = " Select Id_animal, Nombre, Id_Finca, Id_Raza" +
                "Fecha_Nacimiento, Sexo, Id_Madre, Id_Padre" +
                " From	Animales ";
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
                    miListaAnimal.Add(new ObjetoAnimal
                    {
                        IdentificacionAnimal = Convert.ToInt32(lectorDatos["Id_animal"].ToString()),
                        SexoAnimal = lectorDatos["Sexo"].ToString(),
                        MadreAnimal = Convert.ToInt32(lectorDatos["Id_Madre"].ToString()),
                        PadreAnimal = Convert.ToInt32(lectorDatos["Id_Padre"].ToString()),
                        NombreAnimal = lectorDatos["Nombre"].ToString(),
                        FechaNacimientoAnimal = lectorDatos["Fecha_Nacimiento"].ToString(),
                        ObjetoFincaAnimal = miControladorFRMFinca.BuscarFinca(Convert.ToInt32(lectorDatos["Id_Finca"].ToString())),
                        ObjetoRazaAnimal = miControladorFRMRaza.BuscarRaza(Convert.ToInt32(lectorDatos["Id_Raza"].ToString()))
                    });
                }//fin while
            }//fin if
            //cerrar conexion
            cadenaConexion.cerrar();

            return miListaAnimal;

        }//fin ObtenerMiLista

        /*
         * GetObjetoAnimal = devuelve un objeto Animal con sus valores respectivos
         */
        public ObjetoAnimal GetObjetoAnimal(int identificacionAnimal, string sexoAnimal, int madreAnimal, int padreAnimal, string nombreAnimal,
            string fechaNacimientoAnimal, ObjetoFinca objFincaAnimal, ObjetoRaza objRazaAnimal)
        {
            miObjetoAnimal = new ObjetoAnimal(identificacionAnimal, sexoAnimal, madreAnimal, padreAnimal, nombreAnimal,
                fechaNacimientoAnimal, objFincaAnimal, objRazaAnimal);
            return miObjetoAnimal;
        }//fin GetObjetoAnimal

    }//fin clase ControladorFRMAnimal
}
