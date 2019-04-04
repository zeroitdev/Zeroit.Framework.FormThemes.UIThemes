// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="NetSeal.cs" company="Zeroit Dev Technologies">
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
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 90. Net Seal
        private Rectangle NetSeal_R1;
        private Pen NetSeal_P1 = new Pen(Color.FromArgb(24, 24, 24));
        private Pen NetSeal_P2 = new Pen(Color.FromArgb(60, 60, 60));

        private SolidBrush NetSeal_B1 = new SolidBrush(Color.FromArgb(50, 50, 50));

        private int NetSeal_Pad;
        private int _AccentOffset = 42;

        void NetSeal_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(50, 50, 50));
            DrawBorders(NetSeal_P2, 1);

            G.DrawLine(NetSeal_P1, 0, 26, Width, 26);
            G.DrawLine(NetSeal_P2, 0, 25, Width, 25);

            NetSeal_Pad = Math.Max(Measure().Width + 20, 80);
            NetSeal_R1 = new Rectangle(NetSeal_Pad, 17, Width - (NetSeal_Pad * 2) + _AccentOffset, 8);

            G.DrawRectangle(NetSeal_P2, NetSeal_R1);
            G.DrawRectangle(NetSeal_P1, NetSeal_R1.X + 1, NetSeal_R1.Y + 1, NetSeal_R1.Width - 2, NetSeal_R1.Height);

            G.DrawLine(NetSeal_P1, 0, 29, Width, 29);
            G.DrawLine(NetSeal_P2, 0, 30, Width, 30);




            DrawText(Brushes.Black, HorizontalAlignment.Left, 8, 1);
            DrawText(Brushes.WhiteSmoke, HorizontalAlignment.Left, 7, 0);

            G.FillRectangle(NetSeal_B1, 0, 27, Width, 2);
            DrawBorders(Pens.Black);
        }


        #endregion
    }
}
