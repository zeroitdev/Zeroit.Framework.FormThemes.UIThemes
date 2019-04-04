// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Loyal.cs" company="Zeroit Dev Technologies">
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
        #region 79. Loyal
        private TextAlign _TextAlignment = TextAlign.Center;
        private int _HeaderSize = 30;

        void Loyal_PaintHook(PaintEventArgs e)
        {

            var _with1 = G;
            StringFormat _StringF = new StringFormat { LineAlignment = StringAlignment.Center };
            _with1.Clear(Color.FromArgb(31, 31, 31));
            _with1.FillRectangle(new SolidBrush(Color.Aqua), new Rectangle(0, 0, Width, 5));
            _with1.FillRectangle(new SolidBrush(Color.FromArgb(34, 34, 34)), new Rectangle(0, 5, Width, _HeaderSize));
            _with1.DrawLine(new Pen(Color.FromArgb(38, 38, 38)), new Point(0, _HeaderSize + 5), new Point(Width, _HeaderSize + 5));
            _with1.DrawLine(new Pen(Color.FromArgb(24, 24, 24)), new Point(0, _HeaderSize + 6), new Point(Width, _HeaderSize + 6));
            _with1.DrawLine(Pens.Fuchsia, new Point(0, 0), new Point(0, 2));
            _with1.DrawLine(Pens.Fuchsia, new Point(0, 0), new Point(2, 0));
            _with1.DrawLine(Pens.Fuchsia, new Point(Width - 1, 0), new Point(Width - 1, 2));
            _with1.DrawLine(Pens.Fuchsia, new Point(Width - 1, 0), new Point(Width - 3, 0));


            switch (_TextAlignment)
            {
                case TextAlign.Center:
                    _StringF.Alignment = StringAlignment.Center;
                    _with1.DrawString(Text, new Font("Arial", 9), Brushes.White, new RectangleF(0, 5, Width, _HeaderSize), _StringF);

                    break;
                case TextAlign.Left:
                    _with1.DrawString(Text, new Font("Arial", 9), Brushes.White, new RectangleF(10, 5, Width, _HeaderSize), _StringF);

                    break;
                case TextAlign.Right:
                    int _TextLength = TextRenderer.MeasureText(Text, new Font("Arial", 9)).Width + 10;
                    _with1.DrawString(Text, new Font("Arial", 9), Brushes.White, new RectangleF(Width - _TextLength, 5, Width, _HeaderSize), _StringF);
                    break;
            }
        }

        #endregion
    }
}
