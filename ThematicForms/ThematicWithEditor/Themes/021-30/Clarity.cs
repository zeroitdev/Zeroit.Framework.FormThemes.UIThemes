// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Clarity.cs" company="Zeroit Dev Technologies">
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
        #region 24. Clarity


        void Clarity_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(31, 31, 31));


            LinearGradientBrush GradientBG = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(67, 68, 69), Color.FromArgb(22, 22, 22), -270);
            G.FillRectangle(GradientBG, new Rectangle(0, 0, Width - 1, Height - 1));


            HatchBrush BodyHatch = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
            G.FillRectangle(BodyHatch, new Rectangle(0, 0, Width - 1, Height - 1));

            G.DrawRectangle(new Pen(Color.FromArgb(32, 32, 32)), new Rectangle(10, 32, Width - 21, Height - 43));
            G.DrawRectangle(new Pen(Color.FromArgb(6, 6, 6)), new Rectangle(9, 31, Width - 19, Height - 41));


            LinearGradientBrush Header = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, 30), Color.FromArgb(25, 25, 25), Color.FromArgb(40, 40, 40), 270);
            G.FillRectangle(Header, new Rectangle(0, 0, Width - 1, 30));
            HatchBrush HeaderHatch = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
            G.FillRectangle(HeaderHatch, new Rectangle(0, 0, Width - 1, 30));
            G.FillRectangle(new SolidBrush(Color.FromArgb(15, Color.White)), 0, 0, Width - 1, 15);

            G.DrawLine(new Pen(Color.FromArgb(42, 42, 42)), 0, 15, Width - 1, 15);



            G.FillRectangle(new SolidBrush(Color.FromArgb(22, 22, 22)), new Rectangle(11, 33, Width - 23, Height - 45));
            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawRectangle(new Pen(Color.FromArgb(49, 49, 49)), new Rectangle(1, 1, Width - 3, Height - 3));


            if (_ShowIcon == false)
            {
                G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(255, 255, 255)), new Rectangle(0, 0, Width, 37), new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                });
            }
            else
            {
                G.DrawIcon(Parent.FindForm().Icon, new Rectangle(new Point(9, 7), new Size(16, 16)));
                G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(255, 255, 255)), new Rectangle(0, 0, Width, 37), new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                });
            }

        }

        #endregion
    }
}
