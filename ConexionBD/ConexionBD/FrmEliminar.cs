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
    public partial class FrmEliminar : Form
    {
        public FrmEliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
       "¿Está seguro de eliminar este cliente?",
       "Confirmación",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                using (MySqlConnection conexion = Conexion.ObtenerConexion())
                {
                    conexion.Open();

                    string consulta = "DELETE FROM Clientes WHERE Nombre=@nombre";

                    MySqlCommand cmd = new MySqlCommand(consulta, conexion);

                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);

                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("Cliente eliminado correctamente");
                        txtNombre.Clear();
                        txtNombre.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado");
                    }
                }
            }
        }
    }
}

