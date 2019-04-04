// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="SteamAlt.cs" company="Zeroit Dev Technologies">
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
        #region 120. SteamAlt

        void SteamAlt_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(44, 42, 40));

            HatchBrush T = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(20, 19, 19), Color.FromArgb(46, 44, 42));
            G.FillRectangle(T, ClientRectangle);
            DrawGradient(Color.Transparent, Color.FromArgb(29, 28, 27), new Rectangle(0, 0 - Height / 3 - Height / 9, Width, Height));
            G.FillRectangle(new SolidBrush(Color.FromArgb(29, 28, 28)), new Rectangle(0, Height / 3 + Height / 3 - Height / 9, Width, Height));


            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(0, 0, 0))));
            DrawText(new SolidBrush(Color.FromArgb(195, 193, 191)), HorizontalAlignment.Left, 4, 0);

        }

        #endregion
    }
}
