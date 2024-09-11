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
using Factura;


namespace InventarioView
{
    public partial class Inventario : Form
    {
        ConsultaBD claseConsu = new ConsultaBD(); 
        public Inventario()
        {
            InitializeComponent();
            dataView.DataSource = claseConsu.ConsultaInventario();
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
           //***
            
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // claseConsu.EliminarInventario(txtEliminar.Text);
            claseConsu.EliminarInventario(txtEliminar.Text);

            dataView.DataSource = claseConsu.ConsultaInventario();

            txtEliminar.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SALIENDO DEL PROGRAMA");
            Application.Exit(); 

            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Completar aqui
            claseConsu.IngresarInventario(
               textProducto.Text.ToUpper(),
               textCategoria.Text.ToUpper(),
               textPrecio.Text
               );

            dataView.DataSource = claseConsu.ConsultaInventario();

            textProducto.Clear();
            textCategoria.Clear();
            textPrecio.Clear();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            claseConsu.ModificarInventario(
                textPrecioMod.Text,
                txtID.Text
                );

            txtID.Clear();
            textPrecioMod.Clear();

            dataView.DataSource = claseConsu.ConsultaInventario();

            
        }
    }
}
