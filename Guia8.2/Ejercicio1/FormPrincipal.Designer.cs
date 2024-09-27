namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaInicioPlan = new System.Windows.Forms.DateTimePicker();
            this.nupCuotas = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVer = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.tbApellidoNombres = new System.Windows.Forms.TextBox();
            this.btnGenerarPlan = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnAltaFeriados = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCuotas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.tbVer);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnGenerarPlan);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 493);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alta de plan de pagos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtpFechaInicioPlan);
            this.groupBox3.Controls.Add(this.nupCuotas);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbMonto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(6, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 127);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del plan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha Inicio Plan";
            // 
            // dtpFechaInicioPlan
            // 
            this.dtpFechaInicioPlan.CustomFormat = "";
            this.dtpFechaInicioPlan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicioPlan.Location = new System.Drawing.Point(205, 89);
            this.dtpFechaInicioPlan.Name = "dtpFechaInicioPlan";
            this.dtpFechaInicioPlan.Size = new System.Drawing.Size(160, 26);
            this.dtpFechaInicioPlan.TabIndex = 6;
            // 
            // nupCuotas
            // 
            this.nupCuotas.Location = new System.Drawing.Point(205, 57);
            this.nupCuotas.Name = "nupCuotas";
            this.nupCuotas.Size = new System.Drawing.Size(120, 26);
            this.nupCuotas.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "En cuotras";
            // 
            // tbMonto
            // 
            this.tbMonto.Location = new System.Drawing.Point(205, 25);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(129, 26);
            this.tbMonto.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Monto de la infracción";
            // 
            // tbVer
            // 
            this.tbVer.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVer.Location = new System.Drawing.Point(6, 310);
            this.tbVer.Multiline = true;
            this.tbVer.Name = "tbVer";
            this.tbVer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbVer.Size = new System.Drawing.Size(530, 172);
            this.tbVer.TabIndex = 15;
            this.tbVer.WordWrap = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbDNI);
            this.groupBox2.Controls.Add(this.tbApellidoNombres);
            this.groupBox2.Location = new System.Drawing.Point(6, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 99);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos y Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "DNI";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(205, 25);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(129, 26);
            this.tbDNI.TabIndex = 0;
            // 
            // tbApellidoNombres
            // 
            this.tbApellidoNombres.Location = new System.Drawing.Point(205, 59);
            this.tbApellidoNombres.Name = "tbApellidoNombres";
            this.tbApellidoNombres.Size = new System.Drawing.Size(308, 26);
            this.tbApellidoNombres.TabIndex = 1;
            // 
            // btnGenerarPlan
            // 
            this.btnGenerarPlan.Location = new System.Drawing.Point(170, 263);
            this.btnGenerarPlan.Name = "btnGenerarPlan";
            this.btnGenerarPlan.Size = new System.Drawing.Size(201, 41);
            this.btnGenerarPlan.TabIndex = 14;
            this.btnGenerarPlan.Text = "Generar Plan de pagos";
            this.btnGenerarPlan.UseVisualStyleBackColor = true;
            this.btnGenerarPlan.Click += new System.EventHandler(this.btnGenerarPlan_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(560, 148);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(127, 73);
            this.btnVer.TabIndex = 16;
            this.btnVer.Text = "Consultar Planes realizados";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnAltaFeriados
            // 
            this.btnAltaFeriados.Location = new System.Drawing.Point(560, 238);
            this.btnAltaFeriados.Name = "btnAltaFeriados";
            this.btnAltaFeriados.Size = new System.Drawing.Size(127, 73);
            this.btnAltaFeriados.TabIndex = 17;
            this.btnAltaFeriados.Text = "Ver/Editar feriados";
            this.btnAltaFeriados.UseVisualStyleBackColor = true;
            this.btnAltaFeriados.Click += new System.EventHandler(this.btnAltaFeriados_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 511);
            this.Controls.Add(this.btnAltaFeriados);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCuotas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nupCuotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.Button btnGenerarPlan;
        private System.Windows.Forms.TextBox tbVer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.TextBox tbApellidoNombres;
        private System.Windows.Forms.DateTimePicker dtpFechaInicioPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnAltaFeriados;
    }
}

