using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cliente
{
    class ObjetoTratamientoAnimal
    {
        //atributos
        private int intIdentificacionAnimal, intDiasTratamiento;
        private string strFecha, strDiagnosticoAnimal, strObservacionesAnimal, strMedicamento;

        //constructores
        public ObjetoTratamientoAnimal()
        {
            this.intIdentificacionAnimal = 0;
            this.intDiasTratamiento = 0;
            this.strFecha = "";
            this.strDiagnosticoAnimal = "";
            this.strObservacionesAnimal = "";
            this.strMedicamento = "";
        }//fin construcor sin parametros
        public ObjetoTratamientoAnimal(int identificacionAnimal, int diasTratamiento, string fecha,
            string diagnosticoAnimal, string observacionesAnimal, string medicamento)
        {
            this.intIdentificacionAnimal = identificacionAnimal;
            this.intDiasTratamiento = diasTratamiento;
            this.strFecha = fecha;
            this.strDiagnosticoAnimal = diagnosticoAnimal;
            this.strObservacionesAnimal = observacionesAnimal;
            this.strMedicamento = medicamento;
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
        //DiasTratamiento
        public int DiasTratamiento
        {
            set
            {
                this.intDiasTratamiento = value;
            }
            get
            {
                return this.intDiasTratamiento;
            }
        }//fin DiasTratamiento
        //Fecha
        public string Fecha
        {
            set
            {
                this.strFecha = value;
            }
            get
            {
                return this.strFecha;
            }
        }//fin Fecha
        //DiagnosticoAnimal
        public string DiagnosticoAnimal
        {
            set
            {
                this.strDiagnosticoAnimal = value;
            }
            get
            {
                return this.strDiagnosticoAnimal;
            }
        }//fin DiagnosticoAnimal
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

        //MedicamentoAnimal
        public string MedicamentoAnimal
        {
            set
            {
                this.strMedicamento = value;
            }
            get
            {
                return this.strMedicamento;
            }
        }//fin MedicamentoAnimal

        //GetInformacionObjetoTratamientoAnimal
        public string GetInformacionTratamientoAnimal()
        {
            return "Información de tratamiento animal*\nIdentificacion Animal = " + this.IdentificacionAnimal + 
                ", Dias tratamiento = " + this.DiasTratamiento +
                ", Fecha tratamiento = " + this.Fecha + 
                ", Diagnostico Animal = " + this.DiagnosticoAnimal + 
                ", Observaciones Animal = " + this.ObservacionesAnimal +
                ", Medicamento Animal = " + this.MedicamentoAnimal;
        }//fin GetInformacionObjetoTratamientoAnimal
    }
}
