using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Funciones
{
    public class UpdateCronos
    {
        private const string newline = "\n\r";
        public static SqlConnection Conection;

        public static string ActualizarUsuario(int idUsuario, string codigo, string usuario, string password, int idEmpleado, int idPermiso, int estatus, SqlTransaction transaction_ext)
        {
            string psStatus = "";

            SqlCommand command = Conection.CreateCommand();
            SqlTransaction transaction;

            if (transaction_ext == null)
                transaction = Conection.BeginTransaction("CronosUpdate");
            else
                transaction = transaction_ext;

            try
            {
                command.Connection = Conection;
                command.Transaction = transaction;

                command.CommandText = "UPDATE USUARIO" + newline +
                                      "SET Codigo = '" + codigo + "'," + newline +
                                      "Usuario = '" + usuario + "'," + newline +
                                      "Password = '" + password + "'," + newline +
                                      "ID_Empleado =" + idEmpleado +","+ newline +
                                      "ID_Permisos = " + idPermiso +","+ newline +
                                      "Estatus = " + estatus + newline +
                                      "WHERE ID_Usuario =" + idUsuario;
                command.ExecuteNonQuery();

                if (transaction_ext == null)
                    transaction.Commit();

                psStatus = "Successful";
            }
            catch (Exception EX)
            {
                try
                {
                    if (transaction_ext == null)
                        transaction.Rollback();

                    psStatus = "Rollback" + EX.Message;
                }
                catch (Exception)
                {
                    psStatus = "Error Rollback";
                }
            }

            return psStatus;
        }

    }
}
