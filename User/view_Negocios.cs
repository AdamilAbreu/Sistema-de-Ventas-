using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escritorioforms;
using InventarioView;
using Consulta;
using Factura;
using System.Drawing.Printing;
using ClientesView;
using System.Windows.Forms;


namespace User
{
    public partial class view_Negocios : Form
    {
        

        DataTable dt = new DataTable();
        
        ConsultaBD consu = new ConsultaBD();

        private double subTotal = 0;
        private double total = 0;
        private double descuento = 0;

        public view_Negocios()
        {
            
            InitializeComponent();

            txtVentaImpuest.Text = txtventas2.Text;
            txtDescuento.Text = txtDescuento2.Text;

            dt.Columns.Add("Codigo");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Precio X Unidad");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Precio Total");

            dataGridView1.DataSource = dt;
            txtFactura.Text = consu.Id_Facturas().ToString();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            View_User vi = new View_User();
            this.Hide();
            vi.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inventario inve = new Inventario();
            this.Hide();    
            inve.ShowDialog();  
            this.Show();    
        }

        

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_User vi = new View_User();
            this.Hide();
            vi.ShowDialog();
            this.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario inve = new Inventario();
            this.Hide();
            inve.ShowDialog();
            this.Show();
        }

        int codigo = 0;
        int cantidad = 0;
        public void button2_Click_1(object sender, EventArgs e)
        {
            

            if (string.IsNullOrWhiteSpace(txtCodigo_Producto.Text))
            {
               
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO 'CODIGO DE PRODUCTO' ");
                codigo++;

                if(codigo >= 3)
                {
                    MessageBox.Show("LO SIENTO, HAS INTENTADO ENTRAR '"+ codigo + "' DE VECES: EL PROGRAMA SE CERRARA");
                    Application.Exit(); 
                }

            }
            else if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO 'CANTIDAD' ");
                cantidad++;

                if(cantidad >= 3)
                {
                    MessageBox.Show("LO SIENTO, HAS INTENTADO ENTRAR '" + cantidad + "' DE VECES: EL PROGRAMA SE CERRARA");
                    Application.Exit();
                }
            }
            else
            {
                var resultado = consu.TuplaInventario(txtCodigo_Producto.Text);
                DataRow row = dt.NewRow();


                row["Codigo"] = txtCodigo_Producto.Text;
                row["Producto"] = resultado.Item1;
                row["Precio X Unidad"] = resultado.Item2;
                row["Cantidad"] = txtCantidad.Text;
                row["Descuento"] = txtDescuento2.Text;
                row["Precio Total"] = Int32.Parse(txtCantidad.Text) * double.Parse(resultado.Item2);

                dt.Rows.Add(row);

                subTotal += (Int32.Parse(txtCantidad.Text) * double.Parse(resultado.Item2));
                total = subTotal + double.Parse(txtVentaImpuest.Text);


                if (descuento != 0)
                {
                    total -= (total * descuento / 100);
                }

                labeltotal.Text = total.ToString();
                labelSubTotal.Text = subTotal.ToString();
            }

            
        }

        
        public void btnFactura_Click(object sender, EventArgs e)
        {
            ConsultaBD consu = new ConsultaBD();

            List<ClaseFactura> listfact = new List <ClaseFactura>();   

            foreach (DataRow row in dt.Rows)
            {
                ClaseFactura factura = new ClaseFactura();

                factura.Codigo = row["Codigo"].ToString();
                factura.Producto = row["PRODUCTO"].ToString();
                factura.PrecioUnidad = row["PRECIO X UNIDAD"].ToString();
                factura.Cantidad = row["CANTIDAD"].ToString();
                factura.Descuento = row["DESCUENTO"].ToString();
                factura.Preciototal = row["PRECIO TOTAL"].ToString();
                factura.Subtotal = subTotal.ToString();
                factura.Clientes = txtCliente.Text;
                factura.ClienteDescuento =  descuento.ToString();   
                factura.Total = total.ToString();
                factura.NumFacturas1 = txtFactura.Text;


                listfact.Add(factura);
            }
            
            consu.InsertarFactura(listfact);


            txtFactura.Text = Convert.ToString(consu.Id_Facturas());

            printDocument1 = new PrintDocument();  
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();


        }

        //-------------------------IMPRIMIR--------------------//
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font fon = new Font("Arial", 14);
            int ancho = 300;
            int y = 20;

            e.Graphics.DrawString("----PUNTO DE VENTA----", fon, Brushes.Black, new RectangleF(0,y += 20,ancho,20));
            MessageBox.Show("\n");
            e.Graphics.DrawString("FACTURA# " + txtFactura.Text, fon, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("CLIENTE " + txtCliente.Text, fon, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            MessageBox.Show("\n");
            e.Graphics.DrawString("------PRODUCTO-----", fon, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            foreach(DataRow row in dt.Rows)
            {
                e.Graphics.DrawString(row["CODIGO"].ToString() + " " +
                    row["PRODUCTO"].ToString() + " " + 
                    row["PRECIO TOTAL"].ToString()
                    , fon, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            }
            e.Graphics.DrawString("------SUBTOTAL-----", fon, Brushes.Black, new RectangleF(0, y += 30, ancho, 20));
            e.Graphics.DrawString("------TOTAL $: "+ total.ToString(), fon, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            MessageBox.Show("\n");
            e.Graphics.DrawString("------GRACIAS POR VISITARNOS-----", fon, Brushes.Black, new RectangleF(0, y += 40, ancho, 20));
        }

        

        public void button1_Click_1(object sender, EventArgs e)
        {
            ConsultaBD consu = new ConsultaBD();

            var cliente = consu.consultaCliente(txtcodigo_Cliente.Text);
            txtCliente.Text = cliente.Item1 + " DESC: " + cliente.Item2;

            descuento = cliente.Item2;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            this.Hide();
            clientes.ShowDialog();  
            this.Show();
            
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
