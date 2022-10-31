using AppLaboratorio.UserControlls;
namespace AppLaboratorio.Views
{
    partial class MenuUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUser));
            this.MenuContainer = new System.Windows.Forms.Panel();
            this.BtnPrestamos = new FontAwesome.Sharp.IconButton();
            this.BtnUser = new FontAwesome.Sharp.IconButton();
            this.BtnFichas = new FontAwesome.Sharp.IconButton();
            this.ContainerTileBar = new AppLaboratorio.UserControlls.SPanel();
            this.RelogContainer = new AppLaboratorio.UserControlls.Relog();
            this.CalendarioContainer = new AppLaboratorio.UserControlls.Calendario();
            this.TitleUsuario = new AppLaboratorio.UserControlls.BarraUsuario();
            this.BtnBack = new FontAwesome.Sharp.IconButton();
            this.PanelForm = new AppLaboratorio.UserControlls.SPanel();
            this.ContainerComponents = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MenuContainer.SuspendLayout();
            this.ContainerTileBar.SuspendLayout();
            this.PanelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MenuContainer.Controls.Add(this.BtnPrestamos);
            this.MenuContainer.Controls.Add(this.BtnUser);
            this.MenuContainer.Controls.Add(this.BtnFichas);
            this.MenuContainer.Location = new System.Drawing.Point(0, 147);
            this.MenuContainer.Margin = new System.Windows.Forms.Padding(0);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(154, 433);
            this.MenuContainer.TabIndex = 13;
            this.MenuContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuContainer_Paint);
            // 
            // BtnPrestamos
            // 
            this.BtnPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnPrestamos.FlatAppearance.BorderSize = 0;
            this.BtnPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnPrestamos.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnPrestamos.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.BtnPrestamos.IconColor = System.Drawing.Color.White;
            this.BtnPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPrestamos.Location = new System.Drawing.Point(2, 73);
            this.BtnPrestamos.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPrestamos.Name = "BtnPrestamos";
            this.BtnPrestamos.Size = new System.Drawing.Size(151, 64);
            this.BtnPrestamos.TabIndex = 13;
            this.BtnPrestamos.Text = "Prestamos";
            this.BtnPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrestamos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPrestamos.UseVisualStyleBackColor = false;
            this.BtnPrestamos.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // BtnUser
            // 
            this.BtnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.BtnUser.FlatAppearance.BorderSize = 0;
            this.BtnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnUser.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.BtnUser.IconColor = System.Drawing.Color.White;
            this.BtnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnUser.Location = new System.Drawing.Point(3, 330);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(153, 64);
            this.BtnUser.TabIndex = 9;
            this.BtnUser.Text = "Sesión";
            this.BtnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUser.UseVisualStyleBackColor = false;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            this.BtnUser.MouseHover += new System.EventHandler(this.BtnUser_MouseHover);
            // 
            // BtnFichas
            // 
            this.BtnFichas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnFichas.FlatAppearance.BorderSize = 0;
            this.BtnFichas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFichas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnFichas.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnFichas.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.BtnFichas.IconColor = System.Drawing.Color.White;
            this.BtnFichas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnFichas.Location = new System.Drawing.Point(2, 3);
            this.BtnFichas.Margin = new System.Windows.Forms.Padding(0);
            this.BtnFichas.Name = "BtnFichas";
            this.BtnFichas.Size = new System.Drawing.Size(151, 64);
            this.BtnFichas.TabIndex = 6;
            this.BtnFichas.Text = "Inventario";
            this.BtnFichas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFichas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFichas.UseVisualStyleBackColor = false;
            this.BtnFichas.Click += new System.EventHandler(this.BtnFichas_Click);
            this.BtnFichas.MouseHover += new System.EventHandler(this.BtnFichas_MouseHover);
            // 
            // ContainerTileBar
            // 
            this.ContainerTileBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ContainerTileBar.BorderColor = System.Drawing.Color.White;
            this.ContainerTileBar.Controls.Add(this.RelogContainer);
            this.ContainerTileBar.Controls.Add(this.CalendarioContainer);
            this.ContainerTileBar.Controls.Add(this.TitleUsuario);
            this.ContainerTileBar.Controls.Add(this.BtnBack);
            this.ContainerTileBar.Edge = 20;
            this.ContainerTileBar.Location = new System.Drawing.Point(159, 12);
            this.ContainerTileBar.Name = "ContainerTileBar";
            this.ContainerTileBar.Size = new System.Drawing.Size(876, 72);
            this.ContainerTileBar.TabIndex = 28;
            // 
            // RelogContainer
            // 
            this.RelogContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.RelogContainer.Location = new System.Drawing.Point(558, 18);
            this.RelogContainer.Name = "RelogContainer";
            this.RelogContainer.Size = new System.Drawing.Size(155, 38);
            this.RelogContainer.TabIndex = 16;
            // 
            // CalendarioContainer
            // 
            this.CalendarioContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CalendarioContainer.Fecha = "31-10-2022";
            this.CalendarioContainer.Location = new System.Drawing.Point(732, 24);
            this.CalendarioContainer.Name = "CalendarioContainer";
            this.CalendarioContainer.Size = new System.Drawing.Size(131, 31);
            this.CalendarioContainer.TabIndex = 15;
            // 
            // TitleUsuario
            // 
            this.TitleUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TitleUsuario.Location = new System.Drawing.Point(54, 22);
            this.TitleUsuario.Name = "TitleUsuario";
            this.TitleUsuario.Size = new System.Drawing.Size(131, 31);
            this.TitleUsuario.TabIndex = 14;
            this.TitleUsuario.UserName = null;
            // 
            // BtnBack
            // 
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.BtnBack.IconColor = System.Drawing.Color.White;
            this.BtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnBack.Location = new System.Drawing.Point(3, 18);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(40, 43);
            this.BtnBack.TabIndex = 13;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Visible = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click_1);
            // 
            // PanelForm
            // 
            this.PanelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.PanelForm.BorderColor = System.Drawing.Color.White;
            this.PanelForm.Controls.Add(this.ContainerComponents);
            this.PanelForm.Edge = 20;
            this.PanelForm.Location = new System.Drawing.Point(159, 56);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Padding = new System.Windows.Forms.Padding(160, 15, 160, 0);
            this.PanelForm.Size = new System.Drawing.Size(876, 532);
            this.PanelForm.TabIndex = 14;
            this.PanelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.sPanel1_Paint);
            // 
            // ContainerComponents
            // 
            this.ContainerComponents.Location = new System.Drawing.Point(0, 34);
            this.ContainerComponents.Name = "ContainerComponents";
            this.ContainerComponents.Size = new System.Drawing.Size(876, 500);
            this.ContainerComponents.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppLaboratorio.Properties.Resources.tcnm_blanco;
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // MenuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(1048, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ContainerTileBar);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.MenuContainer);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sea Manager";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.Move += new System.EventHandler(this.MenuAdmin_Move);
            this.MenuContainer.ResumeLayout(false);
            this.ContainerTileBar.ResumeLayout(false);
            this.PanelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlls.SPanel PanelForm;
        private FontAwesome.Sharp.IconButton BtnFichas;
        private FontAwesome.Sharp.IconButton BtnUser;
        private System.Windows.Forms.Panel MenuContainer;
        private UserControlls.SPanel ContainerTileBar;
        private FontAwesome.Sharp.IconButton BtnBack;
        private System.Windows.Forms.Panel ContainerComponents;
        private UserControlls.Relog RelogContainer;
        private UserControlls.Calendario CalendarioContainer;
        private UserControlls.BarraUsuario TitleUsuario;
        private FontAwesome.Sharp.IconButton BtnPrestamos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}