// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Element.cs" company="Zeroit Dev Technologies">
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
        #region 43. Element
        private bool _CenterText;
        public bool CenterText
        {
            get
            {
                bool functionReturnValue = false;
                return functionReturnValue;
                return functionReturnValue;
            }
            set { _CenterText = value; }
        }

        void Element_PaintHook(PaintEventArgs e)
        {

            G = e.Graphics;
            G.Clear(Color.FromArgb(32, 32, 32));
            G.FillRectangle(new SolidBrush(Color.FromArgb(41, 41, 41)), new Rectangle(9, _Header, Width - 18, Height - _Header - 9));
            if (_CenterText == true)
            {
                StringFormat _StringF = new StringFormat();
                _StringF.Alignment = StringAlignment.Center;
                _StringF.LineAlignment = StringAlignment.Center;
                G.DrawString(Text, new Font("Arial", 11), Brushes.White, new RectangleF(0, 0, Width, _Header), _StringF);
            }
            else
            {
                G.DrawString(Text, new Font("Arial", 11), Brushes.White, new Point(8, 7));
            }
        }

        #endregion
    }
}
