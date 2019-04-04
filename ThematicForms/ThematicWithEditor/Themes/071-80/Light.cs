// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Light.cs" company="Zeroit Dev Technologies">
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
        #region 77. Light

        void Light_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(176, 176, 176));
            this.ForeColor = Color.FromArgb(45, 45, 45);
            HatchBrush hb = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(20, Color.White), Color.Transparent);
            HatchBrush hb2 = new HatchBrush(HatchStyle.BackwardDiagonal, Color.FromArgb(35, Color.White), Color.Transparent);
            DrawGradient(Color.FromArgb(176, 176, 176), Color.FromArgb(215, 215, 215), 0, 0, Width, 30, 270);
            G.FillRectangle(hb, 1, 1, Width, Height);
            G.FillRectangle(new SolidBrush(Color.FromArgb(235, 235, 235)), 5, 30, Width - 10, Height - 35);
            G.FillRectangle(hb2, 5, 30, Width - 10, Height - 35);
            DrawGradient(Color.FromArgb(30, Color.White), Color.Transparent, 3, 3, Width - 6, 14, 60);
            G.DrawRectangle(new Pen(Color.FromArgb(195, 195, 195)), 5, 30, Width - 10, Height - 35);
            DrawBorders(new Pen(Color.FromArgb(109, 109, 109)), Pens.LightGray, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(5, 6, 20, 20));
            G.DrawString(Parent.FindForm().Text, this.Font, new SolidBrush(this.ForeColor), new Point(25, 10));

        }

        #endregion
    }
}
