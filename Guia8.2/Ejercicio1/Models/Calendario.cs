using System;
using System.Collections.Generic;

namespace Ejercicio1.Models
{
    public class Calendario
    {
        List<Feriado> feriados = new List<Feriado>();

        public int CantidadFeriados 
        {
            get 
            {
                return feriados.Count;
            }
        }

        public Feriado AgregarFeriado(DateTime dia, string descripcion)
        {
            Feriado nuevo = new Feriado(dia, descripcion);
            feriados.Add(nuevo);
            return nuevo;
        }

        public Feriado this[int idx] 
        {
            get
            {
                if (idx >= 0 && idx < CantidadFeriados)
                    return feriados[idx];
                return null;
            }
        }

        public Feriado this[DateTime dia]
        {
            get
            {
                foreach (Feriado feriado in feriados)
                {
                    if (feriado.Fecha.Year==dia.Year && feriado.Fecha.Month == dia.Month && feriado.Fecha.Day == dia.Day)
                    { 
                        return feriado; 
                    }
                }
                return null;
            }
        }
    }
}
