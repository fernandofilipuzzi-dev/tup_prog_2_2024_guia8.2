
using System;

namespace Ejercicio2.Models
{
    public class Contrato
    {
        public int DNI { get; private set; }
        public string ApellidoNombres { get; private set; }
        public DateTime Inicio { get;private set; }
        public DateTime Fin { get;private set; }
        public double ValorPorHoraH { get;private set; }
        public double ValorPorHoraNH { get; private set; }
        public int CantHoraH { get; private set; }
        public int CantHoraNH { get; private set; }

        public double ValorTotalHoraH { get; private set; }
        public double ValorTotalHoraNH { get; private set; }

        public double ValorNominal { get; private set; }
        public double ValorAporteProvisionalNominal { get; private set; }
        public double ValorAporteVoluntario { get; private set; }
        public double ValorTotalACobrar { get; private set; }

        public Contrato(int dni, string apellidoNombres, DateTime inicio, DateTime fin, double valorH, double valorNH)
        {
            DNI = dni;
            ApellidoNombres = apellidoNombres;
            Inicio = inicio;
            Fin = fin;
            ValorPorHoraH= valorH;
            ValorPorHoraNH = valorNH;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
