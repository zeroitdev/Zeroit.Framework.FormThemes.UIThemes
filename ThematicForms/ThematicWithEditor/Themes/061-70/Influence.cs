﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Influence.cs" company="Zeroit Dev Technologies">
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
        #region 70. Influence

        void Influence_Paint(System.Windows.Forms.PaintEventArgs e)
        {


            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            //if (_minimBool)
            //{
            //    Controls.Add(minimBtn);
            //}
            //else
            //{
            //    Controls.Remove(minimBtn);
            //}

            //minimBtn.Location = new Point(Width - 81, 0);
            //closeBtn.Location = new Point(Width - 52, 0);

            G.SmoothingMode = SmoothingMode.HighSpeed;
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Color TransparencyKey = this.ParentForm.TransparencyKey;
            Draw d = new Draw();


            G.Clear(TransparencyKey);

            G.FillPath(new SolidBrush(Color.FromArgb(20, 20, 20)), d.RoundRect(ClientRectangle, 2));


            HatchBrush h1 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
            LinearGradientBrush g1 = new LinearGradientBrush(new Rectangle(0, 2, Width - 1, 25), Color.FromArgb(40, 40, 40), Color.FromArgb(29, 29, 29), 90);

            G.FillPath(g1, d.RoundRect(new Rectangle(0, 2, Width - 1, 25), 2));
            G.FillPath(h1, d.RoundRect(new Rectangle(0, 2, Width - 1, 25), 2));

            LinearGradientBrush s1 = new LinearGradientBrush(g1.Rectangle, Color.FromArgb(15, Color.White), Color.FromArgb(0, Color.White), 90);
            G.FillRectangle(s1, new Rectangle(1, 1, Width - 1, 13));

            G.DrawLine(new Pen(Color.FromArgb(75, Color.White)), 1, 1, Width - 1, 1);

            G.DrawLine(new Pen(Color.FromArgb(18, 18, 18)), 1, 26, Width - 1, 26);

            G.DrawRectangle(new Pen(Color.FromArgb(37, 37, 37)), new Rectangle(1, 27, Width - 3, Height - 29));

            G.DrawPath(Pens.Black, d.RoundRect(ClientRectangle, 2));

            G.DrawString(Text, Font, Brushes.Black, new Rectangle(8, 8, Width - 1, 10), new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Near
            });
            G.DrawString(Text, Font, Brushes.White, new Rectangle(8, 9, Width - 1, 11), new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Near
            });

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }


        #endregion
    }
}
