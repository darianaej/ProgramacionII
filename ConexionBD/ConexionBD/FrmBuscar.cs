using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ConexionBD.ConexionBD;

namespace ConexionBD
{
    public partial class FrmBuscar : Form
    {
        public FrmBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();

                string consulta = "SELECT Correo FROM Clientes WHERE Nombre=@nombre";

                MySqlCommand cmd = new MySqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);

                MySqlDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    txtCorreo.Text = lector["Correo"].ToString();
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();

                string consulta = "UPDATE Clientes SET Correo=@correo WHERE Nombre=@nombre";

                MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);

                int filas = cmd.ExecuteNonQuery();

                if (filas > 0)
                {
                    MessageBox.Show("Correo actualizado");
                }
                else
                {
                    MessageBox.Show("No se encontró el cliente");
                }
            }
        }
    }
}
    
