using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Reflection;

namespace Zeroit.Framework.FormEditors.UIThemes.ControlEditor
{

    public enum ShapeType
    {
        /// <summary>
        /// 	Specifies a pie control type.
        /// </summary>
        None,
        /// <summary>
        /// 	Specifies a rectangle control type
        /// </summary>
        Rectangle,

        /// <summary>
        /// 	Specifies a rectangle control type
        /// </summary>
        RoundedRectangle,

        /// <summary>
        /// 	Specifies a polygon control type
        /// </summary>
        Circle,

        /// <summary>
        /// 	Specifies a polygon control type
        /// </summary>
        Polygon,

        /// <summary>
        /// 	Specifies a pie control type.
        /// </summary>
        Pie,

    };

    /// <summary>
    /// 	Class representing a solid, hatched, or gradient fill.
    /// </summary>
    [TypeConverter(typeof(ShapePopulate.Converter))]
    [EditorAttribute(typeof(ShapePopulateEditor), typeof(System.Drawing.Design.UITypeEditor))]
    public class ShapePopulate
    {

        #region Private Fields
        private int borderwidth = 1;
        private int upperLeftCurve = 10;
        private int upperRightCurve = 10;
        private int downLeftCurve = 5;
        private int downRightCurve = 10;
        private int curve = 10;

        private bool rounding = false;
        private bool colorShape = false;
        private bool drawBorder = true;

        private readonly bool pieDraw = true;
        private readonly bool noneDraw = true;


        private Color bordercolor = Color.DeepSkyBlue;
        private Color shapecolor = Color.DarkSlateBlue;

        private int sides = 3;
        private int radius = 10;
        private int startingangle = 90;
        private int controlWidth;

        private float startangle = 0;
        private float endangle = 90;

        private readonly shapes rectangleShape = shapes.Rectangle;
        //private readonly shapes roundedRectangle = shapes.RoundedRectangle;
        private readonly shapes circle = shapes.Circle;
        private readonly shapes polygon = shapes.Polygon;
        private readonly shapes pie = shapes.Pie;
        private readonly shapes none = shapes.None;

        private Graphics graph;
        private Rectangle rectangle; 
        #endregion
        
        #region Public Properties
        /// <summary>
        /// 	Gets foreground color in a solid fill.
        /// </summary>
        /// <value>
        /// 	Foreground color in a solid fill.
        /// </value>
        /// 
        public shapes None
        {
            get { return none; }
        }
        /// <summary>
        /// 	Gets foreground color in a solid fill.
        /// </summary>
        /// <value>
        /// 	Foreground color in a solid fill.
        /// </value>
        /// 
        /// 
        public shapes Rectangle
        {
            get { return rectangleShape; }
        }

        /// <summary>
        /// 	Gets foreground color in a solid fill.
        /// </summary>
        /// <value>
        /// 	Foreground color in a solid fill.
        /// </value>
        /// 
        public shapes Circle
        {
            get { return circle; }
        }

        /// <summary>
        /// 	Gets foreground color in a solid fill.
        /// </summary>
        /// <value>
        /// 	Foreground color in a solid fill.
        /// </value>
        /// 
        public shapes Pie
        {
            get { return pie; }
        }

        /// <summary>
        /// 	Gets foreground color in a solid fill.
        /// </summary>
        /// <value>
        /// 	Foreground color in a solid fill.
        /// </value>
        /// 
        public shapes Polygon
        {
            get { return polygon; }
        }

        /// <summary>
        /// 	Gets foreground color in a solid fill.
        /// </summary>
        /// <value>
        /// 	Foreground color in a solid fill.
        /// </value>
        /// 
        //public shapes RoundedRectangle
        //{
        //    get { return roundedRectangle; }
        //}


        /// <summary>
        /// 	Gets foreground color in a solid fill.
        /// </summary>
        /// <value>
        /// 	Foreground color in a solid fill.
        /// </value>
        public Color ShapeColor
        {
            get { return shapecolor; }
            set { shapecolor = value; }
        }

