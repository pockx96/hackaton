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
using AppLaboratorio.UserControlls;
using AppLaboratorio.Models;
using AppLaboratorio.Controllers;

namespace AppLaboratorio.UserControlls.InventarioFolder
{
    public partial class Inventario : UserControl
    {
        public Inventario(string laboratorio)
        {
            InitializeComponent();
            this.Laboratorio = laboratorio;

        }



        private void ListaFolios_Load(object sender, EventArgs e)
        {
            LoadData(Laboratorio);
            DatagridHerramienta.CurrentRow.Selected = true;
        }

        public string Laboratorio { get; set; }

        public delegate void CrearDelegate();
        public event CrearDelegate Crear;

        public delegate void InfoDelegate(Herramienta herramienta);
        public event InfoDelegate Info;


        public void LoadData(string laboratorio)
        {
            HerramientaController herramientaController = new HerramientaController();
            List<Herramienta> ListHerramienta = herramientaController.GetByLaboratorio(laboratorio);
            int index;
            foreach (Herramienta element in ListHerramienta)
            {
                index = DatagridHerramienta.RowCount - 1;
                DatagridHerramienta.Rows.Insert(index,Convert.ToString(element.IdHerramienta),element.herramienta,element.cantidad);
            }



        }

 
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DatagridHerramienta.RowCount > 1)
            {

            }

        }

        private void DatagridFolios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Animations animations = new Animations();
            Point Location = animations.BtnlocationDatagrid(DatagridHerramienta,318,Cursor.Position.Y,new Point(440, 158),12);
            OptionsContainer.Location = Location;
            DatagridHerramienta.CurrentRow.Selected = true;
        }


        public  string GetProvedor()
        {
            return DatagridHerramienta.CurrentRow.Cells[0].Value.ToString().Replace(" ", String.Empty);
        }

      

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (Crear!=null)
            {
                Crear();
            }
        }

        private void BtnInformacion_Click(object sender, EventArgs e)
        {
            string id = DatagridHerramienta.CurrentRow.Cells[0].Value.ToString();
            HerramientaController herramientaController = new HerramientaController();
            Herramienta herramienta = herramientaController.Get(id);
            if (Info != null)
            {
                Info(herramienta);
            }
        }
    }
}
