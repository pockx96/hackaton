using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLaboratorio.Models;
using AppLaboratorio.Controllers;


namespace AppLaboratorio.UserControlls.PrestamosFolder
{
    public partial class InfoPrestamoEmpleado : UserControl
    {
        public InfoPrestamoEmpleado(PrestamosEmpleados prestamo)
        {
            InitializeComponent();
            Empleado = prestamo;

        }



        private void NuevoUsuario_Load_1(object sender, EventArgs e)
        {
            BtnState = "1";
            PrimeraPagina();

        }

        string BtnState { get; set; }

        PrestamosEmpleados Empleado = new PrestamosEmpleados();


        private void Clear()
        {
            Txt1.Text = "";
            Txt2.Text = "";
            Txt3.Text = "";
            Txt4.Text = "";

        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            switch (BtnState) 
            {
                case "1":
                    SegundaPagina();
                    break;
                case "2":
                    BtnGuardar.Enabled = false;
                    break;
            }
            
          
        }

        private void PrimeraPagina()
        {
            BtnVolver.Enabled = false;
            Icon2.BackColor = Color.Silver;
            Icon2.ForeColor = Color.Black;
            Icon1.BackColor = Color.FromArgb(82, 122, 242);
            Icon1.ForeColor = Color.White;
            BtnState = "1";
            Lbl1.Text = "No.Empleado:";
            Txt1.Text = Empleado.numero_de_control;
            Lbl2.Text = "Docente:";
            Txt2.Text = Empleado.nombre;
            Lbl3.Text = "Celular:";
            Txt3.Text = Empleado.celular;
            Lbl4.Visible = true;
            Lbl4.Text = "Herramienta:";
            Txt4.Visible = true;
            Txt4.Text = Empleado.herramienta;
            Lbl5.Visible = true;
            Lbl5.Text = "Cantidad:";
            Txt5.Visible = true;
            Txt5.Text = Empleado.cantidad;

        }

        private void SegundaPagina()
        {
            BtnVolver.Enabled = true;
            Icon2.BackColor = Color.FromArgb(82, 122, 242);
            Icon2.ForeColor = Color.White;
            Icon1.BackColor = Color.Silver;
            Icon1.ForeColor = Color.Black;
            BtnState = "2";
            Lbl1.Text = "Fecha de salida:";
            Txt1.Text = Empleado.fecha_salida;
            Lbl2.Text = "Fecha de regreso:";
            Txt2.Text = Empleado.fecha_regreso;
            Lbl3.Text = "Motivo del prestamo";
            Txt3.Text = Empleado.necesidad;
            Lbl4.Visible = false;
            Txt4.Visible = false;
            Lbl5.Visible = false;
            Txt5.Visible = false;


        }





        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PrimeraPagina();        

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}