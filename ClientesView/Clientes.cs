using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;


namespace ClientesView
{
    public partial class Clientes : Form
    {

        OracleConnection con = new OracleConnection("DATA SOURCE = ORCLPDB; USER ID = ADAM; PASSWORD = 1234;");
        public Clientes()
        {
            InitializeComponent();
            DataViewGrid.DataSource = ClienteConsulta();
        }
        public DataTable ClienteConsulta()
        {
            OracleConnection con = new OracleConnection("DATA SOURCE = ORCLPDB; USER ID = ADAM; PASSWORD = 1234;");
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string query = "SELECT * FROM ADAM.CLIENTES";
                OracleCommand cmd = new OracleCommand(query,con);  
                OracleDataAdapter adapte = new OracleDataAdapter(cmd);
                adapte.Fill(dt);
                
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
            return dt;
        }

        private void DataViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
