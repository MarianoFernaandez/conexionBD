﻿using practicaUno.Models;
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
            = "Data Source=SQLSERVER\\SQLSERVER;Initial Catalog=bdg1;User=bdg1;Password=bdg1"; //user=bdg1;Password=bdg1;
        /*
            Data Source= ;
            Initial Catalog= ;
            User= ;v
            Password= ;
        */
        //    "DefaultConnection": "Server=DESKTOP-4UG60OM\\SQLEXPRESS;Database=expressions;Trusted_Connection=True;MultipleActiveResultSets=True;Encrypt=False"

        public List<Cerveza> getcervezas()
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            string query = "SELECT cantidad, nombre , alcohol , marca   FROM [bdg1].[db_owner].[cervezadb]";
             
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int cantidad = reader.GetInt32(3.);
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
