// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="SkyBase.cs" company="Zeroit Dev Technologies">
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
        #region 114. SkyBase

        Rectangle SkyBase_T1;
        Color SkyBase_C1 = Color.FromArgb(62, 60, 58);
        Color SkyBase_C2 = Color.FromArgb(81, 79, 77);
        Color SkyBase_C3 = Color.FromArgb(71, 70, 69);

        Color SkyBase_C4 = Color.FromArgb(58, 56, 54);

        void SkyBase_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            SkyBase_T1 = new Rectangle(1, 1, Width - 3, 18);

            Bitmap SkyBase_B = new Bitmap(Width, Height);
            G = Graphics.FromImage(SkyBase_B);

            //Drawing
            G.Clear(SkyBase_C1);
            LinearGradientBrush SkyBase_G1 = new LinearGradientBrush(new Point(SkyBase_T1.X, SkyBase_T1.Y), new Point(SkyBase_T1.X, SkyBase_T1.Y + SkyBase_T1.Height), SkyBase_C3, SkyBase_C4);
            G.FillRectangle(SkyBase_G1, SkyBase_T1);
            G.DrawRectangle(ConversionFunctions.ToPen(SkyBase_C2), SkyBase_T1);
            G.DrawRectangle(ConversionFunctions.ToPen(SkyBase_C2), new Rectangle(SkyBase_T1.X, SkyBase_T1.Y + SkyBase_T1.Height + 2, SkyBase_T1.Width, Height - SkyBase_T1.Y - SkyBase_T1.Height - 4));

            SkyBase_G1.Dispose();

            G.DrawString(Text, Font, ConversionFunctions.ToBrush(113, 170, 186), new Rectangle(new Point(SkyBase_T1.X + 4, SkyBase_T1.Y), new Size(SkyBase_T1.Width - 40, SkyBase_T1.Height)), new StringFormat { LineAlignment = StringAlignment.Center });


            //Finish Up
            e.Graphics.DrawImage((Bitmap)SkyBase_B.Clone(), 0, 0);
            //G.Dispose();
            SkyBase_B.Dispose();
        }


        #endregion
    }
}
