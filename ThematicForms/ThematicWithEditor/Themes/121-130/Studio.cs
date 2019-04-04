// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Studio.cs" company="Zeroit Dev Technologies">
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
        #region 122. Studio


        private Color Studio_C1 = Color.FromArgb(50, 70, 100);
        private Color Studio_C2 = Color.FromArgb(65, 85, 115);
        private Color Studio_C3 = Color.FromArgb(50, 70, 100);
        private Color Studio_C4 = Color.FromArgb(15, Color.Black);
        private Color Studio_C5 = Color.Transparent;
        private Pen Studio_P1 = new Pen(Color.Fuchsia, 3);
        private Pen Studio_P2 = new Pen(Color.FromArgb(12, 32, 62));
        private Pen Studio_P3 = new Pen(Color.FromArgb(20, Color.Black));
        private Pen Studio_P4 = new Pen(Color.FromArgb(30, Color.White));
        private Pen Studio_P5 = new Pen(Color.Black);
        private HatchBrush Studio_B1;

        private SolidBrush Studio_B2;

        private Rectangle Studio_RT1;

        private GraphicsPath Studio_Path = new GraphicsPath();

        void Studio_PaintHook(PaintEventArgs e)
        {
            Studio_B1 = new HatchBrush(HatchStyle.LightDownwardDiagonal, Color.FromArgb(20, 40, 70), Color.FromArgb(40, 60, 90));
            Studio_B2 = new SolidBrush(Color.White);

            G.DrawRectangle(Studio_P1, ClientRectangle);

            Studio_Path.Reset();
            Studio_Path.AddLines(new Point[] {
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
            G.SetClip(Studio_Path);

            G.Clear(Studio_C1);
            DrawGradient(Studio_C2, Studio_C3, 0, 0, Width, 30);

            Studio_RT1 = new Rectangle(12, 30, Width - 24, Height - 12 - 30);
            G.FillRectangle(Studio_B1, Studio_RT1);

            DrawGradient(Studio_C4, Studio_C5, 12, 30, Width - 24, 30);

            DrawBorders(Studio_P2, Studio_RT1);
            DrawBorders(Studio_P3, 14, 32, Width - 26, Height - 12 - 32);

            DrawText(Studio_B2, HorizontalAlignment.Left, 12, 0);

            DrawBorders(Studio_P4, 1);

            G.ResetClip();
            G.DrawPath(Studio_P5, Studio_Path);
        }


        #endregion
    }
}