        /// <summary>
        /// 	Gets foreground color in a hatched fill.
        /// </summary>
        /// <value>
        /// 	Foreground color in a hatched fill.
        /// </value>
        public Color BorderColor
        {
            get { return bordercolor; }

            set { bordercolor = value; }
        }

        /// <summary>
        /// 	Gets background color in a hatched fill.
        /// </summary>
        /// <value>
        /// 	Background color in a hatched fill.
        /// </value>
        public Color BackColor { get { return shapecolor; }
            set { shapecolor = value; }
        }

        /// <summary>
        /// 	Type of fill.
        /// </summary>
        public shapes ShapeType = shapes.Rectangle;



        public int ControlWidth
        {
            get { return controlWidth; }
            set
            {
                controlWidth = value;
            }
        }
        
        [Category("Pie Control")]
        public float StartAngle
        {
            get { return startangle; }
            set
            {
                startangle = value;
                
            }
        }

        [Category("Pie Control")]
        public float EndAngle
        {
            get { return endangle; }
            set
            {
                endangle = value;
                
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
                
            }
        }

        public int UpperLeftCurve
        {
            get { return upperLeftCurve; }
            set
            {
                upperLeftCurve = value;
                
            }
        }

        [Category("Rounded Rectangle Control")]
        public int UpperRightCurve
        {
            get { return upperRightCurve; }
            set
            {
                upperRightCurve = value;
                
            }
        }

        [Category("Rounded Rectangle Control")]
        public int DownLeftCurve
        {
            get { return downLeftCurve; }
            set
            {
                downLeftCurve = value;

            }
        }

