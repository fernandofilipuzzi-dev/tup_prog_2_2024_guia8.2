namespace Ejercicio1
{
    partial class FormFeriados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mCCalendario = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescripcionFeriado = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mCCalendario
            // 
            this.mCCalendario.Location = new System.Drawing.Point(9, 52);
            this.mCCalendario.Margin = new System.Windows.Forms.Padding(14);
            this.mCCalendario.MaxSelectionCount = 1;
            this.mCCalendario.Name = "mCCalendario";
            this.mCCalendario.TabIndex = 17;
            this.mCCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mCCalendario_DateSelected);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(236, 233);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 53);
            this.button1.TabIndex = 18;
            this.button1.Text = "Editar día";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Descripción";
            // 
            // tbDescripcionFeriado
            // 
            this.tbDescripcionFeriado.Location = new System.Drawing.Point(275, 52);
            this.tbDescripcionFeriado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDescripcionFeriado.Multiline = true;
            this.tbDescripcionFeriado.Name = "tbDescripcionFeriado";
            this.tbDescripcionFeriado.Size = new System.Drawing.Size(298, 162);
            this.tbDescripcionFeriado.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(420, 233);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 54);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Calendario";
            // 
            // FormFeriados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 301);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescripcionFeriado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mCCalendario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormFeriados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición de feriados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.MonthCalendar mCCalendario;
        public System.Windows.Forms.TextBox tbDescripcionFeriado;
    }
}