// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="MetroUI.cs" company="Zeroit Dev Technologies">
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
        #region 82. MetroUI

        void MetroUI_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(53, 157, 181));

            G.FillRectangle(new SolidBrush(Color.White), new Rectangle(1, 1, Width - 2, Height - 24));
            G.FillRectangle(new SolidBrush(Color.FromArgb(53, 157, 181)), new Rectangle(0, 50, 7, 50));


            // G.DrawEllipse(circlec, New Rectangle(Width - 7, Height - 7, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 7, Height - 7, 3, 3));

            //G.DrawEllipse(circlec, New Rectangle(Width - 13, Height - 7, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 13, Height - 7, 3, 3));

            //  G.DrawEllipse(circlec, New Rectangle(Width - 19, Height - 7, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 19, Height - 7, 3, 3));

            //  G.DrawEllipse(circlec, New Rectangle(Width - 7, Height - 13, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 7, Height - 13, 3, 3));

            // G.DrawEllipse(circlec, New Rectangle(Width - 7, Height - 19, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 7, Height - 19, 3, 3));

            //  G.DrawEllipse(circlec, New Rectangle(Width - 13, Height - 13, 3, 3))
            G.FillEllipse(new SolidBrush(Color.White), new Rectangle(Width - 13, Height - 13, 3, 3));


            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 5, 23, 23));
            DrawText(new SolidBrush(Color.Black), HorizontalAlignment.Left, 44, 2);
            G.DrawString("|", Font, new SolidBrush(Color.Black), new Point(37, -3));

        }

        #endregion
    }
}
