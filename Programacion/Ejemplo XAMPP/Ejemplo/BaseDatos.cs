using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
namespace academia_03data
{
    static class BaseDatos
    {
        static public string Error { get; set; }
        static public int NumRegModif { set; get; }
        static private MySqlConnection Conectar()
        {
            string cad = "datasource=127.0.0.1; port=3306; username=root; password=; database=academia;";
            MySqlConnection conexionBD = new MySqlConnection(cad);
            return (conexionBD);
        }
        static public DataTable Consulta(string sql)
        {
            MySqlConnection conexionBD = Conectar();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexionBD);
            try
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                NumRegModif = 0;
                Error = "";
                return (ds.Tables[0]);
            }
            catch (Exception e)
            {
                Error = e.Message;
                NumRegModif = -1;
                return (null);
            }
            finally { conexionBD.Close(); }
        }
        static public int Modificacion(string sql)
        {
            MySqlConnection conexionBD = Conectar();
            do
            {
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    conexionBD.Open();
                    NumRegModif = comando.ExecuteNonQuery();
                    Error = "";
                    return NumRegModif;
                }
                catch (MySqlException ex)
                {
                    Error = ex.Message;
                    NumRegModif = -1;
                    return NumRegModif;
                }
                finally { conexionBD.Close(); }


            } while (conexionBD.Equals(""));
        }
    }
}