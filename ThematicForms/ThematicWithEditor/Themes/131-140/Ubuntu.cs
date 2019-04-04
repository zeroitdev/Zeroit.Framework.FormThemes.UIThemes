// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Ubuntu.cs" company="Zeroit Dev Technologies">
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
        #region 132. Ubuntu

        void Ubuntu_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            Rectangle TopBar = new Rectangle(0, 0, Width - 1, 30);
            Rectangle FixBottom = new Rectangle(0, 26, Width - 1, 0);
            Rectangle Body = new Rectangle(0, 5, Width - 1, Height - 6);

            G.Clear(Color.Fuchsia);

            G.SmoothingMode = SmoothingMode.HighSpeed;

            LinearGradientBrush lbb = new LinearGradientBrush(Body, Color.FromArgb(242, 241, 240), Color.FromArgb(240, 240, 238), 90);
            G.FillPath(lbb, Utilities.Draw.RoundRect(Body, 1));
            G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(60, 60, 60))), Utilities.Draw.RoundRect(Body, 1));

            LinearGradientBrush lgb = new LinearGradientBrush(TopBar, Color.FromArgb(87, 86, 81), Color.FromArgb(60, 59, 55), 90);
            //Dim tophatch As New HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(20, 20, 20), Color.Transparent)
            G.FillPath(lgb, Utilities.Draw.RoundRect(TopBar, 4));
            //G.FillPath(tophatch, Draw.RoundRect(TopBar, 4))
            G.DrawPath(Pens.Black, Utilities.Draw.RoundRect(TopBar, 3));
            G.DrawPath(Pens.Black, Utilities.Draw.RoundRect(FixBottom, 1));
            G.FillRectangle(Brushes.White, 1, 27, Width - 2, Height - 29);

            Font drawFont = new Font("Tahoma", 10, FontStyle.Regular);
            G.DrawString(Text, drawFont, new SolidBrush(Color.WhiteSmoke), new Rectangle(25, 0, Width - 1, 27), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            });

            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(5, 5, 16, 16));

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }


        #endregion
    }
}
