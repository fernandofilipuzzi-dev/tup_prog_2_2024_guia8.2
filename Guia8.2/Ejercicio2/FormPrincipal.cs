using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2_ADN
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnPreproceso_Click(object sender, EventArgs e)
        {
            string contenido= tbContenido.Text;
            tbCorrectos.Text = "";

            foreach (string linea in contenido.Split('\n'))
            {
                //limpio la cadena de todos los caracteres que no sea letras
                string adn = Regex.Replace(linea, @"[^A-Za-z]","").ToUpper();

                //descartando las cadenas correctas obtengo las icorrectas
                Match m = Regex.Match(adn, @"[^TCGA]+");
                if (m.Success == true)
                {
                    tbIncorrectos.Text += adn + "\r\n";
                }
                else 
                {
                    string lineaFormateada = "";

                    int start = adn.IndexOf("ATG");

                    if (start > -1)
                    {
                        string extract = adn.Substring(start);
                        Match mg = Regex.Match(extract, @"(.{3})");

                        for (int p = 1; p < mg.Groups.Count; p++)
                        {
                            lineaFormateada += mg.Groups[p].Value + "-";
                        }

                        tbCorrectos.Text += lineaFormateada+"\r\n";
                    }
                }
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

        }
    }
}
