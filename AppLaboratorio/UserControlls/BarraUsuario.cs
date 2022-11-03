using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLaboratorio.UserControlls
{
    public partial class BarraUsuario : UserControl
    {
        public BarraUsuario()
        {
            InitializeComponent();
        }

        public string UserName { get; set; }
        private void BarraUsuario_Load(object sender, EventArgs e)
        {
            if (UserName != null)
            {
                LblUser.Text = UserName;
            }
        }

        public void LoadName(string name)
        {
            LblUser.Text = name;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
