// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Uplay.cs" company="Zeroit Dev Technologies">
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
        #region 134. Uplay

        private Color Uplay_G1 = Color.FromArgb(50, 50, 50);
        private Color Uplay_G2 = Color.FromArgb(70, 70, 70);
        void Uplay_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(221, 221, 221));

            G.DrawRectangle(new Pen(Color.FromArgb(60, 60, 60)), new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), new Point(0, 26), new Point(Width, 26));
            LinearGradientBrush LB = new LinearGradientBrush(new Rectangle(new Point(1, 1), new Size(Width - 2, 25)), Uplay_G2, Uplay_G1, 90f);
            G.FillRectangle(LB, new Rectangle(new Point(1, 1), new Size(Width - 2, 25)));

            //Draw glow
            G.FillRectangle(new SolidBrush(Uplay_G2), new Rectangle(new Point(1, 1), new Size(Width - 2, 11)));
            G.DrawString(Parent.FindForm().Text, new Font("Segoe UI", 9), Brushes.White, new Point(5, 4));
            switch (_Rounding)
            {
                // thanks to mava
                case RoundingType.TypeOne:
                    //////left upper corner
                    DrawPixel(Color.Fuchsia, 0, 0);
                    DrawPixel(Color.Fuchsia, 1, 0);
                    DrawPixel(Color.Fuchsia, 0, 1);
                    DrawPixel(Color.FromArgb(60, 60, 60), 1, 1);
                    //////right upper corner
                    DrawPixel(Color.Fuchsia, Width - 1, 0);
                    DrawPixel(Color.Fuchsia, Width - 2, 0);
                    DrawPixel(Color.Fuchsia, Width - 1, 1);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 2, 1);
                    //////left bottom corner
                    DrawPixel(Color.Fuchsia, 0, Height - 1);
                    DrawPixel(Color.Fuchsia, 1, Height - 1);
                    DrawPixel(Color.Fuchsia, 0, Height - 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), 1, Height - 2);
                    //////right bottom corner
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 2, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 2, Height - 2);
                    break;
                case RoundingType.TypeTwo:
                    //////left upper corner
                    DrawPixel(Color.Fuchsia, 0, 0);
                    DrawPixel(Color.Fuchsia, 1, 0);
                    DrawPixel(Color.Fuchsia, 2, 0);
                    DrawPixel(Color.Fuchsia, 3, 0);
                    DrawPixel(Color.Fuchsia, 0, 1);
                    DrawPixel(Color.Fuchsia, 0, 2);
                    DrawPixel(Color.Fuchsia, 0, 3);
                    DrawPixel(Color.Fuchsia, 1, 1);
                    DrawPixel(Color.FromArgb(60, 60, 60), 2, 1);
                    DrawPixel(Color.FromArgb(60, 60, 60), 3, 1);
                    DrawPixel(Color.FromArgb(60, 60, 60), 1, 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), 1, 3);
                    //////right upper corner
                    DrawPixel(Color.Fuchsia, Width - 1, 0);
                    DrawPixel(Color.Fuchsia, Width - 2, 0);
                    DrawPixel(Color.Fuchsia, Width - 3, 0);
                    DrawPixel(Color.Fuchsia, Width - 4, 0);
                    DrawPixel(Color.Fuchsia, Width - 1, 1);
                    DrawPixel(Color.Fuchsia, Width - 1, 2);
                    DrawPixel(Color.Fuchsia, Width - 1, 3);
                    DrawPixel(Color.Fuchsia, Width - 2, 1);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 3, 1);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 4, 1);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 2, 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 2, 3);
                    //////left bottom corner
                    DrawPixel(Color.Fuchsia, 0, Height - 1);
                    DrawPixel(Color.Fuchsia, 0, Height - 2);
                    DrawPixel(Color.Fuchsia, 0, Height - 3);
                    DrawPixel(Color.Fuchsia, 0, Height - 4);
                    DrawPixel(Color.Fuchsia, 1, Height - 1);
                    DrawPixel(Color.Fuchsia, 2, Height - 1);
                    DrawPixel(Color.Fuchsia, 3, Height - 1);
                    DrawPixel(Color.Fuchsia, 1, Height - 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), 2, Height - 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), 3, Height - 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), 1, Height - 3);
                    DrawPixel(Color.FromArgb(60, 60, 60), 1, Height - 4);
                    //////right bottom corner
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 2);
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 3);
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 4);
                    DrawPixel(Color.Fuchsia, Width - 2, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 3, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 4, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 2, Height - 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 3, Height - 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 4, Height - 2);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 2, Height - 3);
                    DrawPixel(Color.FromArgb(60, 60, 60), Width - 2, Height - 4);
                    break;
            }


        }

        #endregion
    }
}
