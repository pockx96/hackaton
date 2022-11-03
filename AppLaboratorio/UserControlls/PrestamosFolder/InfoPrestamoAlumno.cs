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
    public partial class InfoPrestamoAlumno : UserControl
    {
        public InfoPrestamoAlumno(PrestamosAlumno prestamo)
        {
            InitializeComponent();
            Alumno = prestamo;
        }



        private void NuevoUsuario_Load_1(object sender, EventArgs e)
        {
            PrimeraPagina();

        }

        string BtnState { get; set; }

        PrestamosAlumno Alumno = new PrestamosAlumno();
        public delegate void backDelegate();
        public event backDelegate Back;


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
            BtnGuardar.Enabled = true;
            BtnVolver.Enabled = false;
            Icon2.BackColor = Color.Silver;
            Icon2.ForeColor = Color.Black;
            Icon1.BackColor = Color.FromArgb(82, 122, 242);
            Icon1.ForeColor = Color.White;
            BtnState = "1";
            Lbl1.Text = "Matricula:";
            Txt1.Text = Alumno.matricula;
            Lbl2.Text = "Alumno:";
            Txt2.Text = Alumno.nombre;
            Lbl3.Visible = true;
            Lbl3.Text = "Herramienta:";
            Txt3.Visible = true;
            Txt3.Text = Alumno.Herramienta;
            Lbl4.Visible = true;
            Lbl4.Text = "Cantidad:";
            Txt4.Visible = true;
            Txt4.Text = Alumno.cantidad;


        }

        private void SegundaPagina()
        {
            BtnVolver.Enabled = true;
            Icon2.BackColor = Color.FromArgb(82, 122, 242);
            Icon2.ForeColor = Color.White;
            Icon1.BackColor = Color.Silver;
            Icon1.ForeColor = Color.Black;
            BtnState = "2";
            Lbl1.Text = "Fecha salida:";
            Txt1.Text = Alumno.fecha_salida;
            Lbl2.Text = "Alumno";
            Txt2.Text = Alumno.fecha_regreso;
            Lbl3.Visible = false;
            Txt3.Visible = false;
            Lbl4.Visible = false;
            Txt4.Visible = false;
            


            
        }



        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PrimeraPagina();        

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Txt5_Click(object sender, EventArgs e)
        {
        }
    }
}