// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Vitality.cs" company="Zeroit Dev Technologies">
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
        #region 137. Vitality

        Color Vitality_G1 = Color.White;
        Color Vitality_G2 = Color.LightGray;

        Color Vitality_BG = Color.FromArgb(240, 240, 240);

        void Vitality_PaintHook(PaintEventArgs e)
        {
            G.Clear(Vitality_BG);

            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(new Point(1, 1), new Size(this.Width - 2, 23)), Vitality_G1, Vitality_G2, 90f);
            G.FillRectangle(LGB, new Rectangle(new Point(1, 1), new Size(this.Width - 2, 23)));

            G.DrawLine(Pens.LightGray, 1, 25, this.Width - 2, 25);
            G.DrawLine(Pens.White, 1, 26, this.Width - 2, 26);

            DrawCorners(TransparencyKey);
            DrawBorders(Pens.LightGray, 1);

            Rectangle IconRec = new Rectangle(3, 3, 20, 20);
            G.DrawIcon(ParentForm.Icon, IconRec);

            G.DrawString(ParentForm.Text, new Font("Segoe UI", 9), Brushes.Gray, new Point(25, 5));
        }

        #endregion
    }
}
