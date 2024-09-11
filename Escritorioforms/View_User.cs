using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consulta;

namespace Escritorioforms
{
    public partial class View_User : Form
    {
        ConsultaBD ora = new ConsultaBD();
        public View_User()
        {
            InitializeComponent();
            DataView.DataSource = ora.Consulta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

       

       

        public void button2_Click_1(object sender, EventArgs e)
        {
            ora.Insertar(
                txtNombre.Text,
                txtContrasena.Text);
           
            DataView.DataSource = ora.Consulta();

            txtNombre.Clear();
            txtContrasena.Clear();   
        }

        public void button3_Click(object sender, EventArgs e)
        {
            ora.Eliminar(
                txtNombre.Text,
                txtContrasena.Text);

            DataView.DataSource= ora.Consulta(); 
            
            txtNombre.Clear();
            txtContrasena.Clear();
        }

        private void btnModifcar_Click(object sender, EventArgs e)
        {
            ora.Modificar(
                txtContrasena.Text,
                txtNombre.Text);

            DataView.DataSource = ora.Consulta();
            
            txtContrasena.Clear();
            txtNombre.Clear();
        }

    }
}
