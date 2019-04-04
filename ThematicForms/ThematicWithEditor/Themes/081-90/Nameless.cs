// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Nameless.cs" company="Zeroit Dev Technologies">
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
        #region 89. Nameless

        private Pen Nameless_P1;
        int Nameless_H = 25;
        void Nameless_PaintHook(PaintEventArgs e)
        {
            Nameless_P1 = new Pen(Color.FromArgb(100, 100, 100));
            G.Clear(Color.FromArgb(0, 0, 0));

            //Sides Gradient
            DrawGradient(Color.Black, Color.FromArgb(45, 45, 45), new Rectangle(1, Nameless_H, Width, 100));
            //Inner Rect Grad
            DrawGradient(Color.FromArgb(35, 35, 35), Color.FromArgb(5, 5, 5), 9, 32, Width - 19, Height - 39);

            //Header Grad
            LinearGradientBrush HeaderLGB = new LinearGradientBrush(new Rectangle(2, 2, Width - 5, 11), Color.FromArgb(150, 150, 150), Color.FromArgb(50, 50, 50), 90);
            G.FillRectangle(HeaderLGB, new Rectangle(2, 2, Width - 5, 12));
            DrawBorders(new Pen(Color.FromArgb(65, 65, 65)), new Rectangle(3, 3, Width - 6, 26));
            //----------

            //buttom Gradient.
            DrawGradient(Color.FromArgb(8, 8, 8), Color.FromArgb(34, 34, 34), 9, 31, Width - 20, 20);
            DrawGradient(Color.Black, Color.FromArgb(75, 75, 75), 0, Height - 9, Width / 2, Height, 360);
            DrawGradient(Color.Black, Color.FromArgb(75, 75, 75), Width / 2, Height - 9, Width / 2, Height, 180);
            G.DrawLine(new Pen(Color.FromArgb(75, 75, 75)), Width / 2, Height - 9, Width / 2, Height);
            //----------

            //Inner Rect
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(55, 55, 55))), new Rectangle(9, 30, Width - 19, Height - 41));
            G.DrawLine(new Pen(Color.FromArgb(50, 50, 50)), 9, 30, Width - 10, 30);


            DrawBorders(Nameless_P1, 1);
            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(0, 0, 0))), ClientRectangle);


            DrawCorners(Color.Fuchsia, ClientRectangle);
            G.DrawString(Text, Font, Brushes.White, new Point(9, 7));

        }

        #endregion
    }
}
