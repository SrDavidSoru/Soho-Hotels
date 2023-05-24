using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.ComponentModel;

namespace StPaul_s.Class
{
    public class ButtonPers : Button
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.FromArgb(17, 91, 85);

        //Proprties
        [Category("Button Pers")]
        public int BorderSize { get => borderSize; 
            set { borderSize = value;
                this.Invalidate();
            } 
        }

        [Category("Button Pers")]
        public int BorderRadius { get => borderRadius; 
            set {
                if (value <= this.Height)
                {
                    borderRadius = value;
                }
                else
                {
                    borderRadius = this.Height;
                }
                this.Invalidate();
            }
        }

        [Category("Button Pers")]
        public Color BorderColor { get => borderColor; 
            set
            { 
                borderColor = value; 
                this.Invalidate();
            }
        }

        [Category("Button Pers")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("Button Pers")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Constructor
        public ButtonPers()
        {

            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(110, 51);
            this.BackColor = Color.FromArgb(17, 91, 85);
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        //Methods

        private void Button_Resize (Object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                BorderRadius = this.Height;
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

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectangleSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectangleBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectangleSurface, borderRadius))
                using (GraphicsPath pathBorders = GetFigurePath(rectangleBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    
                    //Button border
                    if (borderSize > 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorders);
                }
                
            }
            else  //Normal button
            {
                //Button border
                this.Region = new Region(rectangleSurface);
                if (borderSize > 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize)) {

                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(Object sender, EventArgs e) 
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
