namespace HappyHollidays.Forms
{
    partial class FormDialogActivitats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDialogActivitats));
            this.labelGestionarActivitats = new System.Windows.Forms.Label();
            this.listBoxActivitatsDisponibles = new System.Windows.Forms.ListBox();
            this.bindingSourceActDisponibles = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAfegir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNomHotel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelActivitatsHotel = new System.Windows.Forms.Label();
            this.listBoxActivitatsHotel = new System.Windows.Forms.ListBox();
            this.bindingSourceActHotel = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelDescripcio = new System.Windows.Forms.Label();
            this.buttonTornar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGestionarActivitats
            // 
            this.labelGestionarActivitats.AutoSize = true;
            this.labelGestionarActivitats.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestionarActivitats.Location = new System.Drawing.Point(13, 9);
            this.labelGestionarActivitats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGestionarActivitats.Name = "labelGestionarActivitats";
            this.labelGestionarActivitats.Size = new System.Drawing.Size(427, 54);
            this.labelGestionarActivitats.TabIndex = 8;
            this.labelGestionarActivitats.Text = "Gestionar Activitats";
            // 
            // listBoxActivitatsDisponibles
            // 
            this.listBoxActivitatsDisponibles.DataSource = this.bindingSourceActDisponibles;
            this.listBoxActivitatsDisponibles.DisplayMember = "descripcion";
            this.listBoxActivitatsDisponibles.FormattingEnabled = true;
            this.listBoxActivitatsDisponibles.ItemHeight = 16;
            this.listBoxActivitatsDisponibles.Location = new System.Drawing.Point(22, 170);
            this.listBoxActivitatsDisponibles.Name = "listBoxActivitatsDisponibles";
            this.listBoxActivitatsDisponibles.Size = new System.Drawing.Size(269, 356);
            this.listBoxActivitatsDisponibles.TabIndex = 9;
            // 
            // bindingSourceActDisponibles
            // 
            this.bindingSourceActDisponibles.DataSource = typeof(HappyHollidays.Models.actividades);
            // 
            // buttonAfegir
            // 
            this.buttonAfegir.BackColor = System.Drawing.Color.LightPink;
            this.buttonAfegir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAfegir.BackgroundImage")));
            this.buttonAfegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfegir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAfegir.Location = new System.Drawing.Point(329, 306);
            this.buttonAfegir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAfegir.Name = "buttonAfegir";
            this.buttonAfegir.Size = new System.Drawing.Size(136, 62);
            this.buttonAfegir.TabIndex = 12;
            this.buttonAfegir.UseVisualStyleBackColor = false;
            this.buttonAfegir.Click += new System.EventHandler(this.buttonAfegir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightPink;
            this.pictureBox1.Location = new System.Drawing.Point(23, 159);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 5);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // labelNomHotel
            // 
            this.labelNomHotel.AutoSize = true;
            this.labelNomHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomHotel.Location = new System.Drawing.Point(16, 124);
            this.labelNomHotel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNomHotel.Name = "labelNomHotel";
            this.labelNomHotel.Size = new System.Drawing.Size(268, 31);
            this.labelNomHotel.TabIndex = 13;
            this.labelNomHotel.Text = "Activitats disponibles";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightPink;
            this.pictureBox2.Location = new System.Drawing.Point(520, 159);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(269, 5);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // labelActivitatsHotel
            // 
            this.labelActivitatsHotel.AutoSize = true;
            this.labelActivitatsHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActivitatsHotel.Location = new System.Drawing.Point(513, 124);
            this.labelActivitatsHotel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelActivitatsHotel.Name = "labelActivitatsHotel";
            this.labelActivitatsHotel.Size = new System.Drawing.Size(191, 31);
            this.labelActivitatsHotel.TabIndex = 16;
            this.labelActivitatsHotel.Text = "Activitats hotel";
            // 
            // listBoxActivitatsHotel
            // 
            this.listBoxActivitatsHotel.DataSource = this.bindingSourceActHotel;
            this.listBoxActivitatsHotel.DisplayMember = "descripcion";
            this.listBoxActivitatsHotel.FormattingEnabled = true;
            this.listBoxActivitatsHotel.ItemHeight = 16;
            this.listBoxActivitatsHotel.Location = new System.Drawing.Point(519, 170);
            this.listBoxActivitatsHotel.Name = "listBoxActivitatsHotel";
            this.listBoxActivitatsHotel.Size = new System.Drawing.Size(269, 356);
            this.listBoxActivitatsHotel.TabIndex = 15;
            // 
            // bindingSourceActHotel
            // 
            this.bindingSourceActHotel.DataSource = typeof(HappyHollidays.Models.actividades);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.LightPink;
            this.buttonEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.BackgroundImage")));
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEliminar.Location = new System.Drawing.Point(519, 533);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(130, 62);
            this.buttonEliminar.TabIndex = 18;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.LightPink;
            this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(657, 533);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(130, 62);
            this.buttonGuardar.TabIndex = 19;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelDescripcio
            // 
            this.labelDescripcio.AutoSize = true;
            this.labelDescripcio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcio.Location = new System.Drawing.Point(18, 76);
            this.labelDescripcio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescripcio.Name = "labelDescripcio";
            this.labelDescripcio.Size = new System.Drawing.Size(441, 25);
            this.labelDescripcio.TabIndex = 20;
            this.labelDescripcio.Text = "Gestiona les activitats que oferirà l\'hotel XXXXXX";
            // 
            // buttonTornar
            // 
            this.buttonTornar.BackColor = System.Drawing.Color.LightPink;
            this.buttonTornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTornar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTornar.ForeColor = System.Drawing.Color.White;
            this.buttonTornar.Location = new System.Drawing.Point(657, 9);
            this.buttonTornar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTornar.Name = "buttonTornar";
            this.buttonTornar.Size = new System.Drawing.Size(130, 62);
            this.buttonTornar.TabIndex = 21;
            this.buttonTornar.Text = "TORNAR";
            this.buttonTornar.UseVisualStyleBackColor = false;
            this.buttonTornar.Click += new System.EventHandler(this.buttonTornar_Click);
            // 
            // FormDialogActivitats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.buttonTornar);
            this.Controls.Add(this.labelDescripcio);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelActivitatsHotel);
            this.Controls.Add(this.listBoxActivitatsHotel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNomHotel);
            this.Controls.Add(this.buttonAfegir);
            this.Controls.Add(this.listBoxActivitatsDisponibles);
            this.Controls.Add(this.labelGestionarActivitats);
            this.Name = "FormDialogActivitats";
            this.Text = "FormDialogActivitats";
            this.Load += new System.EventHandler(this.FormDialogActivitats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGestionarActivitats;
        private System.Windows.Forms.ListBox listBoxActivitatsDisponibles;
        private System.Windows.Forms.Button buttonAfegir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNomHotel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelActivitatsHotel;
        private System.Windows.Forms.ListBox listBoxActivitatsHotel;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelDescripcio;
        private System.Windows.Forms.Button buttonTornar;
        private System.Windows.Forms.BindingSource bindingSourceActDisponibles;
        private System.Windows.Forms.BindingSource bindingSourceActHotel;
    }
}