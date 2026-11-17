using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static ConexionBD.ConexionBD;


namespace ConexionBD
{
    public partial class FrmInsertar : Form
    {
        private string cadena;

        public FrmInsertar()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre.");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Debe ingresar un correo.");
                txtCorreo.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = "INSERT INTO Clientes(Nombre, Correo) VALUES(@nombre, @correo)";

                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente insertado correctamente.");

                    txtNombre.Clear();
                    txtCorreo.Clear();
                    txtNombre.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            if (!txtCorreo.Text.Contains("@"))
            {
                MessageBox.Show("Ingrese un correo válido.");
                txtCorreo.Focus();
                return;
            }
        }
    }
}

