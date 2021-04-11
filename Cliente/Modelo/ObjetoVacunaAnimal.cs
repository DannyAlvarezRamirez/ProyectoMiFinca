using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ProyectoMiFinca
{
    class ObjetoVacunaAnimal
    {
        //atributos
        private int intIdentificacionAnimal, intIdentificacionVacuna;
        private string strFechaNacimientoAnimal, strEnfermedadAnimal, strObservacionesAnimal;

        //constructores
        public ObjetoVacunaAnimal()
        {
            this.intIdentificacionAnimal = 0;
            this.intIdentificacionVacuna = 0;
            this.strFechaNacimientoAnimal = "";
            this.strEnfermedadAnimal = "";
            this.strObservacionesAnimal = "";
        }//fin construcor sin parametros
        public ObjetoVacunaAnimal(int identificacionAnimal, int identificacionVacuna, string fechaNacimientoAnimal,
            string enfermedadAnimal, string observacionesAnimal)
        {
            this.intIdentificacionAnimal = identificacionAnimal;
            this.intIdentificacionVacuna = identificacionVacuna;
            this.strFechaNacimientoAnimal = fechaNacimientoAnimal;
            this.strEnfermedadAnimal = enfermedadAnimal;
            this.strObservacionesAnimal = observacionesAnimal;
        }//fin construcor con parametros

        //parametros
        //IdentificacionAnimal
        public int IdentificacionAnimal
        {
            set
            {
                this.intIdentificacionAnimal = value;
            }
            get
            {
                return this.intIdentificacionAnimal;
            }
        }//fin IdentificacionAnimal
        //IdentificacionVacuna
        public int IdentificacionVacuna
        {
            set
            {
                this.intIdentificacionVacuna = value;
            }
            get
            {
                return this.intIdentificacionVacuna;
            }
        }//fin IdentificacionVacuna
        //FechaNacimientoAnimal
        public string FechaNacimientoAnimal
        {
            set
            {
                this.strFechaNacimientoAnimal = value;
            }
            get
            {
                return this.strFechaNacimientoAnimal;
            }
        }//fin FechaNacimientoAnimal
        //EnfermedadAnimal
        public string EnfermedadAnimal
        {
            set
            {
                this.strEnfermedadAnimal = value;
            }
            get
            {
                return this.strEnfermedadAnimal;
            }
        }//fin EnfermedadAnimal
        //ObservacionesAnimal
        public string ObservacionesAnimal
        {
            set
            {
                this.strObservacionesAnimal = value;
            }
            get
            {
                return this.strObservacionesAnimal;
            }
        }//fin ObservacionesAnimal
        
        //GetInformacionObjetoVacunaAnimal
        public string GetInformacionObjetoAnimal()
        {
            return "Información de vacuna animal*\nIdentificacion Animal = " + this.IdentificacionAnimal + 
                ", Identificacion Vacuna = " + this.IdentificacionVacuna +
                ", Fecha Nacimiento Animal = " + this.FechaNacimientoAnimal + 
                ", Enfermedad Animal = " + this.EnfermedadAnimal + 
                ", Observaciones Animal = " + this.ObservacionesAnimal;
        }//fin GetInformacionObjetoVacunaAnimal
    }
}
