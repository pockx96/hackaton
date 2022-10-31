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
    public partial class NuevoPrestamosEstudiantes : UserControl
    {
        public NuevoPrestamosEstudiantes()
        {
            InitializeComponent();
        }

        private void NuevoPrestamosEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string DateToday = DateTime.Now.ToString("dd-MM-yyyy");
            PrestamosAlumnoController empleadoController = new PrestamosAlumnoController();
            PrestamosAlumno prestamo = new PrestamosAlumno()
            {
                matricula = txtMatricula.Texts,
                nombre = txtNombre.Texts,
                materia = txtMateria.Texts,
                Herramienta=txtHerramienta.Texts,
                cantidad = txtCantidad.Texts,
                fecha_salida = DateToday,
                fecha_regreso = txtReingreso.Text
            };

            empleadoController.post(prestamo);
        }
    }

}

