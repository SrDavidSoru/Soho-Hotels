namespace HappyHollidays.Forms
{
    partial class Hotels
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotels));
            this.labelHotels = new System.Windows.Forms.Label();
            this.dataGridViewHotels = new System.Windows.Forms.DataGridView();
            this.textBoxNomHotels = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idciudadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acthotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadenasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceHotels = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHotels)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHotels
            // 
            this.labelHotels.AutoSize = true;
            this.labelHotels.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotels.Location = new System.Drawing.Point(39, 25);
            this.labelHotels.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHotels.Name = "labelHotels";
            this.labelHotels.Size = new System.Drawing.Size(156, 54);
            this.labelHotels.TabIndex = 0;
            this.labelHotels.Text = "Hotels";
            // 
            // dataGridViewHotels
            // 
            this.dataGridViewHotels.AllowUserToAddRows = false;
            this.dataGridViewHotels.AllowUserToDeleteRows = false;
            this.dataGridViewHotels.AutoGenerateColumns = false;
            this.dataGridViewHotels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHotels.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridViewHotels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewHotels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHotels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.idciudadDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.cifDataGridViewTextBoxColumn,
            this.acthotelDataGridViewTextBoxColumn,
            this.cadenasDataGridViewTextBoxColumn,
            this.ciudadesDataGridViewTextBoxColumn});
            this.dataGridViewHotels.DataSource = this.bindingSourceHotels;
            this.dataGridViewHotels.GridColor = System.Drawing.Color.LightPink;
            this.dataGridViewHotels.Location = new System.Drawing.Point(48, 126);
            this.dataGridViewHotels.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewHotels.MultiSelect = false;
            this.dataGridViewHotels.Name = "dataGridViewHotels";
            this.dataGridViewHotels.ReadOnly = true;
            this.dataGridViewHotels.RowHeadersWidth = 51;
            this.dataGridViewHotels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHotels.Size = new System.Drawing.Size(815, 385);
            this.dataGridViewHotels.TabIndex = 1;
            this.dataGridViewHotels.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewHotels_CellFormatting);
            // 
            // textBoxNomHotels
            // 
            this.textBoxNomHotels.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNomHotels.Location = new System.Drawing.Point(48, 92);
            this.textBoxNomHotels.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomHotels.Name = "textBoxNomHotels";
            this.textBoxNomHotels.Size = new System.Drawing.Size(695, 22);
            this.textBoxNomHotels.TabIndex = 2;
            this.textBoxNomHotels.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNomHotels_KeyPress);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.LightPink;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBuscar.Location = new System.Drawing.Point(752, 89);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(111, 30);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.BackColor = System.Drawing.Color.LightPink;
            this.buttonAfegir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAfegir.BackgroundImage")));
            this.buttonAfegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfegir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAfegir.Location = new System.Drawing.Point(883, 126);
            this.buttonAfegir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(136, 62);
            this.buttonAfegir.TabIndex = 4;
            this.buttonAfegir.UseVisualStyleBackColor = false;
            this.buttonAfegir.Click += new System.EventHandler(this.buttonAfegir_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.LightPink;
            this.buttonEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.BackgroundImage")));
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEliminar.Location = new System.Drawing.Point(883, 449);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(136, 62);
            this.buttonEliminar.TabIndex = 5;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.LightPink;
            this.buttonEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditar.BackgroundImage")));
            this.buttonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEditar.Location = new System.Drawing.Point(883, 380);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(136, 62);
            this.buttonEditar.TabIndex = 6;
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idciudadDataGridViewTextBoxColumn
            // 
            this.idciudadDataGridViewTextBoxColumn.DataPropertyName = "id_ciudad";
            this.idciudadDataGridViewTextBoxColumn.HeaderText = "Ciudad";
            this.idciudadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idciudadDataGridViewTextBoxColumn.Name = "idciudadDataGridViewTextBoxColumn";
            this.idciudadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Estrelles";
            this.categoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direcció";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telèfon";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipus";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cifDataGridViewTextBoxColumn
            // 
            this.cifDataGridViewTextBoxColumn.DataPropertyName = "cif";
            this.cifDataGridViewTextBoxColumn.HeaderText = "Cadena";
            this.cifDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cifDataGridViewTextBoxColumn.Name = "cifDataGridViewTextBoxColumn";
            this.cifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acthotelDataGridViewTextBoxColumn
            // 
            this.acthotelDataGridViewTextBoxColumn.DataPropertyName = "act_hotel";
            this.acthotelDataGridViewTextBoxColumn.HeaderText = "act_hotel";
            this.acthotelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acthotelDataGridViewTextBoxColumn.Name = "acthotelDataGridViewTextBoxColumn";
            this.acthotelDataGridViewTextBoxColumn.ReadOnly = true;
            this.acthotelDataGridViewTextBoxColumn.Visible = false;
            // 
            // cadenasDataGridViewTextBoxColumn
            // 
            this.cadenasDataGridViewTextBoxColumn.DataPropertyName = "cadenas";
            this.cadenasDataGridViewTextBoxColumn.HeaderText = "cadenas";
            this.cadenasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cadenasDataGridViewTextBoxColumn.Name = "cadenasDataGridViewTextBoxColumn";
            this.cadenasDataGridViewTextBoxColumn.ReadOnly = true;
            this.cadenasDataGridViewTextBoxColumn.Visible = false;
            // 
            // ciudadesDataGridViewTextBoxColumn
            // 
            this.ciudadesDataGridViewTextBoxColumn.DataPropertyName = "ciudades";
            this.ciudadesDataGridViewTextBoxColumn.HeaderText = "ciudades";
            this.ciudadesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ciudadesDataGridViewTextBoxColumn.Name = "ciudadesDataGridViewTextBoxColumn";
            this.ciudadesDataGridViewTextBoxColumn.ReadOnly = true;
            this.ciudadesDataGridViewTextBoxColumn.Visible = false;
            // 
            // bindingSourceHotels
            // 
            this.bindingSourceHotels.DataSource = typeof(HappyHollidays.Models.hoteles);
            // 
            // Hotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1045, 538);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAfegir);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxNomHotels);
            this.Controls.Add(this.dataGridViewHotels);
            this.Controls.Add(this.labelHotels);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hotels";
            this.Text = "Hotels";
            this.Load += new System.EventHandler(this.Hotels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHotels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHotels;
        private System.Windows.Forms.DataGridView dataGridViewHotels;
        private System.Windows.Forms.TextBox textBoxNomHotels;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAfegir;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.BindingSource bindingSourceHotels;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idciudadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acthotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadenasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudadesDataGridViewTextBoxColumn;
    }
}