using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        static ObjetoAnimal miObjetoAnimal;
        static ObjetoFinca miObjetoFinca;
        static ObjetoRaza miObjetoRaza;
        public static List<ObjetoAnimal> miListaAnimal = new List<ObjetoAnimal>();

        //metodos
        /*
         * este metodo se encarga de registrar objeto animal
         */
        public static string RegistrarAnimal(ObjetoAnimal miObjetoAnimal)
        {
            string salida = "";
            if (BuscarIdentificacionAnimal(miObjetoAnimal.IdentificacionAnimal))
            {
                salida = "Ya existe un registro con ese mismo numero de identificacion. Por favor" +
                    " vuelva a intentarlo.";
            }//fin if 
            else
            {
                miListaAnimal.Add(miObjetoAnimal);
                salida = "Se agrego el animal correctamente";

            }//fin else 
            return salida;
        }//fin RegistrarAnimal

        /*
         * BuscarIdentificacionAnimal = se encarga de verificar si existe o no un objeto animal en 
         * el registro
         */
        public static bool BuscarIdentificacionAnimal(int identificacionAnimal)
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
         * GetObjetoAnimal = devuelve un objeto Animal con sus valores respectivos
         */
        public static ObjetoAnimal GetObjetoAnimal(int identificacionAnimal, string sexoAnimal, int madreAnimal, int padreAnimal, string nombreAnimal,
            string fechaNacimientoAnimal, ObjetoFinca objFincaAnimal, ObjetoRaza objRazaAnimal)
        {
            miObjetoAnimal = new ObjetoAnimal(identificacionAnimal, sexoAnimal, madreAnimal, padreAnimal, nombreAnimal,
                fechaNacimientoAnimal, objFincaAnimal, objRazaAnimal);
            return miObjetoAnimal;
        }//fin GetObjetoAnimal

    }//fin clase ControladorFRMAnimal
}
