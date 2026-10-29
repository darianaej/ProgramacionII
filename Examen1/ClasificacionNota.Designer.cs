namespace Examen1
{
    partial class ClasificacionNota
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
            this.lblNota = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.listCategoria = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(26, 27);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(98, 16);
            this.lblNota.TabIndex = 0;
            this.lblNota.Text = "Ingrese la nota:";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(130, 27);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 22);
            this.txtNota.TabIndex = 1;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(29, 115);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 2;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(139, 115);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(136, 74);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(69, 16);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // listCategoria
            // 
            this.listCategoria.FormattingEnabled = true;
            this.listCategoria.ItemHeight = 16;
            this.listCategoria.Location = new System.Drawing.Point(252, 6);
            this.listCategoria.Name = "listCategoria";
            this.listCategoria.Size = new System.Drawing.Size(130, 84);
            this.listCategoria.TabIndex = 5;
            // 
            // ClasificacionNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 165);
            this.Controls.Add(this.listCategoria);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNota);
            this.Name = "ClasificacionNota";
            this.Text = "ClasificacionNota";
            this.Load += new System.EventHandler(this.ClasificacionNota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ListBox listCategoria;
    }
}