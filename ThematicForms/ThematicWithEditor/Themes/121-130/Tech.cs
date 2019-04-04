// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Tech.cs" company="Zeroit Dev Technologies">
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
        #region 126. Tech

        void Tech_PaintHook(PaintEventArgs e)
        {
            Pen lineColor = new Pen(Color.FromArgb(98, 142, 179));
            Pen borderColor1 = new Pen(Color.FromArgb(48, 71, 92));
            Pen borderColor2 = new Pen(Color.FromArgb(17, 36, 53));
            //Dim mainRect As New LinearGradientBrush(ClientRectangle, Color.FromArgb(98, 142, 179), Color.Black, 90S)



            G.Clear(Color.FromArgb(33, 52, 69));
            DrawGradient(Color.FromArgb(3, 13, 32), Color.FromArgb(14, 28, 41), 0, 0, Width, 30, 90);
            G.DrawLine(lineColor, 0, 30, Width, 30);
            DrawGradient(Color.FromArgb(61, 105, 144), Color.FromArgb(33, 52, 69), 0, 30, Width, 30, 90);
            //G.FillRectangle(mainRect, 10, 5, Width - 20, 50)

            //DrawGradient(Color.FromArgb(61, 105, 144), Color.FromArgb(33, 52, 69), 0, Height - 30, Width, Height - 30, 270S)
            //G.DrawLine(lineColor, 0, Height - 30, Width, Height - 30)
            DrawBorders(Pens.LightSteelBlue, Pens.CadetBlue, ClientRectangle);
            DrawText(HorizontalAlignment.Left, Color.FromArgb(204, 231, 250), 5, 3);
        }

        #endregion
    }
}
