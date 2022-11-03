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
    public partial class NuevoPrestamosAlumno : UserControl
    {
        public NuevoPrestamosAlumno(string laboratorio)
        {
            InitializeComponent();
            Laboratorio = laboratorio;
        }

        private void NuevoPrestamosEstudiantes_Load(object sender, EventArgs e)
        {
            PrimeraPagina();
        }


        string BtnState { get; set; }
        PrestamosAlumno PrestamoAlumno = new PrestamosAlumno();
        public delegate void BackDelegate();
        public event BackDelegate Back;
        public string Laboratorio { get; set; }

        private void Clear()
        {
            TxtBoxArriba.Text = "";
            TxtBoxMedio.Text = "";
            TxtSalida.Text = "";
            TxtBoxAbajo.Texts = "";
            TxtCantidad.Value = 0;
        }



        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string DateToday = DateTime.Now.ToString("dd-MM-yyyy");
            switch (BtnState)
            {
                case "1":
                    PrestamoAlumno.matricula = TxtBoxArriba.Texts;
                    PrestamoAlumno.nombre = TxtBoxMedio.Texts;
                    PrestamoAlumno.materia = TxtBoxAbajo.Texts;
                    SegundaPagina();
                    break;
                case "2":
                    PrestamoAlumno.Herramienta= TxtBoxArriba.Texts;
                    PrestamoAlumno.cantidad = TxtCantidad.Value.ToString();
                    PrestamoAlumno.fecha_regreso = TxtSalida.Text;
                    PrestamoAlumno.fecha_salida = DateToday;
                    PrestamoAlumno.Laboratprio = Laboratorio;

                    GuardarHerramienta();
                    break;
            }
        }

        private void PrimeraPagina()
        {
            Icon1.BackColor = Color.FromArgb(82, 122, 242);
            Icon1.ForeColor = Color.White;
            Icon2.BackColor = Color.Silver;
            Icon2.ForeColor = Color.Black;
            BtnState = "1";
            BtnVolver.Enabled = false;
            LblArriba.Text = "Matricula:";
            TxtBoxArriba.PlaceholderText = "Matricula del alumno";
            LblMedio.Text = "Nombre";
            TxtBoxMedio.Visible = true;
            TxtBoxMedio.PlaceholderText = "Nombre completo del alumno";
            LblAbajo.Text = "Materia";
            TxtBoxAbajo.Visible = true;
            TxtBoxAbajo.PlaceholderText = "Materia para la que solicita";
            TxtCantidad.Visible = false;
            TxtSalida.Visible = false;
            BtnGuardar.Text = "Siguiente";

        }

        private void SegundaPagina()
        {
            BtnVolver.Enabled = true;
            Icon1.BackColor = Color.Silver;
            Icon1.ForeColor = Color.Black;
            Icon2.BackColor = Color.FromArgb(82, 122, 242);
            Icon2.ForeColor = Color.White;
            BtnState = "2";
            LblArriba.Text = "Herramienta:";
            TxtBoxArriba.PlaceholderText = "Herramienta solicitada";
            LblMedio.Text = "Cantidad:";
            TxtBoxMedio.Visible = false;
            TxtCantidad.Visible = true;
            LblAbajo.Text = "Fecha de Regreso";
            TxtSalida.Visible= true;
            TxtBoxAbajo.Visible = false;
            BtnGuardar.Text = "Guardar";

        }
        private void GuardarHerramienta()
        {
            PrestamosAlumnoController prestamosAlumnoController = new PrestamosAlumnoController();
            prestamosAlumnoController.post(PrestamoAlumno);

            string NuevaCantidad = prestamosAlumnoController.RestaCantidad(PrestamoAlumno.cantidad, PrestamoAlumno.Herramienta);

            HerramientaController herramientaController = new HerramientaController();
            List<Herramienta> ListHerramienta = herramientaController.Get();

            var HerramientaUpdate = from l in ListHerramienta
                                    where l.herramienta == PrestamoAlumno.Herramienta
                                    select l;
            foreach (Herramienta herramienta in HerramientaUpdate)
            {
                herramienta.cantidad = NuevaCantidad;
                herramientaController.Update(herramienta);
            }


            DialogResult result = RJMessageBox.Show("Prestamo Realizado" + " !.", "Exito!");
            Back();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PrimeraPagina();
        }
    }

}

