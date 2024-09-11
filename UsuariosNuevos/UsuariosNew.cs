using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consulta;
using System.Windows.Forms;

namespace UsuariosNuevos
{
    public partial class UsuariosNew : Form
    {
        public UsuariosNew()
        {
            InitializeComponent();
        }
        ConsultaBD con = new ConsultaBD();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            con.Insertar(
                textNombre.Text.ToUpper(), 
                textContrasena.Text.ToUpper());

            textNombre.Clear(); 
            textContrasena.Clear();

            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
