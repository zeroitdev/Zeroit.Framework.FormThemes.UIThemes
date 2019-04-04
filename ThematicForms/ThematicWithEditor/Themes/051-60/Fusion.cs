// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Fusion.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Form control with themes.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
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
        #region 55. Fusion
        private Pen Fusion_P1 = new Pen(Color.Fuchsia);
        private Pen Fusion_P2 = new Pen(Color.FromArgb(255, Color.Black));
        private Pen Fusion_P3 = new Pen(Color.FromArgb(60, 60, 63));
        private Pen Fusion_P4 = new Pen(Color.FromArgb(60, 60, 63));
        private Pen Fusion_P5 = new Pen(Color.FromArgb(255, Color.Black));
        private Color Fusion_C1 = Color.FromArgb(47, 47, 50);
        private Color Fusion_C2 = Color.FromArgb(52, 52, 55);
        private Color Fusion_C3 = Color.FromArgb(47, 47, 50);
        private SolidBrush Fusion_B1 = new SolidBrush(Color.White);

        private SolidBrush Fusion_B2 = new SolidBrush(Color.White);
        private Rectangle Fusion_RT1;

        private GraphicsPath Fusion_Path;

        private ColorBlend Fusion_Blend;
        void Fusion_PaintHook(PaintEventArgs e)
        {
            Fusion_Path = new GraphicsPath();

            Fusion_Blend = new ColorBlend();
            Fusion_Blend.Colors = new Color[]
            {
                Color.Transparent,
                Color.FromArgb(60, 60, 63),
                Color.Transparent
            };

            Fusion_Blend.Positions = new float[] {
                0f,
                0.5f,
                1f
            };
            G.DrawRectangle(Fusion_P1, ClientRectangle);

            Fusion_Path.Reset();
            Fusion_Path.AddLines(new Point[] {
                new Point(2, 0),
                new Point(Width - 3, 0),
                new Point(Width - 1, 2),
                new Point(Width - 1, Height - 3),
                new Point(Width - 3, Height - 1),
                new Point(2, Height - 1),
                new Point(0, Height - 3),
                new Point(0, 2),
                new Point(2, 0)
            });
            G.SetClip(Fusion_Path);

            G.Clear(Fusion_C1);

            DrawGradient(Fusion_C2, Fusion_C3, 0, 0, 16, Height);
            DrawGradient(Fusion_C2, Fusion_C3, Width - 16, 0, 16, Height);

            DrawText(Fusion_B1, HorizontalAlignment.Left, 12, 0);

            Fusion_RT1 = new Rectangle(12, 34, Width - 24, Height - 34 - 12);

            G.FillRectangle(Fusion_B2, Fusion_RT1);
            DrawBorders(Fusion_P2, Fusion_RT1, 1);
            DrawBorders(Fusion_P3, Fusion_RT1);

            DrawBorders(Fusion_P4, 1);
            DrawGradient(Fusion_Blend, 1, 1, Width - 2, 2, 0f);

            G.ResetClip();
            G.DrawPath(Fusion_P5, Fusion_Path);
        }


        #endregion
    }
}
