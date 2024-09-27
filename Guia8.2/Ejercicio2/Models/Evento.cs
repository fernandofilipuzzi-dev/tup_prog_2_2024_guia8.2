
using System;
using System.Collections.Generic;

namespace Ejercicio2.Models
{
    public class Evento
    {
        public int Numero { get; private set; }
        public string Lugar { get; private set; }

        public double ValorH { get; set; }
        public double ValorNH { get; set; }
      
        public int CantEnHorasH { get; private set; }
        public int TotalEnHorasNH { get; private set;}
        public int CantEnHorasNH { get; private set; }
        public double TotalPrevisional { get; private set; }
        public double TotalVoluntario { get; private set; }
        public double Total { get; set; }

        List<Contrato> contrataciones =new List<Contrato>();
        public int TotalContratados
        {
            get
            { 
                return contrataciones.Count;
            }
        }

        public Contrato this[int idx]
        {
            get 
            {
                if(idx>=0 && idx<contrataciones.Count)
                    return contrataciones[idx];
                return null;
            }
        }

        public Evento(int numero, string lugar, double valorH, double valorNH)
        { 
            Numero = numero;
            Lugar = lugar;
            ValorH = valorH;
            ValorNH = valorNH;
        }

        public Contrato AgregarContratado(int dni, string nombre, DateTime inicio, DateTime fin)
        {
            Contrato nuevo = new Contrato(dni, nombre, inicio, fin, ValorH, ValorNH);
            contrataciones.Add(nuevo);
            return nuevo;
        }
    }
}
