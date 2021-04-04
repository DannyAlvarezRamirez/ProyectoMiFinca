using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoMiFinca
{
    /*
     * esta clase se encarga de controlar las funciones entre la vista y los formularios
     * de finca
     */
    static class ControladorFRMFinca
    {
        //atributos y referencias
        static ObjetoFinca miObjetoFinca;
        public static List<ObjetoFinca> miListaFinca = new List<ObjetoFinca>();

        //metodos
        /*
         * este metodo se encarga de registrar objeto finca
         */
        public static string RegistrarFinca(ObjetoFinca miObjetoFinca)
        {
            string salida = "";
            if (BuscarNumeroFinca(miObjetoFinca.NumeroFinca))
            {
                salida = "Ya existe un registro con ese mismo numero de finca. Por favor" +
                    " vuelva a intentarlo.";
            }//fin if 
            else
            {
                miListaFinca.Add(miObjetoFinca);
                salida = "Se agrego la finca correctamente";
                
            }//fin else 
            return salida;
        }//fin RegistrarFinca

        /*
         * BuscarNumeroFinca = se encarga de verificar si existe o no un objeto finca en 
         * el registro
         */
        public static  bool BuscarNumeroFinca(int numeroFinca)
        {

            bool encontrado = false;

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
        public static ObjetoFinca GetObjetoFinca(int numeroFinca, string nombreFinca, string direccionFinca, int telefonoFinca, double tamanoFinca)
        {
            miObjetoFinca = new ObjetoFinca(numeroFinca, nombreFinca, direccionFinca, telefonoFinca, tamanoFinca);
            return miObjetoFinca;
        }//fin GetLlenarObjetoFinca

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

    }//fin clase ControladorFRMFinca
}
