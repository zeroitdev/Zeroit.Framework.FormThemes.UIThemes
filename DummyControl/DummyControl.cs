using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormEditors.UIThemes.ControlEditor
{
    [ToolboxItem(false)]
    public class DummyControl : Control
    {

        
        private ShapePopulate shapePopulate = new ShapePopulate(shapes.Rectangle, Color.DeepSkyBlue, Color.Yellow, true, false,true,10,10,10,10,10);
        //private ShapePopulate shapePopulate = new ShapePopulate();


        #region ShapePopulate Values

        private int upperLeftCurve_ShapePopulate;
        private int upperRightCurve_ShapePopulate;
        private int downLeftCurve_ShapePopulate;
        private int downRightCurve_ShapePopulate;
        private int curve_ShapePopulate;

        private bool rounding_ShapePopulate;
        private bool colorShape_ShapePopulate;
        private bool drawBorder_ShapePopulate;


        private Color bordercolor_ShapePopulate;
        private Color shapecolor_ShapePopulate;

        private int sides_ShapePopulate;
        private int radius_ShapePopulate;
        private int startingangle_ShapePopulate;
        private int controlWidth_ShapePopulate;

        private float startangle_ShapePopulate;
        private float endangle_ShapePopulate;

        #endregion

        
        public ShapePopulate ShapePopulate
        {
            get
            {
                return shapePopulate; 
                
            }
            set
            {
                shapePopulate = value.Clone();
                Invalidate();
            }
        }

        public Color ShapeColor
        {
            get { return shapePopulate.ShapeColor; }
            set
            {
                shapePopulate.ShapeColor = value;
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return shapePopulate.BorderColor; }
            set
            {
                shapePopulate.BorderColor = value;
                Invalidate();
            }
        }


        [Category("Pie Control")]
        public float StartAngle
        {
            get
            {
                return shapePopulate.StartAngle; }
            set
            {
                shapePopulate.StartAngle = value;
                Invalidate();
            }
        }

        [Category("Pie Control")]
        public float EndAngle
        {
            get { return shapePopulate.EndAngle; }
            set
            {
                shapePopulate.EndAngle = value;
                Invalidate();
            }
        }

        [Category("Rounded Rectangle Control")]
        public int Curve
        {
            get { return shapePopulate.Curve; }
            set
            {
                if (value > 0)
                {
                    shapePopulate.UpperLeftCurve = value;
                    shapePopulate.UpperRightCurve = value;
                    shapePopulate.DownLeftCurve = value;
                    shapePopulate.DownRightCurve = value;
                }

                if (value < 1)
                {
                    value = 1;
                    throw new ArgumentOutOfRangeException("", "Value must be more than 1");
                }

                shapePopulate.Curve = value;
                Invalidate();
            }
        }

        public int UpperLeftCurve
        {
            get { return shapePopulate.UpperLeftCurve; }
            set
            {
                shapePopulate.UpperLeftCurve = value;
                Invalidate();
            }
        }

        [Category("Rounded Rectangle Control")]
        public int UpperRightCurve
        {
            get { return shapePopulate.UpperRightCurve; }
            set
            {
                shapePopulate.UpperRightCurve = value;
                Invalidate();
            }
        }

        [Category("Rounded Rectangle Control")]
        public int DownLeftCurve
        {
            get { return shapePopulate.DownLeftCurve; }
            set
            {
                shapePopulate.DownLeftCurve = value;
                Invalidate();
            }
        }

        [Category("Rounded Rectangle Control")]
        public int DownRightCurve
        {
            get { return shapePopulate.DownRightCurve; }
            set
            {
                shapePopulate.DownRightCurve = value;
                Invalidate();
            }
        }


        public int BorderWidth
        {
            get { return shapePopulate.BorderWidth; }
            set
            {
                shapePopulate.BorderWidth = value;
                Invalidate();
            }
        }

        public bool ColorShape
        {
            get { return shapePopulate.ColorShape; }
            set
            {
                shapePopulate.ColorShape = value;
                Invalidate();
            }
        }

        
        public bool DrawBorder
        {
            get
            {
                return shapePopulate.DrawBorder;
                
            }
            set
            {
                shapePopulate.DrawBorder = value;
                Invalidate();
            }
        }

        public shapes Shape
        {
            get { return shapePopulate.Shape; }
            set
            {
                shapePopulate.Shape = value;
                Invalidate();
            }
        }
        
        public bool Rounding
        {
            get { return shapePopulate.Rounding; }
            set
            {
                shapePopulate.Rounding = value;
                Invalidate();
            }
        }

        #region Polygon

        private int sides = 3;
        private int radius = 10;
        private int startingAngle = 90;
        Point center;

        public Int32 PolygonSides
        {
            get { return shapePopulate.PolygonSides; }
            set
            {
                if (value < 3)
                {
                    shapePopulate.PolygonSides = 3;
                    throw new ArgumentOutOfRangeException("Minimum", "Value cannot go below 3.");
                }
                shapePopulate.PolygonSides = value;
                this.Invalidate();
            }
        }

        public Int32 PolygonRadius
        {
            get { return shapePopulate.PolygonRadius; }
            set
            {
                shapePopulate.PolygonRadius = value;
                this.Invalidate();
            }
        }

        public Int32 PolygonStartingAngle
        {
            get { return shapePopulate.PolygonStartingAngle; }
            set
            {
                shapePopulate.PolygonStartingAngle = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Return an array of 10 points to be used in a Draw- or FillPolygon method
        /// </summary>
        /// <param name="Orig"> The origin is the middle of the star.</param>
        /// <param name="outerradius">Radius of the surrounding circle.</param>
        /// <param name="innerradius">Radius of the circle for the "inner" points</param>
        /// <returns>Array of 10 PointF structures</returns>
        private Point[] CalculateVertices(int sides, int radius, int startingAngle, Point center)
        {
            if (sides < 3)
                throw new ArgumentException("Polygon must have 3 sides or more.");

            List<Point> points = new List<Point>();
            float step = 360.0f / sides;

            float angle = startingAngle; //starting angle
            for (double i = startingAngle; i < startingAngle + 360.0; i += step) //go in a circle
            {
                points.Add(DegreesToXY(angle, radius, center));
                angle += step;
            }

            return points.ToArray();
        }

        private Point DegreesToXY(float degrees, float radius, Point origin)
        {
            Point xy = new Point();
            double radians = degrees * Math.PI / 180.0;

            xy.X = (int)(Math.Cos(radians) * radius + origin.X);
            xy.Y = (int)(Math.Sin(-radians) * radius + origin.Y);

            return xy;
        }

        #endregion

        public DummyControl()
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            
        }

        public void RectangleControl(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rect = new Rectangle((shapePopulate.BorderWidth / 2), (shapePopulate.BorderWidth / 2), Width - shapePopulate.BorderWidth - 1, Height - shapePopulate.BorderWidth - 1);


            if (shapePopulate.ColorShape)
            {
                g.FillRectangle(new SolidBrush(shapePopulate.ShapeColor), rect);

                if (shapePopulate.DrawBorder)
                {
                    g.DrawRectangle(new Pen(shapePopulate.BorderColor, shapePopulate.BorderWidth), rect);
                }

            }

            else
            {
                g.DrawRectangle(new Pen(shapePopulate.BorderColor, shapePopulate.BorderWidth), rect);
            }

            
        }
        
        public void RoundedRectControl(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rect = new Rectangle((shapePopulate.BorderWidth / 2), (shapePopulate.BorderWidth / 2), Width - shapePopulate.BorderWidth - 1, Height - shapePopulate.BorderWidth - 1);
            

            GraphicsPath path = Draw.RoundRect(rect, shapePopulate.Curve, shapePopulate.UpperLeftCurve, shapePopulate.UpperRightCurve, shapePopulate.DownLeftCurve, shapePopulate.DownRightCurve);

            if (shapePopulate.ColorShape)
            {
                
                g.FillPath(new SolidBrush(shapePopulate.ShapeColor), path);

                if(shapePopulate.DrawBorder)
                {
                    g.DrawPath(new Pen(shapePopulate.BorderColor, shapePopulate.BorderWidth), path);
                }

            }

            else
            {
                g.DrawPath(new Pen(shapePopulate.BorderColor, shapePopulate.BorderWidth), path);
            }


        }

        public void CircleControl(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rect = new Rectangle((shapePopulate.BorderWidth / 2), (shapePopulate.BorderWidth / 2), Width - shapePopulate.BorderWidth - 1, Height - shapePopulate.BorderWidth - 1);

            if (shapePopulate.ColorShape)
            {

                g.FillEllipse(new SolidBrush(shapePopulate.ShapeColor), rect);

                if(shapePopulate.DrawBorder)
                {
                    g.DrawEllipse(new Pen(shapePopulate.BorderColor, shapePopulate.BorderWidth), rect);
                }

            }

            else
            {
                g.DrawEllipse(new Pen(shapePopulate.BorderColor, shapePopulate.BorderWidth), rect);
            }


        }

        public void PolygonControl(PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //g.SmoothingMode = SmoothingMode.HighQuality;
            //Rectangle rect = new Rectangle((borderWidth / 2), (borderWidth / 2), Width - borderWidth - 1, Height - borderWidth - 1);


            center = new Point(this.Width / 2, this.Height / 2);

            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            // init 4 stars


            Point[] PolyGon1 = CalculateVertices(shapePopulate.PolygonSides, shapePopulate.PolygonRadius, shapePopulate.PolygonStartingAngle, center);
            SolidBrush FillBrush = new SolidBrush(shapePopulate.ShapeColor);

            
            if (shapePopulate.ColorShape)
            {

                G.FillPolygon(FillBrush, PolyGon1);

                if (shapePopulate.DrawBorder)
                {
                    G.DrawPolygon(new Pen(shapePopulate.BorderColor, shapePopulate.BorderWidth), PolyGon1);
                }

            }

            else
            {
                G.DrawPolygon(new Pen(shapePopulate.BorderColor, shapePopulate.BorderWidth), PolyGon1);
            }
            
        }

        public void PieControl(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rect = new Rectangle((shapePopulate.BorderWidth / 2), (shapePopulate.BorderWidth / 2), Width - shapePopulate.BorderWidth - 1, Height - shapePopulate.BorderWidth - 1);

            if (shapePopulate.ColorShape)
            {

                g.FillPie(new SolidBrush(shapePopulate.ShapeColor), rect, shapePopulate.StartAngle, shapePopulate.EndAngle);

                if (shapePopulate.DrawBorder)
                {
                    g.DrawPie(new Pen(shapePopulate.BorderColor, shapePopulate.BorderWidth), rect, shapePopulate.StartAngle, shapePopulate.EndAngle);
                }

            }

            else
            {
                g.DrawPie(new Pen(shapePopulate.BorderColor, shapePopulate.BorderWidth), rect, shapePopulate.StartAngle, shapePopulate.EndAngle);
            }


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath path = new GraphicsPath();
            
            #region Testing
            Rectangle rect = new Rectangle((shapePopulate.BorderWidth / 2), (shapePopulate.BorderWidth / 2), Width - shapePopulate.BorderWidth - 1, Height - shapePopulate.BorderWidth - 1);

            //ShapePopulate_Value_Sets();
            #endregion

            switch (shapePopulate.Shape)
            {
                case shapes.Rectangle:

                    if (shapePopulate.Rounding)
                    {
                        shapePopulate.RoundedRectangleControl(e, path, rect);
                        //RoundedRectControl(e);
                    }
                    else
                    {
                        shapePopulate.RectangleControl(e, rect);
                        //RectangleControl(e);
                    }

                    break;
                //case shapes.RoundedRectangle:
                //    //RoundedRectControl(e);
                //    break;
                case shapes.Circle:
                    shapePopulate.CircleControl(e, rect);
                    //CircleControl(e);
                    break;
                case shapes.Polygon:
                    shapePopulate.PolygonControl(e, rect);
                    //PolygonControl(e);
                    break;
                case shapes.Pie:
                    shapePopulate.PieControl(e, rect, shapePopulate.StartAngle, shapePopulate.EndAngle);
                    //PieControl(e);
                    break;
                //case shapes.Custom:
                    //shapePopulate.GetShapeAlt(e,TypeOfShape,rect);
                    
                    break;
            }

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            switch (shapePopulate.Shape)
            {
                case shapes.Polygon:
                    shapePopulate.PolygonRadius = (Width / 2);
                    break;
            }
            
        }


    }


}
