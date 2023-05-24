using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using Button = System.Windows.Forms.Button;

namespace StPaul_s.Class
{
    [DefaultEvent("_SelectedIndexChanged")]
    class ComboBox_Pers : UserControl
    {
        //Fiels
        private Color backColor = Color.Azure;
        private Color iconColor = Color.White;
        private Color listBackColor = Color.Azure;
        private Color listTextColor = Color.White;
        private Color borderColor = Color.Azure;
        private int borderSize = 0;
        private int borderRadius = 0;

        //Items
        private ComboBox cmbList;
        private Label lblTxt;
        private Button btnIcon;



        //Properties
        [Category("Pers ComboBox")]
        public new Color BackColor
        {
            get => backColor;
            set
            {
                backColor = value;
                lblTxt.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }

        [Category("Pers ComboBox")]
        public Color IconColor
        {
            get => iconColor;
            set
            {
                iconColor = value;
                btnIcon.Invalidate();//Redraw icon
            }
        }

        [Category("Pers ComboBox")]
        public Color ListBackColor
        {
            get => listBackColor;
            set
            {
                listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }

        [Category("Pers ComboBox")]
        public Color ListTextColor
        {
            get => listTextColor;
            set
            {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;
            }
        }

        [Category("Pers ComboBox")]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                base.BackColor = borderColor;//Border color
            }
        }

        [Category("Pers ComboBox")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);//Border size
                AdjustComboBoxDimensions();
            }
        }

        [Category("Pers ComboBox")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
            }
        }

        [Category("Pers ComboBox")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                lblTxt.ForeColor = value;
            }
        }

        [Category("Pers ComboBox")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                lblTxt.Font = value;
                cmbList.Font = value;
            }
        }

        [Category("Pers ComboBox")]
        public string Texts {
            get { return lblTxt.Text; }
            set { lblTxt.Text = value; }
        }

        [Category("Pers ComboBox")]
        public ComboBoxStyle DropDownStyle 
        {
            get { return cmbList.DropDownStyle; }
            set 
            {
                if(cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }

        //Data
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", typeof(UITypeEditor))]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get
            {
                return cmbList.Items;
            }
        }

        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint),
        AttributeProvider(typeof(IListSource))]
        public new object DataSource
        {
            get 
            {
                return cmbList.DataSource;
            }
            set
            {
                cmbList.DataSource = value;
            }
        }

        [DefaultValue(AutoCompleteMode.None)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get
            {
                return cmbList.AutoCompleteMode;
            }
            set
            {
                cmbList.AutoCompleteMode = value;
            }
        }

        [DefaultValue(AutoCompleteSource.None)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get
            {
                return cmbList.AutoCompleteSource;
            }
            set
            {
                cmbList.AutoCompleteSource = value;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", typeof(UITypeEditor))]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get
            {
                return cmbList.AutoCompleteCustomSource;
            }
            set
            {
                cmbList.AutoCompleteCustomSource = value;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get
            {
                return cmbList.SelectedIndex;
            }
            set
            {
                cmbList.SelectedIndex = value;
            }
        }

        [Browsable(false)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get
            {
                return cmbList.SelectedItem;
            }
            set
            {
                cmbList.SelectedItem = value;
            }
        }



        //Events
        public event EventHandler _SelectedIndexChanged;

        //Constructor
        public ComboBox_Pers() 
        {
            cmbList = new ComboBox();
            lblTxt = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            //ComboBox: Dropdown list
            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(this.Font.Name, 10F);
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged); //Default event
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged); //Refresh text

            //Button icon
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);//Open dropdown
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);//Draw icon

            //Label: Text
            lblTxt.Dock = DockStyle.Fill;
            lblTxt.AutoSize = false;
            lblTxt.BackColor = backColor;
            lblTxt.TextAlign = ContentAlignment.MiddleLeft;
            lblTxt.Padding = new Padding(8, 0, 0, 0);
            lblTxt.Font = new Font(this.Font.Name, 10F);
            //Attach label events to user control event
            lblTxt.Click += new EventHandler(Surface_Click);//Select combo box
            lblTxt.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblTxt.MouseLeave += new EventHandler(Surface_MouseLeave);

            //User Control
            this.Controls.Add(lblTxt);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cmbList);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.White;
            this.Padding = new Padding(borderSize);
            base.BackColor = borderColor; //Border color
            this.ResumeLayout();
            AdjustComboBoxDimensions();

        }

        //Private methods

        //Default event
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_SelectedIndexChanged != null)
                _SelectedIndexChanged.Invoke(sender, e);
            //Refresh text
            lblTxt.Text = cmbList.Text;
        }

        //Draw icon
        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            //Fiels
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;

            //Draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        //Items actions
        private void Icon_Click(object sender, EventArgs e)
        {
            //Open dropdown list
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

        //Event methods
        private void Surface_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            //Select ComboBox
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;//Open dropdown list
        }

        //Adjust comboBox
        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = lblTxt.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblTxt.Bottom - cmbList.Height
            };
        }

        //Change text
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            //Refresh text
            lblTxt.Text = cmbList.Text;
        }

        //Attach label events to user control event
        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        //Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;

            if (borderRadius > 1) //Rounded
            {
                //Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.backColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {//Drawing
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) SetTextBoxRoundedRegion();
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    //Draw border smoothing
                    graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                    //Draw border
                    graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            
            pathTxt = GetFigurePath(cmbList.ClientRectangle, BorderRadius - borderSize);
            cmbList.Region = new Region(pathTxt);
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
