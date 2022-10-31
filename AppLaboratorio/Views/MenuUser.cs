using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using AppLaboratorio.Views;
using AppLaboratorio.UserControlls;
using AppLaboratorio.UserControlls.InventarioFolder;
using AppLaboratorio.UserControlls.PrestamosFolder;
using AppLaboratorio.Models;


namespace AppLaboratorio.Views
{
    public partial class MenuUser : Form
    {
        public MenuUser(Usuarios usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 64);
            MenuContainer.Controls.Add(leftBorderBtn);

        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {

            Inventario();
            
        }

        public Usuarios Usuario { get; set; }
        public string Fecha { get; set; }

        public Point StartPoint = new Point(0, 0);   




        private delegate void BackDelegate();
        private event BackDelegate Back;

  

            
        /// <summary>
        /// 
        /// Contenedores
        /// 
        /// </summary>
        /// 

        




        /// <summary>
        /// Boton de folios
        /// <summary>
        private void Inventario()
        {
            ActivateButton(BtnFichas, RGBColors.color1);
            Inventario inventario = new Inventario(Usuario.Laboratorio) { Location = StartPoint };
            inventario.Crear += new Inventario.CrearDelegate(CrearHerramienta);
            inventario.Info += new Inventario.InfoDelegate(InfoHerramienta);
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(inventario);

        }
        private void BtnFichas_Click(object sender, EventArgs e)
        {
            Inventario();

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            PrestamosEmpleados();
        }


        public void CrearHerramienta()
        {
            this.Back += new BackDelegate(Inventario);
            NuevaHerramienta nuevoHerramineta = new NuevaHerramienta() { Location = StartPoint };
            nuevoHerramineta.Back += new NuevaHerramienta.BackDelegate(Inventario);
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(nuevoHerramineta);
            BtnBack.Visible = true;

        }

        public void InfoHerramienta(Herramienta herramienta)
        {
            this.Back += new BackDelegate(Inventario);
            infoInventario info = new infoInventario() { Location = StartPoint };
            info.Herramienta = herramienta;
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(info);
            BtnBack.Visible = true;
        }

        /// <summary>
        /// Boton Regresar
        /// </summary>

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            Back();
        }

        /// <summary>
        /// Boton de inventario
        /// </summary>

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);

        }

        /// Boton de agregar usuario

        
        private void BtnAjustes_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);


        }
        

        /// <summary>
        /// Boton Agregar Provedoor
        /// </summary>

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);

        }

        private void BtnUser_Click(object sender, EventArgs e)
        {


        }
        ////Boton de producto
        ///
        private void BtnProducto_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);


        }

        /// <summary>
        /// 
        /// Animaciones de Navegacion
        /// 
        /// </summary>

        private IconButton currentBtn;
        private Panel leftBorderBtn;

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(28, 60, 108);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(28, 60, 108);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void PrestamosAlumnos()
        {
            Back += new BackDelegate(PrestamosEmpleados);
            PrestamoEstudiante prestamoEstudiante = new PrestamoEstudiante();
            prestamoEstudiante.Location = StartPoint;
            prestamoEstudiante.Crear += new PrestamoEstudiante.CrearDelegate(NuevoPrestamoEstudiantes);
            prestamoEstudiante.informacion += new PrestamoEstudiante.info(infoPrestamo);
            prestamoEstudiante.Empleados += new PrestamoEstudiante.EmpleadosDelegate(PrestamosEmpleados);
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(prestamoEstudiante);
            BtnBack.Visible = true;
        }
        private void PrestamosEmpleados()
        {
            Back += new BackDelegate(PrestamosEmpleados);
            PrestamoEmpleado prestamoEmpleado = new PrestamoEmpleado();
            BtnBack.Visible = false;
            prestamoEmpleado.Location = StartPoint;
            prestamoEmpleado.Agg += new PrestamoEmpleado.CrearDelegate(NuevoPrestamoEmpleados);
            prestamoEmpleado.info += new PrestamoEmpleado.inf(infoPrestamo);
            prestamoEmpleado.Estudiantes += new PrestamoEmpleado.EstudiantesDelegate(PrestamosAlumnos);
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(prestamoEmpleado);
            BtnBack.Visible = false;
        }
        private void NuevoPrestamoEmpleados()
        {
            NuevoPrestamoEmpleado NprestamoEmpleado = new NuevoPrestamoEmpleado();
            NprestamoEmpleado.Location = StartPoint;
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(NprestamoEmpleado);
            BtnBack.Visible = true;

        }
        private void infoPrestamo()
        {
            InfoPrestamoEstudiante InfoprestamoEstudiante = new InfoPrestamoEstudiante();
            InfoprestamoEstudiante.Location = StartPoint;
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(InfoprestamoEstudiante);
            BtnBack.Visible = true;

        }
        private void NuevoPrestamoEstudiantes()
        {
            BtnBack.Visible = true;
            NuevoPrestamosEstudiantes NprestamoEstudiante = new NuevoPrestamosEstudiantes();
            BtnBack.Visible = false;
            NprestamoEstudiante.Location = StartPoint;
            ContainerComponents.Controls.Clear();
            ContainerComponents.Controls.Add(NprestamoEstudiante);

        }


        /// <summary>
        /// 
        /// Ficha de entradas
        /// 
        /// </summary>


        public void ProveedoresLoad(string proveedor,string usuario,string fecha)
        {

        }
     

       
        private void MenuAdmin_Move(object sender, EventArgs e)
        {
            this.Location = new Point(277,44);
        }

     









        private void BtnFichas_MouseHover(object sender, EventArgs e)
        {


        }

        private void PanelForm_MouseHover(object sender, EventArgs e)
        {

        }

        private void BtnInventario_MouseHover(object sender, EventArgs e)
        {


        }

        private void BtnAjustes_MouseHover(object sender, EventArgs e)
        {

        }

        private void BtnUser_MouseHover(object sender, EventArgs e)
        {


        }

        private void PanelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fichasEntrada1_Load(object sender, EventArgs e)
        {

        }



        private void MenuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitleBar_Click(object sender, EventArgs e)
        {

        }
        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void ContainerBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCamaron_Click(object sender, EventArgs e)
        {

        }

        private void BtnPescado_Click(object sender, EventArgs e)
        {

        }

        private void BtnOtros_Click(object sender, EventArgs e)
        {

        }

       
    }
}
