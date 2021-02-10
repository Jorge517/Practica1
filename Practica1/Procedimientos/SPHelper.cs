using Practica1.Clases;
using System.Data;
using System.Data.SqlClient;
namespace Practica1.Procedimientos
{
    public static class SPHelper

    {

        public static string InsertarUsuario(Usuario user)
        {
            //                               Servidor            Nombre de la base      
            string connString = "Data Source=DESKTOP-2S8MCND;Initial Catalog=tempdb;Integrated Security=True;";

            //Se le envia el parametro de la conneción (connString)
            SqlConnection connSQL = new SqlConnection(connString);


            try
            {

                //Inicializa
                connSQL.Open();
            
                        //Procedimiento almacenado          Procedimiento de SQLSERVER, Conexión
            SqlCommand cmdProcedimiento = new SqlCommand("InsertarUsuario", connSQL);

            {

                //Definir de que tipo es (StoredProcedure)
                cmdProcedimiento.CommandType = CommandType.StoredProcedure;
            }

            //Enviar los  parametros y el valor (Cadena de texto)  (nombre y como esta en la base)
            cmdProcedimiento.Parameters.AddWithValue("nombre", user.Nombre);
            cmdProcedimiento.Parameters.AddWithValue("email", user.Email);
            cmdProcedimiento.Parameters.AddWithValue("password", user.Password);

            //Ejecuta, no estoy esperando ningun valor (ExecuteNonQuery)
            cmdProcedimiento.ExecuteNonQuery();

            return "SI";
        }
        catch(SqlException sqlEx)
            {
             return "ERROR";
            }
            finally
            {
                //Finaliza
            connSQL.Close();
            }

        }
    }
}
