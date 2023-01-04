namespace AppLaboratorio.UserControlls.PrestamosFolder
{
    partial class PrestamoAlumnoMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TitleBar = new FontAwesome.Sharp.IconButton();
            this.BtnInformacion = new System.Windows.Forms.Label();
            this.BtnCrear = new System.Windows.Forms.Label();
            this.DatagridAlumno = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ContainerOptions = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Herramienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Informacion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.devolver = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridAlumno)).BeginInit();
            this.panel3.SuspendLayout();
            this.ContainerOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TitleBar.FlatAppearance.BorderSize = 0;
            this.TitleBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBar.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleBar.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.TitleBar.IconColor = System.Drawing.Color.White;
            this.TitleBar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TitleBar.Location = new System.Drawing.Point(40, 9);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(422, 62);
            this.TitleBar.TabIndex = 34;
            this.TitleBar.Text = "Historial de prestamos";
            this.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleBar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TitleBar.UseVisualStyleBackColor = false;
            // 
            // BtnInformacion
            // 
            this.BtnInformacion.AutoSize = true;
            this.BtnInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInformacion.ForeColor = System.Drawing.Color.White;
            this.BtnInformacion.Location = new System.Drawing.Point(92, 1);
            this.BtnInformacion.Name = "BtnInformacion";
            this.BtnInformacion.Size = new System.Drawing.Size(96, 20);
            this.BtnInformacion.TabIndex = 37;
            this.BtnInformacion.Text = "Información";
            this.BtnInformacion.Click += new System.EventHandler(this.BtnInformacion_Click);
            // 
            // BtnCrear
            // 
            this.BtnCrear.AutoSize = true;
            this.BtnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.ForeColor = System.Drawing.Color.White;
            this.BtnCrear.Location = new System.Drawing.Point(40, 115);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(149, 24);
            this.BtnCrear.TabIndex = 38;
            this.BtnCrear.Text = "Nuevo prestamo";
            this.BtnCrear.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // DatagridAlumno
            // 
            this.DatagridAlumno.AllowUserToDeleteRows = false;
            this.DatagridAlumno.AllowUserToResizeColumns = false;
            this.DatagridAlumno.AllowUserToResizeRows = false;
            this.DatagridAlumno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(224)))));
            this.DatagridAlumno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatagridAlumno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DatagridAlumno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(107)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(107)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridAlumno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatagridAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Herramienta,
            this.Cantidad,
            this.Informacion,
            this.devolver});
            this.DatagridAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridAlumno.DefaultCellStyle = dataGridViewCellStyle4;
            this.DatagridAlumno.EnableHeadersVisualStyles = false;
            this.DatagridAlumno.Location = new System.Drawing.Point(40, 164);
            this.DatagridAlumno.Name = "DatagridAlumno";
            this.DatagridAlumno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridAlumno.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DatagridAlumno.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(204)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DatagridAlumno.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DatagridAlumno.RowTemplate.Height = 35;
            this.DatagridAlumno.Size = new System.Drawing.Size(633, 293);
            this.DatagridAlumno.TabIndex = 39;
            this.DatagridAlumno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridAlumno_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(638, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 53);
            this.panel3.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(94, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 22);
            this.panel2.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "Estudiantes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(0, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Docentes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ContainerOptions
            // 
            this.ContainerOptions.Controls.Add(this.label3);
            this.ContainerOptions.Controls.Add(this.panel5);
            this.ContainerOptions.Controls.Add(this.BtnInformacion);
            this.ContainerOptions.Location = new System.Drawing.Point(402, 96);
            this.ContainerOptions.Name = "ContainerOptions";
            this.ContainerOptions.Size = new System.Drawing.Size(194, 34);
            this.ContainerOptions.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Devolver";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(82, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 22);
            this.panel5.TabIndex = 42;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Matricula";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Herramienta
            // 
            this.Herramienta.HeaderText = "Herramienta";
            this.Herramienta.Name = "Herramienta";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Informacion
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Informacion";
            this.Informacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Informacion.HeaderText = "";
            this.Informacion.Name = "Informacion";
            // 
            // devolver
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Devolver";
            this.devolver.DefaultCellStyle = dataGridViewCellStyle3;
            this.devolver.HeaderText = "";
            this.devolver.Name = "devolver";
            // 
            // PrestamoAlumnoMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.ContainerOptions);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DatagridAlumno);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.TitleBar);
            this.Name = "PrestamoAlumnoMenu";
            this.Size = new System.Drawing.Size(876, 500);
            this.Load += new System.EventHandler(this.ListaFolios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridAlumno)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ContainerOptions.ResumeLayout(false);
            this.ContainerOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton TitleBar;
        private System.Windows.Forms.Label BtnInformacion;
        private System.Windows.Forms.Label BtnCrear;
        private System.Windows.Forms.DataGridView DatagridAlumno;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ContainerOptions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Herramienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn Informacion;
        private System.Windows.Forms.DataGridViewButtonColumn devolver;
    }
}
