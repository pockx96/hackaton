using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLaboratorio.Controllers;
using AppLaboratorio.Models;

namespace AppLaboratorio.UserControlls.PrestamosFolder
{
    public partial class NuevoPrestamoEmpleado : UserControl
    {
        public NuevoPrestamoEmpleado()
        {
            InitializeComponent();
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            PrestamoEmpleadoController prestamo = new PrestamoEmpleadoController();
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string DateToday = DateTime.Now.ToString("dd-MM-yyyy");
            PrestamoEmpleadoController empleadoController = new PrestamoEmpleadoController();
            PrestamosEmpleados prestamo = new PrestamosEmpleados()
            {
                numero_de_control = Convert.ToInt32(TxtNumeroControl.Texts),
                nombre = TxtNombre.Texts,
                celular = TxtCelular.Texts,
                necesidad = TxtHerramienta.Texts,
                cantidad = TxtCantidad.Texts,
                fecha_salida = DateToday,
                fecha_regreso = TxtReingreso.Text
            };

            empleadoController.post(prestamo);
        }
    }
}
