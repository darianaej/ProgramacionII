namespace Examen1
{
    partial class Calculodesalario
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtHorastrabajadas = new System.Windows.Forms.TextBox();
            this.txtPagoporhora = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblHorastrabajadas = new System.Windows.Forms.Label();
            this.lblPagoporhora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(343, 113);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(343, 158);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(188, 175);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(69, 16);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // txtHorastrabajadas
            // 
            this.txtHorastrabajadas.Location = new System.Drawing.Point(203, 82);
            this.txtHorastrabajadas.Name = "txtHorastrabajadas";
            this.txtHorastrabajadas.Size = new System.Drawing.Size(100, 22);
            this.txtHorastrabajadas.TabIndex = 4;
            // 
            // txtPagoporhora
            // 
            this.txtPagoporhora.Location = new System.Drawing.Point(179, 132);
            this.txtPagoporhora.Name = "txtPagoporhora";
            this.txtPagoporhora.Size = new System.Drawing.Size(100, 22);
            this.txtPagoporhora.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(118, 16);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Ingrese el nombre:";
            // 
            // lblHorastrabajadas
            // 
            this.lblHorastrabajadas.AutoSize = true;
            this.lblHorastrabajadas.Location = new System.Drawing.Point(16, 82);
            this.lblHorastrabajadas.Name = "lblHorastrabajadas";
            this.lblHorastrabajadas.Size = new System.Drawing.Size(181, 16);
            this.lblHorastrabajadas.TabIndex = 7;
            this.lblHorastrabajadas.Text = "Ingrese las horas trabajadas:";
            // 
            // lblPagoporhora
            // 
            this.lblPagoporhora.AutoSize = true;
            this.lblPagoporhora.Location = new System.Drawing.Point(16, 132);
            this.lblPagoporhora.Name = "lblPagoporhora";
            this.lblPagoporhora.Size = new System.Drawing.Size(157, 16);
            this.lblPagoporhora.TabIndex = 8;
            this.lblPagoporhora.Text = "Ingrese el pago por hora:";
            // 
            // Calculodesalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 233);
            this.Controls.Add(this.lblPagoporhora);
            this.Controls.Add(this.lblHorastrabajadas);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtPagoporhora);
            this.Controls.Add(this.txtHorastrabajadas);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Calculodesalario";
            this.Text = "Calculodesalario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtHorastrabajadas;
        private System.Windows.Forms.TextBox txtPagoporhora;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblHorastrabajadas;
        private System.Windows.Forms.Label lblPagoporhora;
    }
}