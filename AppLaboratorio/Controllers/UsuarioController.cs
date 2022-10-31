using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AppLaboratorio.Models;
using AppLaboratorio.Controllers;
using MySqlConnector;

namespace AppLaboratorio.Controllers
{
    public class UsuarioController : Conexion
    {

        public List<Usuarios> Get()
        {
            List<Usuarios> ListUsuarios = new List<Usuarios>();

            string query = "select * from administradores";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                Encrypt encrypt = new Encrypt();
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Usuarios Usuarios = new Usuarios();
                        Usuarios.id_usuario = reader.GetString(0).Replace(" ", "");
                        Usuarios.nombre_usuario = reader.GetString(1);
                        Usuarios.password = reader.GetString(2);
                        ListUsuarios.Add(Usuarios);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return ListUsuarios;

            }
        }


        public Usuarios Get(string id)
        {
            Usuarios Usuarios = new Usuarios();

            string query = "select * from administradores where IdAdminitrador = '" + id + "' ";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                Encrypt encrypt = new Encrypt();
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Usuarios.id_usuario = reader.GetString(0).Replace(" ", "");
                        Usuarios.Laboratorio = reader.GetString(1);
                        Usuarios.password = reader.GetString(2);
                        Usuarios.nombre_usuario = reader.GetString(3);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

                return Usuarios;

            }
        }
        public void Post(Usuarios usuarios)
        {
            Encrypt encrypt = new Encrypt();
            string IdUsuario = usuarios.id_usuario;
            string NombreUsuario = usuarios.nombre_usuario;
            string Laboratorio = usuarios.Laboratorio;
            string PasswordUsuario = usuarios.password;
            string query = "insert into administradores(IdAdminitrador, Laboratorio, NombreAdministrador, PasswordAdministrador) values" + "(@IdUsuario, @Laboratorio, @NombreUsuario, @PasswordUsuario)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                command.Parameters.AddWithValue("@Laboratorio", Laboratorio);
                command.Parameters.AddWithValue("@NombreUsuario", NombreUsuario);
                command.Parameters.AddWithValue("@PasswordUsuario", PasswordUsuario);

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

        public void Update(Usuarios usuario)
        {
            Encrypt encrypt = new Encrypt();
            string id = usuario.id_usuario;
            string Nombre = usuario.nombre_usuario;
            string pass = encrypt.EncryptWord(usuario.password);
            string query = "update Usuario set NombreUsuario='" + Nombre + "',PasswordUsuario='" + pass + "' where IdUsuario = '" + id + "';";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch(Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);
                }
 
            }
        }

        public void Delete(string id)
        {
            string query = $"delete from Usuario where IdUsuario = '{id}'";

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

    }
}
