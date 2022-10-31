using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using AppLaboratorio.UserControlls;
using AppLaboratorio.Controllers;
using AppLaboratorio.Models;
namespace AppLaboratorio.UserControlls.PrestamosFolder
{
    public partial class PrestamoEstudiante : UserControl
    {
        public PrestamoEstudiante()
        {
            InitializeComponent();

        }

        private void ListaFolios_Load(object sender, EventArgs e)
        {
            ListaEntrada.Rows.Clear();
            PrestamosAlumnoController prestamoEStudiante = new PrestamosAlumnoController();
            List<PrestamosAlumno> list = prestamoEStudiante.Get();
            int idex;
            foreach (PrestamosAlumno prestamos in list)
            {
                idex = ListaEntrada.RowCount;
                ListaEntrada.Rows.Insert(idex, prestamos.matricula, prestamos.nombre, prestamos.Herramienta, prestamos.cantidad);
            }
        }

        public delegate void CrearDelegate();
        public event CrearDelegate Crear;
        public delegate void info();
        public event info informacion;
        public delegate void EmpleadosDelegate();
        public event EmpleadosDelegate Empleados;

        public void LoadData(string estado)
        {
            


        }


        


      

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (Crear!=null)
            {
                Crear();
            }
        }

        private void BtnInformacion_Click(object sender, EventArgs e)
        {
            if (informacion != null)
            {
                informacion();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Empleados();
        }
    }
}
