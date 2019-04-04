// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Avatar.cs" company="Zeroit Dev Technologies">
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
        #region 8. Avatar

        void Avatar_PaintHook(PaintEventArgs e)
        {
            LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(255, 32, 32, 32), Color.FromArgb(255, 10, 10, 10), 90f);
            G.DrawRectangle(new Pen(Border), new Rectangle(0, 0, Width, Height));
            G.FillRectangle(LGB1, new Rectangle(0, 0, Width, Height));
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(25, 5));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(7, 6, 16, 16));
            //Dim HB As New HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(175, Color.DarkBlue), Color.FromArgb(255, 21, 21, 21))
            LinearGradientBrush LGB2 = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(125, Color.DeepSkyBlue), Color.FromArgb(175, 25, 25, 112), 85f);
            G.FillRectangle(LGB2, new Rectangle(6, 25, Width - 11, Height - 30));
            DrawCorners(Color.Fuchsia);


        }

        #endregion
    }
}
