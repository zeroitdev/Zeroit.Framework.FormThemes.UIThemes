// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Intel.cs" company="Zeroit Dev Technologies">
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
        #region 74. Intel

        void Intel_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Fuchsia);

            //Rounded Form
            GraphicsPath gp = CreateRound(new Rectangle(0, 0, Width - 1, Height - 1), 16);
            G.FillPath(new SolidBrush(Color.FromArgb(45, 45, 45)), gp);
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(60, 60, 60))), 0, 24, Width - 1, 24);
            G.DrawLine(Pens.DeepSkyBlue, 0, 25, Width - 1, 25);
            G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(60, 60, 60))), 0, 26, Width - 1, 26);
            G.DrawPath(Pens.DeepSkyBlue, gp);

            //Title Text and Icon
            Color fontColor = Color.WhiteSmoke;
            if (ShowIcon)
            {
                if (Icon == null)
                    Icon = Parent.FindForm().Icon;
                G.DrawIcon(_Icon, new Rectangle(6, 6, 16, 16));
                G.DrawString(Text, new Font("Verdana", 11), Brushes.Black, new Point(26, 5));
                G.DrawString(Text, new Font("Verdana", 11), new SolidBrush(fontColor), new Point(25, 4));
            }
            else
            {
                G.DrawString(Text, new Font("Verdana", 11), Brushes.Black, new Point(5, 5));
                G.DrawString(Text, new Font("Verdana", 11), new SolidBrush(fontColor), new Point(4, 4));
            }

            //Square Off Bottom Corners
            G.FillRectangle(new SolidBrush(Color.FromArgb(45, 45, 45)), new Rectangle(0, Height - 35, Width - 1, 34));
            G.DrawLine(Pens.DeepSkyBlue, new Point(0, Height - 35), new Point(0, Height - 1));
            G.DrawLine(Pens.DeepSkyBlue, new Point(Width - 1, Height - 35), new Point(Width - 1, Height - 1));
            G.DrawLine(Pens.DeepSkyBlue, new Point(0, Height - 1), new Point(Width - 1, Height - 1));

            //Border Lines
            if (Enable_Border)
            {
                G.DrawLine(Pens.DeepSkyBlue, new Point(6, 25), new Point(6, Height - 7));
                G.DrawLine(Pens.DeepSkyBlue, new Point(6, Height - 7), new Point(Width - 7, Height - 7));
                G.DrawLine(Pens.DeepSkyBlue, new Point(Width - 7, Height - 7), new Point(Width - 7, 25));
            }

        }

        #endregion
    }
}
