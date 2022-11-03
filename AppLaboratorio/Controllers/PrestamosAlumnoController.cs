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
            string query = "SELECT * FROM lab_herramientas.prestamo_alumno;";

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
                        prestamos.materia = reader.GetString(2);
                        prestamos.Herramienta = reader.GetString(3);
                        prestamos.cantidad = reader.GetString(4);
                        prestamos.fecha_salida = reader.GetString(5);
                        prestamos.fecha_regreso = reader.GetString(6);
                        prestamos.Estado = reader.GetString(7);
                        prestamos.Laboratprio = reader.GetString(8);
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
        public PrestamosAlumno Get(string id)
        {
            PrestamosAlumno prestamos = new PrestamosAlumno();
            string query = $"SELECT * FROM lab_herramientas.prestamo_alumno where matricula = '{id}'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        prestamos.matricula = reader.GetString(0);
                        prestamos.nombre = reader.GetString(1);
                        prestamos.materia = reader.GetString(2);
                        prestamos.Herramienta = reader.GetString(3);
                        prestamos.cantidad = reader.GetString(4);
                        prestamos.fecha_salida = reader.GetString(5);
                        prestamos.fecha_regreso = reader.GetString(6);
                        prestamos.Estado = reader.GetString(7);
                        prestamos.Laboratprio = reader.GetString(8);

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("error de la base de datos : " + ex);

                }

            }
            return prestamos;
        }
        public List<PrestamosAlumno> GetByHerramienta(string lab)
        {
            List<PrestamosAlumno> lista = new List<PrestamosAlumno>();
            string query = "SELECT * FROM prestamo_alumno where herramienta like '%" + lab + "%'";

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
                        prestamos.materia = reader.GetString(2);
                        prestamos.Herramienta = reader.GetString(3);
                        prestamos.cantidad = reader.GetString(4);
                        prestamos.fecha_salida = reader.GetString(5);
                        prestamos.fecha_regreso = reader.GetString(6);
                        prestamos.Estado = reader.GetString(7);
                        prestamos.Laboratprio = reader.GetString(8);

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
            string Estado = "Pendiente";
            string Laborario = alumno.Laboratprio;

            string query = "insert into prestamo_alumno(matricula, Nombre, materia,Herramienta,Cantidad,Fecha_Salida,Fecha_Regreso,Estado,Lab) values" + "(@matricula, @Nombre, @materia,@Herramientas,@Cantidad,@FechaSalida,@FechaRegreso,@Estado,@Laborario)";
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
                command.Parameters.AddWithValue("@Estado", Estado);
                command.Parameters.AddWithValue("@Laborario", Laborario);

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

        public void Update(PrestamosAlumno empleados)
        {
            string NumeroControl = empleados.matricula;
            string Nombre = empleados.nombre;
            string Herramientas = empleados.Herramienta;
            string Cantidad = empleados.cantidad;
            string FechaSalida = empleados.fecha_salida;
            string FechaRegreso = empleados.fecha_regreso;
            string Estadp = empleados.Estado;

            string query = $"update prestamo_alumno set Estado='{Estadp}' where numero_de_control = '{NumeroControl}'";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NumeroControl", NumeroControl);
                command.Parameters.AddWithValue("@Nombre", Nombre);
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


        public string RestaCantidad(string CantidadResta, string herramientaName)
        {
            string CantidadTotalString = "";
            HerramientaController herramientaController = new HerramientaController();
            List<Herramienta> ListaHerramienta = herramientaController.Get();

            var herramienta = from l in ListaHerramienta
                              where l.herramienta == herramientaName
                              select l;
            foreach (Herramienta element in herramienta)
            {
                int CantidadActual = Convert.ToInt32(element.cantidad);
                int CantidaTotal = CantidadActual - Convert.ToInt32(CantidadResta);
                CantidadTotalString = CantidaTotal.ToString();
            }

            return CantidadTotalString;

        }

        public string SumaCantidad(string CantidadSuma, string herramientaName)
        {
            string CantidadTotalString = "";
            HerramientaController herramientaController = new HerramientaController();
            List<Herramienta> ListaHerramienta = herramientaController.Get();

            var herramienta = from l in ListaHerramienta
                              where l.herramienta == herramientaName
                              select l;
            foreach (Herramienta element in herramienta)
            {
                int CantidadActual = Convert.ToInt32(element.cantidad);
                int CantidaTotal = CantidadActual + Convert.ToInt32(CantidadSuma);
                CantidadTotalString = CantidaTotal.ToString();
            }

            return CantidadTotalString;

        }
    }
}
