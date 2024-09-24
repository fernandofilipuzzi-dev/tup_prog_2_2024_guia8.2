namespace Ejercicio2_ADN
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbContenido = new System.Windows.Forms.TextBox();
            this.btnPreproceso = new System.Windows.Forms.Button();
            this.tbCorrectos = new System.Windows.Forms.TextBox();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.tbIncorrectos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbContenido
            // 
            this.tbContenido.Location = new System.Drawing.Point(18, 48);
            this.tbContenido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbContenido.Multiline = true;
            this.tbContenido.Name = "tbContenido";
            this.tbContenido.Size = new System.Drawing.Size(718, 88);
            this.tbContenido.TabIndex = 0;
            // 
            // btnPreproceso
            // 
            this.btnPreproceso.Location = new System.Drawing.Point(747, 57);
            this.btnPreproceso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPreproceso.Name = "btnPreproceso";
            this.btnPreproceso.Size = new System.Drawing.Size(148, 63);
            this.btnPreproceso.TabIndex = 1;
            this.btnPreproceso.Text = "Preproceso(1)";
            this.btnPreproceso.UseVisualStyleBackColor = true;
            this.btnPreproceso.Click += new System.EventHandler(this.btnPreproceso_Click);
            // 
            // tbCorrectos
            // 
            this.tbCorrectos.Location = new System.Drawing.Point(18, 197);
            this.tbCorrectos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCorrectos.Multiline = true;
            this.tbCorrectos.Name = "tbCorrectos";
            this.tbCorrectos.Size = new System.Drawing.Size(718, 135);
            this.tbCorrectos.TabIndex = 2;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(747, 206);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(148, 63);
            this.btnProcesar.TabIndex = 3;
            this.btnProcesar.Text = "Procesar(2)";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // tbIncorrectos
            // 
            this.tbIncorrectos.Location = new System.Drawing.Point(22, 387);
            this.tbIncorrectos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIncorrectos.Multiline = true;
            this.tbIncorrectos.Name = "tbIncorrectos";
            this.tbIncorrectos.Size = new System.Drawing.Size(718, 104);
            this.tbIncorrectos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Listado correcto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resultados a evaluar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Listado con errores";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIncorrectos);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.tbCorrectos);
            this.Controls.Add(this.btnPreproceso);
            this.Controls.Add(this.tbContenido);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbContenido;
        private System.Windows.Forms.Button btnPreproceso;
        private System.Windows.Forms.TextBox tbCorrectos;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox tbIncorrectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

