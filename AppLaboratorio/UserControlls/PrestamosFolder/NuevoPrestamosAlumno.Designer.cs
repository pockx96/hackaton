namespace AppLaboratorio.UserControlls.PrestamosFolder
{
    partial class NuevoPrestamosAlumno
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
            this.TxtSalida = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblArriba = new System.Windows.Forms.Label();
            this.LblAbajo = new System.Windows.Forms.Label();
            this.LblMedio = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.NumericUpDown();
            this.BtnVolver = new AppLaboratorio.UserControlls.BotonRedondo();
            this.TxtBoxArriba = new AppLaboratorio.UserControlls.RJTextBox();
            this.TxtBoxMedio = new AppLaboratorio.UserControlls.RJTextBox();
            this.TxtBoxAbajo = new AppLaboratorio.UserControlls.RJTextBox();
            this.Icon2 = new AppLaboratorio.UserControlls.BotonRedondo();
            this.Icon1 = new AppLaboratorio.UserControlls.BotonRedondo();
            this.BtnGuardar = new AppLaboratorio.UserControlls.BotonRedondo();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
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
            // TxtSalida
            // 
            this.TxtSalida.Location = new System.Drawing.Point(35, 272);
            this.TxtSalida.Mask = "00/00/0000";
            this.TxtSalida.Name = "TxtSalida";
            this.TxtSalida.Size = new System.Drawing.Size(100, 26);
            this.TxtSalida.TabIndex = 56;
            this.TxtSalida.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(552, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "________________";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtCantidad);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtSalida);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LblArriba);
            this.groupBox2.Controls.Add(this.TxtBoxArriba);
            this.groupBox2.Controls.Add(this.LblAbajo);
            this.groupBox2.Controls.Add(this.LblMedio);
            this.groupBox2.Controls.Add(this.TxtBoxMedio);
            this.groupBox2.Controls.Add(this.TxtBoxAbajo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(54, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 355);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(27, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "_______________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(27, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "_______________________";
            // 
            // LblArriba
            // 
            this.LblArriba.AutoSize = true;
            this.LblArriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArriba.ForeColor = System.Drawing.SystemColors.Control;
            this.LblArriba.Location = new System.Drawing.Point(27, 22);
            this.LblArriba.Name = "LblArriba";
            this.LblArriba.Size = new System.Drawing.Size(108, 20);
            this.LblArriba.TabIndex = 40;
            this.LblArriba.Text = "Herramienta";
            // 
            // LblAbajo
            // 
            this.LblAbajo.AutoSize = true;
            this.LblAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAbajo.ForeColor = System.Drawing.SystemColors.Control;
            this.LblAbajo.Location = new System.Drawing.Point(31, 231);
            this.LblAbajo.Name = "LblAbajo";
            this.LblAbajo.Size = new System.Drawing.Size(81, 20);
            this.LblAbajo.TabIndex = 30;
            this.LblAbajo.Text = "Cantidad";
            // 
            // LblMedio
            // 
            this.LblMedio.AutoSize = true;
            this.LblMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMedio.ForeColor = System.Drawing.SystemColors.Control;
            this.LblMedio.Location = new System.Drawing.Point(31, 125);
            this.LblMedio.Name = "LblMedio";
            this.LblMedio.Size = new System.Drawing.Size(103, 20);
            this.LblMedio.TabIndex = 29;
            this.LblMedio.Text = "Descripción";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(37, 159);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(98, 26);
            this.TxtCantidad.TabIndex = 57;
            this.TxtCantidad.Visible = false;
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.White;
            this.BtnVolver.BackgroundColor = System.Drawing.Color.White;
            this.BtnVolver.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.BtnVolver.BorderRadius = 20;
            this.BtnVolver.BorderSize = 0;
            this.BtnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVolver.Enabled = false;
            this.BtnVolver.FlatAppearance.BorderSize = 0;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnVolver.Location = new System.Drawing.Point(54, 416);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(87, 40);
            this.BtnVolver.TabIndex = 89;
            this.BtnVolver.Text = "volver";
            this.BtnVolver.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // TxtBoxArriba
            // 
            this.TxtBoxArriba.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxArriba.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.TxtBoxArriba.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.TxtBoxArriba.BorderRadius = 0;
            this.TxtBoxArriba.BorderSize = 2;
            this.TxtBoxArriba.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxArriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtBoxArriba.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxArriba.Location = new System.Drawing.Point(31, 53);
            this.TxtBoxArriba.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxArriba.Multiline = false;
            this.TxtBoxArriba.Name = "TxtBoxArriba";
            this.TxtBoxArriba.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBoxArriba.PasswordChar = false;
            this.TxtBoxArriba.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBoxArriba.PlaceholderText = "Tipo de herramienta";
            this.TxtBoxArriba.Size = new System.Drawing.Size(273, 35);
            this.TxtBoxArriba.TabIndex = 39;
            this.TxtBoxArriba.Texts = "";
            this.TxtBoxArriba.UnderlinedStyle = false;
            // 
            // TxtBoxMedio
            // 
            this.TxtBoxMedio.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxMedio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.TxtBoxMedio.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.TxtBoxMedio.BorderRadius = 0;
            this.TxtBoxMedio.BorderSize = 2;
            this.TxtBoxMedio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtBoxMedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxMedio.Location = new System.Drawing.Point(35, 159);
            this.TxtBoxMedio.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxMedio.Multiline = false;
            this.TxtBoxMedio.Name = "TxtBoxMedio";
            this.TxtBoxMedio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBoxMedio.PasswordChar = false;
            this.TxtBoxMedio.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBoxMedio.PlaceholderText = "Describa brevemente la herramieta";
            this.TxtBoxMedio.Size = new System.Drawing.Size(269, 35);
            this.TxtBoxMedio.TabIndex = 25;
            this.TxtBoxMedio.Texts = "";
            this.TxtBoxMedio.UnderlinedStyle = false;
            // 
            // TxtBoxAbajo
            // 
            this.TxtBoxAbajo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBoxAbajo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.TxtBoxAbajo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.TxtBoxAbajo.BorderRadius = 0;
            this.TxtBoxAbajo.BorderSize = 2;
            this.TxtBoxAbajo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBoxAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtBoxAbajo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBoxAbajo.Location = new System.Drawing.Point(31, 272);
            this.TxtBoxAbajo.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBoxAbajo.Multiline = false;
            this.TxtBoxAbajo.Name = "TxtBoxAbajo";
            this.TxtBoxAbajo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBoxAbajo.PasswordChar = false;
            this.TxtBoxAbajo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBoxAbajo.PlaceholderText = "Describa brevemente la herramieta";
            this.TxtBoxAbajo.Size = new System.Drawing.Size(269, 35);
            this.TxtBoxAbajo.TabIndex = 45;
            this.TxtBoxAbajo.Texts = "";
            this.TxtBoxAbajo.UnderlinedStyle = false;
            this.TxtBoxAbajo.Visible = false;
            // 
            // Icon2
            // 
            this.Icon2.BackColor = System.Drawing.Color.Silver;
            this.Icon2.BackgroundColor = System.Drawing.Color.Silver;
            this.Icon2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Icon2.BorderRadius = 20;
            this.Icon2.BorderSize = 0;
            this.Icon2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon2.FlatAppearance.BorderSize = 0;
            this.Icon2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Icon2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon2.ForeColor = System.Drawing.Color.Black;
            this.Icon2.Location = new System.Drawing.Point(663, 87);
            this.Icon2.Name = "Icon2";
            this.Icon2.Size = new System.Drawing.Size(40, 40);
            this.Icon2.TabIndex = 86;
            this.Icon2.Text = "2";
            this.Icon2.TextColor = System.Drawing.Color.Black;
            this.Icon2.UseVisualStyleBackColor = false;
            // 
            // Icon1
            // 
            this.Icon1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.Icon1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.Icon1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(217)))), ((int)(((byte)(115)))), ((int)(((byte)(26)))));
            this.Icon1.BorderRadius = 20;
            this.Icon1.BorderSize = 0;
            this.Icon1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon1.FlatAppearance.BorderSize = 0;
            this.Icon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Icon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon1.ForeColor = System.Drawing.Color.White;
            this.Icon1.Location = new System.Drawing.Point(506, 87);
            this.Icon1.Name = "Icon1";
            this.Icon1.Size = new System.Drawing.Size(40, 40);
            this.Icon1.TabIndex = 85;
            this.Icon1.Text = "1";
            this.Icon1.TextColor = System.Drawing.Color.White;
            this.Icon1.UseVisualStyleBackColor = false;
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
            this.BtnGuardar.Location = new System.Drawing.Point(165, 416);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(102, 40);
            this.BtnGuardar.TabIndex = 84;
            this.BtnGuardar.Text = "Siguiente";
            this.BtnGuardar.TextColor = System.Drawing.Color.White;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // NuevoPrestamosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Icon2);
            this.Controls.Add(this.Icon1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCrear);
            this.Name = "NuevoPrestamosAlumno";
            this.Size = new System.Drawing.Size(876, 500);
            this.Load += new System.EventHandler(this.NuevoPrestamosEstudiantes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BtnCrear;
        private System.Windows.Forms.MaskedTextBox TxtSalida;
        private BotonRedondo BtnGuardar;
        private BotonRedondo Icon2;
        private BotonRedondo Icon1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblArriba;
        private RJTextBox TxtBoxArriba;
        private System.Windows.Forms.Label LblAbajo;
        private System.Windows.Forms.Label LblMedio;
        private RJTextBox TxtBoxMedio;
        private RJTextBox TxtBoxAbajo;
        private BotonRedondo BtnVolver;
        private System.Windows.Forms.NumericUpDown TxtCantidad;
    }
}
