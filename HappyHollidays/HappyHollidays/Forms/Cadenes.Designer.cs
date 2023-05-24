namespace HappyHollidays.Forms
{
    partial class Cadenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadenes));
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxNomCadenes = new System.Windows.Forms.TextBox();
            this.dataGridViewCadenes = new System.Windows.Forms.DataGridView();
            this.labelCadenes = new System.Windows.Forms.Label();
            this.cifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirfisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourcCadenes = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCadenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcCadenes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.Color.LightPink;
            this.buttonEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEditar.BackgroundImage")));
            this.buttonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEditar.Location = new System.Drawing.Point(877, 382);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(136, 62);
            this.buttonEditar.TabIndex = 13;
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.LightPink;
            this.buttonEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.BackgroundImage")));
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEliminar.Location = new System.Drawing.Point(877, 450);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(136, 62);
            this.buttonEliminar.TabIndex = 12;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.BackColor = System.Drawing.Color.LightPink;
            this.buttonAfegir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAfegir.BackgroundImage")));
            this.buttonAfegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfegir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAfegir.Location = new System.Drawing.Point(877, 127);
            this.buttonAfegir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(136, 62);
            this.buttonAfegir.TabIndex = 11;
            this.buttonAfegir.UseVisualStyleBackColor = false;
            this.buttonAfegir.Click += new System.EventHandler(this.buttonAfegir_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.LightPink;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBuscar.Location = new System.Drawing.Point(747, 90);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(111, 30);
            this.buttonBuscar.TabIndex = 10;
            this.buttonBuscar.Text = "BUSCAR";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxNomCadenes
            // 
            this.textBoxNomCadenes.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNomCadenes.Location = new System.Drawing.Point(43, 94);
            this.textBoxNomCadenes.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNomCadenes.Name = "textBoxNomCadenes";
            this.textBoxNomCadenes.Size = new System.Drawing.Size(695, 22);
            this.textBoxNomCadenes.TabIndex = 9;
            this.textBoxNomCadenes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNomCadenes_KeyPress);
            // 
            // dataGridViewCadenes
            // 
            this.dataGridViewCadenes.AllowUserToAddRows = false;
            this.dataGridViewCadenes.AllowUserToDeleteRows = false;
            this.dataGridViewCadenes.AutoGenerateColumns = false;
            this.dataGridViewCadenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCadenes.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridViewCadenes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCadenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCadenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cifDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.dirfisDataGridViewTextBoxColumn});
            this.dataGridViewCadenes.DataSource = this.bindingSourcCadenes;
            this.dataGridViewCadenes.GridColor = System.Drawing.Color.LightPink;
            this.dataGridViewCadenes.Location = new System.Drawing.Point(43, 127);
            this.dataGridViewCadenes.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCadenes.MultiSelect = false;
            this.dataGridViewCadenes.Name = "dataGridViewCadenes";
            this.dataGridViewCadenes.ReadOnly = true;
            this.dataGridViewCadenes.RowHeadersWidth = 51;
            this.dataGridViewCadenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCadenes.Size = new System.Drawing.Size(815, 385);
            this.dataGridViewCadenes.TabIndex = 8;
            // 
            // labelCadenes
            // 
            this.labelCadenes.AutoSize = true;
            this.labelCadenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadenes.Location = new System.Drawing.Point(33, 26);
            this.labelCadenes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCadenes.Name = "labelCadenes";
            this.labelCadenes.Size = new System.Drawing.Size(211, 54);
            this.labelCadenes.TabIndex = 7;
            this.labelCadenes.Text = "Cadenes";
            // 
            // cifDataGridViewTextBoxColumn
            // 
            this.cifDataGridViewTextBoxColumn.DataPropertyName = "cif";
            this.cifDataGridViewTextBoxColumn.HeaderText = "CIF";
            this.cifDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cifDataGridViewTextBoxColumn.Name = "cifDataGridViewTextBoxColumn";
            this.cifDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dirfisDataGridViewTextBoxColumn
            // 
            this.dirfisDataGridViewTextBoxColumn.DataPropertyName = "dir_fis";
            this.dirfisDataGridViewTextBoxColumn.HeaderText = "Direcció";
            this.dirfisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dirfisDataGridViewTextBoxColumn.Name = "dirfisDataGridViewTextBoxColumn";
            this.dirfisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourcCadenes
            // 
            this.bindingSourcCadenes.DataSource = typeof(HappyHollidays.Models.cadenas);
            // 
            // Cadenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1045, 538);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAfegir);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxNomCadenes);
            this.Controls.Add(this.dataGridViewCadenes);
            this.Controls.Add(this.labelCadenes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cadenes";
            this.Text = "Cadenes";
            this.Load += new System.EventHandler(this.Cadenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCadenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcCadenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAfegir;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxNomCadenes;
        private System.Windows.Forms.DataGridView dataGridViewCadenes;
        private System.Windows.Forms.Label labelCadenes;
        private System.Windows.Forms.BindingSource bindingSourcCadenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dirfisDataGridViewTextBoxColumn;
    }
}