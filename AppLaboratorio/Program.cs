using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLaboratorio.Views;
using AppLaboratorio.Controllers;
using AppLaboratorio.Models;

namespace AppLaboratorio
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //HerramientaController herramientaController = new HerramientaController();
            //Herramienta herramienta = new Herramienta() 
            //{
            //    herramienta = "Kit de programación",
            //    cantidad = "1",
            //    marca = "Development tools",
            //    modelo = "MICROCHIP",
            //    descripcion ="",
            //    laboratorio = "sistemas",
            //    numero_serie = "MTI134900580"
            //};
            //herramientaController.Post(herramienta);
            UsuarioController userControl = new UsuarioController();
            Usuarios usuario = userControl.Get("Pock");



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }





    }
}
