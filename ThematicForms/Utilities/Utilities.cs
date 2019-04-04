// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Utilities.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;

namespace Zeroit.Framework.FormThemes.UIThemes.Utilities
{
    /// <summary>
    /// Class ColorConverter.
    /// </summary>
    public static class ColorConverter
    {
        /// <summary>
        /// Hexadecimals to red.
        /// </summary>
        /// <param name="HexString">The hexadecimal string.</param>
        /// <returns>System.Int32.</returns>
        public static int HexToRed(string HexString)
        {
            return HexToColor(HexString).R;
        }
        /// <summary>
        /// Hexadecimals to green.
        /// </summary>
        /// <param name="HexString">The hexadecimal string.</param>
        /// <returns>System.Int32.</returns>
        public static int HexToGreen(string HexString)
        {
            return HexToColor(HexString).G;
        }
        /// <summary>
        /// Hexadecimals to blue.
        /// </summary>
        /// <param name="HexString">The hexadecimal string.</param>
        /// <returns>System.Int32.</returns>
        public static int HexToBlue(string HexString)
        {
            return HexToColor(HexString).B;
        }
        /// <summary>
        /// Colors to hexadecimal.
        /// </summary>
        /// <param name="Color">The color.</param>
        /// <returns>System.String.</returns>
        public static string ColorToHex(Color Color)
        {
            return string.Format("#{0}{1}{2}", Color.R.ToString("X2"), Color.G.ToString("X2"), Color.B.ToString("X2"));
        }
        /// <summary>
        /// Hexadecimals to RGB.
        /// </summary>
        /// <param name="HexString">The hexadecimal string.</param>
        /// <returns>System.String[].</returns>
        public static string[] HexToRGB(string HexString)
        {
            Color tmpColor = ColorTranslator.FromHtml(HexString);
            string[] rgbArray = new string[4];
            rgbArray[0] = tmpColor.R.ToString();
            rgbArray[1] = tmpColor.G.ToString();
            rgbArray[2] = tmpColor.B.ToString();
            return rgbArray;
        }
        /// <summary>
        /// Hexadecimals to color.
        /// </summary>
        /// <param name="HexString">The hexadecimal string.</param>
        /// <returns>Color.</returns>
        public static Color HexToColor(string HexString)
        {
            return ColorTranslator.FromHtml(HexString);
        }
    }

    /// <summary>
    /// Class Draw.
    /// </summary>
    static class Draw
    {
        /// <summary>
        /// The create round path
        /// </summary>
        private static GraphicsPath CreateRoundPath;

        /// <summary>
        /// The create create roundangle
        /// </summary>
        private static Rectangle CreateCreateRoundangle;

        /// <summary>
        /// Creates the round.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="slope">The slope.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath CreateRound(int x, int y, int width, int height, int slope)
        {
            CreateCreateRoundangle = new Rectangle(x, y, width, height);
            return CreateRound(CreateCreateRoundangle, slope);
        }

