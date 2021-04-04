using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMiFinca
{
    /*
     * esta clase se encarga de controlar las funciones entre la vista y los formularios
     * de raza
     */
    class ControladorFRMRaza
    {
        //atributos y referencias
        static int posicion;
        static ObjetoRaza miObjetoRaza;
        public static List<ObjetoRaza> miListaRaza = new List<ObjetoRaza>();

        //metodos
        /*
         * este metodo se encarga de registrar objeto raza
         */
        public static string RegistrarRaza(ObjetoRaza miObjetoRaza)
        {
            string salida = "";
            if (BuscarCodigoRaza(miObjetoRaza.CodigoRaza))
            {
                salida = "Ya existe un registro con ese mismo numero de codigo. Por favor" +
                    " vuelva a intentarlo.";
            }//fin if 
            else
            {
                miListaRaza.Add(miObjetoRaza);
                salida = "Se agrego la raza correctamente";

            }//fin else 
            return salida;
        }//fin RegistrarRaza

        /*
         * BuscarCodigoRaza = se encarga de verificar si existe o no un objeto raza en 
         * el registro
         */
        public static bool BuscarCodigoRaza(int codigoRaza)
        {

            bool encontrado = false;

            for (int i = 0; i < miListaRaza.Count; i++)
            {
                if (miListaRaza.ElementAt(i).CodigoRaza.Equals(codigoRaza))
                {
                    encontrado = true;
                    miObjetoRaza = miListaRaza.ElementAt(index: codigoRaza);//objetoRaza
                    posicion = i;
                }//fin if verdad
            }//fin

            return encontrado;

        }//fin BuscarCodigoRaza
        /*
         * GetObjetoRaza = devuelve un objeto Raza con sus valores respectivos
         */
        public static ObjetoRaza GetObjetoRaza(int codigoRaza, string descripcionRaza)
        {
            miObjetoRaza = new ObjetoRaza(codigoRaza, descripcionRaza);
            return miObjetoRaza;
        }//fin GetObjetoRaza

        /*
         * este metodo se encarga de buscar un objeto raza en especifico y devolverlo
         */
        public static ObjetoRaza BuscarRaza(int identificacion)
        {
            ObjetoRaza miObjetoRaza = null;
            for (int i = 0; i < ControladorFRMRaza.miListaRaza.Count; i++)
            {
                if (ControladorFRMRaza.miListaRaza.ElementAt(i).Equals(identificacion))
                {
                    miObjetoRaza = ControladorFRMRaza.miListaRaza.ElementAt(i);
                }//fin if
            }//fin for

            return miObjetoRaza;

        }//fin BuscarRaza

    }//fin clase ControladorFRMRaza
}
