// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Orains.cs" company="Zeroit Dev Technologies">
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
        #region 93. Orains
        Color Orains_Border = Color.Black;
        Color Orains_TextColor = Color.Orange;
        Color Orains_R1 = Color.FromArgb(14, 14, 14);
        Color Orains_R2 = Color.FromArgb(20, 20, 20);
        Color Orains_InnerBorder = Color.FromArgb(40, 40, 40);
        Pen Orains_outerborder = Pens.Black;
        Brush Orains_BGColor = new SolidBrush(Color.FromArgb(20, 20, 20));

        Brush HeaderC = new SolidBrush(Color.FromArgb(22, 22, 22));

        void Orains_PaintHook(PaintEventArgs e)
        {
            G.Clear(Orains_R1);



            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Orains_R1, Orains_R2, -90);
            G.FillRectangle(LGB, new Rectangle(0, 0, Width - 1, Height - 1));


            HatchBrush BodyHatch = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(75, Color.Black), Color.Transparent);
            G.FillRectangle(BodyHatch, new Rectangle(0, 0, Width - 1, Height - 1));

            // w x 2 + 1 =  , w + h = 
            G.FillRectangle(Orains_BGColor, new Rectangle(8, 28, Width - 17, Height - 36));
            G.DrawRectangle(new Pen(Orains_InnerBorder), 9, 29, Width - 19, Height - 38);
            G.DrawRectangle(Orains_outerborder, new Rectangle(8, 28, Width - 17, Height - 36));

            G.DrawRectangle(Orains_outerborder, new Rectangle(0, 0, Width - 1, Height - 1));
            // OuterBorder of BackColor

            //  G.FillRectangle(HeaderC, New Rectangle(0, 0, Width - 1, 15))
            //  Dim BodyHatch2 As New HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(30, Color.Black), Color.Transparent)
            // G.FillRectangle(BodyHatch2, New Rectangle(0, 0, Width - 1, 15))

            G.DrawRectangle(new Pen(Orains_InnerBorder), new Rectangle(1, 1, Width - 3, Height - 3));
            //InnerBorder of BackCOlor' 


            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(35, 7));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(10, 4, 22, 22));

            // DrawCorners(Color.Fuchsia)
        }

        #endregion
    }
}
