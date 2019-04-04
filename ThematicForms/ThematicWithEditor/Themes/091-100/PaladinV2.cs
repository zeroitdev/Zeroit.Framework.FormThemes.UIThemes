// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="PaladinV2.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 95. PalaDinV2

        private Pen PalaDinV2_P1;

        void PalaDinV2_PaintHook(PaintEventArgs e)
        {
            PalaDinV2_P1 = new Pen(Color.FromArgb(230, 230, 230));
            G.Clear(Color.FromArgb(200, Color.Gainsboro));
            LinearGradientBrush HeaderLGB = new LinearGradientBrush(new Rectangle(0, 0, Width, 17), Color.FromArgb(230, 230, 230), Color.FromArgb(210, 210, 210), 90);
            G.FillRectangle(HeaderLGB, new Rectangle(0, 0, Width, 17));


            DrawGradient(Color.FromArgb(170, 170, 170), Color.FromArgb(230, 230, 230), 0, Height - 12, Width / 2, Height, 360);
            DrawGradient(Color.FromArgb(170, 170, 170), Color.FromArgb(230, 230, 230), Width / 2, Height - 12, Width / 2, Height, 180);

            G.DrawLine(new Pen(Color.FromArgb(230, 230, 230)), Width / 2, Height - 11, Width / 2, Height);


            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(140, 140, 140))), new Rectangle(8, 32, Width - 18, Height - 42));

            LinearGradientBrush RecLGB = new LinearGradientBrush(new Point(0, 0), new Point(0, Height), Color.FromArgb(180, 180, 180), Color.FromArgb(200, 200, 200));
            G.FillRectangle(RecLGB, new Rectangle(9, 33, Width - 19, Height - 43));

            G.DrawLine(new Pen(Color.White), 1, 2, Width, 2);
            G.DrawLine(new Pen(Color.FromArgb(150, 150, 150)), 8, 30, Width - 10, 30);

            DrawBorders(PalaDinV2_P1, 1);
            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(90, 90, 90))), ClientRectangle);

            DrawCorners(Color.Fuchsia, ClientRectangle);

            DrawImage(HorizontalAlignment.Left, 6, -9);
            DrawText(new SolidBrush(Color.White), HorizontalAlignment.Left, 29, 0);
            DrawText(new SolidBrush(Color.Black), HorizontalAlignment.Left, 30, 0);


        }


        #endregion
    }
}
