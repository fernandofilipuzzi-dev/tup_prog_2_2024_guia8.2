using System;
using System.Collections;

namespace Ejercicio1.Models
{
    public class Cuota
    {
        public int Numero { get; set; }

        /// <summary>
        /// monto base fijado para cada cuota - es el  valor del total sobre  la cantidad de cuotas
        /// </summary>
        public double MontoBase { get; set; }

        /// <summary>
        /// Porcentaje que se aplica al valor base 
        /// </summary>
        public double PorcenVoluntario { get; set; }
        public double MontoVoluntario
        {
            get
            {
                return MontoBase * PorcenVoluntario / 100;
            }
        }

        /// <summary>
        /// Fecha del primer vencimiento, los primeros ocho días hábiles del siguiente mes.
        /// </summary>
        public DateTime FechaPrimerVenc { get; set; }
        public double MontoPrimerVenc
        {
            get
            {
                return MontoBase + MontoVoluntario;
            }
        }

        public double PorcenSegundoVenc { get; set; }

        /// <summary>
        /// Fecha del segundo vencimiento, los primeros 15 días hábiles a partir del primer vencimiento
        /// </summary>
        public DateTime FechaSegundoVenc { get; set; }

        public double MontoSegundoVenc
        {
            get
            {
                return MontoBase + MontoVoluntario;
            }
        }

        public double SobreCargoMontoSegundoVenc
        {
            get
            {
                return MontoSegundoVenc * PorcenSegundoVenc / 100;
            }
        }

        public double MontoSegundoVencConSobr
        {
            get
            {
                return MontoSegundoVenc + SobreCargoMontoSegundoVenc;
            }
        }

        public Cuota(int numero, double montoBase,  DateTime fechaPrimerVenc, double porcenVoluntario, DateTime fechaSegundoVenc,double porcenSegundoVenc )
        {
            Numero = numero;
            MontoBase = montoBase;
            PorcenVoluntario = porcenVoluntario;
            FechaPrimerVenc = fechaPrimerVenc;
            PorcenSegundoVenc = porcenSegundoVenc;
            FechaSegundoVenc = fechaSegundoVenc;
        }

        public override string ToString()
        {
            string linea = $@"{$"Cuota número: {Numero}"}
{$"Valor Cuota: ",-33}${MontoBase,15:f2}
{$"Donación voluntaria ({PorcenVoluntario}%) ",-33}${MontoVoluntario,15:f2}
{$"Primer Venc. ({FechaPrimerVenc:dd/MM/yy})",-33}${MontoPrimerVenc,15:f2}

{$"Base. segundo Venc. ",-33}${MontoSegundoVenc,15:f2}
{$"Rec. segundo Venc. ({PorcenSegundoVenc:f2}%) ",-33}${SobreCargoMontoSegundoVenc,15:f2}
{$"Segundo Venc. ({FechaSegundoVenc:dd/MM/yy})",-33}${MontoSegundoVenc,15:f2}";
            
            return linea;
        }
    }
}

