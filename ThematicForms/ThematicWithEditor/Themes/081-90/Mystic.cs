// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Mystic.cs" company="Zeroit Dev Technologies">
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
        #region 87. Mystic

        private int Mystic_Header = 36;

        void Mystic_PaintHook(PaintEventArgs e)
        {

            G.Clear(Color.FromArgb(44, 51, 62));
            G.FillRectangle(new LinearGradientBrush(new Point(0, 0), new Point(0, Mystic_Header), Color.FromArgb(29, 36, 44), Color.FromArgb(22, 29, 35)), new Rectangle(0, 0, Width, _Header));

            G.FillRectangle(Brushes.Fuchsia, new Rectangle(0, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(1, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(0, 1, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 1, 0, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 1, 1, 1, 1));
            G.FillRectangle(Brushes.Fuchsia, new Rectangle(Width - 2, 0, 1, 1));

            StringFormat _StringF = new StringFormat();
            _StringF.Alignment = StringAlignment.Center;
            _StringF.LineAlignment = StringAlignment.Center;
            G.DrawString(Text, new Font("Segoe UI", 11), new SolidBrush(Color.FromArgb(0, 206, 153)), new RectangleF(0, 0, Width, _Header), _StringF);

        }


        #endregion
    }
}
