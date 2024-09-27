using Ejercicio2.Models;
using System;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        Empresa empresa=new Empresa();
        Evento nuevo;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lugar = "Paraná";
            double valorHora = 1000;
            double valorHoraFinDeSemana = 1500;
            nuevo=empresa.RegistrarEvento(lugar, valorHora, valorHoraFinDeSemana);

            int dni = 33234432;
            string nombre = "Mario Grosso";
            DateTime inicioContrato = new DateTime(2024, 9, 11);
            DateTime finContrato = new DateTime(2024, 9, 17);
            nuevo.AgregarContratado(dni, nombre,inicioContrato, finContrato);

        }
    }
}
