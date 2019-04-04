// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Simpla.cs" company="Zeroit Dev Technologies">
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

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 110. Simpla

        void Simpla_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);

            Rectangle mainTop = new Rectangle(0, 0, Width - 1, 40);
            Rectangle mainBottom = new Rectangle(0, 40, Width, Height);


            G.Clear(Color.Fuchsia);
            G.SetClip(Utilities.Draw.RoundRect(new Rectangle(0, 0, Width, Height), 4));

            SolidBrush gradientBackground = new SolidBrush(Color.FromArgb(34, 34, 34));
            G.FillRectangle(gradientBackground, mainBottom);

            LinearGradientBrush gradientBackground2 = new LinearGradientBrush(mainTop, Color.FromArgb(23, 23, 23), Color.FromArgb(17, 17, 17), 90);
            G.FillRectangle(gradientBackground2, mainTop);

            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(56, 56, 56))), 0, 40, Width - 1, 40);
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(42, 42, 42))), 0, 41, Width - 1, 41);

            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(12, 12, 12))), new Rectangle(0, 0, Width - 1, Height - 1));

            Font drawFont = new Font("Calibri (Body)", 10, FontStyle.Bold);
            G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(225, 225, 225)), 3, 10);

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            B.Dispose();
        }


        #endregion
    }
}
