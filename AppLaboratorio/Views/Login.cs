using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLaboratorio.Models;
using AppLaboratorio.UserControlls;
using AppLaboratorio.Controllers;
using CustomMessageBox;
using AppLaboratorio.Views;

namespace AppLaboratorio.Views
{
    public partial class Login : Form
    {
        //metodos

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtBox_user.GotFocus += new EventHandler(this.TextGotFocus);
            txtBox_user.LostFocus += new EventHandler(this.TextLostFocus);
            txtBox_psswrd.GotFocus += new EventHandler(this.TextGotFocuspass);
            txtBox_psswrd.LostFocus += new EventHandler(this.TextLostFocuspass);


        }
        

        //BOTONLOGIN///////////////////////////////////////////////////////////////////////
        public void BtnAgregar_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();
            Usuarios usuario = usuarioController.Get(txtBox_user.Texts);
            if (txtBox_user.Texts == "" )
            {
                DialogResult result = RJMessageBox.Show("El campo usuario se encuentra vacio " + " !.", "Advertencia!");
                
            }
            else if (txtBox_psswrd.Texts == "")
            {
                DialogResult result = RJMessageBox.Show("El campo de contraseña se encuentra vacio " + " !.", "Advertencia!");
            }
            else if (txtBox_user.Texts != usuario.id_usuario)
            {
                DialogResult result = RJMessageBox.Show("Usuario invalido " + " !.", "Advertencia!");
            }
            else if (txtBox_psswrd.Texts != usuario.password)
            {
                DialogResult result = RJMessageBox.Show("Contraseña incorrecta " + " !.", "Advertencia!");
            }
            else
            {

                MenuUser menu = new MenuUser(usuario);
                menu.Show();
                this.Hide();
            }

        }

        private void txtBox_user_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bttn_login_Click(object sender, EventArgs e)
        {
          

            


        }

        private void containerLogin_Paint(object sender, PaintEventArgs e)
        {

        }
        public void TextGotFocus(object sender, EventArgs e)
        {

            if (txtBox_user.Text == "Usuario")
            {
                txtBox_user.Text = "";
                txtBox_user.ForeColor = Color.Black;
            }
        }

        public void TextLostFocus(object sender, EventArgs e)
        {

            if (txtBox_user.Text == "")
            {
                txtBox_user.Text = "Usuario";
                txtBox_user.ForeColor = Color.LightGray;
            }
        }
        public void TextGotFocuspass(object sender, EventArgs e)
        {

            if (txtBox_psswrd.Text == "Contraseña")
            {
                txtBox_psswrd.Text = "";
                txtBox_psswrd.ForeColor = Color.Black;
            }
        }

        public void TextLostFocuspass(object sender, EventArgs e)
        {

            if (txtBox_psswrd.Text == "")
            {
                txtBox_psswrd.Text = "Contraseña";
                txtBox_psswrd.ForeColor = Color.LightGray;
            }
        }



        private void EyeButton_Click(object sender, EventArgs e)
        {
            if (txtBox_psswrd.PasswordChar == true)
            {
                EyeButton.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtBox_psswrd.PasswordChar = false;
            }
            else
            {
                EyeButton.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtBox_psswrd.PasswordChar = true;
            }
        }

        //private string stringToDb(string word)
        //{
        //    int lenght = 20 - word.Length;
        //    string StringDb = word;
        //    for (int i = 0; i < lenght; i++)
        //    {
        //        StringDb = StringDb + " ";
        //    }
        //    return StringDb;
        //}

        private void sPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
