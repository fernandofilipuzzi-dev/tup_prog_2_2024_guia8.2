
using System;
using System.Collections.Generic;

namespace Ejercicio3.Models
{
    public class Cuota
    {
        public int Numero { get; private set;  }
        public double ValorAPagar { get; private set; }
        public DateTime FechaPago { get; private set; }

        public Cuota(int numero,  double valorAPagar, DateTime fechaPago)
        {
            ValorAPagar = valorAPagar;
            FechaPago = fechaPago;
        }

        public override string ToString()
        {
            return $"{Numero:000}    {FechaPago:dd/MM/yyyy}    ${ValorAPagar:f2}";
        }
    }
}
