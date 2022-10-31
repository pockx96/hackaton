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

            string query = $"select * from herramientas";

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
        public List<Herramienta> GetByLaboratorio(string laboratorio)
        {
            List<Herramienta> ListHerramienta = new List<Herramienta>();

            string query = $"select * from herramientas where laboratorio = '{laboratorio}'";

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

        public Herramienta Get(string id)
        {
            Herramienta herramienta = new Herramienta();
            string query = $"select * from herramientas where IdHerramienta = '{id}'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        herramienta.IdHerramienta = reader.GetInt32(0);
                        herramienta.herramienta = reader.GetString(1);
                        herramienta.marca = reader.GetString(2);
                        herramienta.modelo = reader.GetString(3);
                        herramienta.numero_serie = reader.GetString(4);
                        herramienta.cantidad = reader.GetString(5);
                        herramienta.descripcion = reader.GetString(6);
                        herramienta.laboratorio = reader.GetString(7);


                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return herramienta;

            }
        }

        public void Post(Herramienta herramienta)
        {
            int IdHerramienta = NewId();
            string nombre = herramienta.herramienta;
            string marca = herramienta.marca;
            string modelo = herramienta.modelo;
            string numero_serie = herramienta.numero_serie;
            string cantidad = herramienta.cantidad;
            string laboratorio = herramienta.laboratorio;
            string descripcion = herramienta.descripcion;

            string query = $"insert into herramientas(IdHerramienta, herramienta, marca, modelo,numero_serie,cantidad,laboratorio,descripcion) values('{IdHerramienta}','{nombre}','{marca}','{modelo}','{numero_serie}','{cantidad}','{laboratorio}','{descripcion}')";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }
            }
        }

        public void Delete(string id)
        {
            string query = $"delete from herramientas where Idherramienta = {id}";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();

                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

            }
        }

        private int NewId()
        {
            List<Herramienta> list = Get();
            int id = (list.Count)+1;
            return id;

        }

    }
}
