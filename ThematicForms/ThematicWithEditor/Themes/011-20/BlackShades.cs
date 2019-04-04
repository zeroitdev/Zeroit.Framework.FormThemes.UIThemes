// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="BlackShades.cs" company="Zeroit Dev Technologies">
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
        #region 14. Black Shades

        #region " Control Help - Movement & Flicker Control "
        private Point MouseP = new Point(0, 0);
        private bool Cap = false;
        private int MoveHeight;

        private int pos = 0;

        void BlackShades_OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            const int curve = 7;
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            G.SmoothingMode = SmoothingMode.Default;
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Color TransparencyKey = this.ParentForm.TransparencyKey;
            Draw d = new Draw();

            G.Clear(TransparencyKey);

            G.FillPath(new SolidBrush(Color.FromArgb(42, 47, 49)), d.RoundRect(ClientRectangle, curve));


            //DRAW GRADIENTED BORDER
            LinearGradientBrush innerGradLeft = new LinearGradientBrush(new Rectangle(1, 1, Width / 2 - 1, Height - 3), Color.FromArgb(102, 108, 112), Color.FromArgb(204, 216, 224), 0f);
            LinearGradientBrush innerGradRight = new LinearGradientBrush(new Rectangle(1, 1, Width / 2 - 1, Height - 3), Color.FromArgb(204, 216, 224), Color.FromArgb(102, 108, 112), 0f);
            G.DrawPath(new Pen(innerGradLeft), d.RoundRect(new Rectangle(1, 1, Width / 2 + 3, Height - 3), curve));
            G.DrawPath(new Pen(innerGradRight), d.RoundRect(new Rectangle(Width / 2 - 5, 1, Width / 2 + 3, Height - 3), curve));


            G.FillPath(new SolidBrush(Color.FromArgb(42, 47, 49)), d.RoundRect(new Rectangle(2, 2, Width - 5, Height - 5), curve));


            LinearGradientBrush topGradLeft = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, 25), Color.FromArgb(42, 46, 48), Color.FromArgb(93, 98, 101), 0f);
            LinearGradientBrush topGradRight = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, 25), Color.FromArgb(93, 98, 101), Color.FromArgb(42, 46, 48), 0f);
            G.FillPath(topGradLeft, d.RoundRect(new Rectangle(2, 2, Width / 2 + 2, 25), curve));
            G.FillPath(topGradRight, d.RoundRect(new Rectangle(Width / 2 - 3, 2, Width / 2 - 1, 25), curve));

            G.FillRectangle(new SolidBrush(Color.FromArgb(42, 47, 49)), new Rectangle(2, 23, Width - 5, 10));

            G.DrawPath(new Pen(Color.FromArgb(42, 46, 48)), d.RoundRect(new Rectangle(2, 2, Width - 5, Height - 5), curve));
            G.DrawPath(new Pen(Color.FromArgb(9, 11, 12)), d.RoundRect(ClientRectangle, curve));

            G.DrawString(Text, Font, Brushes.White, new Rectangle(curve, curve - 2, Width - 1, 22), new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Near
            });

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            G.Dispose();
            B.Dispose();
        }


        #endregion


        #endregion
    }
}
