// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="TeamViewer.cs" company="Zeroit Dev Technologies">
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
        #region 125. TeamViewer

        void TeamViewer_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.White);
            DrawGradient(Color.FromArgb(0, 153, 255), Color.FromArgb(0, 102, 255), 0, 0, Width, 28, 90);
            DrawGradient(Color.FromArgb(51, 153, 255), Color.FromArgb(0, 102, 204), 0, 29, Width, 55, 90);
            DrawGradient(Color.White, Color.FromArgb(204, 204, 204), 0, 115, Width, Height - 55, 90);
            DrawGradient(Color.FromArgb(204, 204, 204), Color.White, 0, 84, Width, 35, 90);
            G.DrawLine(Pens.DarkBlue, 0, 28, Width, 28);
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(51, 204, 255))), 0, 29, Width, 29);
            G.DrawLine(Pens.White, 0, 84, Width, 84);
            //G.DrawString(".", Me.Parent.Font, Brushes.Black, -2, Height - 12)
            //G.DrawString(".", Me.Parent.Font, Brushes.Black, Width - 5, Height - 12)
            //DrawBorders(Pens.Black, Pens.Transparent, ClientRectangle)
            //DrawCorners(Color.Fuchsia, ClientRectangle)

            DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Left, 4, 0);

        }

        #endregion
    }
}
