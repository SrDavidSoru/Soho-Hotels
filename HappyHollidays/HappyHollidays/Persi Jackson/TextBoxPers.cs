using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StPaul_s.Class
{
    [DefaultEvent("_TextChanged")]
    public partial class TextBoxPers : UserControl
    {
        //Fiels
        private Color borderColor = Color.FromArgb(17, 91, 85);
        private int borderSize = 0;
        private int borderRadius = 0;
        private bool underLinedStyle = false;
        private Color borderFocusColor = Color.Black;
        private bool isFocused = false;

        public TextBoxPers()
        {
            InitializeComponent();
        }

        //Events
        public event EventHandler _TextChanged;
        
        //Properties
        [Category("Pers TextBox")]
        public Color BorderColor { get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Pers TextBox")]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Pers TextBox")]
        public bool UnderLinedStyle
        {
            get => underLinedStyle;
            set
            { 
                underLinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("Pers TextBox")]
        public bool PasswordChar 
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        [Category("Pers TextBox")]
        public bool Multiline 
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("Pers TextBox")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("Pers TextBox")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("Pers TextBox")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category ("Pers TextBox")]
        public string Texts {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        [Category("Pers TextBox")]
        public Color BorderFocusColor
        {
            get
            {
                return borderFocusColor;
            }
            set
            {
                borderFocusColor = value;
            }
        }

        [Category("Pers TextBox")]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();//Redraw control
                }
            }
        }

        //Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;

            if (borderRadius > 1) //Rounded
            {
                //Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, - borderSize, -borderSize);
                int smoothSize = borderSize > 0? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //Drawing
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) SetTextBoxRoundedRegion();
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

                    if (isFocused) penBorder.Color = BorderFocusColor;

                    if (underLinedStyle) //Line Style
                    {
                        //Draw boder smoothing
                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graphics.SmoothingMode= SmoothingMode.None;
                        graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Rectangle Style
                    {
                        //Draw border smoothing
                        graphics.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                } 
            }
            else //Rectangle 
            {

                //Draw border
                using (Pen penBorder = new Pen(BorderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                    if (!isFocused)
                    {
                        if (underLinedStyle) //Line Style
                        {
                            graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else //Rectangle Style
                        {
                            graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                        }
                    }
                    else
                    {
                        penBorder.Color = borderFocusColor;

                        if (underLinedStyle) //Line Style
                        {
                            graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else //Rectangle Style
                        {
                            graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                        }
                    }
                }
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, BorderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            } 
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize * 2);
                textBox1.Region = new Region(pathTxt); 
            }
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
    }
}
