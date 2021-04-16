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
     * de control de vacunas
     */
    class ControladorVacunaAnimal
    {

        //atributos y referencias
        public int posicion;
        public ObjetoVacunaAnimal miObjetoVacunaAnimal;
        public static List<ObjetoVacunaAnimal> miListaVacunasAnimal;
        public ConexionServidorBBDD cadenaConexion = new ConexionServidorBBDD();

        //constructor
        public ControladorVacunaAnimal()
        {
            miListaVacunasAnimal = new List<ObjetoVacunaAnimal>();
        }//fin constructor

        //metodos
        /*
         * este metodo se encarga de registrar objeto vacuna animal
         */
        public string RegistrarVacunaAnimal(ObjetoVacunaAnimal miObjetoVacunasAnimal)
        {
            string salida = "";
            if (BuscarIdentificacionVacunaAnimal(miObjetoVacunasAnimal.IdentificacionAnimal))
            {
                salida = "Ya existe un registro con ese mismo numero de identificacion. Por favor" +
                    " vuelva a intentarlo.";
            }//fin if
            else
            {
                SqlCommand comando = new SqlCommand();
                string sentencia = " Insert	Into Vacuna_Animal(Id_animal, Id_vacuna, Fec_vacuna" +
                    "Enfermedad, Observaciones)" +
                    " Values (@Id_animal, @Id_vacuna, @Fec_vacuna, @Enfermedad, @Observaciones)";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = cadenaConexion.conexion;
                comando.Parameters.AddWithValue("@Id_animal", miObjetoVacunaAnimal.IdentificacionAnimal);
                comando.Parameters.AddWithValue("@Id_vacuna", miObjetoVacunaAnimal.IdentificacionVacuna);
                comando.Parameters.AddWithValue("@Fec_vacuna", miObjetoVacunaAnimal.FechaNacimientoAnimal);
                comando.Parameters.AddWithValue("@Enfermedad", miObjetoVacunaAnimal.EnfermedadAnimal);
                comando.Parameters.AddWithValue("@Observaciones", miObjetoVacunaAnimal.ObservacionesAnimal);

                //abrir conexion
                cadenaConexion.abrir();
                comando.ExecuteNonQuery();
                //cerrar conexion
                cadenaConexion.cerrar();
                salida = "Se agrego la vacuna correctamente";
            }//fin else

            return salida;
        }//fin RegistrarVacuna

        /*
         * este metodo se encarga de devolver una lista de vacunas animal
         */
        public List<ObjetoVacunaAnimal> ObtenerMiLista()
        {
            //cargar miListaFinca desde base de datos
            SqlCommand comando = new SqlCommand();
            string sentencia = " Select Id_animal, Id_vacuna, Fec_vacuna" +
                    "Enfermedad, Observaciones From Vacuna_Animal";
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
                    miListaVacunasAnimal.Add(new ObjetoVacunaAnimal
                    {
                        IdentificacionAnimal = Convert.ToInt32(lectorDatos["Id_animal"].ToString()),
                        IdentificacionVacuna = Convert.ToInt32(lectorDatos["Id_vacuna"].ToString()),
                        FechaNacimientoAnimal = lectorDatos["Fec_vacuna"].ToString(),
                        EnfermedadAnimal = lectorDatos["Enfermedad"].ToString(),
                        ObservacionesAnimal = lectorDatos["Observaciones"].ToString()
                    });
                }//fin while
            }//fin if
            //cerrar conexion
            cadenaConexion.cerrar();

            return miListaVacunasAnimal;

        }//fin ObtenerMiLista

        /*
         * BuscarIdentificacionVacunaAnimal = se encarga de verificar si existe o no un objeto vacuna animal en 
         * el registro
         */
        public bool BuscarIdentificacionVacunaAnimal(int identificacionAnimal)
        {

            bool encontrado = false;

            for (int i = 0; i < miListaVacunasAnimal.Count; i++)
            {
                if (miListaVacunasAnimal.ElementAt(i).IdentificacionAnimal.Equals(identificacionAnimal))
                {
                    encontrado = true;
                    miObjetoVacunaAnimal = miListaVacunasAnimal.ElementAt(index: identificacionAnimal);//objetoVacunaAnimal
                    posicion = i;
                }//fin if verdad
            }//fin

            return encontrado;

        }//fin BuscarIdentificacionVacunaAnimal

        /*
         * GetObjetoVacunaAnimal = devuelve un objeto vacuna animal con sus valores respectivos
         */
        public ObjetoVacunaAnimal GetObjetoVacunaAnimal(int identificacionAnimal, int identificacionVacuna,
            string fechaNacimientoAnimal, string enfermedadAnimal, string observacionesAnimal)
        {
            miObjetoVacunaAnimal = new ObjetoVacunaAnimal(identificacionAnimal, identificacionVacuna,
                fechaNacimientoAnimal, enfermedadAnimal, observacionesAnimal);
            return miObjetoVacunaAnimal;
        }//fin GetObjetoVacunaAnimal

        /*
         * este metodo se encarga de buscar un objeto vacuna animal en especifico y devolverlo
         */
        public ObjetoVacunaAnimal BuscarVacunaAnimal(int identificacion)
        {
            ObjetoVacunaAnimal miObjetoVacunaAnimal = null;
            for (int i = 0; i < miListaVacunasAnimal.Count; i++)
            {
                if (miListaVacunasAnimal.ElementAt(i).Equals(identificacion))
                {
                    miObjetoVacunaAnimal = miListaVacunasAnimal.ElementAt(i);
                }//fin if
            }//fin for

            return miObjetoVacunaAnimal;

        }//fin BuscarVacunaAnimal

    }//fin clase ControladorVacunaAnimal
}
