using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLaboratorio.Controllers;
using MySqlConnector;
using AppLaboratorio.Models;

namespace AppLaboratorio.Controllers
{
    public class PrestamosAlumnoController : Conexion
    {
        public List<PrestamosAlumno> Get()
        {
            List<PrestamosAlumno> lista = new List<PrestamosAlumno>();
            string query = "SELECT matricula,nombre,Herramienta,cantidad FROM lab_herramientas.prestamo_alumno;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        PrestamosAlumno prestamos = new PrestamosAlumno();
                        prestamos.matricula = reader.GetString(0);
                        prestamos.nombre = reader.GetString(1);
                        prestamos.Herramienta = reader.GetString(2);
                        prestamos.cantidad = reader.GetString(3);
                        lista.Add(prestamos);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

            }
            return lista;
        }
        public void post(PrestamosAlumno alumno)
        {
            string NumeroControl = alumno.matricula;
            string Nombre = alumno.nombre;
            string materia = alumno.materia;
            string Herramientas = alumno.Herramienta;
            string Cantidad = alumno.cantidad;
            string FechaSalida = alumno.fecha_salida;
            string FechaRegreso = alumno.fecha_regreso;

            string query = "insert into prestamo_alumno(matricula, Nombre, materia,Herramienta,Cantidad,Fecha_Salida,Fecha_Regreso) values" + "(@matricula, @Nombre, @materia,@Herramientas,@Cantidad,@FechaSalida,@FechaRegreso)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@matricula", NumeroControl);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@materia", materia);
                command.Parameters.AddWithValue("@Herramientas", Herramientas);
                command.Parameters.AddWithValue("@Cantidad", Cantidad);
                command.Parameters.AddWithValue("@FechaSalida", FechaSalida);
                command.Parameters.AddWithValue("@FechaRegreso", FechaRegreso);

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
