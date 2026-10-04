namespace Unidad1_Controles
{
    partial class Form_Sumar
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
            this.Numero1 = new System.Windows.Forms.Label();
            this.Numero2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.Sumar1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Numero1
            // 
            this.Numero1.AutoSize = true;
            this.Numero1.Location = new System.Drawing.Point(190, 68);
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(62, 16);
            this.Numero1.TabIndex = 0;
            this.Numero1.Text = "Numero1";
            // 
            // Numero2
            // 
            this.Numero2.AutoSize = true;
            this.Numero2.Location = new System.Drawing.Point(190, 166);
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(62, 16);
            this.Numero2.TabIndex = 1;
            this.Numero2.Text = "Numero2";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(341, 68);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 22);
            this.txtNumero1.TabIndex = 3;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(341, 160);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 22);
            this.txtNumero2.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(190, 249);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 16);
            this.lblResultado.TabIndex = 5;
            // 
            // Sumar1
            // 
            this.Sumar1.Location = new System.Drawing.Point(341, 249);
            this.Sumar1.Name = "Sumar1";
            this.Sumar1.Size = new System.Drawing.Size(75, 23);
            this.Sumar1.TabIndex = 7;
            this.Sumar1.Text = "Sumar";
            this.Sumar1.UseVisualStyleBackColor = true;
            this.Sumar1.Click += new System.EventHandler(this.Sumar1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 385);
            this.Controls.Add(this.Sumar1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Numero1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Numero1;
        private System.Windows.Forms.Label Numero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button Sumar1;
    }
}