using System;
using System.Collections.Generic;

namespace Ejercicio3.Models
{
    public class Financiera
    {
        List<Credito> creditos = new List<Credito>();
        public double CantidadCreditos
        {
            get
            {
                return creditos.Count;
            }
        }

        List<Cliente> clientes = new List<Cliente>();
        public double CantidadClientes
        {
            get
            {
                return clientes.Count;
            }
        }

        public double TasaAnual { get; set; }

        public Cliente this[int idx]
        {
            get 
            {
                if(idx>=0 && idx<CantidadCreditos)
                    return clientes[idx];
                return null;

            }
        }

        public Credito OtorgarCredito(int dniCliente, string nombreCliente, double valorSolicitado, 
                                         int cantidadCuotas, DateTime fecha)
        {
            Cliente cliente = new Cliente(dniCliente, "");

            clientes.Sort();
            int idx = clientes.BinarySearch(cliente);
            if (idx >= 0)
                cliente = clientes[idx];
            else
                cliente = new Cliente(dniCliente, nombreCliente);
                                    
            Credito credito = new Credito(cliente, cantidadCuotas, TasaAnual, valorSolicitado, fecha);
            creditos.Add(credito);

            return credito;
        }

        public Cliente AgregarCliente(int dni, string apellidoNombres)
        {
            Cliente cliente = new Cliente(dni, apellidoNombres);
            clientes.Add(cliente);
            return cliente;

        }

    }
}
