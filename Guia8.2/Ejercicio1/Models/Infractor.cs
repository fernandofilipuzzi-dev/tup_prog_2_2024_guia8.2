using System;

namespace Ejercicio1.Models
{
    public class Infractor
    {
        public int DNI { get; set; }
        public string ApelldosyNombres { get; set; }

        public Infractor(int dNI, string apelldosyNombres)
        {
            DNI = dNI;
            ApelldosyNombres = apelldosyNombres;
        }

        public override string ToString()
        {
            return $"{ApelldosyNombres}({DNI})";
        }
    }
}
