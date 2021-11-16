using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Funciones
{
    public class SelectCronos
    {
        //Variables para las funciones
        private string newline = "\r\n";
        public SqlConnection Conection;

        //Función para buscar un usuario dentro de la base de datos basado en su Código
        public DataTable BuscarUsuario(string codigo, SqlTransaction transaction_ext)
        {
            DataTable ds = new DataTable();
            try
            {
                //cnx.Conectar();
                string myQuery = "SELECT u.ID_Usuario as IdUsuario, u.Codigo, u.ID_Empleado, e.Nombre, e.Paterno, e.Materno," + newline +
                                 "       u.Usuario, u.Password, u.ID_Permisos, p.Tipo_Permiso AS Permiso, u.Estatus" + newline +
                                 "FROM USUARIO u" + newline +
                                 "INNER JOIN EMPLEADO e ON u.ID_Empleado = e.ID_Empleado" + newline +
                                 "INNER JOIN PERMISO p ON u.ID_Permisos = p.ID_Permiso" + newline +
                                 "WHERE u.Codigo = '" + codigo + "'";
                SqlDataAdapter myAdapter = new SqlDataAdapter(myQuery, Conection);

                if (transaction_ext != null)
                    myAdapter.SelectCommand.Transaction = transaction_ext;

                myAdapter.Fill(ds);
                return ds;

            }
            catch (SqlException )
            {
                //MessageBox.Show("Error: "+ex.Message);
                return null;
            }
            finally
            {
                //cnx.Desconectar();
            }
        }

        //Función que devuelve el número de usuarios registrados, para generar el consecutivo en el código
        public DataTable GenerarUsuario(SqlTransaction transaction_ext)
        {
            DataTable dt = new DataTable();
            try
            {
                string myQuery = "SELECT COUNT(*) FROM USUARIO";
                SqlDataAdapter myAdapter = new SqlDataAdapter(myQuery, Conection);

                if (transaction_ext != null)
                    myAdapter.SelectCommand.Transaction = transaction_ext;

                myAdapter.Fill(dt);
                return dt;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        //Función para agregar el Empleado cuando se registra uno nuevo, para no permitir que el usuario lo teclee
        public DataTable AgregarEmpleado(string idEmpleado, SqlTransaction transaction_ext)
        {
            DataTable dt = new DataTable();
            try
            {
                string myQuery = "SELECT e.Nombre, e.Paterno, e.Materno" + newline +
                                 "FROM EMPLEADO e" + newline +
                                 "WHERE e.ID_Empleado = " + idEmpleado;
                SqlDataAdapter myAdapter = new SqlDataAdapter(myQuery, Conection);

                if (transaction_ext != null)
                    myAdapter.SelectCommand.Transaction = transaction_ext;

                myAdapter.Fill(dt);
                return dt;
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        //Función para agregar el Permiso cuando se registra uno nuevo, para no permitir que el usuario lo teclee
        public DataTable AgregarPermiso(string idPermiso, SqlTransaction transaction_ext)
        {
            DataTable dt = new DataTable();
            try
            {
                string myQuery = "SELECT p.Tipo_Permiso" + newline +
                                 "FROM PERMISO p" + newline +
                                 "WHERE p.ID_Permiso = " + idPermiso;
                SqlDataAdapter myAdapter = new SqlDataAdapter(myQuery, Conection);

                if (transaction_ext != null)
                    myAdapter.SelectCommand.Transaction = transaction_ext;

                myAdapter.Fill(dt);
                return dt;
            }
            catch (SqlException)
            {
                return null;
            }
        }


        //Validación de Login de Usuario
        public DataTable ValidarUsuario(string Usuario, string Password, SqlTransaction transaction_ext)
        {
            DataTable dt = new DataTable();
            try
            {
                string myQuery = "SELECT u.Usuario, u.Password" + newline +
                                 "FROM USUARIO u" + newline +
                                 "WHERE u.Usuario = '" + Usuario + "' and u.Password = '" + Password + "'";

                SqlDataAdapter myAdapter = new SqlDataAdapter(myQuery, Conection);

                if (transaction_ext != null)
                    myAdapter.SelectCommand.Transaction = transaction_ext;

                myAdapter.Fill(dt);
                return dt;
            }
            catch (SqlException)
            {
                return null;
            }
        }
        
    }
}
