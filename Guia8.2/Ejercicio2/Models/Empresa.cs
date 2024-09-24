using System.Collections.Generic;

namespace Ejercicio2.Models
{


    class Empresa
    {
        int numeroEvento;

        public int CantidadEventos { get { return eventos.Count; } }

        List<Evento> eventos = new List<Evento>();

        public Evento RegistrarEvento(string lugar)
        { 
            Evento nuevo=new Evento(++numeroEvento,lugar,valorH,valorNH);
            eventos.Add(nuevo);
        }

        public Evento VerEvento(int idx)
        {
            return eventos[idx];
        }
    }
}

