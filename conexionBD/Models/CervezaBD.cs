using practicaUno.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexionBD.Models
{
    internal class CervezaBD
    {
        private string connectionString
            = "server=127.0.0.1;port=3307;database=world;uid=root;password=454848"; //Corregir esto.

        //"Data Source=pc82\\HEIDISQL;Initial Catalog=practicauno;Integrated Security=True;" //falta esto

        // server=server_address;port=3306;database=database_name;uid=username;password=password


        public List<Cerveza> getcervezas()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "selecct nombre, marca, alcohol, cantidad from cerveza";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int cantidad = reader.GetInt32(3);
                    string nombre = reader.GetString(0);
                    Cerveza cerveza = new Cerveza(cantidad, nombre);

                    cerveza.alcohol = reader.GetInt32(2);
                    cerveza.marca = reader.GetString(1);

                    cervezas.Add(cerveza);
                }

                reader.Close();
                connection.Close();
            }
            return cervezas;
        }
    }
}
