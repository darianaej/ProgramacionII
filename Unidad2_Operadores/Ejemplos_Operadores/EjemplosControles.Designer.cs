namespace Unidad2_Operadores.Ejemplos_Operadores
{
    partial class EjemplosControles
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnMorado = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(36, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 132);
            this.listBox1.TabIndex = 0;
            // 
            // btnRojo
            // 
            this.btnRojo.Location = new System.Drawing.Point(13, 180);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(75, 23);
            this.btnRojo.TabIndex = 1;
            this.btnRojo.Text = "Rojo";
            this.btnRojo.UseVisualStyleBackColor = true;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnMorado
            // 
            this.btnMorado.Location = new System.Drawing.Point(125, 179);
            this.btnMorado.Name = "btnMorado";
            this.btnMorado.Size = new System.Drawing.Size(75, 23);
            this.btnMorado.TabIndex = 2;
            this.btnMorado.Text = "Morado";
            this.btnMorado.UseVisualStyleBackColor = true;
            this.btnMorado.Click += new System.EventHandler(this.btnMorado_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.Location = new System.Drawing.Point(239, 179);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(75, 23);
            this.btnAzul.TabIndex = 3;
            this.btnAzul.Text = "Azul";
            this.btnAzul.UseVisualStyleBackColor = true;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // EjemplosControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 222);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnMorado);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.listBox1);
            this.Name = "EjemplosControles";
            this.Text = "EjemplosControles";
            this.Load += new System.EventHandler(this.EjemplosControles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnMorado;
        private System.Windows.Forms.Button btnAzul;
    }
}