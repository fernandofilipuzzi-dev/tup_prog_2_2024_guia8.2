using System;
using System.Collections.Generic;

namespace Ejercicio2.Models
{
    public class Calendario
    {
        List<Feriado> feriados = new List<Feriado>();

        public Feriado Buscar(DateTime fecha)
        {
            Feriado buscado = null;
            int n = 0;
            while (n < feriados.Count && buscado == null)
            {
                if (feriados[n].Dia.Year == fecha.Year &&
                    feriados[n].Dia.Month == fecha.Month &&
                    feriados[n].Dia.Day == fecha.Day)
                {
                    buscado = feriados[n];
                }
                else
                {
                    n++;
                }
            }
            return buscado;
        }

        public DateTime[] Fechas()
        {
            DateTime[] fechas = new DateTime[feriados.Count];
            int n = 0;
            while (n < feriados.Count)
            {
                fechas[n] = feriados[n].Dia;
                n++;
            }
            return fechas;
        }

        public void AgregarFeriado(DateTime dia, string descripcion)
        {
            feriados.Add(new Feriado() { Dia = dia, Descripcion = descripcion });
        }
    }
}
