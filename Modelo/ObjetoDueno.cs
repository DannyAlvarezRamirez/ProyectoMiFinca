using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoMiFinca
{
    class ObjetoDueno: ObjetoPersona
    {
        //atributos
        private string strCorreoElectronicoDueno;
        private int intNumeroCelularDueno;
        private ObjetoFinca objFincaDueno;

        //constructores
        public ObjetoDueno()
        {

        }//fin contructor vacio
        public ObjetoDueno(int identificacionPersona, string nombrePersona, string primerApellido, string segundoApellido,
            string correoElectronicoDueno, int numeroCelularDueno, ObjetoFinca objFincaDueno)
            :base(identificacionPersona, nombrePersona, primerApellido, segundoApellido)
        {
            this.strCorreoElectronicoDueno = correoElectronicoDueno;
            this.intNumeroCelularDueno = numeroCelularDueno;
            this.objFincaDueno = objFincaDueno;
        }//fin constructor con parametros

        //parametros
        //CorreoElectronicoDueno
        public string CorreoElectronicoDueno
        {
            set
            {
                this.strCorreoElectronicoDueno = value;
            }
            get
            {
                return this.strCorreoElectronicoDueno;
            }
        }//fin CorreoElectronicoDueno
        //NumeroCelularDueno
        public int NumeroCelularDueno
        {
            set
            {
                this.intNumeroCelularDueno = value;
            }
            get
            {
                return this.intNumeroCelularDueno;
            }
        }//fin NumeroCelularDueno
        //FincaDueno
        public ObjetoFinca FincaDueno
        {
            set
            {
                this.objFincaDueno = value;
            }
            get
            {
                return this.objFincaDueno;
            }
        }//fin FincaDueno
        //GetInformacionObjetoDueno
        public string GetInformacionObjetoDueno()
        {
            return "Información del dueno*\nIdentificacion = " + this.IdentificacionPersona + ", Nombre = " + this.NombrePersona + ", " +
                "Primer Apellido = " + this.PrimerApellidoPersona + ", Segundo Apellido = " + this.SegunoApellidoPersona + ", Correo electronico = " + this.CorreoElectronicoDueno +
                ", Numero Celular = " + this.NumeroCelularDueno + ", Codigo de la Finca = " + this.objFincaDueno.NumeroFinca;
        }//fin GetInformacionObjetoDueno
    }
}
