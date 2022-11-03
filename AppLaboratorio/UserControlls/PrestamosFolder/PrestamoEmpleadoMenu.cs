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
using CustomMessageBox;

namespace AppLaboratorio.UserControlls.PrestamosFolder
{
    public partial class PrestamoEmpleadoMenu : UserControl 
    {
        public PrestamoEmpleadoMenu(string laboratorio)
        {
            InitializeComponent();
            Laboratorio = laboratorio;
        }
        public delegate void CrearDelegate();
        public event CrearDelegate Crear;
        public delegate void infoDelegado(PrestamosEmpleados prestamo);
        public event infoDelegado Info;
        public string Laboratorio { get; set; }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (Crear != null)
            {
                Crear();
            }
        }

        public delegate void EstudiantesDelegate();
        public event EstudiantesDelegate Estudiantes;

        private void BtnInformacion_Click(object sender, EventArgs e)
        {
            string id = DatagridEmpleados.CurrentRow.Cells[0].Value.ToString();
            PrestamoEmpleadoController empleadoController = new PrestamoEmpleadoController();
            PrestamosEmpleados prestamo = empleadoController.Get(id);
            if (Info != null)
            {
                Info(prestamo);
            }
        }

        private void PrestamoEmpleado_Load(object sender, EventArgs e)
        {
            DatagridEmpleados.Rows.Clear();
            LoadData();
            DatagridEmpleados.CurrentRow.Selected = true;
        }

        private void LoadData()
        {
            PrestamoEmpleadoController prestamoEmpleado = new PrestamoEmpleadoController();
            List<PrestamosEmpleados> list = prestamoEmpleado.Get();
            var ListSort = from p in list
                           where p.Estado == "Pendiente" 
                           where p.Laboratorio == Laboratorio
                           select p;

            int index;
            foreach (PrestamosEmpleados element in ListSort)
            {
                index = DatagridEmpleados.RowCount;
                DatagridEmpleados.Rows.Insert(index, element.numero_de_control, element.herramienta, element.fecha_salida,element.fecha_regreso);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {
            Estudiantes();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var result = RJMessageBox.Show("¿Desea confirmar esta devolución?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Devolucion();
            }
        }

        private void Devolucion()
        {
            string id = DatagridEmpleados.CurrentRow.Cells[0].Value.ToString();
            PrestamoEmpleadoController prestamosController = new PrestamoEmpleadoController();
            PrestamosEmpleados prestamosEmpleado = prestamosController.Get(id);
            prestamosEmpleado.Estado = "Finalizado";
            prestamosController.Update(prestamosEmpleado);

            string NuevaCantidad = prestamosController.SumaCantidad(prestamosEmpleado.cantidad, prestamosEmpleado.herramienta);

            HerramientaController herramientaController = new HerramientaController();
            List<Herramienta> ListHerramienta = herramientaController.Get();

            var HerramientaUpdate = from l in ListHerramienta
                                    where l.herramienta == prestamosEmpleado.herramienta
                                    select l;
            foreach (Herramienta herramienta in HerramientaUpdate)
            {
                herramienta.cantidad = NuevaCantidad;
                herramientaController.Update(herramienta);
            }


            DialogResult result = RJMessageBox.Show("Devolucion Exitosa" + " !.", "Exito!");
        }

        private void DatagridEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Animations animations = new Animations();
            Point Location = animations.BtnlocationDatagrid(DatagridEmpleados, 370, Cursor.Position.Y, new Point(449, 200), 12);
            ContainerOptions.Location = Location;
            DatagridEmpleados.CurrentRow.Selected = true;
        }
    }
}
