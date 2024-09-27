using System;

namespace Ejercicio2.Models
{
    public class Feriado
    {
        public DateTime Fecha { get; set; }

        public string Descripcion { get; set; }

        public Feriado(DateTime dia, string descripcion)
        {
            Fecha = dia;
            Descripcion = descripcion;
        }   
    }
}
