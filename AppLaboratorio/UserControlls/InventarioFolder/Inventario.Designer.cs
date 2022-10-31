namespace AppLaboratorio.UserControlls.InventarioFolder
{
    partial class Inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DatagridHerramienta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleBar = new FontAwesome.Sharp.IconButton();
            this.BtnInformacion = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCrear = new System.Windows.Forms.Label();
            this.OptionsContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridHerramienta)).BeginInit();
            this.OptionsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatagridHerramienta
            // 
            this.DatagridHerramienta.AllowUserToResizeColumns = false;
            this.DatagridHerramienta.AllowUserToResizeRows = false;
            this.DatagridHerramienta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            this.DatagridHerramienta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatagridHerramienta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DatagridHerramienta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(13)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridHerramienta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatagridHerramienta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DatagridHerramienta.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridHerramienta.DefaultCellStyle = dataGridViewCellStyle2;
            this.DatagridHerramienta.EnableHeadersVisualStyles = false;
            this.DatagridHerramienta.Location = new System.Drawing.Point(32, 125);
            this.DatagridHerramienta.Name = "DatagridHerramienta";
            this.DatagridHerramienta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(135)))), ((int)(((byte)(5)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridHerramienta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DatagridHerramienta.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(122)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(82)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DatagridHerramienta.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DatagridHerramienta.RowTemplate.Height = 34;
            this.DatagridHerramienta.Size = new System.Drawing.Size(402, 340);
            this.DatagridHerramienta.TabIndex = 31;
            this.DatagridHerramienta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridFolios_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Herramienta";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
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
            this.TitleBar.Location = new System.Drawing.Point(32, 2);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(422, 62);
            this.TitleBar.TabIndex = 34;
            this.TitleBar.Text = "Inventario de herramientas";
            this.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleBar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TitleBar.UseVisualStyleBackColor = false;
            // 
            // BtnInformacion
            // 
            this.BtnInformacion.AutoSize = true;
            this.BtnInformacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInformacion.Font = new System.Drawing.Font("Liberation Sans Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInformacion.ForeColor = System.Drawing.Color.White;
            this.BtnInformacion.Location = new System.Drawing.Point(76, 0);
            this.BtnInformacion.Name = "BtnInformacion";
            this.BtnInformacion.Size = new System.Drawing.Size(87, 22);
            this.BtnInformacion.TabIndex = 37;
            this.BtnInformacion.Text = "Infomaciòn";
            this.BtnInformacion.Click += new System.EventHandler(this.BtnInformacion_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.AutoSize = true;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.Font = new System.Drawing.Font("Liberation Sans Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(-4, 0);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(65, 22);
            this.BtnEliminar.TabIndex = 35;
            this.BtnEliminar.Text = "Eliminar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(67, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 22);
            this.panel1.TabIndex = 36;
            // 
            // BtnCrear
            // 
            this.BtnCrear.AutoSize = true;
            this.BtnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCrear.Font = new System.Drawing.Font("Liberation Sans Narrow", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.ForeColor = System.Drawing.Color.White;
            this.BtnCrear.Location = new System.Drawing.Point(43, 79);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(191, 22);
            this.BtnCrear.TabIndex = 38;
            this.BtnCrear.Text = "Añadir nueva herramienta";
            this.BtnCrear.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // OptionsContainer
            // 
            this.OptionsContainer.Controls.Add(this.BtnInformacion);
            this.OptionsContainer.Controls.Add(this.BtnEliminar);
            this.OptionsContainer.Controls.Add(this.panel1);
            this.OptionsContainer.Location = new System.Drawing.Point(455, 140);
            this.OptionsContainer.Name = "OptionsContainer";
            this.OptionsContainer.Size = new System.Drawing.Size(163, 25);
            this.OptionsContainer.TabIndex = 39;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.OptionsContainer);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.DatagridHerramienta);
            this.Name = "Inventario";
            this.Size = new System.Drawing.Size(876, 500);
            this.Load += new System.EventHandler(this.ListaFolios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridHerramienta)).EndInit();
            this.OptionsContainer.ResumeLayout(false);
            this.OptionsContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DatagridHerramienta;
        private FontAwesome.Sharp.IconButton TitleBar;
        private System.Windows.Forms.Label BtnInformacion;
        private System.Windows.Forms.Label BtnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BtnCrear;
        private System.Windows.Forms.Panel OptionsContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
