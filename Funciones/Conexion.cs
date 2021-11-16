using System;
//Para agregar este componente es necesario agregarlo como referencia al framework
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Funciones
{
    public class Conexion
    {
        public SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-6M8F774\DEVJR;Initial Catalog=Relojería;Integrated Security=True");
        private string sqlConexion;

        //Funcion para conectar a la Base de Datos
        public void Conectar()
        {
            try
            {
                sqlConexion = @"Data Source=DESKTOP-6M8F774\DEVJR;Initial Catalog=Relojería;Integrated Security=True";
                cnx = new SqlConnection(sqlConexion);
                cnx.Open();
                //MessageBox.Show("Conexión Exitosa!!");
            }
            catch (Exception)
            {
                //MessageBox.Show("Error en la conexión. Error: "+ex.Message);
            }
        }

        //Función para Desconectar de la Base de datos
        public void Desconectar()
        {
            try
            {
                if(cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                    //MessageBox.Show("Conexión Cerrada!");
                }
                else
                {
                    //MessageBox.Show("No pudo cerrarse la Conexión!");
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("Error en la conexión. Error: " + ex.Message);
            }
        }
    }
}
