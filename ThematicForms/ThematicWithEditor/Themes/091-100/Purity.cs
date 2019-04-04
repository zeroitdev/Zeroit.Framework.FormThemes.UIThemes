// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Purity.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 100. Purity

        void Purity_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromKnownColor(KnownColor.Control));
            // Clear the form first

            //DrawGradient(Color.FromArgb(64, 64, 64), Color.FromArgb(32, 32, 32), 0, 0, Width, Height, 90S)   ' Form Gradient
            G.Clear(Color.FromArgb(60, 60, 60));
            DrawGradient(Color.FromArgb(45, 40, 45), Color.FromArgb(32, 32, 32), 0, 0, Width, 25, 90);
            // Form Top Bar

            G.DrawLine(Pens.Black, 0, 25, Width, 25);
            // Top Line
            //G.DrawLine(Pens.Black, 0, Height - 25, Width, Height - 25)   ' Bottom Line

            DrawCorners(Color.Fuchsia, ClientRectangle);
            // Then draw some clean corners
            DrawBorders(Pens.Black, Pens.DimGray, ClientRectangle);
            // Then we draw our form borders

            DrawText(HorizontalAlignment.Left, Color.Red, 7, 1);
            // Finally, we draw our text
        }

        #endregion
    }
}
