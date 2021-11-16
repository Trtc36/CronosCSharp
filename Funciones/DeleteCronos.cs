using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Funciones
{
    public class DeleteCronos
    {
        private const string newline = "\n\r";
        public static SqlConnection Conection;

        public static string BorrarUsuario(int idUsuario, SqlTransaction transaction_ext)
        {
            string psStatus = "";

            SqlCommand command = Conection.CreateCommand();
            SqlTransaction transaction = null;

            try
            {
                if (transaction_ext == null)
                    transaction = Conection.BeginTransaction();
                else
                    transaction = transaction_ext;

                command.Connection = Conection;
                command.Transaction = transaction;

               command.CommandText = "DELETE FROM USUARIO"+newline+
                                     "WHERE ID_Usuario = "+ idUsuario;

                command.ExecuteNonQuery();

                if (transaction_ext == null)
                    transaction.Commit();

                psStatus = "Sucessfull";
            }
            catch (Exception)
            {
                try
                {
                    if (transaction_ext == null)
                        transaction.Rollback();

                    psStatus = "Rollback";
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
