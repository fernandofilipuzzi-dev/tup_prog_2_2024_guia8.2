using System;

namespace Ejercicio3.Models
{
    public class Cliente
    {
        public int DNI { get; private set; }

        public string ApellidosNombres { get; private set; }

        public Cliente(int dni, string nombre)
        {
            DNI = dni;
            ApellidosNombres = nombre;
        }

        public override string ToString()
        {
            return $"{ApellidosNombres}({DNI})";
        }
    }
}
