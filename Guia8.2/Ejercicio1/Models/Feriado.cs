using System;

namespace Ejercicio1.Models
{
    public class Feriado
    {
        public DateTime Dia { get; set; }

        public string Descripcion { get; set; }

        public Feriado(DateTime dia, string descripcion)
        {
            Dia = dia;
            Descripcion = descripcion;
        }   
    }
}
