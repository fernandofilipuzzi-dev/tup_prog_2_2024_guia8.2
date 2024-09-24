using System;

namespace Ejercicio2.Models
{
    public class Feriado
    {
        public DateTime Dia { get; set; }

        public string Descripcion { get; set; }

        public bool CompararDia(DateTime day)
        {
            return day != null && Dia != null && day.Year == Dia.Year && day.Month == Dia.Month && day.Day == Dia.Day;
        }
    }
}
