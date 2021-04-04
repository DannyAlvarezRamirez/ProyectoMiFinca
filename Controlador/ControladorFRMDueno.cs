using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMiFinca
{
    /*
     * esta clase se encarga de controlar las funciones entre la vista y los formularios
     * de dueno
     */
    static class ControladorFRMDueno
    {
        //atributos y referencias
        static ObjetoDueno miObjetoDueno;
        public static List<ObjetoDueno> miListaDueno = new List<ObjetoDueno>();

        //metodos
        /*
         * este metodo se encarga de registrar objeto dueno
         */
        public static string RegistrarDueno(ObjetoDueno miObjetoDueno)
        {
            string salida = "";
            if (BuscarIdentificacionPersona(miObjetoDueno.IdentificacionPersona))
            {
                salida = "Ya existe un registro con ese mismo numero de identificacion. Por favor" +
                    " vuelva a intentarlo.";
            }//fin if 
            else
            {
                miListaDueno.Add(miObjetoDueno);
                salida = "Se agrego el dueno correctamente";

            }//fin else 
            return salida;
        }//fin RegistrarDueno

        /*
         * BuscarIdentificacionPersona = se encarga de verificar si existe o no un objeto dueno en 
         * el registro
         */
        public static bool BuscarIdentificacionPersona(int identificacionDueno)
        {

            bool encontrado = false;

            for (int i = 0; i < miListaDueno.Count; i++)
            {
                if (miListaDueno.ElementAt(i).IdentificacionPersona.Equals(identificacionDueno))
                {
                    encontrado = true;
                }//fin if verdad
            }//fin

            return encontrado;

        }//fin BuscarIdentificacionPersona
        /*
         * GetObjetoDueno = devuelve un objeto Dueno con sus valores respectivos
         */
        public static ObjetoDueno GetObjetoDueno(int identificacionPersona, string nombrePersona, string primerApellido, string segundoApellido,
            string correoElectronico, int numeroCelular, ObjetoFinca objetoFinca)
        {
            miObjetoDueno = new ObjetoDueno(identificacionPersona, nombrePersona, primerApellido, segundoApellido,
                correoElectronico, numeroCelular, objetoFinca);
            return miObjetoDueno;
        }//fin GetLlenarObjetoDueno

        /*
         * este metodo se encarga de buscar un objeto finca en especifico y devolverlo
         */
        public static ObjetoFinca BuscarFinca(int numeroFinca)
        {
            ObjetoFinca miObjetoFinca = null;
            for (int i = 0; i < ControladorFRMFinca.miListaFinca.Count; i++)
            {
                if (ControladorFRMFinca.miListaFinca.ElementAt(i).Equals(numeroFinca))
                {
                    miObjetoFinca = ControladorFRMFinca.miListaFinca.ElementAt(i);
                }//fin if
            }//fin for

            return miObjetoFinca;

        }//fin BuscarFinca

    }//fin clase ControladorFRMDueno
}
