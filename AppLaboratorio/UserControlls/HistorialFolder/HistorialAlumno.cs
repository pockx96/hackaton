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
using SpreadsheetLight;

namespace AppLaboratorio.UserControlls.HistorialFolder
{
    public partial class HistorialAlumno : UserControl
    {
        PrestamosAlumnoController prestamosAlumnoServices = new PrestamosAlumnoController();
        
        public HistorialAlumno()
        {
            InitializeComponent();
        }

        private void TitleBar_Click(object sender, EventArgs e)
        {

        }

        private void Historial_Load(object sender, EventArgs e)
        {
            List<PrestamosAlumno> ListHerramienta = prestamosAlumnoServices.Get();
            prestamosAlumnoServices.Get();
            int index;
            foreach (PrestamosAlumno element in ListHerramienta)
            {
                index = DatagridHerramienta.RowCount;
                DatagridHerramienta.Rows.Insert(index, element.matricula, element.nombre, element.materia,element.Herramienta,element.cantidad,element.fecha_salida,element.fecha_regreso);
            }
        }

        private void txtBuscar__TextChanged(object sender, EventArgs e)
        {
            DatagridHerramienta.Rows.Clear();
            PrestamosAlumnoController prestamoAlumnosServices = new PrestamosAlumnoController();
            List<PrestamosAlumno> ListPrestamos = prestamoAlumnosServices.GetByHerramienta(txtBuscar.Texts);
            int index;
            foreach (PrestamosAlumno element in ListPrestamos)
            {
                index = DatagridHerramienta.RowCount;
                DatagridHerramienta.Rows.Insert(index, element.matricula, element.nombre, element.materia, element.Herramienta, element.cantidad, element.fecha_salida, element.fecha_regreso);
            }
        }

        private  void iconButton2_Click(object sender, EventArgs e)
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
                ir++;
            }
            sl.SaveAs(@"C:\Users\kriz_\Documents\.NETpracticas\AppLaboratorio\HistorialEmpleados.xlsx");
            MessageBox.Show("Guardado con exito");
        }

 


        public delegate void HistorialEmpleadoDelegate();
        public event HistorialEmpleadoDelegate Empleado;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDocentes_Click(object sender, EventArgs e)
        {
            if (Empleado != null)
            {
                Empleado();
            }
        }

        private void DatagridHerramienta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatagridHerramienta.CurrentRow.Selected = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }    
}
