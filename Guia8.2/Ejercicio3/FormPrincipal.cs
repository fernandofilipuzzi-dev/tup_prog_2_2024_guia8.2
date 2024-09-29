using Ejercicio3.Models;
using System;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class FormPrincipal : Form
    {
        Financiera crediTUP =new Financiera();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            double tasaAnual = 1.1;//%
            crediTUP.TasaAnual = tasaAnual;
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            int dni = 32432432;
            string nombre = "Gutierrez, Alejandro";
            double monto = 15000;
            int cuotas = 3;
            DateTime fecha=DateTime.Now;
            
            Credito nuevo=crediTUP.OtorgarCredito(dni, nombre, monto, cuotas, fecha);

            tbVer.Clear();
            foreach (string linea in nuevo.VerDatos())
            {
                tbVer.Text += linea + Environment.NewLine;
            }
        }

        private void tbVer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
