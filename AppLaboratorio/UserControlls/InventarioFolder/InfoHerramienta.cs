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
using AppLaboratorio.Controllers;
using AppLaboratorio.UserControlls;
using AppLaboratorio.Models;


namespace AppLaboratorio.UserControlls.InventarioFolder
{
    public partial class infoInventario : UserControl
    {
        public infoInventario()
        {
            InitializeComponent();
            

        }


        private void NuevoUsuario_Load_1(object sender, EventArgs e)
        {

            BtnState = "1";
            Txt1.Text = Herramienta.herramienta;
            Txt2.Text = Herramienta.descripcion;
            Txt3.Text = Herramienta.cantidad;
            Txt4.Text = Herramienta.laboratorio;
        }

        public delegate void BackDelegate();
        public event BackDelegate Back;

        string BtnState { get; set; }
        public Herramienta Herramienta { get; set; }




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
                    GuardarHerramienta();
                    break;
            }
            
          
        }

        private void PrimeraPagina()
        {
            BtnVolver.Enabled = false;
            Lbl1.Text = "Herramienta";
            Lbl2.Text = "Descripción";
            Lbl3.Text = "Cantidad";
            Lbl4.Text = "Laboratorio";
            Lbl4.Visible = true;

            Txt1.Text = Herramienta.herramienta;
            Txt2.Text = Herramienta.descripcion;
            Txt3.Text = Herramienta.cantidad;
            Txt4.Text = Herramienta.laboratorio;
            Icon2.BackColor = Color.Silver;
            Icon1.BackColor = Color.FromArgb(82, 122, 242);
            BtnState = "1";

        }

        private void SegundaPagina()
        {
            BtnVolver.Enabled = true;
            Lbl1.Text = "Marca";
            Lbl2.Text = "Modelo";
            Lbl3.Text = "No. serie";
            Lbl4.Visible = false;

            Txt1.Text = Herramienta.marca;
            Txt2.Text = Herramienta.modelo;
            Txt3.Text = Herramienta.numero_serie;
            Icon1.BackColor = Color.Silver;
            Icon2.BackColor = Color.FromArgb(82, 122, 242);
            Txt4.Visible = true;
            
            BtnState = "2";
        }


        private void GuardarHerramienta()
        {
            MessageBox.Show("GUARDADO");
        }


        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PrimeraPagina();        

        }




































       
    }
}