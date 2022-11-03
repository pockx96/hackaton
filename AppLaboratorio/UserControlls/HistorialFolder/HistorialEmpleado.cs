using SpreadsheetLight;
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

namespace AppLaboratorio.UserControlls.HistorialFolder
{
    public partial class HistorialEmpleado : UserControl
    {
        public HistorialEmpleado()
        {
            InitializeComponent();
        }
        public delegate void HistorialAlumnoDelegate();
        public event HistorialAlumnoDelegate Alumno;
        PrestamoEmpleadoController prestamoEmpleadoServices = new PrestamoEmpleadoController();
        private void HistorialEmpleado_Load(object sender, EventArgs e)
        {
            List<PrestamosEmpleados> prestamosEmpleados = prestamoEmpleadoServices.Get();
            prestamoEmpleadoServices.Get();
            int index;
            foreach (PrestamosEmpleados element in prestamosEmpleados)
            {
                index = DatagridHerramienta.RowCount;
                DatagridHerramienta.Rows.Insert(index, element.numero_de_control, element.nombre, element.celular, element.necesidad,element.herramienta, element.cantidad, element.fecha_salida, element.fecha_regreso);
            }
        }

        private void lblAlumnos_Click(object sender, EventArgs e)
        {
            if (Alumno != null)
            {
                Alumno();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            int ir = 2;
            int cl = 1;
            SLDocument sl = new SLDocument();
            SLStyle style = new SLStyle();
            style.Font.FontSize = 10;
            style.Font.Bold = true;
            foreach (DataGridViewColumn column in DatagridHerramienta.Columns)
            {
                sl.SetCellValue(1, cl, column.HeaderText.ToString());
                sl.SetCellStyle(1, cl, style);
                cl++;

            }

            foreach (DataGridViewRow row in DatagridHerramienta.Rows)
            {
                sl.SetCellValue(ir, 1, row.Cells[0].Value.ToString());
                sl.SetCellValue(ir, 2, row.Cells[1].Value.ToString());
                sl.SetCellValue(ir, 3, row.Cells[2].Value.ToString());
                sl.SetCellValue(ir, 4, row.Cells[3].Value.ToString());
                sl.SetCellValue(ir, 5, row.Cells[4].Value.ToString());
                sl.SetCellValue(ir, 6, row.Cells[5].Value.ToString());
                sl.SetCellValue(ir, 7, row.Cells[6].Value.ToString());
                sl.SetCellValue(ir, 8, row.Cells[7].Value.ToString());
                ir++;
            }
            sl.SaveAs(@"C:\Users\kriz_\Documents\.NETpracticas\AppLaboratorio\HistorialEmpleados.xlsx");
            MessageBox.Show("Guardado con exito");
        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            DatagridHerramienta.Rows.Clear();
            PrestamoEmpleadoController prestamoEmpleadoServices = new PrestamoEmpleadoController();
            List<PrestamosEmpleados> ListPrestamos = prestamoEmpleadoServices.GetByHerramienta(txtBuscar.Texts);
            int index;
            foreach (PrestamosEmpleados element in ListPrestamos)
            {
                index = DatagridHerramienta.RowCount;
                DatagridHerramienta.Rows.Insert(index, element.numero_de_control, element.nombre, element.celular, element.necesidad, element.herramienta, element.cantidad, element.fecha_salida, element.fecha_regreso);
            }
        }

        private void DatagridHerramienta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridHerramienta.CurrentRow.Selected = true;
        }
    }
}
