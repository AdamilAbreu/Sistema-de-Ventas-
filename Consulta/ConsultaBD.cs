using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;
using Factura;
using System.Collections;

namespace Consulta
{
    public class ConsultaBD
    {
        OracleConnection con = new OracleConnection("DATA SOURCE = ORCLPDB; USER ID = ADAM; PASSWORD = 1234;");
        DataTable data = new DataTable();
        public DataTable Consulta()
        {
            DataTable data = new DataTable();
            try
            {

                con.Open();
                string query = "SELECT * FROM ADAM.USUARIOS";
                OracleCommand cmd = new OracleCommand(query, con);
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                
                adapter.Fill(data);

            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR EN LA BASE DE DATOS: " + e.Message);
                throw;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {

                    con.Close();
                }
            }

            return data;
        }

       

        public int  Insertar(string nombre, string contrasena)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO NOMBRE");
            }
            else if (string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO CONTRASENA");
            }

            int insert = 0; 
            OracleConnection con = new OracleConnection("DATA SOURCE = ORCLPDB; USER ID = ADAM; PASSWORD = 1234;");
            try
            {
                con.Open();
                string query = "INSERT INTO  ADAM.USUARIOS (NOMBRE,CONTRASENA) " +
                "VALUES ('" + nombre + "', '" + contrasena + "')";
                OracleCommand cmd = new OracleCommand(query, con);
                insert = cmd.ExecuteNonQuery();

                if (insert >= 1)
                {
                    MessageBox.Show("EL USUARIO '" + nombre + "' HA SIDO AGREGADO");
                }
                else
                {
                    MessageBox.Show("EL USUARIO '" + nombre + "' NO HA SIDO ENCONTRADO");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR EN LA BASE DE DATOS: "+ e.Message);
                throw;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();   
                }  
            }
            return insert;
            
        }

        public int Eliminar(string nombre, string contrasena)
        {
            if (string.IsNullOrEmpty(nombre))
            {

                MessageBox.Show("FAVOR DE LLENAR EL CAMPO NOMBRE");
            }
            else if (string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO CONTRASEÑA");
            }

            OracleConnection con = new OracleConnection("DATA SOURCE = ORCLPDB; USER ID = ADAM; PASSWORD = 1234;");
            int fila = 0;
            try
            {
                con.Open();
                string query = "DELETE FROM ADAM.USUARIOS WHERE NOMBRE = '" + nombre + "' " +
                 "AND CONTRASENA = '" + contrasena + "' ";

                OracleCommand cmd = new OracleCommand(@query, con);

                fila = cmd.ExecuteNonQuery();

                if (fila >= 1)
                {
                    MessageBox.Show("EL USUARIO '" + nombre + "' HA SIDO ELIMINADO");
                }
                else
                {
                    MessageBox.Show("EL USUARIO '" + nombre + "' NO HA SIDO ENCONTRADO, POR LO TANTO NO PODRA SER ELIMINADO");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR EN LA BASE DE DATOS: " + e.Message);
                throw;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }  
            }
            return fila;
        }

        public int Modificar(string contrasena, string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("FAVOR DE INGRESAR EL NOMBRE");
            }
            else if(string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("FAVOR DE INGRESAR LA CONTRASEÑA");
            }
            

            OracleConnection con = new OracleConnection("DATA SOURCE = ORCLPDB; USER ID = ADAM; PASSWORD = 1234;");
            int filas = 0;
            try
            {
                con.Open();
                string query = "UPDATE ADAM.USUARIOS SET CONTRASENA = '" + contrasena + "' WHERE NOMBRE = '" + nombre + "' ";
                OracleCommand cmd = new OracleCommand(@query, con);
                filas = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR EN LA BASE DE DATOS: " + e.Message);
                throw;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();    
                }
            }

            return filas;
        }

        

        public int Id_Facturas()
        {
            OracleConnection con = new OracleConnection("DATA SOURCE = ORCLPDB; USER ID = ADAM; PASSWORD = 1234;");
            int maxId = 0;
            try
            {
                con.Open();
                string query = "SELECT MAX(ID_FACTURA) + 1 FROM ADAM.FACTURAS";
                OracleCommand comando = new OracleCommand(query, con);
                comando.ExecuteNonQuery();
                Object result = comando.ExecuteScalar();

                if (result != null)
                {
                    maxId = Convert.ToInt32(result);
                    Console.WriteLine("El mayor ID_FACTURA es: " + maxId);
                }
                else
                {
                    Console.WriteLine("No se encontraron registros.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR EN LA BASE DE DATOS: " + e.Message);
                throw;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();    
                }
            }
            return maxId;


        }

        public Tuple<string, string> TuplaInventario(string id_Inventario)
        {
            OracleConnection con = new OracleConnection("DATA SOURCE = ORCLPDB; USER ID = ADAM; PASSWORD = 1234;");
            con.Open();

            string producto;
            string precio;

            string query = "SELECT * FROM ADAM.INVENTARIO WHERE ID_INVENTARIO = '" + id_Inventario + "'";
            OracleCommand comando = new OracleCommand(query, con);
            OracleDataReader reg = comando.ExecuteReader();

            if (reg.Read())
            {
                producto = reg["PRODUCTO"].ToString();
                precio = reg["PRECIO"].ToString();

                con.Close();
            }
            else
            {
                return Tuple.Create("Null", " PRODUCTO NO ENCONTRADO");

            }
            return Tuple.Create(producto, precio);

        }



        public Tuple<string, double> consultaCliente(string codigo)
        {
            OracleConnection con = new OracleConnection("DATA SOURCE = ORCLPDB; USER ID = ADAM; PASSWORD = 1234;");
            string resultado = "Null";
            double resultado1 = 0;
            try
            {
                con.Open();
                string query = "SELECT NOMBRE_CLIENTE || ' '||APELLIDO_CLIENTE AS NOMBRE, DESCUENTO FROM ADAM.CLIENTES WHERE CODIGO_CLIENTE = '" + codigo + "' ";

                OracleCommand comando = new OracleCommand(@query, con);
                comando.Parameters.Add(new OracleParameter(":codigo", codigo));
                OracleDataReader reg = comando.ExecuteReader();


                if (reg.Read())
                {
                    resultado = reg["NOMBRE"].ToString();
                    resultado1 = double.Parse(reg["DESCUENTO"].ToString());

                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR EN LA BASE DE DATOS" + e.Message);
                throw;
            }
            finally
            {
                if(con.State ==  ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return Tuple.Create(resultado, resultado1);
        }

        public void InsertarFactura(List<ClaseFactura> f)
        {
            con.Open();

            foreach(ClaseFactura factura in f)
            {

                string query = "INSERT INTO ADAM.FACTURAS(CODIGO, PRODUCTO, PRECIO_X_UNIDAD, CANTIDAD, CLIENTES, DESCUENTO_CLIENTE, MONTO_TOTAL, NUM_FACTURAS) " +
                    "VALUES('"+factura.Codigo+"' , '"+factura.Producto+"',  '"+Convert.ToDouble(factura.PrecioUnidad)+"' , " +
                    "'"+Convert.ToInt32(factura.Cantidad)+"' , '"+factura.Clientes+"' ,  '"+Convert.ToDouble(factura.ClienteDescuento)+"' , " +
                    "'"+Convert.ToDouble(factura.Total)+"' , '"+Convert.ToInt32(factura.NumFacturas1)+"' )";

                OracleCommand cmd = new OracleCommand(query, con);
                cmd.ExecuteNonQuery();

            }
            con.Close();

        }


        public DataTable ConsultaInventario()
        {
            OracleConnection con = new OracleConnection("DATA SOURCE = ORCLPDB; USER ID = ADAM; PASSWORD = 1234;");
            DataTable data = new DataTable();
            try
            {
               
                con.Open();
                string query = "SELECT * FROM ADAM.INVENTARIO";
                OracleCommand comando = new OracleCommand(query, con);
                using (OracleDataAdapter rapter = new OracleDataAdapter(comando))
                {
                    rapter.Fill(data);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR EN LA CONEXION DE LA BASE DE DATOS: " + e.Message);
                throw;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();    
                }
            }

            return data;    
        }

       
        public int EliminarInventario(string id_Inventario)
        {
            OracleConnection con = new OracleConnection("DATA SOURCE = ORCLPDB; USER ID = ADAM; PASSWORD = 1234;");
            int id = 0;

            if (string.IsNullOrEmpty(id_Inventario))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO ID");
            }

            try
            {
                con.Open();
                string query = "DELETE FROM ADAM.INVENTARIO WHERE ID_INVENTARIO = :id_inventario ";
                OracleCommand comando = new OracleCommand(query, con);

                comando.Parameters.Add(new OracleParameter(":id_inventario", id_Inventario));
                id = comando.ExecuteNonQuery();

                if(id == 1){
                    MessageBox.Show("EL PRODUCTO HA SIDO ELIMINADO");
                    
                }
                else
                {
                    MessageBox.Show("EL PRODUCTO NO HA SIDO ELIMINADO");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR EN LA BASE DE DATOS: " + e.Message);
                throw;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();    
                }  
            }

            return id;   
        }

        public int IngresarInventario(string Producto, string Categoria, string Precio)
        {
            OracleConnection con = new OracleConnection("DATA SOURCE = ORCLPDB; USER ID = ADAM; PASSWORD = 1234;");
            int revisador = 0;


            if (string.IsNullOrWhiteSpace(Producto) || string.IsNullOrWhiteSpace(Categoria) || string.IsNullOrWhiteSpace(Precio))
            {
                MessageBox.Show("Hay un campo vacío.");
                return revisador;
            }
            
            try
            {
                con.Open();
                string query = "INSERT INTO ADAM.INVENTARIO (PRODUCTO, CATEGORIA, PRECIO)\r\n" +
                    "VALUES( :PRODUCTO, :CATEGORIA, :PRECIO)";

                OracleCommand comando = new OracleCommand(query, con);
                comando.Parameters.Add(new OracleParameter(":PRODUCTO ", Producto));
                comando.Parameters.Add(new OracleParameter(":CATEGORIA ", Categoria));
                comando.Parameters.Add(new OracleParameter(":PRECIO ", Convert.ToDecimal(Precio)));
                


                revisador  = comando.ExecuteNonQuery();

                if(revisador == 1)
                {
                    MessageBox.Show("LOS PRODUCTOS HAN SIDO AGREGADO");
                    
                }
                else
                {
                    MessageBox.Show("EL PRODUCTO NO HA SIDO AGREGADO");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR EN LA BASE DE DATOS");
                throw;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return revisador;
        }

       
        public int ModificarInventario( string Precio, string id)
        {
            OracleConnection con = new OracleConnection("DATA SOURCE = ORCLPDB; USER ID = ADAM; PASSWORD = 1234;");

            int inve = 0;
            try
            {
                con.Open();
                string query = "UPDATE ADAM.INVENTARIO SET PRECIO  = :PRECIO WHERE ID_INVENTARIO = :ID";
                OracleCommand comando = new OracleCommand(query,con);

                comando.Parameters.Add(new OracleParameter("PRECIO" , Precio));
                comando.Parameters.Add(new OracleParameter("ID", id));

                inve = comando.ExecuteNonQuery(); 
                
                if(inve == 1)
                {
                    MessageBox.Show("PRODUCTO MODIFICADO EXITOSAMENTE");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR EN LA BASE DE DATOS: " +e.Message);
                throw;
            }
            finally
            {
                if(con.State == ConnectionState.Open)
                {
                    con.Close();    
                }
            }

            return inve;
        }

    }
}
