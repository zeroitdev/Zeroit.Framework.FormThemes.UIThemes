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

    public class ShapeControl : Control
    {

        private bool colorShape = true;
        private bool drawBorder = true;
        private bool rounding = false;

        private int curve = 10;
        private int borderWidth = 1;

        private int upperLeftCurve = 10;
        private int upperRightCurve = 10;
        private int downLeftCurve = 10;
        private int downRightCurve = 10;

        private float startAngle = 0f;
        private float endAngle = 90f;

        private Color shapeColor = Color.Yellow;
        private Color borderColor = Color.Black;

        public shapes _shapes = shapes.Rectangle;

        
        private ShapePopulate shapePopulate = new ShapePopulate();


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

        public void ShapePopulate_Value_Sets()
        {
            upperLeftCurve_ShapePopulate = shapePopulate.UpperLeftCurve;
            upperRightCurve_ShapePopulate = shapePopulate.UpperRightCurve;
            downLeftCurve_ShapePopulate = shapePopulate.DownLeftCurve;
            downRightCurve_ShapePopulate = shapePopulate.DownRightCurve;
            curve_ShapePopulate = shapePopulate.Curve;

            rounding_ShapePopulate = shapePopulate.Rounding;
            colorShape_ShapePopulate = shapePopulate.ColorShape;
            drawBorder_ShapePopulate = shapePopulate.ColorShape;


            bordercolor_ShapePopulate = shapePopulate.BorderColor;
            shapecolor_ShapePopulate = shapePopulate.ShapeColor;

            sides_ShapePopulate = shapePopulate.PolygonSides;
            radius_ShapePopulate = shapePopulate.PolygonRadius;
            startingangle_ShapePopulate = shapePopulate.PolygonStartingAngle;
            controlWidth_ShapePopulate = shapePopulate.ControlWidth;

            startangle_ShapePopulate = shapePopulate.StartAngle;
            endangle_ShapePopulate = shapePopulate.EndAngle;
    }


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
            get { return shapeColor; }
            set
            {
                shapeColor = value;
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }


        [Category("Pie Control")]
        public float StartAngle
        {
            get { return startAngle; }
            set
            {
                startAngle = value;
                Invalidate();
            }
        }

        [Category("Pie Control")]
        public float EndAngle
        {
            get { return endAngle; }
            set
            {
                endAngle = value;
                Invalidate();
            }
        }

        [Category("Rounded Rectangle Control")]
        public int Curve
        {
            get { return curve; }
            set
            {
                if (value > 0)
                {
                    upperLeftCurve = value;
                    upperRightCurve = value;
                    downLeftCurve = value;
                    downRightCurve = value;
                }

                if (value < 1)
                {
                    value = 1;
                    throw new ArgumentOutOfRangeException("", "Value must be more than 1");
                }

                curve = value;
                Invalidate();
            }
        }

        public int UpperLeftCurve
        {
            get { return upperLeftCurve; }
            set
            {
                upperLeftCurve = value;
                Invalidate();
            }
        }

        [Category("Rounded Rectangle Control")]
        public int UpperRightCurve
        {
            get { return upperRightCurve; }
            set
            {
                upperRightCurve = value;
                Invalidate();
            }
        }

        [Category("Rounded Rectangle Control")]
        public int DownLeftCurve
        {
            get { return downLeftCurve; }
            set
            {
                downLeftCurve = value;
                Invalidate();
            }
        }

        [Category("Rounded Rectangle Control")]
        public int DownRightCurve
        {
            get { return downRightCurve; }
            set
            {
                downRightCurve = value;
                Invalidate();
            }
        }


        public int BorderWidth
        {
            get { return borderWidth; }
            set
            {
                borderWidth = value;
                Invalidate();
            }
        }

        public bool ColorShape
        {
            get { return colorShape; }
            set
            {
                colorShape = value;
                Invalidate();
            }
        }


        public shapes TypeOfShape
        {
            get { return shapePopulate.ShapeType; }
            set
            {
                shapePopulate.ShapeType = value;
                Invalidate();
            }
        }

        public int TypeOfLeftCurve
        {
            get { return shapePopulate.UpperLeftCurve; }
            set
            {
                shapePopulate.UpperLeftCurve = value;
                Invalidate();
            }
        }

        public bool DrawBorder
        {
            get
            {
                return drawBorder;
                
            }
            set
            {
                drawBorder = value;
                Invalidate();
            }
        }

        public shapes Shape
        {
            get { return _shapes; }
            set
            {
                _shapes = value;
                Invalidate();
            }
        }
        
        public bool Rounding
        {
            get { return rounding; }
            set
            {
                rounding = value;
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
            get { return sides; }
            set
            {
                if (value < 3)
                {
                    sides = 3;
                    throw new ArgumentOutOfRangeException("Minimum", "Value cannot go below 3.");
                }
                sides = value;
                this.Invalidate();
            }
        }

        public Int32 PolygonRadius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.Invalidate();
            }
        }

        public Int32 PolygonStartingAngle
        {
            get { return startingAngle; }
            set
            {
                startingAngle = value;
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

        public ShapeControl()
        {

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            
        }

        public void RectangleControl(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rect = new Rectangle((borderWidth / 2), (borderWidth / 2), Width - borderWidth - 1, Height - borderWidth - 1);


            if (colorShape)
            {
                g.FillRectangle(new SolidBrush(shapeColor), rect);

                if (drawBorder)
                {
                    g.DrawRectangle(new Pen(borderColor, borderWidth), rect);
                }

            }

            else
            {
                g.DrawRectangle(new Pen(borderColor, borderWidth), rect);
            }

            
        }
        
        public void RoundedRectControl(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rect = new Rectangle((borderWidth / 2), (borderWidth / 2), Width - borderWidth - 1, Height - borderWidth - 1);
            

            GraphicsPath path = Draw.RoundRect(rect,curve, upperLeftCurve,upperRightCurve, downLeftCurve, downRightCurve);

            if (colorShape)
            {
                
                g.FillPath(new SolidBrush(shapeColor), path);

                if(drawBorder)
                {
                    g.DrawPath(new Pen(borderColor, borderWidth), path);
                }

            }

            else
            {
                g.DrawPath(new Pen(borderColor,borderWidth), path);
            }


        }

        public void CircleControl(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rect = new Rectangle((borderWidth / 2), (borderWidth / 2), Width - borderWidth - 1, Height - borderWidth - 1);

            if (colorShape)
            {

                g.FillEllipse(new SolidBrush(shapeColor), rect);

                if(drawBorder)
                {
                    g.DrawEllipse(new Pen(borderColor, borderWidth), rect);
                }

            }

            else
            {
                g.DrawEllipse(new Pen(borderColor, borderWidth), rect);
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


            Point[] PolyGon1 = CalculateVertices(sides, radius, startingAngle, center);
            SolidBrush FillBrush = new SolidBrush(shapeColor);

            
            if (colorShape)
            {

                G.FillPolygon(FillBrush, PolyGon1);

                if (drawBorder)
                {
                    G.DrawPolygon(new Pen(borderColor, borderWidth), PolyGon1);
                }

            }

            else
            {
                G.DrawPolygon(new Pen(borderColor, borderWidth), PolyGon1);
            }
            
        }

        public void PieControl(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rect = new Rectangle((borderWidth / 2), (borderWidth / 2), Width - borderWidth - 1, Height - borderWidth - 1);

            if (colorShape)
            {

                g.FillPie(new SolidBrush(shapeColor), rect, startAngle, endAngle);

                if (drawBorder)
                {
                    g.DrawPie(new Pen(borderColor, borderWidth), rect, startAngle, endAngle);
                }

            }

            else
            {
                g.DrawPie(new Pen(borderColor, borderWidth), rect, startAngle, endAngle);
            }


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            
            #region Testing
            Rectangle rect = new Rectangle((borderWidth / 2), (borderWidth / 2), Width - borderWidth - 1, Height - borderWidth - 1);

            //ShapePopulate_Value_Sets();
            #endregion

            switch (_shapes)
            {
                case shapes.Rectangle:

                    if (rounding)
                    {
                        RoundedRectControl(e);
                    }
                    else
                    {
                        RectangleControl(e);
                    }

                    break;
                //case shapes.RoundedRectangle:
                //    //RoundedRectControl(e);
                //    break;
                case shapes.Circle:
                    CircleControl(e);
                    break;
                case shapes.Polygon:
                    PolygonControl(e);
                    break;
                case shapes.Pie:
                    PieControl(e);
                    break;
                //case shapes.None:
                //    shapePopulate.GetShapeAlt(e,TypeOfShape,rect);
                    
                    break;
            }

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            switch (_shapes)
            {
                case shapes.Polygon:
                    radius = (Width / 2);
                    break;
            }
            
        }


    }


}
