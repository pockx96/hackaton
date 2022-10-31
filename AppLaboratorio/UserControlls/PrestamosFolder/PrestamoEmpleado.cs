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
    public partial class PrestamoEmpleado : UserControl
    {
        public PrestamoEmpleado()
        {
            InitializeComponent();
        }
        public delegate void CrearDelegate();
        public event CrearDelegate Agg;
        public delegate void inf();
        public event inf info;
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (Agg != null)
            {
                Agg();
            }
        }

        public delegate void EstudiantesDelegate();
        public event EstudiantesDelegate Estudiantes;

        private void BtnInformacion_Click(object sender, EventArgs e)
        {
            if (info != null)
            {
                info();
            }
        }

        private void PrestamoEmpleado_Load(object sender, EventArgs e)
        {
            ListaEntrada.Rows.Clear();
            PrestamoEmpleadoController prestamoEmpleado = new PrestamoEmpleadoController();
            List<PrestamosEmpleados> list= prestamoEmpleado.Get();
            int idex;
            foreach (PrestamosEmpleados prestamos in list)
            {
                idex = ListaEntrada.RowCount ;
                ListaEntrada.Rows.Insert(idex,prestamos.numero_de_control,prestamos.nombre,prestamos.herramienta,prestamos.cantidad);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Estudiantes();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
