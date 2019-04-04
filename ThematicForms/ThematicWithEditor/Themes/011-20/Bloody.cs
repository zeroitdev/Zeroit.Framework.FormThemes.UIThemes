// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Bloody.cs" company="Zeroit Dev Technologies">
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
        #region 15. Bloody


        void Bloody_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(195, 100, 0, 0));
            //Lignes diagonales
            HatchBrush HB = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(200, 45, 0, 0), Color.Black);
            //Dessine le "fond"
            G.FillRectangle(new SolidBrush(BackColor), new Rectangle(6, 24, Width - 12, Height - 30));
            //Dessine les lignes diagonales
            G.FillRectangle(HB, new Rectangle(6, 24, Width - 12, Height - 30));


            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Point(10, 3));
            DrawCorners(Color.Fuchsia);
        }

        #endregion
    }
}
