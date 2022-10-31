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
                        prestamos.numero_de_control = reader.GetInt32(0);
                        prestamos.nombre = reader.GetString(1);
                        prestamos.herramienta = reader.GetString(4);
                        prestamos.cantidad = reader.GetString(5);
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
            int NumeroControl = empleados.numero_de_control;
            string Nombre = empleados.nombre;
            string Celular = empleados.celular;
            string Ncecesidad = empleados.necesidad;
            string Herramientas = empleados.herramienta;
            string Cantidad = empleados.cantidad;
            string FechaSalida = empleados.fecha_salida;
            string FechaRegreso = empleados.fecha_regreso;

            string query = "insert into prestamo_empleado(Numero_de_Control, Nombre, Celular, Necesidad,Herramienta,Cantidad,Fecha_Salida,Fecha_Regreso) values" + "(@NumeroControl, @Nombre, @Celular, @Ncecesidad,@Herramientas,@Cantidad,@FechaSalida,@FechaRegreso)";
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