        /// <summary>
        /// Creates the round.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="slope">The slope.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath CreateRound(Rectangle r, int slope)
        {
            CreateRoundPath = new GraphicsPath(FillMode.Winding);
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180f, 90f);
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270f, 90f);
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0f, 90f);
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90f, 90f);
            CreateRoundPath.CloseFigure();
            return CreateRoundPath;
        }

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="Rectangle">The rectangle.</param>
        /// <param name="Curve">The curve.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath RoundRect(Rectangle Rectangle, int Curve)
        {
            GraphicsPath P = new GraphicsPath();
            int ArcRectangleWidth = Curve * 2;
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
            P.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
            return P;
        }

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="X">The x.</param>
        /// <param name="Y">The y.</param>
        /// <param name="Width">The width.</param>
        /// <param name="Height">The height.</param>
        /// <param name="Curve">The curve.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath RoundRect(int X, int Y, int Width, int Height, int Curve)
        {
            Rectangle Rectangle = new Rectangle(X, Y, Width, Height);
            GraphicsPath P = new GraphicsPath();
            int ArcRectangleWidth = Curve * 2;
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
            P.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
            return P;
        }

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="r">The r.</param>
        /// <param name="r1">The r1.</param>
        /// <param name="r2">The r2.</param>
        /// <param name="r3">The r3.</param>
        /// <param name="r4">The r4.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath RoundRect(RectangleF r, float r1, float r2, float r3, float r4)
        {
            float x = r.X;
            float y = r.Y;
            float w = r.Width;
            float h = r.Height;
            GraphicsPath rr5 = new GraphicsPath();
            rr5.AddBezier(x, y + r1, x, y, x + r1, y, x + r1, y);
            rr5.AddLine(x + r1, y, x + w - r2, y);
            rr5.AddBezier(x + w - r2, y, x + w, y, x + w, y + r2, x + w, y + r2);
            rr5.AddLine(x + w, y + r2, x + w, y + h - r3);
            rr5.AddBezier(x + w, y + h - r3, x + w, y + h, x + w - r3, y + h, x + w - r3, y + h);
            rr5.AddLine(x + w - r3, y + h, x + r4, y + h);
            rr5.AddBezier(x + r4, y + h, x, y + h, x, y + h - r4, x, y + h - r4);
            rr5.AddLine(x, y + h - r4, x, y + r1);
            return rr5;
        }

        /// <summary>
        /// Images from code.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>Image.</returns>
        public static Image ImageFromCode(ref String str)
        {
            byte[] imageBytes = Convert.FromBase64String(str);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image i = Image.FromStream(ms, true);
            return i;
        }

        /// <summary>
        /// Tileds the texture from code.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>TextureBrush.</returns>
        public static TextureBrush TiledTextureFromCode(string str)
        {
            return new TextureBrush(Draw.ImageFromCode(ref str), WrapMode.Tile);
        }

        /// <summary>
        /// Inners the glow.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="Rectangle">The rectangle.</param>
        /// <param name="Colors">The colors.</param>
        public static void InnerGlow(Graphics G, Rectangle Rectangle, Color[] Colors)
        {
            int SubtractTwo = 1;
            int AddOne = 0;
            foreach (Color c_loopVariable in Colors)
            {
                Color c = c_loopVariable;
                G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(c.R, c.B, c.G))), Rectangle.X + AddOne, Rectangle.Y + AddOne, Rectangle.Width - SubtractTwo, Rectangle.Height - SubtractTwo);
                SubtractTwo += 2;
                AddOne += 1;
            }
        }

        /// <summary>
        /// Inners the glow rounded.
        /// </summary>
        /// <param name="G">The g.</param>
        /// <param name="Rectangle">The rectangle.</param>
        /// <param name="Degree">The degree.</param>
        /// <param name="Colors">The colors.</param>
        public static void InnerGlowRounded(Graphics G, Rectangle Rectangle, int Degree, Color[] Colors)
        {
            int SubtractTwo = 1;
            int AddOne = 0;
            foreach (Color c_loopVariable in Colors)
            {
                Color c = c_loopVariable;
                G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(c.R, c.B, c.G))), Draw.RoundRect(Rectangle.X + AddOne, Rectangle.Y + AddOne, Rectangle.Width - SubtractTwo, Rectangle.Height - SubtractTwo, Degree));
                SubtractTwo += 2;
                AddOne += 1;
            }
        }

        /// <summary>
        /// Blends the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="c3">The c3.</param>
        /// <param name="c">The c.</param>
        /// <param name="d">The d.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public static void Blend(Graphics g, Color c1, Color c2, Color c3, float c, int d, int x, int y, int width, int height)
        {
            ColorBlend V = new ColorBlend(3);
            V.Colors = new Color[] {
                c1,
                c2,
                c3
            };
            V.Positions = new float[] {
                0,
                c,
                1
            };
            Rectangle R = new Rectangle(x, y, width, height);
            using (LinearGradientBrush T = new LinearGradientBrush(R, c1, c1, (LinearGradientMode)d))
            {
                T.InterpolationColors = V;
                g.FillRectangle(T, R);
            }
        }

        /// <summary>
        /// Creates the round rectangle.
        /// </summary>
        /// <param name="rectangle">The rectangle.</param>
        /// <param name="radius">The radius.</param>
        /// <param name="TopLeft">if set to <c>true</c> [top left].</param>
        /// <param name="TopRigth">if set to <c>true</c> [top rigth].</param>
        /// <param name="BottomRigth">if set to <c>true</c> [bottom rigth].</param>
        /// <param name="BottomLeft">if set to <c>true</c> [bottom left].</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath CreateRoundRectangle(Rectangle rectangle, int radius, bool TopLeft = true, bool TopRigth = true, bool BottomRigth = true, bool BottomLeft = true)
        {
            GraphicsPath path = new GraphicsPath();
            int l = rectangle.Left;
            int t = rectangle.Top;
            int w = rectangle.Width;
            int h = rectangle.Height;
            int d = radius << 1;

            if (TopLeft)
            {
                path.AddArc(l, t, d, d, 180, 90);
                if (TopRigth)
                    path.AddLine(l + radius, t, l + w - radius, t);
                else
                    path.AddLine(l + radius, t, l + w, t);
            }
            else
            {
                if (TopRigth)
                    path.AddLine(l, t, l + w - radius, t);
                else
                    path.AddLine(l, t, l + w, t);
            }

            if (TopRigth)
            {
                path.AddArc(l + w - d, t, d, d, 270, 90);
                if (BottomRigth)
                    path.AddLine(l + w, t + radius, l + w, t + h - radius);
                else
                    path.AddLine(l + w, t + radius, l + w, t + h);
            }
            else
            {
                if (BottomRigth)
                    path.AddLine(l + w, t, l + w, t + h - radius);
                else
                    path.AddLine(l + w, t, l + w, t + h);
            }

            if (BottomRigth)
            {
                path.AddArc(l + w - d, t + h - d, d, d, 0, 90);
                if (BottomLeft)
                    path.AddLine(l + w - radius, t + h, l + radius, t + h);
                else
                    path.AddLine(l + w - radius, t + h, l, t + h);
            }
            else
            {
                if (BottomLeft)
                    path.AddLine(l + w, t + h, l + radius, t + h);
                else
                    path.AddLine(l + w, t + h, l, t + h);
            }

            if (BottomLeft)
            {
                path.AddArc(l, t + h - d, d, d, 90, 90);
                if (TopLeft)
                    path.AddLine(l, t + h - radius, l, t + radius);
                else
                    path.AddLine(l, t + h - radius, l, t);
            }
            else
            {
                if (TopLeft)
                    path.AddLine(l, t + h, l, t + radius);
                else
                    path.AddLine(l, t + h, l, t);
            }

            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// Clears the outside path.
        /// </summary>
        /// <param name="B">The b.</param>
        /// <param name="Path">The path.</param>
        /// <returns>Bitmap.</returns>
        public static Bitmap ClearOutsidePath(Bitmap B, GraphicsPath Path)
        {
            Color C = Color.FromArgb(0, 0, 0, 0);

            Bitmap TmpB = new Bitmap(B.Width, B.Height);
            Graphics G = Graphics.FromImage(TmpB);
            G.FillPath(Brushes.Black, Path);
            G.Dispose();

            for (int x = 0; x <= B.Width - 1; x++)
            {
                for (int y = 0; y <= B.Height - 1; y++)
                {
                    if (B.GetPixel(x, y) != C)
                        if (TmpB.GetPixel(x, y) == C)
                            B.SetPixel(x, y, C);
                }
            }

            return B;
        }

        /// <summary>
        /// Gradients the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="c1">The c1.</param>
        /// <param name="c2">The c2.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public static void Gradient(Graphics g, Color c1, Color c2, int x, int y, int width, int height)
        {
            Rectangle R = new Rectangle(x, y, width, height);
            using (LinearGradientBrush T = new LinearGradientBrush(R, c1, c2, LinearGradientMode.Vertical))
            {
                g.FillRectangle(T, R);
            }
        }

        /// <summary>
        /// Noises the brush.
        /// </summary>
        /// <param name="colors">The colors.</param>
        /// <returns>TextureBrush.</returns>
        public static TextureBrush NoiseBrush(Color[] colors)
        {
            Bitmap B = new Bitmap(128, 128);
            Random R = new Random(128);

            //colors = new Color[]
            //{
            //    Color.DarkSlateGray,
            //    Color.Orange,
            //    Color.Blue,
            //    Color.Cyan,
            //    Color.DeepPink,
            //    Color.Gainsboro,
            //    Color.Red,
            //    Color.Yellow

            //};

            for (int X = 0; X <= B.Width - 1; X++)
            {
                for (int Y = 0; Y <= B.Height - 1; Y++)
                {
                    B.SetPixel(X, Y, colors[R.Next(0, colors.Length)]);
                }
            }

            TextureBrush T = new TextureBrush(B);
            B.Dispose();

            return T;
        }

        /// <summary>
        /// Gets the brush.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>SolidBrush.</returns>
        public static SolidBrush GetBrush(Color c)
        {
            return new SolidBrush(c);
        }

        /// <summary>
        /// Gets the pen.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <returns>Pen.</returns>
        public static Pen GetPen(Color c)
        {
            return new Pen(new SolidBrush(c));
        }

        
    }

    /// <summary>
    /// Class Shapes.
    /// </summary>
    static class Shapes
    {
        /// <summary>
        /// Triangles the specified location.
        /// </summary>
        /// <param name="Location">The location.</param>
        /// <param name="Size">The size.</param>
        /// <returns>Point[].</returns>
        public static Point[] Triangle(Point Location, Size Size)
        {
            Point[] ReturnPoints = new Point[4];
            ReturnPoints[0] = Location;
            ReturnPoints[1] = new Point(Location.X + Size.Width, Location.Y);
            ReturnPoints[2] = new Point(Location.X + Size.Width / 2, Location.Y + Size.Height);
            ReturnPoints[3] = Location;

            return ReturnPoints;
        }
    }

    /// <summary>
    /// Class ImageToCodeClass.
    /// </summary>
    public class ImageToCodeClass
    {
        /// <summary>
        /// Images to code.
        /// </summary>
        /// <param name="Img">The img.</param>
        /// <returns>System.String.</returns>
        public string ImageToCode(Bitmap Img)
        {
            return Convert.ToBase64String((byte[])System.ComponentModel.TypeDescriptor.GetConverter(Img).ConvertTo(Img, typeof(byte[])));
        }

        /// <summary>
        /// Codes to image.
        /// </summary>
        /// <param name="Code">The code.</param>
        /// <returns>Image.</returns>
        public Image CodeToImage(string Code)
        {
            return Image.FromStream(new System.IO.MemoryStream(Convert.FromBase64String(Code)));
        }
    }

    /// <summary>
    /// Class DrawHelpers.
    /// </summary>
    static class DrawHelpers
    {

        #region "Functions"

        /// <summary>
        /// The height
        /// </summary>
        static int Height;

        /// <summary>
        /// The width
        /// </summary>
        static int Width;
        /// <summary>
        /// Rounds the record.
        /// </summary>
        /// <param name="Rectangle">The rectangle.</param>
        /// <param name="Curve">The curve.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath RoundRec(Rectangle Rectangle, int Curve)
        {
            GraphicsPath P = new GraphicsPath();
            int ArcRectangleWidth = Curve * 2;
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
            P.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
            P.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
            P.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
            return P;
        }

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="w">The w.</param>
        /// <param name="h">The h.</param>
        /// <param name="r">The r.</param>
        /// <param name="TL">if set to <c>true</c> [tl].</param>
        /// <param name="TR">if set to <c>true</c> [tr].</param>
        /// <param name="BR">if set to <c>true</c> [br].</param>
        /// <param name="BL">if set to <c>true</c> [bl].</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath RoundRect(dynamic x, dynamic y, dynamic w, dynamic h, dynamic r, bool TL = true, bool TR = true, bool BR = true, bool BL = true)
        {
            r = 0.3;

            GraphicsPath functionReturnValue = default(GraphicsPath);
            dynamic d = Math.Min(w, h) * r;
            dynamic xw = x + w;
            dynamic yh = y + h;
            functionReturnValue = new GraphicsPath();

            var _with1 = functionReturnValue;
            if (TL)
                _with1.AddArc(x, y, d, d, 180, 90);
            else
                _with1.AddLine(x, y, x, y);
            if (TR)
                _with1.AddArc(xw - d, y, d, d, 270, 90);
            else
                _with1.AddLine(xw, y, xw, y);
            if (BR)
                _with1.AddArc(xw - d, yh - d, d, d, 0, 90);
            else
                _with1.AddLine(xw, yh, xw, yh);
            if (BL)
                _with1.AddArc(x, yh - d, d, d, 90, 90);
            else
                _with1.AddLine(x, yh, x, yh);

            _with1.CloseFigure();
            return functionReturnValue;
        }

        /// <summary>
        /// Enum MouseState
        /// </summary>
        public enum MouseState : byte
        {
            /// <summary>
            /// The none
            /// </summary>
            None = 0,
            /// <summary>
            /// The over
            /// </summary>
            Over = 1,
            /// <summary>
            /// Down
            /// </summary>
            Down = 2,
            /// <summary>
            /// The block
            /// </summary>
            Block = 3
        }

        #endregion

    }

    /// <summary>
    /// Class DesignFunctions.
    /// </summary>
    static class DesignFunctions
    {
        /// <summary>
        /// To the brush.
        /// </summary>
        /// <param name="A">a.</param>
        /// <param name="R">The r.</param>
        /// <param name="G">The g.</param>
        /// <param name="B">The b.</param>
        /// <returns>Brush.</returns>
        public static Brush ToBrush(int A, int R, int G, int B)
        {
            return ToBrush(Color.FromArgb(A, R, G, B));
        }
        /// <summary>
        /// To the brush.
        /// </summary>
        /// <param name="R">The r.</param>
        /// <param name="G">The g.</param>
        /// <param name="B">The b.</param>
        /// <returns>Brush.</returns>
        public static Brush ToBrush(int R, int G, int B)
        {
            return ToBrush(Color.FromArgb(R, G, B));
        }
        /// <summary>
        /// To the brush.
        /// </summary>
        /// <param name="A">a.</param>
        /// <param name="C">The c.</param>
        /// <returns>Brush.</returns>
        public static Brush ToBrush(int A, Color C)
        {
            return ToBrush(Color.FromArgb(A, C));
        }
        /// <summary>
        /// To the brush.
        /// </summary>
        /// <param name="Pen">The pen.</param>
        /// <returns>Brush.</returns>
        public static Brush ToBrush(Pen Pen)
        {
            return ToBrush(Pen.Color);
        }
        /// <summary>
        /// To the brush.
        /// </summary>
        /// <param name="Color">The color.</param>
        /// <returns>Brush.</returns>
        public static Brush ToBrush(Color Color)
        {
            return new SolidBrush(Color);
        }
        /// <summary>
        /// To the pen.
        /// </summary>
        /// <param name="A">a.</param>
        /// <param name="R">The r.</param>
        /// <param name="G">The g.</param>
        /// <param name="B">The b.</param>
        /// <returns>Pen.</returns>
        public static Pen ToPen(int A, int R, int G, int B)
        {
            return ToPen(Color.FromArgb(A, R, G, B));
        }
        /// <summary>
        /// To the pen.
        /// </summary>
        /// <param name="R">The r.</param>
        /// <param name="G">The g.</param>
        /// <param name="B">The b.</param>
        /// <returns>Pen.</returns>
        public static Pen ToPen(int R, int G, int B)
        {
            return ToPen(Color.FromArgb(R, G, B));
        }
        /// <summary>
        /// To the pen.
        /// </summary>
        /// <param name="A">a.</param>
        /// <param name="C">The c.</param>
        /// <returns>Pen.</returns>
        public static Pen ToPen(int A, Color C)
        {
            return ToPen(Color.FromArgb(A, C));
        }
        /// <summary>
        /// To the pen.
        /// </summary>
        /// <param name="Color">The color.</param>
        /// <returns>Pen.</returns>
        public static Pen ToPen(Color Color)
        {
            return ToPen(new SolidBrush(Color));
        }
        /// <summary>
        /// To the pen.
        /// </summary>
        /// <param name="Brush">The brush.</param>
        /// <returns>Pen.</returns>
        public static Pen ToPen(SolidBrush Brush)
        {
            return new Pen(Brush);
        }

        /// <summary>
        /// Class CornerStyle.
        /// </summary>
        public class CornerStyle
        {
            /// <summary>
            /// The top left
            /// </summary>
            public bool TopLeft;
            /// <summary>
            /// The top right
            /// </summary>
            public bool TopRight;
            /// <summary>
            /// The bottom left
            /// </summary>
            public bool BottomLeft;
            /// <summary>
            /// The bottom right
            /// </summary>
            public bool BottomRight;
        }

        /// <summary>
        /// Advs the rect.
        /// </summary>
        /// <param name="Rectangle">The rectangle.</param>
        /// <param name="CornerStyle">The corner style.</param>
        /// <param name="Curve">The curve.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath AdvRect(Rectangle Rectangle, CornerStyle CornerStyle, int Curve)
        {
            GraphicsPath functionReturnValue = default(GraphicsPath);
            functionReturnValue = new GraphicsPath();
            int ArcRectangleWidth = Curve * 2;

            if (CornerStyle.TopLeft)
            {
                functionReturnValue.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
            }
            else
            {
                functionReturnValue.AddLine(Rectangle.X, Rectangle.Y, Rectangle.X + ArcRectangleWidth, Rectangle.Y);
            }

            if (CornerStyle.TopRight)
            {
                functionReturnValue.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
            }
            else
            {
                functionReturnValue.AddLine(Rectangle.X + Rectangle.Width, Rectangle.Y, Rectangle.X + Rectangle.Width, Rectangle.Y + ArcRectangleWidth);
            }

            if (CornerStyle.BottomRight)
            {
                functionReturnValue.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
            }
            else
            {
                functionReturnValue.AddLine(Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height, Rectangle.X + Rectangle.Width - ArcRectangleWidth, Rectangle.Y + Rectangle.Height);
            }

            if (CornerStyle.BottomLeft)
            {
                functionReturnValue.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
            }
            else
            {
                functionReturnValue.AddLine(Rectangle.X, Rectangle.Y + Rectangle.Height, Rectangle.X, Rectangle.Y + Rectangle.Height - ArcRectangleWidth);
            }

            functionReturnValue.CloseAllFigures();

            return functionReturnValue;
            return functionReturnValue;
        }

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="Rectangle">The rectangle.</param>
        /// <param name="Curve">The curve.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath RoundRect(Rectangle Rectangle, int Curve)
        {
            GraphicsPath functionReturnValue = default(GraphicsPath);
            functionReturnValue = new GraphicsPath();
            int ArcRectangleWidth = Curve * 2;
            functionReturnValue.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90);
            functionReturnValue.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90);
            functionReturnValue.AddArc(new Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90);
            functionReturnValue.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90);
            functionReturnValue.AddLine(new Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), new Point(Rectangle.X, ArcRectangleWidth + Rectangle.Y));
            functionReturnValue.CloseAllFigures();
            return functionReturnValue;
            return functionReturnValue;
        }

        /// <summary>
        /// Rounds the rect.
        /// </summary>
        /// <param name="X">The x.</param>
        /// <param name="Y">The y.</param>
        /// <param name="Width">The width.</param>
        /// <param name="Height">The height.</param>
        /// <param name="Curve">The curve.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath RoundRect(int X, int Y, int Width, int Height, int Curve)
        {
            return RoundRect(new Rectangle(X, Y, Width, Height), Curve);
        }

        /// <summary>
        /// Class PillStyle.
        /// </summary>
        public class PillStyle
        {
            /// <summary>
            /// The left
            /// </summary>
            public bool Left;
            /// <summary>
            /// The right
            /// </summary>
            public bool Right;
        }

        /// <summary>
        /// Pills the specified rectangle.
        /// </summary>
        /// <param name="Rectangle">The rectangle.</param>
        /// <param name="PillStyle">The pill style.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath Pill(Rectangle Rectangle, PillStyle PillStyle)
        {
            GraphicsPath functionReturnValue = default(GraphicsPath);
            functionReturnValue = new GraphicsPath();

            if (PillStyle.Left)
            {
                functionReturnValue.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, Rectangle.Height, Rectangle.Height), -270, 180);
            }
            else
            {
                functionReturnValue.AddLine(Rectangle.X, Rectangle.Y + Rectangle.Height, Rectangle.X, Rectangle.Y);
            }

            if (PillStyle.Right)
            {
                functionReturnValue.AddArc(new Rectangle(Rectangle.X + Rectangle.Width - Rectangle.Height, Rectangle.Y, Rectangle.Height, Rectangle.Height), -90, 180);
            }
            else
            {
                functionReturnValue.AddLine(Rectangle.X + Rectangle.Width, Rectangle.Y, Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height);
            }

            functionReturnValue.CloseAllFigures();

            return functionReturnValue;
            return functionReturnValue;
        }

        /// <summary>
        /// Pills the specified x.
        /// </summary>
        /// <param name="X">The x.</param>
        /// <param name="Y">The y.</param>
        /// <param name="Width">The width.</param>
        /// <param name="Height">The height.</param>
        /// <param name="PillStyle">The pill style.</param>
        /// <returns>System.Object.</returns>
        public static object Pill(int X, int Y, int Width, int Height, PillStyle PillStyle)
        {
            return Pill(new Rectangle(X, Y, Width, Height), PillStyle);
        }

    }

    /// <summary>
    /// Class Control_Box.
    /// </summary>
    static class Control_Box
    {
        /// <summary>
        /// Closes the button.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        /// <param name="control">The control.</param>
        /// <param name="color">The color.</param>
        public static void CloseButton(PaintEventArgs e, Control control, Color color)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            var _with2 = g;
            //_with2.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), control.Width - 40, 0, control.Width - 40, 22);

            //'Close Button
            _with2.DrawLine(new Pen(color, 2), control.Width - 33, 6, control.Width - 22, 16);
            _with2.DrawLine(new Pen(color, 2), control.Width - 33, 16, control.Width - 22, 6);

            
        }

        /// <summary>
        /// Minimizes the button.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        /// <param name="control">The control.</param>
        /// <param name="color">The color.</param>
        public static void MinimizeButton(PaintEventArgs e, Control control, Color color)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            var _with2 = g;

            //'Minimize Button

            _with2.DrawLine(new Pen(color), control.Width - 83, 16, control.Width - 72, 16);
            
        }

        /// <summary>
        /// Maximizes the button.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        /// <param name="control">The control.</param>
        /// <param name="color">The color.</param>
        public static void MaximizeButton(PaintEventArgs e, Control control, Color color)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            var _with2 = g;


            //'Maximize Button

            _with2.DrawLine(new Pen(color), control.Width - 58, 16, control.Width - 47, 16);
            _with2.DrawLine(new Pen(color), control.Width - 58, 16, control.Width - 58, 6);
            _with2.DrawLine(new Pen(color), control.Width - 47, 16, control.Width - 47, 6);
            _with2.DrawLine(new Pen(color), control.Width - 58, 6, control.Width - 47, 6);
            _with2.DrawLine(new Pen(color), control.Width - 58, 7, control.Width - 47, 7);
            
        }




        /// <summary>
        /// The close box
        /// </summary>
        public static  bool CloseBox = true;
        /// <summary>
        /// The maximize box
        /// </summary>
        public static bool MaximizeBox = true;
        /// <summary>
        /// The minimize box
        /// </summary>
        public static bool MinimizeBox = true;

        /// <summary>
        /// The header size
        /// </summary>
        public static int _HeaderSize = 30;
        /// <summary>
        /// The controls format
        /// </summary>
        private static StringFormat _ControlsFormat = new StringFormat { LineAlignment = StringAlignment.Center };
        /// <summary>
        /// The controls alignment
        /// </summary>
        public static ControlsAlign _ControlsAlignment = ControlsAlign.Right;


        /// <summary>
        /// Closes the button tetra.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        /// <param name="control">The control.</param>
        /// <param name="color">The color.</param>
        public static void CloseButtonTetra(PaintEventArgs e, Control control, Color color)
        {
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;
            
            var _with1 = G;
            if (_ControlsAlignment == ControlsAlign.Right)
            {
                if (CloseBox == true)
                {
                    _with1.DrawString("r", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(control.Width - 23, 5, 23, _HeaderSize + 3), _ControlsFormat);
                }
                
            }
            if (_ControlsAlignment == ControlsAlign.Left)
            {
                
                    _with1.DrawString("r", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(5, 5, 23, _HeaderSize + 3), _ControlsFormat);
                
            }
        }

        /// <summary>
        /// Minimizes the button tetra.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        /// <param name="control">The control.</param>
        /// <param name="color">The color.</param>
        public static void MinimizeButtonTetra(PaintEventArgs e, Control control, Color color)
        {
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;

            var _with1 = G;
            if (_ControlsAlignment == ControlsAlign.Right)
            {
                
                if (MinimizeBox == true)
                {
                    if (MaximizeBox == true)
                    {
                        if (CloseBox == true)
                        {
                            G.DrawString("0", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(control.Width - 57, 5, 23, _HeaderSize + 3), _ControlsFormat);
                        }
                        else
                        {
                            G.DrawString("0", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(control.Width - 41, 5, 23, _HeaderSize + 3), _ControlsFormat);
                        }
                    }
                    else
                    {
                        if (CloseBox == true)
                        {
                            G.DrawString("0", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(control.Width - 41, 5, 23, _HeaderSize + 3), _ControlsFormat);
                        }
                        else
                        {
                            G.DrawString("0", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(control.Width - 23, 5, 23, _HeaderSize + 3), _ControlsFormat);
                        }
                    }
                }

                
            }
            if (_ControlsAlignment == ControlsAlign.Left)
            {
                
                if (MinimizeBox == true)
                {
                    if (MaximizeBox == true)
                    {
                        if (CloseBox == true)
                        {
                            G.DrawString("0", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(41, 5, 23, _HeaderSize + 3), _ControlsFormat);
                        }
                        else
                        {
                            G.DrawString("0", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(23, 5, 23, _HeaderSize + 3), _ControlsFormat);
                        }
                    }
                    else
                    {
                        if (CloseBox == true)
                        {
                            G.DrawString("0", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(23, 5, 23, _HeaderSize + 3), _ControlsFormat);
                        }
                        else
                        {
                            G.DrawString("0", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(5, 5, 23, _HeaderSize + 3), _ControlsFormat);
                        }
                    }
                }
                
            }
        }

        /// <summary>
        /// Maximizes the button tetra.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        /// <param name="control">The control.</param>
        /// <param name="color">The color.</param>
        public static void MaximizeButtonTetra(PaintEventArgs e, Control control, Color color)
        {
            Graphics G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;

            var _with1 = G;
            if (_ControlsAlignment == ControlsAlign.Right)
            {
                //if (CloseBox == true)
                //{
                //    _with1.DrawString("r", new Font("Marlett", 11), Brushes.White, new RectangleF(control.Width - 23, 5, 23, _HeaderSize + 3), _ControlsFormat);
                //}

                
                if (MaximizeBox == true)
                {
                    if (CloseBox == true)
                    {
                        if (control.Parent.FindForm().WindowState == FormWindowState.Maximized)
                        {
                            _with1.DrawString("1", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(control.Width - 41, 5, 23, _HeaderSize + 3), _ControlsFormat);
                        }
                        else if (control.Parent.FindForm().WindowState == FormWindowState.Normal)
                        {
                            _with1.DrawString("2", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(control.Width - 41, 5, 23, _HeaderSize + 3), _ControlsFormat);
                        }
                    }
                    else
                    {
                        if (control.Parent.FindForm().WindowState == FormWindowState.Maximized)
                        {
                            _with1.DrawString("1", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(control.Width - 23, 5, 23, _HeaderSize + 3), _ControlsFormat);
                        }
                        else if (control.Parent.FindForm().WindowState == FormWindowState.Normal)
                        {
                            _with1.DrawString("2", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(control.Width - 23, 5, 23, _HeaderSize + 3), _ControlsFormat);
                        }
                    }
                }
            }
            if (_ControlsAlignment == ControlsAlign.Left)
            {
                //if (CloseBox == true)
                //{
                //    _with1.DrawString("r", new Font("Marlett", 11), Brushes.White, new RectangleF(5, 5, 23, _HeaderSize + 3), _ControlsFormat);
                //}

                
                if (MaximizeBox == true)
                {
                    if (CloseBox == true)
                    {
                        if (control.Parent.FindForm().WindowState == FormWindowState.Maximized)
                        {
                            _with1.DrawString("1", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(23, 5, 23, _HeaderSize + 3), _ControlsFormat);
                        }
                        else if (control.Parent.FindForm().WindowState == FormWindowState.Normal)
                        {
                            _with1.DrawString("2", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(23, 5, 23, _HeaderSize + 3), _ControlsFormat);
                        }
                    }
                    else
                    {
                        if (control.Parent.FindForm().WindowState == FormWindowState.Maximized)
                        {
                            _with1.DrawString("1", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(5, 5, 23, _HeaderSize + 3), _ControlsFormat);
                        }
                        else if (control.Parent.FindForm().WindowState == FormWindowState.Normal)
                        {
                            _with1.DrawString("2", new Font("Marlett", 11), new SolidBrush(color), new RectangleF(5, 5, 23, _HeaderSize + 3), _ControlsFormat);
                        }
                    }
                }
            }
        }

    }

    

}
