﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FormFeriados : Form
    {
        public FormFeriados()
        {
            InitializeComponent();
        }

        private void mCCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }
    }
}
