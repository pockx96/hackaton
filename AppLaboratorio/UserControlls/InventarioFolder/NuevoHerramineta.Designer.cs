namespace AppLaboratorio.UserControlls.InventarioFolder
{
    partial class NuevoHerramineta
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
            this.BtnAjustes = new FontAwesome.Sharp.IconButton();
            this.LblAbajo = new System.Windows.Forms.Label();
            this.LblMedio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.LblArriba = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Icon2 = new AppLaboratorio.UserControlls.BotonRedondo();
            this.Icon1 = new AppLaboratorio.UserControlls.BotonRedondo();
            this.BtnVolver = new AppLaboratorio.UserControlls.BotonRedondo();
            this.TxtBoxArriba = new AppLaboratorio.UserControlls.RJTextBox();
            this.TxtBoxMedio = new AppLaboratorio.UserControlls.RJTextBox();
            this.TxtBoxAbajo = new AppLaboratorio.UserControlls.RJTextBox();
            this.BtnGuardar = new AppLaboratorio.UserControlls.BotonRedondo();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAjustes
            // 
            this.BtnAjustes.BackColor = System.Drawing.Color.Transparent;
            this.BtnAjustes.FlatAppearance.BorderSize = 0;
            this.BtnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjustes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAjustes.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAjustes.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.BtnAjustes.IconColor = System.Drawing.Color.White;
            this.BtnAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAjustes.Location = new System.Drawing.Point(28, -67);
            this.BtnAjustes.Name = "BtnAjustes";
            this.BtnAjustes.Size = new System.Drawing.Size(140, 64);
            this.BtnAjustes.TabIndex = 22;
            this.BtnAjustes.Text = "Usuarios";
            this.BtnAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjustes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAjustes.UseVisualStyleBackColor = false;
            // 
            // LblAbajo
            // 
            this.LblAbajo.AutoSize = true;
            this.LblAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAbajo.ForeColor = System.Drawing.SystemColors.Control;
            this.LblAbajo.Location = new System.Drawing.Point(31, 247);
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
            this.LblMedio.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LblArriba);
            this.groupBox1.Controls.Add(this.TxtBoxArriba);
            this.groupBox1.Controls.Add(this.LblAbajo);
            this.groupBox1.Controls.Add(this.LblMedio);
            this.groupBox1.Controls.Add(this.TxtBoxMedio);
            this.groupBox1.Controls.Add(this.TxtBoxAbajo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 355);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(27, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "_______________________";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(37, 288);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(98, 26);
            this.numericUpDown.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(27, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "_______________________";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(568, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "________________";
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
            this.Icon2.Location = new System.Drawing.Point(679, 70);
            this.Icon2.Name = "Icon2";
            this.Icon2.Size = new System.Drawing.Size(40, 40);
            this.Icon2.TabIndex = 36;
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
            this.Icon1.Location = new System.Drawing.Point(522, 70);
            this.Icon1.Name = "Icon1";
            this.Icon1.Size = new System.Drawing.Size(40, 40);
            this.Icon1.TabIndex = 35;
            this.Icon1.Text = "1";
            this.Icon1.TextColor = System.Drawing.Color.White;
            this.Icon1.UseVisualStyleBackColor = false;
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
            this.BtnVolver.Location = new System.Drawing.Point(40, 440);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(87, 40);
            this.BtnVolver.TabIndex = 34;
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
            this.TxtBoxArriba._TextChanged += new System.EventHandler(this.TxtBoxId__TextChanged);
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
            this.TxtBoxAbajo.Location = new System.Drawing.Point(31, 288);
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
            this.BtnGuardar.Location = new System.Drawing.Point(143, 440);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(102, 40);
            this.BtnGuardar.TabIndex = 23;
            this.BtnGuardar.Text = "Siguiente";
            this.BtnGuardar.TextColor = System.Drawing.Color.White;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.botonRedondo1_Click);
            // 
            // NuevoHerramineta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.Icon2);
            this.Controls.Add(this.Icon1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnAjustes);
            this.Controls.Add(this.BtnGuardar);
            this.Name = "NuevoHerramineta";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(876, 500);
            this.Load += new System.EventHandler(this.NuevoUsuario_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnAjustes;
        private System.Windows.Forms.Label LblAbajo;
        private System.Windows.Forms.Label LblMedio;
        private AppLaboratorio.UserControlls.RJTextBox TxtBoxMedio;
        private BotonRedondo BtnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblArriba;
        private AppLaboratorio.UserControlls.RJTextBox TxtBoxArriba;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private BotonRedondo BtnVolver;
        private BotonRedondo Icon1;
        private BotonRedondo Icon2;
        private System.Windows.Forms.Label label2;
        private RJTextBox TxtBoxAbajo;
    }
}
