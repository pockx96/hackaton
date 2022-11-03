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
using System.Linq;

namespace AppLaboratorio.UserControlls.PrestamosFolder
{
    public partial class NuevoPrestamoEmpleado : UserControl
    {
        public NuevoPrestamoEmpleado(string laboratorio)
        {
            InitializeComponent();
            Laboratorio = laboratorio;
        }

        private void NuevoPrestamosEstudiantes_Load(object sender, EventArgs e)
        {
            PrimeraPagina();
            LoadCatalago();
        }

        public string Laboratorio { get; set; }
        string BtnState { get; set; }
        PrestamosEmpleados PrestamoEmpleado = new PrestamosEmpleados();
        public delegate void BackDelegate();
        public event BackDelegate Back;


        private void Clear()
        {
            TxtBox1.Text = "";
            TxtBox2.Text = "";
            TxtSalida.Text = "";
            TxtBox3.Texts = "";
            TxtCantidad.Value = 0;
        }



        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string DateToday = DateTime.Now.ToString("dd-MM-yyyy");
            switch (BtnState)
            {
                case "1":
                    PrestamoEmpleado.numero_de_control = TxtBox1.Texts;
                    PrestamoEmpleado.nombre = TxtBox2.Texts;
                    PrestamoEmpleado.celular = TxtBox3.Texts;
                    PrestamoEmpleado.necesidad = TxtBox4.Texts;
                    SegundaPagina();
                    break;
                case "2":
                    PrestamoEmpleado.herramienta= CmboxHerramienta.Text;
                    PrestamoEmpleado.cantidad = TxtCantidad.Value.ToString();
                    PrestamoEmpleado.fecha_regreso = TxtSalida.Text;
                    PrestamoEmpleado.fecha_salida = DateToday;
                    PrestamoEmpleado.Laboratorio = Laboratorio;

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
            Lbl1.Text = "No. Empleado:";
            TxtBox1.Visible = true;
            CmboxHerramienta.Visible = false;
            TxtBox1.PlaceholderText = "Numero de empleado del docente";
            Lbl2.Text = "Nombre:";
            TxtBox2.Visible = true;
            TxtBox2.PlaceholderText = "Nombre del docente";
            Lbl3.Text = "Celular:";
            TxtBox3.Visible = true;
            TxtBox3.PlaceholderText = "638-123-45-67";
            Lbl4.Text = "Motivo:";
            TxtBox4.PlaceholderText = "Motivo del prestamo";
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
            Lbl1.Text = "Herramienta:";
            TxtBox1.Visible = false;
            CmboxHerramienta.Visible = true;
            Lbl2.Text = "Cantidad:";
            TxtBox2.Visible = false;
            TxtCantidad.Visible = true;
            Lbl3.Text = "Fecha de Regreso";
            TxtSalida.Visible= true;
            TxtBox3.Visible = false;
            Lbl4.Visible = false;
            TxtBox4.Visible = false;
            BtnGuardar.Text = "Guardar";

        }
        private void GuardarHerramienta()
        {
            PrestamoEmpleadoController prestamoEmpleadoController = new PrestamoEmpleadoController();
            prestamoEmpleadoController.post(PrestamoEmpleado);

            string NuevaCantidad = prestamoEmpleadoController.RestaCantidad(PrestamoEmpleado.cantidad,PrestamoEmpleado.herramienta);

            HerramientaController herramientaController = new HerramientaController();
            List<Herramienta> ListHerramienta= herramientaController.Get();

            var HerramientaUpdate = from l in ListHerramienta
                                    where l.herramienta == PrestamoEmpleado.herramienta
                                    select l;
            foreach (Herramienta herramienta in HerramientaUpdate)
            {
                herramienta.cantidad = NuevaCantidad;
                herramientaController.Update(herramienta);
            }

                            
            DialogResult result = RJMessageBox.Show("Prestamo Realizado" + " !.", "Exito!");
            Back();
        }


        private void LoadCatalago()
        {
            HerramientaController herramientaController = new HerramientaController();
            List<Herramienta> ListHerramientas = herramientaController.GetByLaboratorio(Laboratorio);

            foreach (Herramienta herramienta in ListHerramientas)
            {
                CmboxHerramienta.Items.Add(herramienta.herramienta);
            }

        }
        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PrimeraPagina();
        }

        private void Icon1_Click(object sender, EventArgs e)
        {

        }

        private void Icon2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

}

