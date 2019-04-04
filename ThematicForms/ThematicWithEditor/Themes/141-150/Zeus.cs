// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Zeus.cs" company="Zeroit Dev Technologies">
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
        #region 145. Zeus

        void Zeus_PaintHook(PaintEventArgs e)
        {
            Color C1 = Color.FromArgb(38, 38, 38);
            Color C2 = Color.AliceBlue;
            Pen P1 = Pens.Black;
            Pen P2 = Pens.AliceBlue;


            G.Clear(C1);
            G.DrawLine(P2, 50, 0, 0, 50);
            G.DrawLine(P2, Width - 50, 0, Width, 50);
            G.DrawLine(P2, 50, 20, Width - 50, 20);
            G.DrawLine(P2, 70, 0, 50, 20);
            G.DrawLine(P2, Width - 70, 0, Width - 50, 20);
            G.DrawLine(P2, 0, 75, 35, 40);
            G.DrawLine(P2, Width - 35, 40, Width, 75);
            G.DrawLine(P2, 35, 40, Width - 35, 40);
            G.DrawRectangle(P2, 15, 75, Width - 30, Height - 90);
            G.DrawString("<<>>", this.Font, Brushes.AliceBlue, Width - 32, 0);
            G.DrawString("<<>>", this.Font, Brushes.AliceBlue, 8, 0);
            DrawBorders(P1, P2, ClientRectangle);
            DrawText(HorizontalAlignment.Center, C2, 0);

        }


        #endregion
    }
}
