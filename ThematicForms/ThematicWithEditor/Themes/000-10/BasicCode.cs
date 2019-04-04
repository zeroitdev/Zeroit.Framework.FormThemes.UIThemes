// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="BasicCode.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 10. Basic Code

        private ColorBlend Blend;

        private float GlowPosition = -1f;
        private void MoveGlow()
        {
            while (true)
            {
                GlowPosition += 0.01f;
                if (GlowPosition >= 1f)
                    GlowPosition = -1f;
                Invalidate();
                System.Threading.Thread.Sleep(60);
            }
        }
        private float TextPosition = -1f;
        private void MoveText()
        {
            while (true)
            {
                TextPosition += 0.01f;
                if (TextPosition >= 1f)
                    TextPosition = -1f;
                Invalidate();
                System.Threading.Thread.Sleep(60);
            }
        }
        private Point[] BasePoints;
        private LinearGradientBrush BaseBrush;
        private Color BaseCol;
        private Color BaseCol2;
        private Point[] TBox;
        private Point[] TIBox;
        private Point[] TRPBox;
        private HatchBrush HBrush;

        void BasicCode_PaintHook(PaintEventArgs e)
        {
            Blend = new ColorBlend();
            Blend.Colors = new Color[] {
                Color.FromArgb(16, 16, 16),
                Color.FromArgb(46, 46, 46),
                Color.FromArgb(46, 46, 46),
                Color.FromArgb(16, 16, 16)
            };
            Blend.Positions = new float[] {
                0f,
                0.45f,
                0.65f,
                1f
            };

            TBox = new Point[] {
                new Point(98, 1),
                new Point(ClientRectangle.Width - 98, 1),
                new Point(ClientRectangle.Width - 98, 22),
                new Point(98, 22),
                new Point(98, 1)
            };
            TIBox = new Point[] {
                new Point(101, 4),
                new Point(ClientRectangle.Width - 101, 4),
                new Point(ClientRectangle.Width - 101, 19),
                new Point(101, 19),
                new Point(101, 4)
            };
            TRPBox = new Point[] {
                new Point(100, 3),
                new Point(ClientRectangle.Width - 100, 3),
                new Point(ClientRectangle.Width - 100, 20),
                new Point(100, 20),
                new Point(100, 3)
            };
            BaseCol = Color.FromArgb(255, 170, 0, 0);
            BaseCol2 = Color.FromArgb(255, 150, 0, 0);
            BaseBrush = new LinearGradientBrush(ClientRectangle, BaseCol, BaseCol2, LinearGradientMode.Vertical);
            G.FillRectangle(BaseBrush, ClientRectangle);
            HBrush = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(24, 24, 24), Color.FromArgb(8, 8, 8));

            G.FillRectangle(HBrush, 11, 30, Width - 22, Height - 41);
            G.DrawLines(new Pen(Color.FromArgb(32, 32, 32), 1), TBox);
            G.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), 98, 1, ClientRectangle.Width - 196, 8);
            DrawGradient(Color.FromArgb(8, 8, 8), Color.FromArgb(23, 23, 23), 98, 1, ClientRectangle.Width - 196, 22, 90f);
            G.SetClip(new Rectangle(101, 3, ClientRectangle.Width - 201, 17));
            G.FillRectangle(new SolidBrush(Color.FromArgb(16, 16, 16)), 98, 1, ClientRectangle.Width - 196, 22);
            DrawGradient(Blend, Convert.ToInt32(GlowPosition * ClientRectangle.Width + 50), 1, ClientRectangle.Width - 196, 22, 0f);
            G.DrawLines(new Pen(Color.FromArgb(15, Color.White), 1), TIBox);
            DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, -Convert.ToInt32(TextPosition * ClientRectangle.Width + 50), 0);
            G.ResetClip();
            G.FillRectangle(new SolidBrush(Color.FromArgb(26, Color.White)), 98, 1, ClientRectangle.Width - 196, 8);
            G.DrawLines(Pens.Black, TRPBox);
            G.DrawLines(Pens.Black, TBox);
            DrawBorders(Pens.Maroon, 0);
            DrawCorners(Color.Red, 0);
        }


        #endregion
    }
}
