using System;
using System.Data.SqlClient;

namespace XO.DB.SQL
{
    public class Database
    {
        public const string connectionString = "Data Source=.;Initial Catalog=rainbow;Integrated Security=True";

        public void TestConnection()
        {
            var connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                connection.Close();
            }
            catch (Exception ex)
            {
            }
        }

        public void PrintData()
        {
            var connection = new SqlConnection(connectionString);                        
            var command = new SqlCommand("SELECT * FROM Producto", connection);

            connection.Open();
            var reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                Console.WriteLine($"{reader.GetInt32(0)} / {reader.GetString(2)} / {reader.GetDecimal(3)}");
            }

            connection.Close();
        }
    }
}
