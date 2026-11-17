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

namespace ConexionBD
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConexion1_Click(object sender, EventArgs e)
        {
            FrmConexion frm = new FrmConexion();
            frm.ShowDialog();
        }
        private void btnInsertar1_Click(object sender, EventArgs e)
        {
            FrmInsertar frm = new FrmInsertar();
            frm.ShowDialog();
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            FrmBuscar frm = new FrmBuscar();
            frm.ShowDialog();
        }

        private void btnEliminar1_Click(object sender, EventArgs e)
        {
            FrmEliminar frm = new FrmEliminar();
            frm.ShowDialog();
        }

        }
    }

