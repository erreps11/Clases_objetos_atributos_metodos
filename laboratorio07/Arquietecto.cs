using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio07
{
    public class Arquietecto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string CondicioContrato { get; set; }
        public string Especialidad { get; set; }
        private static decimal porc_Estructuras = (decimal)0.16;
        private static decimal porc_RecurHidricos = (decimal)0.18;
        public string TipoActividad { get; set; }
        public decimal SueldoBase { get; set; }
        public decimal Bonificacion { get; set; }
        public string TipoAfiliacion { get; set; }
        private static decimal porc_Afp = (decimal)0.15;
        private static decimal porc_Snp = (decimal)0.8;
        private static int contador = 0;

        public Arquietecto(string codigo, string nombre, string condicionContrato,string especialidad, string tipoActividad, decimal sueldoBase, decimal bonificacion, string tipoAfiliacion)
        {
            contador++;
            Codigo = codigo;
            Nombre = nombre;
            CondicioContrato = condicionContrato;
            Especialidad = especialidad;
            TipoActividad = tipoActividad;
            SueldoBase = sueldoBase;
            Bonificacion = bonificacion;
            TipoAfiliacion = tipoAfiliacion;
        }

        public decimal CalcularBonificacion()
        {
            if (Especialidad == "porc_Estructuras")
                return SueldoBase + SueldoBase * porc_Estructuras;

            if (TipoActividad =="porcRecurHidricos")
                return SueldoBase + SueldoBase * porc_RecurHidricos;
            return 0;
            
        }

        public decimal CalcularMontoSeguro()
        {
            if (TipoAfiliacion == "AFP")
                return SueldoBase * porc_Afp;
            if (TipoAfiliacion == "SNP")
                return SueldoBase * porc_Snp;

            return 0;
        }

        public decimal SueldoBruto()
        {
            return SueldoBase + Bonificacion;
        }

        public decimal SueldoNeto()
        {
            return SueldoBruto() - CalcularMontoSeguro();
        }

        public static int GetContador()
        {
            return contador;
        }
    }
}
