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


namespace AppLaboratorio.UserControlls.PrestamosFolder
{
    public partial class InfoPrestamoEstudiante : UserControl
    {
        public InfoPrestamoEstudiante()
        {
            InitializeComponent();


        }


        private void NuevoUsuario_Load_1(object sender, EventArgs e)
        {
            BtnState = "1";
        }

        string BtnState { get; set; }



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
            Txt1.Text = "Tipo de herramienta";
            Lbl2.Text = "Descripción";
            Txt2.Text = "Describa brevemente la herramieta";
            Lbl3.Text = "Cantidad";
            Txt3.Text = "Describa brevemente la herramieta";
            Lbl4.Text = "Cantidad";
            Txt4.Text = "Describa brevemente la herramieta";
            Icon2.BackColor = Color.Silver;
            Icon1.BackColor = Color.FromArgb(82, 122, 242);
            BtnState = "1";

        }

        private void SegundaPagina()
        {
            BtnVolver.Enabled = true;
            Lbl1.Text = "Marca";
            Txt1.Text = "Especifique la marca";
            Lbl2.Text = "Modelo";
            Txt2.Text = "Especifique el modelo";
            Lbl3.Text = "No. serie";
            Txt3.Text = "Capture el numero de serie";
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