        [Category("Rounded Rectangle Control")]
        public int DownRightCurve
        {
            get { return downRightCurve; }
            set
            {
                downRightCurve = value;
                
            }
        }

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
                
            }
        }

        public Int32 PolygonRadius
        {
            get { return radius; }
            set
            {
                radius = value;
                
            }
        }

        public Int32 PolygonStartingAngle
        {
            get { return startingangle; }
            set
            {
                startingangle = value;
                
            }
        }

        public int BorderWidth
        {
            get { return borderwidth; }
            set
            {
                borderwidth = value;
                
            }
        }

        public bool ColorShape
        {
            get { return colorShape; }
            set
            {
                colorShape = value;
                
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
                
            }
        }
        
        public bool Rounding
        {
            get { return rounding; }
            set
            {
                rounding = value;
                
            }
        }

        public shapes Shape
        {
            get { return ShapeType; }
            set
            {
                ShapeType = value;
            }
        }

        #endregion

        #region Constructors

        // Internal constructor 
        private ShapePopulate(shapes type, Color borderColor, Color shapeColor, int borderWidth, bool Rounding, bool ColorShape, bool drawborder, int Curve, int upperLeftCurve, int upperRightCurve, int downLeftCurve, int downRightCurve, int PolygonSides, int PolygonAngle, float StartAngle, float EndAngle, bool alwaysYes)
        {
            ShapeType = type;
            bordercolor = borderColor;
            shapecolor = shapeColor;
            borderwidth = borderWidth;
            this.sides = PolygonSides;
            this.startingangle = PolygonAngle;
            this.startangle = StartAngle;
            this.endangle = EndAngle;
            this.pieDraw = alwaysYes;
            this.rounding = Rounding;
            this.colorShape = ColorShape;
            this.upperLeftCurve = upperLeftCurve;
            this.upperRightCurve = upperRightCurve;
            this.downLeftCurve = downLeftCurve;
            this.downRightCurve = downRightCurve;
            this.drawBorder = drawborder;
            this.curve = Curve;
        }


        /// <summary>
        /// 	Constructor for no fill.
        /// </summary>
        public ShapePopulate() : this(shapes.Default, Color.Empty, Color.Empty, 2, true, true, true, 10, 10, 10, 10, 10, 3, 90, 0, 90, true) /* gradientColors */
        {
        }

        /// <summary>
        /// 	Constructor for none fill.
        /// </summary>
        public ShapePopulate(shapes None, bool draw) : 
            this(shapes.None, Color.Empty, Color.Empty, 2, true, true,true,10, 10, 10, 10, 10, 3, 90, 0, 90, true) /* gradientColors */
        {
        }

        public ShapePopulate(shapes Rectangle, 
            Color borderColor, Color shapeColor, 
            bool rounding, bool colorshape, bool drawborder,
            int curve, int upperLeftCurve, int upperRightCurve, int downLeftCurve, int downRightCurve) : 
            this(shapes.Rectangle, Color.DeepSkyBlue, Color.Yellow, 2, true, false, true, 10, 10, 10, 10, 10, 3, 90, 0, 90, true)
        {
            

        }

        //public ShapePopulate(shapes RoundedRectangle, int upperLeftCurve, int upperRightCurve,
        //    int downLeftCurve, int downRightCurve) : this(shapes.RoundedRectangle, Color.DeepSkyBlue, Color.Yellow, borderwidth)
        //{

        //}

        public ShapePopulate(shapes Circle, Color borderColor, Color shapeColor, bool colorshape, bool drawborder) : 
            this(shapes.Circle, Color.DeepSkyBlue, Color.Yellow, 2, true, false, true, 10, 10, 10, 10, 10, 3, 90, 0, 90, true)
        {

        }

        public ShapePopulate(shapes Polygon, int PolygonSides, int PolygonAngle) : 
            this(shapes.Polygon,Color.DeepSkyBlue, Color.Yellow, 2, true, false, true, 10, 10, 10, 10, 10, 3, 90, 0, 90, true)
        {

        }

        public ShapePopulate(shapes Pie, float StartingAngle, float EndingAngle, bool alwaysYes) : 
            this(shapes.Pie,Color.DeepSkyBlue, Color.Yellow, 2, true, false, true, 10, 10, 10, 10, 10, 3, 90, 0, 90, true)
        {

        }

        //public ShapePopulate(shapes Custom, PaintEventArgs e) : this(shapes.Custom,
        //    Color.DeepSkyBlue, Color.Yellow, 2, true, false, true, 10, 10, 10, 10, 10, 3, 90, 0, 90, true)
        //{

        //}


        #endregion

        #region Public Methods


        public ShapePopulate Clone()
        {
            return new ShapePopulate(
                ShapeType, 
                bordercolor, 
                shapecolor, 
                borderwidth,
                rounding,
                colorShape,
                drawBorder,
                curve,
                upperLeftCurve,
                upperRightCurve,
                downLeftCurve,
                downRightCurve,
                sides,
                startingangle,
                startangle,
                endangle,
                pieDraw);
        }


        public static ShapePopulate Empty()
        {
            return new ShapePopulate();
        }



        #endregion

        #region Paint Events
        public void RectangleControl(PaintEventArgs e, Rectangle rectangle)
        {

            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            if (colorShape)
            {
                G.FillRectangle(new SolidBrush(shapecolor), rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);

                if (drawBorder)
                {
                    G.DrawRectangle(new Pen(bordercolor, borderwidth), rectangle.X, rectangle.Y, rectangle.Width,
                        rectangle.Height);
                }
                
            }
            
            else
            {
                G.DrawRectangle(new Pen(bordercolor, borderwidth), rectangle.X, rectangle.Y, rectangle.Width,
                    rectangle.Height);
            }
        }

        public void RoundedRectangleControl(PaintEventArgs e, GraphicsPath P, Rectangle rectangle)
        {
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            //GraphicsPath P = new GraphicsPath();

            int UpperLeftCorner = upperLeftCurve * 2;
            int UpperRightCorner = upperRightCurve * 2;
            int DownLeftCorner = downLeftCurve * 2;
            int DownRightCorner = downRightCurve * 2;


            P.AddArc(new Rectangle(rectangle.X, rectangle.Y, UpperLeftCorner, UpperLeftCorner), -180, 90);
            P.AddArc(new Rectangle(rectangle.Width - UpperRightCorner + rectangle.X, rectangle.Y, UpperRightCorner, UpperRightCorner), -90, 90);
            P.AddArc(new Rectangle(rectangle.Width - DownRightCorner + rectangle.X, rectangle.Height - DownRightCorner + rectangle.Y, DownRightCorner, DownRightCorner), 0, 90);
            P.AddArc(new Rectangle(rectangle.X, rectangle.Height - DownLeftCorner + rectangle.Y, DownLeftCorner, DownLeftCorner), 90, 90);

            P.CloseAllFigures();
            

            if (colorShape)
            {
                G.FillPath(new SolidBrush(shapecolor), P);

                if (drawBorder)
                {
                    G.DrawPath(new Pen(bordercolor, borderwidth), P);
                }

            }

            else
            {
                G.DrawPath(new Pen(bordercolor, borderwidth), P);
            }
        }

        public void CircleControl(PaintEventArgs e, Rectangle rectangle)
        {
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;

            if (colorShape)
            {
                G.FillEllipse(new SolidBrush(shapecolor), rectangle);

                if (drawBorder)
                {
                    G.DrawEllipse(new Pen(bordercolor, borderwidth), rectangle);
                }

            }

            else
            {
                G.DrawEllipse(new Pen(bordercolor, borderwidth), rectangle);
            }

            
        }

        public void PolygonControl(PaintEventArgs e, Rectangle rectangle)
        {
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;

            Point center = new Point(rectangle.Width / 2, rectangle.Height / 2);

            if (colorShape)
            {
                G.FillPolygon(new SolidBrush(shapecolor), Draw.CalculateVertices(sides, radius, startingangle, center));

                if (drawBorder)
                {
                    G.DrawPolygon(new Pen(bordercolor, borderwidth), Draw.CalculateVertices(sides, radius, startingangle, center));
                }

            }

            else
            {
                G.DrawPolygon(new Pen(bordercolor, borderwidth), Draw.CalculateVertices(sides, radius, startingangle, center));
            }

            
        }

        public void PieControl(PaintEventArgs e, Rectangle rectangle, float startAngle, float endAngle)
        {
            this.startangle = startAngle;
            this.endangle = endAngle;
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;

            if (colorShape)
            {
                G.FillPie(new SolidBrush(shapecolor), rectangle, startAngle, endAngle);

                if (drawBorder)
                {
                    G.DrawPie(new Pen(bordercolor, borderwidth), rectangle, startAngle, endAngle);
                }

            }

            else
            {
                G.DrawPie(new Pen(bordercolor, borderwidth), rectangle, startAngle, endAngle);
            }

            
        }

        public Graphics GetShape(PaintEventArgs e, Control control)
        {

            controlWidth = control.Width;
            control.Resize += Control_Resize;
            rectangle = new Rectangle((borderwidth / 2), (borderwidth / 2), control.Width - borderwidth - 1, control.Height - borderwidth - 1);
            Graphics G = e.Graphics;

            G.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath path = new GraphicsPath();

            CircleControl(e, rectangle);

            if (ShapeType == shapes.Rectangle)
            {
                if (rounding)
                {
                    RectangleControl(e, rectangle);
                }
                else
                {
                    RoundedRectangleControl(e, path, rectangle);
                }

                return G;
            }

            //if (ShapeType == shapes.RoundedRectangle)
            //{
            //    RoundedRectangleControl(e, path, rectangle);
            //    return G;

            //}

            if (ShapeType == shapes.Circle)
            {
                CircleControl(e, rectangle);
                return G;
            }

            if (ShapeType == shapes.Polygon)
            {

                PolygonControl(e, rectangle);
                return G;
            }

            if (ShapeType == shapes.Pie)
            {
                PieControl(e, rectangle, startangle, endangle);
                return G;

            }

            return null;
        }

        public Graphics GetShapeAlt(PaintEventArgs e, shapes Shape, Rectangle rectangle)
        {


            rectangle = new Rectangle((borderwidth / 2), (borderwidth / 2), rectangle.Width - borderwidth - 1, rectangle.Height - borderwidth - 1);
            Graphics G = e.Graphics;

            G.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath path = new GraphicsPath();

            RoundedRectangleControl(e, path, rectangle);

            //if (ShapeType == Shape)
            //{

            //    RectangleControl(e, rectangle);
            //    return G;
            //}

            //if (ShapeType == Shape)
            //{
            //    RoundedRectangleControl(e, path, rectangle);
            //    return G;

            //}

            //if (ShapeType == Shape)
            //{
            //    CircleControl(e, rectangle);
            //    return G;
            //}


            //if (ShapeType == Shape)
            //{
            //    PieControl(e, rectangle, startangle, endangle);
            //    return G;

            //}

            return null;
        }
        #endregion

        #region Mouse Events

        private void Control_Resize(object sender, EventArgs e)
        {
            radius = (controlWidth / 2);
        } 
        
        #endregion
        
        #region Converter

        internal class Converter : TypeConverter
        {
           
            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                if (destinationType == typeof(InstanceDescriptor) || destinationType == typeof(string))
                {
                    return true;
                }
                return base.CanConvertTo(context, destinationType);
            }

            // This code allows the designer to generate the Shape constructor

            public override object ConvertTo(ITypeDescriptorContext context,
                CultureInfo culture,
                object value,
                Type destinationType)
            {
                if (value is ShapePopulate)
                {
                    if (destinationType == typeof(string))
                    {
                        // Display string in designer
                        return "(ShapePopulate)";
                    }
                    else if (destinationType == typeof(InstanceDescriptor))
                    {
                        ShapePopulate shapePopulate = (ShapePopulate)value;

                        if (shapePopulate.ShapeType == shapes.Rectangle)
                        {
                            ConstructorInfo ctor = typeof(ShapePopulate).GetConstructor(new Type[]
                            {
                                typeof(shapes),
                                typeof(Color),
                                typeof(Color),
                                typeof(bool),
                                typeof(bool),
                                typeof(bool),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                typeof(int)


                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                    shapePopulate.Rectangle,
                                    shapePopulate.bordercolor,
                                    shapePopulate.shapecolor,
                                    shapePopulate.rounding,
                                    shapePopulate.colorShape,
                                    shapePopulate.drawBorder,
                                    shapePopulate.curve,
                                    shapePopulate.upperLeftCurve,
                                    shapePopulate.upperRightCurve,
                                    shapePopulate.downLeftCurve,
                                    shapePopulate.downRightCurve});
                            }
                        }
                        
                        else if (shapePopulate.ShapeType == shapes.Circle)
                        {
                            ConstructorInfo ctor = typeof(ShapePopulate).GetConstructor(new Type[] { typeof(shapes),
                                typeof(Color),
                                typeof(Color),
                                typeof(bool),
                                typeof(bool),
                                });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] { shapePopulate.Circle,
                                    shapePopulate.bordercolor,
                                    shapePopulate.shapecolor,
                                    shapePopulate.colorShape,
                                    shapePopulate.drawBorder,
                                    });
                            }
                        }
                        else if (shapePopulate.ShapeType == shapes.Polygon)
                        {
                            ConstructorInfo ctor = typeof(ShapePopulate).GetConstructor(new Type[] { typeof(shapes),
                                typeof(int),
                                typeof(int) });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] { shapePopulate.Polygon,
                                    shapePopulate.sides,
                                    shapePopulate.startingangle,
                                    });
                            }
                        }
                        else if (shapePopulate.ShapeType == shapes.Pie)
                        {
                            ConstructorInfo ctor = typeof(ShapePopulate).GetConstructor(new Type[] { typeof(shapes),
                                typeof(float),
                                typeof(float),
                                typeof(bool)});
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] { shapePopulate.Pie,
                                    shapePopulate.startangle,
                                    shapePopulate.endangle,
                                    shapePopulate.pieDraw
                                });
                            }
                        }

                        else if (shapePopulate.ShapeType == shapes.None)
                        {
                            ConstructorInfo ctor = typeof(ShapePopulate).GetConstructor(new Type[] {
                                typeof(shapes),
                                typeof(bool),
                                });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                    shapePopulate.None,
                                    shapePopulate.noneDraw,

                                });
                            }
                        }

                        
                        else
                        {
                            ConstructorInfo ctor = typeof(ShapePopulate).GetConstructor(Type.EmptyTypes);
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, null);
                            }
                        }
                    }
                }
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }

        #endregion



    }
}
