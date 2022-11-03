using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLaboratorio.Models;
using AppLaboratorio.Controllers;

namespace AppLaboratorio.Controllers
{
    public class PrestamoEmpleadoController : Conexion
    {
        public List<PrestamosEmpleados> Get()
        {
            List<PrestamosEmpleados> lista = new List<PrestamosEmpleados>();
            string query = "SELECT * FROM prestamo_empleado";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        PrestamosEmpleados prestamos = new PrestamosEmpleados();
                        prestamos.numero_de_control = reader.GetString(0);
                        prestamos.nombre = reader.GetString(1);
                        prestamos.celular = reader.GetString(2);
                        prestamos.necesidad = reader.GetString(3);
                        prestamos.herramienta = reader.GetString(4);
                        prestamos.cantidad = reader.GetString(5);
                        prestamos.fecha_salida = reader.GetString(6);
                        prestamos.fecha_regreso = reader.GetString(7);
                        prestamos.Estado = reader.GetString(8);
                        prestamos.Laboratorio = reader.GetString(9);

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
        public PrestamosEmpleados Get(string id)
        {
            PrestamosEmpleados prestamos = new PrestamosEmpleados();
            string query = $"SELECT * FROM prestamo_empleado where numero_de_control = '{id}'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        prestamos.numero_de_control = reader.GetString(0);
                        prestamos.nombre = reader.GetString(1);
                        prestamos.celular = reader.GetString(2);
                        prestamos.necesidad = reader.GetString(3);
                        prestamos.herramienta = reader.GetString(4);
                        prestamos.cantidad = reader.GetString(5);
                        prestamos.fecha_salida = reader.GetString(6);
                        prestamos.fecha_regreso = reader.GetString(7);
                        prestamos.Estado = reader.GetString(8);
                        prestamos.Laboratorio = reader.GetString(9);

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

        public List<PrestamosEmpleados> GetByLaboratorio(string lab)
        {
            List<PrestamosEmpleados> lista = new List<PrestamosEmpleados>();
            string query = $"SELECT * FROM prestamo_empleado where Laboratorio = {lab}'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        PrestamosEmpleados prestamos = new PrestamosEmpleados();
                        prestamos.numero_de_control = reader.GetString(0);
                        prestamos.nombre = reader.GetString(1);
                        prestamos.celular = reader.GetString(2);
                        prestamos.necesidad = reader.GetString(3);
                        prestamos.herramienta = reader.GetString(4);
                        prestamos.cantidad = reader.GetString(5);
                        prestamos.fecha_salida = reader.GetString(6);
                        prestamos.fecha_regreso = reader.GetString(7);
                        prestamos.Estado = reader.GetString(8);
                        prestamos.Laboratorio = reader.GetString(9);
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

        public List<PrestamosEmpleados> GetByHerramienta(string lab)
        {
            List<PrestamosEmpleados> lista = new List<PrestamosEmpleados>();
            string query = "SELECT * FROM prestamo_empleado where herramienta like '%" + lab + "%'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        PrestamosEmpleados prestamos = new PrestamosEmpleados();
                        prestamos.numero_de_control = reader.GetString(0);
                        prestamos.nombre = reader.GetString(1);
                        prestamos.celular = reader.GetString(2);
                        prestamos.necesidad = reader.GetString(3);
                        prestamos.herramienta = reader.GetString(4);
                        prestamos.cantidad = reader.GetString(5);
                        prestamos.fecha_salida = reader.GetString(6);
                        prestamos.fecha_regreso = reader.GetString(7);
                        prestamos.Estado = reader.GetString(8);
                        prestamos.Laboratorio = reader.GetString(9);
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
        public void post(PrestamosEmpleados empleados)
        {
            string NumeroControl = empleados.numero_de_control;
            string Nombre = empleados.nombre;
            string Celular = empleados.celular;
            string Ncecesidad = empleados.necesidad;
            string Herramientas = empleados.herramienta;
            string Cantidad = empleados.cantidad;
            string FechaSalida = empleados.fecha_salida;
            string FechaRegreso = empleados.fecha_regreso;
            string Estado = "Pendiente";
            string Laborario = empleados.Laboratorio;

            string query = "insert into prestamo_empleado(Numero_de_Control, Nombre, Celular, Necesidad,Herramienta,Cantidad,Fecha_Salida,Fecha_Regreso,Estado,Lab) values" + "(@NumeroControl, @Nombre, @Celular, @Ncecesidad,@Herramientas,@Cantidad,@FechaSalida,@FechaRegreso,@Estado,@Laborario)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NumeroControl", NumeroControl);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Celular", Celular);
                command.Parameters.AddWithValue("@Ncecesidad", Ncecesidad);
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

        public void Update(PrestamosEmpleados empleados)
        {
            string NumeroControl = empleados.numero_de_control;
            string Nombre = empleados.nombre;
            string Celular = empleados.celular;
            string Ncecesidad = empleados.necesidad;
            string Herramientas = empleados.herramienta;
            string Cantidad = empleados.cantidad;
            string FechaSalida = empleados.fecha_salida;
            string FechaRegreso = empleados.fecha_regreso;
            string Estadp = empleados.Estado;
            string Laborario = empleados.Laboratorio;

            string query = $"update prestamo_empleado set Estado='{Estadp}' where numero_de_control = '{NumeroControl}'";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NumeroControl", NumeroControl);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Celular", Celular);
                command.Parameters.AddWithValue("@Ncecesidad", Ncecesidad);
                command.Parameters.AddWithValue("@Herramientas", Herramientas);
                command.Parameters.AddWithValue("@Cantidad", Cantidad);
                command.Parameters.AddWithValue("@FechaSalida", FechaSalida);
                command.Parameters.AddWithValue("@FechaRegreso", FechaRegreso);
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