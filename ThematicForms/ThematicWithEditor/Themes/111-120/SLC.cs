// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="SLC.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 116. SLC


        private Color topc = Color.FromArgb(21, 18, 37);
        private Color botc = Color.FromArgb(32, 35, 54);
        private Color topc2 = Color.FromArgb(32, 35, 54);
        private Color botc2 = Color.FromArgb(21, 18, 37);



        private GraphicsPath PrepareBorder()
        {
            GraphicsPath P = new GraphicsPath();

            List<Point> PS = new List<Point>();
            PS.Add(new Point(0, 2));
            PS.Add(new Point(2, 0));
            PS.Add(new Point(100, 0));
            PS.Add(new Point(115, 15));
            PS.Add(new Point(Width - 1 - 115, 15));
            PS.Add(new Point(Width - 1 - 100, 0));
            PS.Add(new Point(Width - 2, 0));
            PS.Add(new Point(Width - 1, 3));


            //PS.Add(New Point(Width - 1, Height - 1))

            //bottom
            PS.Add(new Point(Width - 1, Height - 3));
            PS.Add(new Point(Width - 3, Height - 1));
            PS.Add(new Point(Width - 100, Height - 1));
            PS.Add(new Point(Width - 115, Height - 15 - 1));
            PS.Add(new Point(116, Height - 15 - 1));
            PS.Add(new Point(101, Height - 1));
            PS.Add(new Point(2, Height - 1));
            PS.Add(new Point(0, Height - 2));

            P.AddPolygon(PS.ToArray());
            return P;
        }

        void SLC_PaintHook(PaintEventArgs e)
        {
            TransparencyKey = Color.Fuchsia;

            G.Clear(Color.Fuchsia);

            HatchBrush HB = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(50, Color.FromArgb(38, 138, 201)), Color.FromArgb(80, Color.FromArgb(12, 40, 57)));
            LinearGradientBrush linear = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(108, 137, 184), Color.FromArgb(13, 20, 25), 20f);

            G.FillRectangle(linear, new Rectangle(3, 3, Width - 5, Height - 3));

            G.FillRectangle(HB, new Rectangle(3, 3, Width - 5, Height - 3));


            G.DrawLine(Pens.Fuchsia, 1, 0, Width - 1, 0);
            G.DrawLine(Pens.Fuchsia, 1, 1, Width - 1, 1);
            G.DrawLine(new Pen(Color.FromArgb(26, 47, 59)), 1, 2, Width - 1, 2);

            G.DrawLine(Pens.Fuchsia, 1, Height - 1, Width - 1, Height - 1);
            G.DrawLine(Pens.Fuchsia, 1, Height - 2, Width - 1, Height - 2);
            G.DrawLine(new Pen(Color.FromArgb(26, 47, 59)), 1, Height - 2, Width - 4, Height - 2);




            GraphicsPath GPF = PrepareBorder();


            PathGradientBrush PB2 = default(PathGradientBrush);
            PB2 = new PathGradientBrush(GPF);
            PB2.CenterColor = Color.FromArgb(250, 250, 250);
            PB2.SurroundColors = new Color[] { Color.FromArgb(237, 237, 237) };
            PB2.FocusScales = new PointF(0.9f, 0.5f);

            G.SetClip(GPF);

            G.FillPath(PB2, GPF);
            G.DrawPath(new Pen(Color.White, 3), GPF);
            G.ResetClip();

            GraphicsPath tmpG = PrepareBorder();

            G.DrawPath(Pens.Gray, tmpG);



            LinearGradientBrush linear2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(13, 59, 85), Color.FromArgb(22, 35, 43), 180f);



            GraphicsPath barGP = new GraphicsPath();

            PathGradientBrush PB3 = default(PathGradientBrush);
            PB3 = new PathGradientBrush(GPF);
            PB3.CenterColor = Color.FromArgb(39, 60, 73);
            PB3.SurroundColors = new Color[] { Color.FromArgb(31, 105, 152) };
            PB3.FocusScales = new PointF(0.5f, 0.5f);
            PB3.CenterPoint = new Point(Width / 2, 10);

            barGP.AddRectangle(new Rectangle(0, 39, Width - 1, 20));

            G.FillPath(PB3, barGP);
            G.FillPath(new HatchBrush(HatchStyle.NarrowHorizontal, Color.FromArgb(20, 34, 45), Color.Transparent), barGP);

            //// get rid of some pixels
            G.DrawRectangle(Pens.Fuchsia, new Rectangle(Width - 4, 40, 3, 17));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 4, 40, 3, 17));

            G.DrawRectangle(Pens.Fuchsia, new Rectangle(0, 40, 3, 17));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(0, 40, 3, 17));


            //// inside square

            //Dim SQpth As GraphicsPath = FormInsideSQ()
            // G.DrawPath(Pens.Red, SQpth)



            DrawText(new SolidBrush(Color.FromArgb(30, Color.Black)), HorizontalAlignment.Left, 12, 6);
            DrawText(new SolidBrush(Color.FromArgb(20, Color.Black)), HorizontalAlignment.Left, 11, 5);
            DrawText(Brushes.Black, HorizontalAlignment.Left, 10, 4);





        }
        #endregion
    }
}
