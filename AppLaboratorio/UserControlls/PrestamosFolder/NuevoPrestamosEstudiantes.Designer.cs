namespace AppLaboratorio.UserControlls.PrestamosFolder
{
    partial class NuevoPrestamosEstudiantes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCrear = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReingreso = new System.Windows.Forms.MaskedTextBox();
            this.txtMatricula = new AppLaboratorio.UserControlls.RJTextBox();
            this.txtNombre = new AppLaboratorio.UserControlls.RJTextBox();
            this.txtHerramienta = new AppLaboratorio.UserControlls.RJTextBox();
            this.txtMateria = new AppLaboratorio.UserControlls.RJTextBox();
            this.txtCantidad = new AppLaboratorio.UserControlls.RJTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGuardar = new AppLaboratorio.UserControlls.BotonRedondo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCrear
            // 
            this.BtnCrear.AutoSize = true;
            this.BtnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.ForeColor = System.Drawing.Color.White;
            this.BtnCrear.Location = new System.Drawing.Point(3, 0);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(0, 24);
            this.BtnCrear.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(23, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(23, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(23, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(23, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Reingreso";
            // 
            // txtReingreso
            // 
            this.txtReingreso.Location = new System.Drawing.Point(23, 296);
            this.txtReingreso.Mask = "00/00/0000";
            this.txtReingreso.Name = "txtReingreso";
            this.txtReingreso.Size = new System.Drawing.Size(100, 20);
            this.txtReingreso.TabIndex = 56;
            this.txtReingreso.ValidatingType = typeof(System.DateTime);
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.SystemColors.Window;
            this.txtMatricula.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMatricula.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMatricula.BorderRadius = 0;
            this.txtMatricula.BorderSize = 2;
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMatricula.Location = new System.Drawing.Point(23, 20);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatricula.Multiline = false;
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMatricula.PasswordChar = false;
            this.txtMatricula.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatricula.PlaceholderText = "Matricula";
            this.txtMatricula.Size = new System.Drawing.Size(228, 31);
            this.txtMatricula.TabIndex = 62;
            this.txtMatricula.Texts = "";
            this.txtMatricula.UnderlinedStyle = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombre.BorderRadius = 0;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(23, 77);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 31);
            this.txtNombre.TabIndex = 63;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = false;
            // 
            // txtHerramienta
            // 
            this.txtHerramienta.BackColor = System.Drawing.SystemColors.Window;
            this.txtHerramienta.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtHerramienta.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHerramienta.BorderRadius = 0;
            this.txtHerramienta.BorderSize = 2;
            this.txtHerramienta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHerramienta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHerramienta.Location = new System.Drawing.Point(23, 181);
            this.txtHerramienta.Margin = new System.Windows.Forms.Padding(4);
            this.txtHerramienta.Multiline = false;
            this.txtHerramienta.Name = "txtHerramienta";
            this.txtHerramienta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHerramienta.PasswordChar = false;
            this.txtHerramienta.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHerramienta.PlaceholderText = "Herramienta";
            this.txtHerramienta.Size = new System.Drawing.Size(228, 31);
            this.txtHerramienta.TabIndex = 64;
            this.txtHerramienta.Texts = "";
            this.txtHerramienta.UnderlinedStyle = false;
            // 
            // txtMateria
            // 
            this.txtMateria.BackColor = System.Drawing.SystemColors.Window;
            this.txtMateria.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMateria.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMateria.BorderRadius = 0;
            this.txtMateria.BorderSize = 2;
            this.txtMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMateria.Location = new System.Drawing.Point(23, 129);
            this.txtMateria.Margin = new System.Windows.Forms.Padding(4);
            this.txtMateria.Multiline = false;
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMateria.PasswordChar = false;
            this.txtMateria.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMateria.PlaceholderText = "Materia";
            this.txtMateria.Size = new System.Drawing.Size(228, 31);
            this.txtMateria.TabIndex = 65;
            this.txtMateria.Texts = "";
            this.txtMateria.UnderlinedStyle = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txtCantidad.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCantidad.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCantidad.BorderRadius = 0;
            this.txtCantidad.BorderSize = 2;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCantidad.Location = new System.Drawing.Point(23, 238);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCantidad.PasswordChar = false;
            this.txtCantidad.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCantidad.PlaceholderText = "Cantidad";
            this.txtCantidad.Size = new System.Drawing.Size(228, 31);
            this.txtCantidad.TabIndex = 66;
            this.txtCantidad.Texts = "";
            this.txtCantidad.UnderlinedStyle = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMatricula);
            this.groupBox1.Controls.Add(this.txtReingreso);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMateria);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtHerramienta);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(65, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 354);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnGuardar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.BtnGuardar.BorderRadius = 20;
            this.BtnGuardar.BorderSize = 0;
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(169, 402);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(102, 40);
            this.BtnGuardar.TabIndex = 84;
            this.BtnGuardar.Text = "Siguiente";
            this.BtnGuardar.TextColor = System.Drawing.Color.White;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // NuevoPrestamosEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCrear);
            this.Name = "NuevoPrestamosEstudiantes";
            this.Size = new System.Drawing.Size(876, 500);
            this.Load += new System.EventHandler(this.NuevoPrestamosEstudiantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BtnCrear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtReingreso;
        private RJTextBox txtMatricula;
        private RJTextBox txtNombre;
        private RJTextBox txtHerramienta;
        private RJTextBox txtMateria;
        private RJTextBox txtCantidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private BotonRedondo BtnGuardar;
    }
}
