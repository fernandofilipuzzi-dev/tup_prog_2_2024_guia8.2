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
                string nombre = tbApellidoNombres.Text;
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
                tbApellidoNombres.Clear();
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

            if (string.IsNullOrEmpty(tbApellidoNombres.Text.Trim()) == true)
            {
                isNoOk |= true;
                tbApellidoNombres.BackColor = Color.Orange;
            }

            if (string.IsNullOrEmpty(tbMonto.Text.Trim()) == true)
            {
                isNoOk |= true;
                tbMonto.BackColor = Color.Orange;
            }

            return isNoOk == false;
        }

        private void btnAltaFeriados_Click(object sender, EventArgs e)
        {
            FormFeriados fFeriados = new FormFeriados();

            for (int idx = 0; idx < calendario.CantidadFeriados; idx++)
            {
                DateTime dia = calendario[idx].Dia;
                fFeriados.mCCalendario.AddBoldedDate(dia);
            }

            fFeriados.ShowDialog();

            while (fFeriados.DialogResult == DialogResult.OK || 
                        fFeriados.DialogResult == DialogResult.Retry)
            {
                if (fFeriados.DialogResult == DialogResult.OK)
                {
                    DateTime dia = fFeriados.mCCalendario.SelectionStart;
                    string descripcion = fFeriados.tbDescripcionFeriado.Text;

                    Feriado f = calendario[dia];
                    if (f == null)
                    {
                        f = calendario.AgregarFeriado(dia, descripcion);
                        fFeriados.mCCalendario.AddBoldedDate(f.Dia);
                    }
                    else
                    {
                        f.Descripcion = descripcion;
                    }
                }
                else if (fFeriados.DialogResult == DialogResult.Retry)
                {
                    DateTime dia = fFeriados.mCCalendario.SelectionStart;
                    Feriado feriado = calendario[dia];
                    if (feriado != null)
                    {
                        fFeriados.tbDescripcionFeriado.Text = feriado.Descripcion;
                    }
                    else
                    {
                        fFeriados.tbDescripcionFeriado.Clear();
                    }
                }

                fFeriados.ShowDialog();
            }
        }
    }
}
