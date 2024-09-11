using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User;
using UsuariosNuevos;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Security.Cryptography.X509Certificates;

namespace LoginForms1
{
    public partial class LoginQuery : Form
    {
        // Se crea una conexion a la base de datos Oracle. Se inicializa la conexion con los parametros de conexion.
        OracleConnection ora = new OracleConnection("DATA SOURCE = ORCLPDB; USER ID = ADAM; PASSWORD = 1234;");
         
        public LoginQuery()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login();
            // Metodo que se ejecuta al hacer clic en el boton "Entrar". Llama al metodo Login.
        }

        /*Metodo login que tiene como funcionalidad de confirmar que un usuario existe,
        si existe entrara al sistema mediante las conexiones de la base de datos y
        el try/catch que sirve para hacer mas segura la conexion a la base de datos.*/
        
        public void Login()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO NOMBRE");
            }
            else if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show("FAVOR DE LLENAR EL CAMPO CONTRASEÑA");
            }

            try
            {
                ora.Open();

                string query = "SELECT * FROM ADAM.USUARIOS WHERE NOMBRE = :nombre AND CONTRASENA = :contrasena";
                OracleCommand cmd = new OracleCommand(@query, ora);

                cmd.Parameters.Add(new OracleParameter(":nombre", txtNombre.Text.ToUpper()));
                cmd.Parameters.Add(new OracleParameter(":contrasena", txtContrasena.Text.ToUpper()));

                OracleDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    view_Negocios user = new view_Negocios();
                    this.Hide();
                    user.ShowDialog();
                }
                else
                {
                    MessageBox.Show("EL USUARIO NO EXISTE");
                }
            }
        
            catch (Exception e)
            {
                MessageBox.Show("ERROR EN LA BASE DE DATOS" + e.Message);
                throw;
            }
            finally
            {
                if(ora.State == ConnectionState.Open)
                {
                    ora.Close();
                }
            }
        }

        public string Empleado()
        {
            string Empleado = txtNombre.Text;    
            return Empleado.Trim(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SALIENDO DEL PROGRAMA");
            Application.Exit(); 
        }

        private void CrearUsuario_Click(object sender, EventArgs e)
        {
            UsuariosNew usuariosNew = new UsuariosNew();
            usuariosNew.ShowDialog();   

        }
    }
}
