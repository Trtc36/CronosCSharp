using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Funciones
{
    public class InsertCronos
    {

        private const string newline = "\r\n";
        public static SqlConnection Conection;

        public static string GuardarUsuario(string codigo, string usuario, string password, int idEmpleado, int idPermiso, int estatus, SqlTransaction transaction_ext)
        {
            string psStatus = "";

            SqlCommand command = Conection.CreateCommand();
            SqlTransaction transaction;

            if (transaction_ext == null)
                transaction = Conection.BeginTransaction("CronosSave");
            else
                transaction = transaction_ext;


            try
            {
                command.Connection = Conection;
                command.Transaction = transaction;

                command.CommandText = "INSERT INTO USUARIO(Codigo, Usuario, Password, ID_Empleado, ID_Permisos, Estatus)" + newline +
                                      "VALUES('" + codigo + "','" + usuario + "','" + password + "'," + idEmpleado + "," + idPermiso + "," + estatus + ")";

                command.ExecuteNonQuery();

                if (transaction_ext == null)
                    transaction.Commit();

                psStatus = "Successful";
            }
            catch (System.Exception ex)
            {
                try
                {
                    if (transaction_ext == null)
                        transaction.Rollback();
                    psStatus = "Rollback: ";
                }
                catch (System.Exception)
                {
                    psStatus = "Error Rollback";
                }
            }

            return psStatus;

        }
    }
}
