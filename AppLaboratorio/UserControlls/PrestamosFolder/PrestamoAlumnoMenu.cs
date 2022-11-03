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
using CustomMessageBox;
namespace AppLaboratorio.UserControlls.PrestamosFolder
{
    public partial class PrestamoAlumnoMenu : UserControl 
    {
        public PrestamoAlumnoMenu(string laboratorio)
        {
            InitializeComponent();
            Laboratorio = laboratorio;
        }

        private void ListaFolios_Load(object sender, EventArgs e)
        {
            DatagridAlumno.Rows.Clear();
            LoadData();
            DatagridAlumno.CurrentRow.Selected = true;

        }
        public string Laboratorio { get; set; }
        public delegate void CrearDelegate();
        public event CrearDelegate Crear;
        public delegate void info(PrestamosAlumno prestamos);
        public event info informacion;
        public delegate void EmpleadosDelegate();
        public event EmpleadosDelegate Empleados;

        public void LoadData()
        {

            PrestamosAlumnoController prestamoEStudiante = new PrestamosAlumnoController();
            List<PrestamosAlumno> list = prestamoEStudiante.Get();

            var ListSort = from p in list
                           where p.Estado == "Pendiente"
                           where p.Laboratprio == Laboratorio
                           select p;
            int idex;

            foreach (PrestamosAlumno prestamos in ListSort)
            {
                idex = DatagridAlumno.RowCount;
                DatagridAlumno.Rows.Insert(idex, prestamos.matricula, prestamos.nombre, prestamos.Herramienta, prestamos.cantidad);
            }


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
            string id = DatagridAlumno.CurrentRow.Cells[0].Value.ToString();
            PrestamosAlumnoController prestamosController = new PrestamosAlumnoController();
            PrestamosAlumno prestamosAlumno = prestamosController.Get(id);
            if (informacion != null)
            {
                informacion(prestamosAlumno);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Empleados();
        }

        private void DatagridAlumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Animations animations = new Animations();
            Point Location = animations.BtnlocationDatagrid(DatagridAlumno, 356, Cursor.Position.Y, new Point(488, 181), 12);
            ContainerOptions.Location = Location;
            DatagridAlumno.CurrentRow.Selected = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var result = RJMessageBox.Show("¿Desea confirmar esta devolución?","Advertencia",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Devolucion();
            }
        }

        private void Devolucion()
        {
            string id = DatagridAlumno.CurrentRow.Cells[0].Value.ToString();
            PrestamosAlumnoController prestamosController = new PrestamosAlumnoController();
            PrestamosAlumno prestamosAlumno = prestamosController.Get(id);
            prestamosAlumno.Estado = "Finalizado";
            prestamosController.Update(prestamosAlumno);

            string NuevaCantidad = prestamosController.SumaCantidad(prestamosAlumno.cantidad, prestamosAlumno.Herramienta);

            HerramientaController herramientaController = new HerramientaController();
            List<Herramienta> ListHerramienta = herramientaController.Get();

            var HerramientaUpdate = from l in ListHerramienta
                                    where l.herramienta == prestamosAlumno.Herramienta
                                    select l;
            foreach (Herramienta herramienta in HerramientaUpdate)
            {
                herramienta.cantidad = NuevaCantidad;
                herramientaController.Update(herramienta);
            }


            DialogResult result = RJMessageBox.Show("Devolucion Exitosa" + " !.", "Exito!");
        }
    }
}
