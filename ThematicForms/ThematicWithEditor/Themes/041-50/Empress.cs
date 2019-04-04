// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Empress.cs" company="Zeroit Dev Technologies">
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
        #region 45. Empress

        void Empress_PaintHook(PaintEventArgs e)
        {
            int Curve = 6;
            G.Clear(Parent.FindForm().TransparencyKey);
            HatchBrush BodyHatch = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(20, Color.Black), Color.Transparent);
            G.FillPath(new SolidBrush(Utilities.ColorConverter.HexToColor("#A12F35")), Utilities.Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), Curve));
            G.DrawPath(Pens.Black, Utilities.Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), Curve));
            G.SetClip(Utilities.Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), Curve));
            G.FillRectangle(BodyHatch, new Rectangle(0, 0, Width - 1, Height - 1));
            G.ResetClip();
            G.FillRectangle(new SolidBrush(Utilities.ColorConverter.HexToColor("#DE873A")), new Rectangle(6, 36, Width - 13, Height - 43));
            G.DrawString(FindForm().Text, Font, new SolidBrush(ForeColor), new Point(35, 10));
            G.DrawIcon(FindForm().Icon, new Rectangle(10, 10, 18, 18));
        }

        #endregion
    }
}
