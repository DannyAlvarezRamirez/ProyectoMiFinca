using System;
using System.Collections.Generic;
using System.Text;

//de este objeto o clase van a heredar las clases u objetos Dueno y Empleado
namespace AgroganaderaMiFincaGui
{
    class ObjetoPersona
    {
        //atributos
        private int intIdentificacionPersona;
        private string strNombrePersona, strPrimerApellidoPersona, strSegundoApellidoPersona;

        //constructores
        public ObjetoPersona()
        {
            this.intIdentificacionPersona = 0;
            this.strNombrePersona = "";
            this.strPrimerApellidoPersona = "";
            this.strSegundoApellidoPersona = "";
        }//fin constructor sin parametros
        public ObjetoPersona(int identificacionPersona, string nombrePersona, string primerApellido, string segundoApellido)
        {
            this.intIdentificacionPersona = identificacionPersona;
            this.strNombrePersona = nombrePersona;
            this.strPrimerApellidoPersona = primerApellido;
            this.strSegundoApellidoPersona = segundoApellido;
        }//fin constructor con parametros

        //parametros
        //IdentificacionPersona
        public int IdentificacionPersona
        {
            set
            {
                this.intIdentificacionPersona = value;
            }
            get
            {
                return this.intIdentificacionPersona;
            }
        }//IdentificacionPersona
        //NombrePersona
        public string NombrePersona
        {
            set
            {
                this.strNombrePersona = value;
            }
            get
            {
                return this.strNombrePersona;
            }
        }//NombrePersona
        //PrimerApellidoPersona
        public string PrimerApellidoPersona
        {
            set
            {
                this.strPrimerApellidoPersona = value;
            }
            get
            {
                return this.strPrimerApellidoPersona;
            }
        }//PrimerApellidoPersona
        //SegunoApellidoPersona
        public string SegunoApellidoPersona
        {
            set
            {
                this.strSegundoApellidoPersona = value;
            }
            get
            {
                return this.strSegundoApellidoPersona;
            }
        }//SegunoApellidoPersona
    }
}
