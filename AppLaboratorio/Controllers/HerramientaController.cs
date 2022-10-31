using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLaboratorio.Models;
using AppLaboratorio.Controllers;
using MySqlConnector;

namespace AppLaboratorio.Controllers
{
    public class HerramientaController:Conexion
    {
        public List<Herramienta> Get()
        {
            List<Herramienta> ListHerramienta = new List<Herramienta>();

            string query = "select * from herrramientas";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Herramienta herramienta = new Herramienta();
                        herramienta.IdHerramienta = reader.GetInt32(0);
                        herramienta.herramienta = reader.GetString(1);
                        herramienta.marca = reader.GetString(2);
                        herramienta.modelo = reader.GetString(3);
                        herramienta.numero_serie = reader.GetString(4);
                        herramienta.cantidad = reader.GetString(5);
                        herramienta.descripcion = reader.GetString(6);
                        herramienta.laboratorio = reader.GetString(7);
                        ListHerramienta.Add(herramienta);

                       
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return ListHerramienta;

            }
        }
    }
}
