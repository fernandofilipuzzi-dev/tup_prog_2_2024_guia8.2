using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Ejercicio1.Models;

namespace Ejercicio1
{

    public partial class FormPrincipal : Form
    {
        Calendario calendario = new Calendario();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnGenerarPlan_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                int dni = Convert.ToInt32(tbDNI.Text);
                string nombre = tbNombres.Text;
                double monto = Convert.ToDouble(tbMonto.Text);
                int cantCuotas = Convert.ToInt32(nupCuotas.Value);
                DateTime fechaAltaPlan = pkFechaInicioPlan.Value;

                Infractor destinatario = new Infractor
                {
                    DNI = dni,
                    ApelldosyNombres = nombre
                };

                PlanDePago plan = new PlanDePago(monto, cantCuotas, fechaAltaPlan, destinatario, calendario);

                tbVer.Text = plan.VerDetalle();

                #region limpiando controles
                tbDNI.Clear();
                tbNombres.Clear();
                tbMonto.Clear();
                nupCuotas.Value = 0;
                #endregion
            }
        }

        public bool Validar()
        {
            bool isNoOk = false;

            if (string.IsNullOrEmpty(tbDNI.Text.Trim()) == true)
            {
                isNoOk |= true;
                tbDNI.BackColor = Color.Orange;
            }

            if (string.IsNullOrEmpty(tbApellidosYNombres.Text.Trim()) == true)
            {
                isNoOk |= true;
                tbApellidosYNombres.BackColor = Color.Orange;
            }

            if (string.IsNullOrEmpty(tbMonto.Text.Trim()) == true)
            {
                isNoOk |= true;
                tbMonto.BackColor = Color.Orange;
            }

            return isNoOk == false;
        }
    }
}
