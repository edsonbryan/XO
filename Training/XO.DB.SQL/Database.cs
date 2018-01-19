using System;
using System.Collections.Generic;
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

        public List<Producto> GetProductos()
        {
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand("SELECT * FROM Producto", connection);
            var products = new List<Producto>();
            
            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var idTipo = reader.GetInt32(1);
                var nombre = reader.GetString(2);
                var precio = reader.GetDecimal(3);

                var product = new Producto
                {
                    Id = id,
                    IdTipo = idTipo,
                    Nombre = nombre,
                    Precio = precio
                };

                products.Add(product);
            }

            connection.Close();

            return products;
        }

        public List<TipoProducto> GetTipos()
        {
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand("SELECT * FROM TipoProducto", connection);
            var tipos = new List<TipoProducto>();

            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var id = reader.GetInt32(0);
                var descripcion = reader.GetString(1);

                var tipo = new TipoProducto
                {
                    Id = id,
                    Descripcion = descripcion
                };

                tipos.Add(tipo);
            }

            connection.Close();

            return tipos;
        }
    }
}
