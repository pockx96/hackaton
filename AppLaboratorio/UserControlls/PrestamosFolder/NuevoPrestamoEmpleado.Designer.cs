namespace AppLaboratorio.UserControlls.PrestamosFolder
{
    partial class NuevoPrestamoEmpleado
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
            this.TxtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.TxtBox1 = new AppLaboratorio.UserControlls.RJTextBox();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.TxtBox2 = new AppLaboratorio.UserControlls.RJTextBox();
            this.TxtBox3 = new AppLaboratorio.UserControlls.RJTextBox();
            this.BtnVolver = new AppLaboratorio.UserControlls.BotonRedondo();
            this.Icon2 = new AppLaboratorio.UserControlls.BotonRedondo();
            this.Icon1 = new AppLaboratorio.UserControlls.BotonRedondo();
            this.BtnGuardar = new AppLaboratorio.UserControlls.BotonRedondo();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.TxtBox4 = new AppLaboratorio.UserControlls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.TxtSalida.Location = new System.Drawing.Point(35, 256);
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
            this.label2.Location = new System.Drawing.Point(580, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "________________";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtCantidad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Lbl4);
            this.groupBox2.Controls.Add(this.TxtBox4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtSalida);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Lbl1);
            this.groupBox2.Controls.Add(this.TxtBox1);
            this.groupBox2.Controls.Add(this.Lbl3);
            this.groupBox2.Controls.Add(this.Lbl2);
            this.groupBox2.Controls.Add(this.TxtBox2);
            this.groupBox2.Controls.Add(this.TxtBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(54, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 406);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(37, 152);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(98, 26);
            this.TxtCantidad.TabIndex = 57;
            this.TxtCantidad.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(27, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "_______________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(27, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "_______________________";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl1.Location = new System.Drawing.Point(27, 22);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(108, 20);
            this.Lbl1.TabIndex = 40;
            this.Lbl1.Text = "Herramienta";
            // 
            // TxtBox1
            // 
            this.TxtBox1.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.TxtBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.TxtBox1.BorderRadius = 0;
            this.TxtBox1.BorderSize = 2;
            this.TxtBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBox1.Location = new System.Drawing.Point(31, 53);
            this.TxtBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox1.Multiline = false;
            this.TxtBox1.Name = "TxtBox1";
            this.TxtBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBox1.PasswordChar = false;
            this.TxtBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBox1.PlaceholderText = "Tipo de herramienta";
            this.TxtBox1.Size = new System.Drawing.Size(273, 35);
            this.TxtBox1.TabIndex = 39;
            this.TxtBox1.Texts = "";
            this.TxtBox1.UnderlinedStyle = false;
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl3.Location = new System.Drawing.Point(31, 224);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(81, 20);
            this.Lbl3.TabIndex = 30;
            this.Lbl3.Text = "Cantidad";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl2.Location = new System.Drawing.Point(31, 118);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(103, 20);
            this.Lbl2.TabIndex = 29;
            this.Lbl2.Text = "Descripción";
            // 
            // TxtBox2
            // 
            this.TxtBox2.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.TxtBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.TxtBox2.BorderRadius = 0;
            this.TxtBox2.BorderSize = 2;
            this.TxtBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBox2.Location = new System.Drawing.Point(35, 152);
            this.TxtBox2.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox2.Multiline = false;
            this.TxtBox2.Name = "TxtBox2";
            this.TxtBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBox2.PasswordChar = false;
            this.TxtBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBox2.PlaceholderText = "Describa brevemente la herramieta";
            this.TxtBox2.Size = new System.Drawing.Size(269, 35);
            this.TxtBox2.TabIndex = 25;
            this.TxtBox2.Texts = "";
            this.TxtBox2.UnderlinedStyle = false;
            // 
            // TxtBox3
            // 
            this.TxtBox3.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.TxtBox3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.TxtBox3.BorderRadius = 0;
            this.TxtBox3.BorderSize = 2;
            this.TxtBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBox3.Location = new System.Drawing.Point(31, 256);
            this.TxtBox3.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox3.Multiline = false;
            this.TxtBox3.Name = "TxtBox3";
            this.TxtBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBox3.PasswordChar = false;
            this.TxtBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBox3.PlaceholderText = "Describa brevemente la herramieta";
            this.TxtBox3.Size = new System.Drawing.Size(269, 35);
            this.TxtBox3.TabIndex = 45;
            this.TxtBox3.Texts = "";
            this.TxtBox3.UnderlinedStyle = false;
            this.TxtBox3.Visible = false;
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
            this.BtnVolver.Location = new System.Drawing.Point(54, 440);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(87, 40);
            this.BtnVolver.TabIndex = 89;
            this.BtnVolver.Text = "volver";
            this.BtnVolver.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
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
            this.Icon2.Location = new System.Drawing.Point(691, 50);
            this.Icon2.Name = "Icon2";
            this.Icon2.Size = new System.Drawing.Size(40, 40);
            this.Icon2.TabIndex = 86;
            this.Icon2.Text = "2";
            this.Icon2.TextColor = System.Drawing.Color.Black;
            this.Icon2.UseVisualStyleBackColor = false;
            this.Icon2.Click += new System.EventHandler(this.Icon2_Click);
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
            this.Icon1.Location = new System.Drawing.Point(534, 50);
            this.Icon1.Name = "Icon1";
            this.Icon1.Size = new System.Drawing.Size(40, 40);
            this.Icon1.TabIndex = 85;
            this.Icon1.Text = "1";
            this.Icon1.TextColor = System.Drawing.Color.White;
            this.Icon1.UseVisualStyleBackColor = false;
            this.Icon1.Click += new System.EventHandler(this.Icon1_Click);
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
            this.BtnGuardar.Location = new System.Drawing.Point(165, 440);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(102, 40);
            this.BtnGuardar.TabIndex = 84;
            this.BtnGuardar.Text = "Siguiente";
            this.BtnGuardar.TextColor = System.Drawing.Color.White;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl4.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl4.Location = new System.Drawing.Point(26, 318);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(108, 20);
            this.Lbl4.TabIndex = 60;
            this.Lbl4.Text = "Herramienta";
            // 
            // TxtBox4
            // 
            this.TxtBox4.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152)))));
            this.TxtBox4.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.TxtBox4.BorderRadius = 0;
            this.TxtBox4.BorderSize = 2;
            this.TxtBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TxtBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBox4.Location = new System.Drawing.Point(30, 342);
            this.TxtBox4.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBox4.Multiline = false;
            this.TxtBox4.Name = "TxtBox4";
            this.TxtBox4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TxtBox4.PasswordChar = false;
            this.TxtBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TxtBox4.PlaceholderText = "Tipo de herramienta";
            this.TxtBox4.Size = new System.Drawing.Size(273, 35);
            this.TxtBox4.TabIndex = 59;
            this.TxtBox4.Texts = "";
            this.TxtBox4.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(28, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "_______________________";
            // 
            // NuevoPrestamoEmpleado
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
            this.Name = "NuevoPrestamoEmpleado";
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
        private System.Windows.Forms.Label Lbl1;
        private RJTextBox TxtBox1;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl2;
        private RJTextBox TxtBox2;
        private RJTextBox TxtBox3;
        private BotonRedondo BtnVolver;
        private System.Windows.Forms.NumericUpDown TxtCantidad;
        private System.Windows.Forms.Label Lbl4;
        private RJTextBox TxtBox4;
        private System.Windows.Forms.Label label4;
    }
}
