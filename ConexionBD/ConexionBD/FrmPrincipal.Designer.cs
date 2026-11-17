namespace ConexionBD
{
    partial class FrmPrincipal
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
            this.btnBuscar1 = new System.Windows.Forms.Button();
            this.btnInsertar1 = new System.Windows.Forms.Button();
            this.btnEliminar1 = new System.Windows.Forms.Button();
            this.btnConexion1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscar1
            // 
            this.btnBuscar1.Location = new System.Drawing.Point(152, 79);
            this.btnBuscar1.Name = "btnBuscar1";
            this.btnBuscar1.Size = new System.Drawing.Size(81, 40);
            this.btnBuscar1.TabIndex = 0;
            this.btnBuscar1.Text = "Buscar";
            this.btnBuscar1.UseVisualStyleBackColor = true;
            this.btnBuscar1.Click += new System.EventHandler(this.btnBuscar1_Click);
            // 
            // btnInsertar1
            // 
            this.btnInsertar1.Location = new System.Drawing.Point(30, 79);
            this.btnInsertar1.Name = "btnInsertar1";
            this.btnInsertar1.Size = new System.Drawing.Size(75, 40);
            this.btnInsertar1.TabIndex = 1;
            this.btnInsertar1.Text = "Insertar";
            this.btnInsertar1.UseVisualStyleBackColor = true;
            this.btnInsertar1.Click += new System.EventHandler(this.btnInsertar1_Click);
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.Location = new System.Drawing.Point(283, 79);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(79, 40);
            this.btnEliminar1.TabIndex = 2;
            this.btnEliminar1.Text = "Eliminar";
            this.btnEliminar1.UseVisualStyleBackColor = true;
            this.btnEliminar1.Click += new System.EventHandler(this.btnEliminar1_Click);
            // 
            // btnConexion1
            // 
            this.btnConexion1.Location = new System.Drawing.Point(158, 12);
            this.btnConexion1.Name = "btnConexion1";
            this.btnConexion1.Size = new System.Drawing.Size(75, 40);
            this.btnConexion1.TabIndex = 3;
            this.btnConexion1.Text = "Conexion";
            this.btnConexion1.UseVisualStyleBackColor = true;
            this.btnConexion1.Click += new System.EventHandler(this.btnConexion1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 136);
            this.Controls.Add(this.btnConexion1);
            this.Controls.Add(this.btnEliminar1);
            this.Controls.Add(this.btnInsertar1);
            this.Controls.Add(this.btnBuscar1);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar1;
        private System.Windows.Forms.Button btnInsertar1;
        private System.Windows.Forms.Button btnEliminar1;
        private System.Windows.Forms.Button btnConexion1;
    }
}