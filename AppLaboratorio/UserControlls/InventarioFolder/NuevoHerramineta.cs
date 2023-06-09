﻿using System;
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
using AppLaboratorio.Models;
using CustomMessageBox;


namespace AppLaboratorio.UserControlls.InventarioFolder
{
    public partial class NuevaHerramienta : UserControl
    {
        public NuevaHerramienta(string laboratorio)
        {
            InitializeComponent();
            Laboratorio=laboratorio;


        }

        Herramienta herramienta = new Herramienta();
        string Laboratorio { get; set; }

        private void NuevoUsuario_Load_1(object sender, EventArgs e)
        {
            Clear();
            BtnState = "1";

        }

        string BtnState { get; set; }
        public delegate void BackDelegate();
        public event BackDelegate Back;


        private void Clear()
        {
            TxtBoxArriba.Text = "";
            TxtBoxMedio.Text = "";
            numericUpDown.Value = 0;
            TxtBoxAbajo.Texts = "";
        }

        private void botonRedondo1_Click(object sender, EventArgs e)
        {
            switch (BtnState) 
            {
                case "1":
                    herramienta.herramienta = TxtBoxArriba.Texts;
                    herramienta.descripcion = TxtBoxMedio.Texts;
                    herramienta.cantidad = Convert.ToString(numericUpDown.Value);

                    SegundaPagina();
                    break;
                case "2":
                    herramienta.marca = TxtBoxArriba.Texts;
                    herramienta.modelo = TxtBoxMedio.Texts;
                    herramienta.numero_serie = TxtBoxAbajo.Texts;
                    herramienta.laboratorio = Laboratorio;
                    GuardarHerramienta();
                    break;
            }
            
          
        }

        private void PrimeraPagina()
        {
            BtnVolver.Enabled = false;
            LblArriba.Text = "Herramienta";
            TxtBoxArriba.PlaceholderText = "Tipo de herramienta";
            LblMedio.Text = "Descripción";
            TxtBoxMedio.PlaceholderText = "Describa brevemente la herramieta";
            LblAbajo.Text = "Cantidad";
            numericUpDown.Visible = true;
            TxtBoxAbajo.Visible = false;
            Icon1.BackColor = Color.FromArgb(82, 122, 242);
            Icon2.BackColor = Color.Silver;
            BtnState = "1";

        }

        private void SegundaPagina()
        {
            BtnVolver.Enabled = true;
            LblArriba.Text = "Marca";
            TxtBoxArriba.PlaceholderText = "Especifique la marca";
            LblMedio.Text = "Modelo";
            TxtBoxMedio.PlaceholderText = "Especifique el modelo";
            LblAbajo.Text = "No. serie";
            TxtBoxAbajo.PlaceholderText = "Capture el numero de serie";
            numericUpDown.Visible = false;
            TxtBoxAbajo.Visible = true;
            Icon1.BackColor = Color.Silver;
            Icon2.BackColor = Color.FromArgb(82, 122, 242);
            BtnState = "2";

        }

        private void GuardarHerramienta()
        {
            HerramientaController herramientaController = new HerramientaController();
            herramientaController.Post(herramienta);
            DialogResult result = RJMessageBox.Show("Herramienta añadida" + " !.", "Exito!");
            Back();
        }


        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PrimeraPagina();        

        }






































        private void NuevoUsuario_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void BtnAjustes_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TxtBoxId__TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       
    }
}