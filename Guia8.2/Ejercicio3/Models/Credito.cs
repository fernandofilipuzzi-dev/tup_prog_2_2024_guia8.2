
using System;
using System.Collections.Generic;

namespace Ejercicio3.Models
{
    public class Credito
    {
        public DateTime OtorgadoEn { get; private set; }
        public double ValorSolicitado{ get;set; }
        public double ValorCreditoConIntereses 
        {
            get
            {
                double monto = 0;
                foreach (Cuota cuota in cuotas)
                {
                    monto += cuota.ValorAPagar;
                }
                return monto;
            }
        }
        public double TasaAnual { get; private set; }
        public int CantidadCuotas 
        {
            get 
            {
                return cuotas.Count;
            }
        }

        List<Cuota> cuotas = new List<Cuota>();
        public Cuota this[int idx]
        {
            get
            {
                if (idx >= 0 && idx < CantidadCuotas)
                    return cuotas[idx];
                return null;
            }
        }

        public Cliente Cliente {get; private set;}

        public Credito(Cliente cliente, int cantidadCuotas, double tasaAnual, double valorSolicitado, DateTime otorgadoEn)
        {
            Cliente = cliente;
            TasaAnual = tasaAnual;
            ValorSolicitado = valorSolicitado;
            OtorgadoEn= otorgadoEn;

            double valorBase = ValorSolicitado / cantidadCuotas;

            for (int n = 0; n < cantidadCuotas; n++)
            {
                double valorCuota = CalcularValorCuota(cantidadCuotas);
                DateTime fechaCuota = CalcularFechaPago(n);
                Cuota nueva=new Cuota(n, valorCuota, fechaCuota);
                cuotas.Add(nueva);
            }
        }

        protected double CalcularValorCuota(int cantidadCuotas)
        {
            double tasaMensual = Math.Pow(TasaAnual/100 + 1, 1.0/12) - 1;
            double valorCuota = tasaMensual * ValorSolicitado / (1 - Math.Pow(1 + tasaMensual, -cantidadCuotas));
            return valorCuota;
        }

        private DateTime CalcularFechaPago(int numeroCuota)
        {
            DateTime fecha = new DateTime(OtorgadoEn.Year, OtorgadoEn.Month, 5);
            fecha=fecha.AddMonths(numeroCuota);
            return fecha;
        }

        public string[] VerDatos()
        {
            string[] lineas = new string[3+CantidadCuotas];

            lineas[0]=$"Fecha: {OtorgadoEn:dd/MM/yyyy}";
            lineas[1] = $"Otorgado a: {Cliente.ToString()}";

            for (int n = 0; n < CantidadCuotas; n++)
            {
                lineas[n+2]+= cuotas[n].ToString();
            }
            lineas[3 + CantidadCuotas - 1] = $"Valotor Total con intereses: ${ValorCreditoConIntereses:f2}";

            return lineas;
        }
    }
}
