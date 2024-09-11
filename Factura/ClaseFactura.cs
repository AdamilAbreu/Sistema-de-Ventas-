using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura
{
    public class ClaseFactura
    {
        private string codigo = "";
        private string producto = "";
        private string precioUnidad = "";
        private string cantidad = "";
        private string descuento = "";
        private string preciototal = "";
        private string subtotal = "";
        private string clientes = "";
        private string clienteDescuento = "";
        private string total = "";
        private string NumFacturas = "";

        public string Codigo { get => codigo; set => codigo = value; }
        public string Producto { get => producto; set => producto = value; }
        public string PrecioUnidad { get => precioUnidad; set => precioUnidad = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public string Descuento { get => descuento; set => descuento = value; }
        public string Preciototal { get => preciototal; set => preciototal = value; }
        public string Subtotal { get => subtotal; set => subtotal = value; }
        public string Clientes { get => clientes; set => clientes = value; }
        public string ClienteDescuento { get => clienteDescuento; set => clienteDescuento = value; }
        public string Total { get => total; set => total = value; }
        public string NumFacturas1 { get => NumFacturas; set => NumFacturas = value; }
        
    }
}
