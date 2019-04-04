// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Deumos.cs" company="Zeroit Dev Technologies">
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
        #region  35. Deumos

        void Deumos_ColorHook()
        {
            Header = 24;
            TransparencyKey = Color.Fuchsia;
            BackColor = Deumos_C1;
        }

        private Color Deumos_C1 = Color.FromArgb(14, 14, 14);
        private Color Deumos_C2 = Color.FromArgb(48, 48, 48);
        private Color Deumos_C3 = Color.FromArgb(4, 4, 4);
        private Pen Deumos_P1 = new Pen(Color.FromArgb(45, 45, 45));
        private Pen Deumos_P2 = new Pen(Color.Black);
        private Pen Deumos_P3 = new Pen(Color.Black);
        private Pen Deumos_P4 = new Pen(Color.FromArgb(100, 100, 100));
        private Pen Deumos_P5 = new Pen(Color.FromArgb(14, 14, 14));
        private SolidBrush Deumos_B1 = new SolidBrush(Color.FromArgb(100, 100, 100));
        private SolidBrush Deumos_B2 = new SolidBrush(Color.FromArgb(255, Color.Gray));
        private SolidBrush Deumos_B3 = new SolidBrush(Color.White);
        private SolidBrush Deumos_B4 = new SolidBrush(Color.FromArgb(100, 100, 100));
        private Rectangle Deumos_R1;

        private GraphicsPath Deumos_Path;
        private GraphicsPath Deumos_PathClone;

        private LinearGradientBrush Deumos_G1;

        private int _HeaderOffset = 1;
        public int HeaderOffset
        {
            get { return _HeaderOffset; }
            set
            {
                if (value < 0 || value > 2)
                    return;

                _HeaderOffset = value;
                Invalidate();
            }
        }
        void Deumos_PaintHook(PaintEventArgs e)
        {
            Deumos_Path = new GraphicsPath();
            Blend = new ColorBlend();

            Blend.Colors = new Color[] {
                Color.FromArgb(14, 14, 14),
                Color.FromArgb(41, 41, 41),
                Color.FromArgb(41, 41, 41),
                Color.FromArgb(14, 14, 14)
            };

            Blend.Positions = new float[] {
                0,
                0.4f,
                0.6f,
                1
            };

            Deumos_P1.Alignment = PenAlignment.Inset;

            //Draw background
            G.Clear(Color.FromArgb(14, 14, 14));
            G.FillRectangle(Brushes.Fuchsia, 0, 0, Width, 3);

            //Draw border
            DrawBorders(Deumos_P1, 0, 17, Width + 1, Height - 16);
            //Border

            //Draw outline
            DrawBorders(Deumos_P5, 1, 23, Width - 2, Height - 24);
            DrawBorders(Deumos_P2, 0, 24, Width, Height - 24);
            //InnerOutline
            DrawBorders(Deumos_P2, 7, 23, Width - 14, Height - 30);
            //OuterOutline

            //Draw title gradient
            Deumos_R1 = new Rectangle(30, _HeaderOffset, Width - 67, 24 - _HeaderOffset);
            Deumos_G1 = new LinearGradientBrush(Deumos_R1, Color.Empty, Color.Empty, 0f);
            Deumos_G1.InterpolationColors = Blend;
            G.FillRectangle(Deumos_G1, Deumos_R1);

            //Draw title gloss
            G.FillRectangle(Deumos_B1, 30, _HeaderOffset, Width - 67, 12 - _HeaderOffset);
            G.DrawLine(Deumos_P4, 30, _HeaderOffset + 1, Width - 67, _HeaderOffset + 1);

            //Draw title outline
            G.DrawLine(Deumos_P2, 30, _HeaderOffset, Width - 67, _HeaderOffset);
            //TitleOutline

            Deumos_Path.Reset();

            Deumos_Path.AddLine(3, 0, 31, 0);
            Deumos_Path.AddLine(55, 24, 0, 24);
            Deumos_Path.AddLine(0, 24, 0, 3);
            Deumos_Path.CloseFigure();

            Deumos_Path.AddLine(Width - 68, 0, Width - 4, 0);
            Deumos_Path.AddLine(Width - 1, 3, Width - 1, 24);
            Deumos_Path.AddLine(Width - 1, 24, Width - 92, 24);
            Deumos_Path.CloseFigure();

            Deumos_PathClone = (GraphicsPath)Deumos_Path.Clone();
            Deumos_PathClone.Widen(Pens.Black);
            //Draw corner gradient
            G.SetClip(Deumos_Path);
            Deumos_R1 = new Rectangle(0, 0, Width, 24);
            Deumos_G1 = new LinearGradientBrush(Deumos_R1, Deumos_C2, Deumos_C3, 90);
            G.FillRectangle(Deumos_G1, Deumos_R1);

            //Draw corner gloss
            G.FillRectangle(Deumos_B2, 0, 0, Width, 11);
            G.DrawPath(Deumos_P3, Deumos_PathClone);
            G.ResetClip();

            //Draw corner outline
            G.DrawPath(Deumos_P2, Deumos_Path);
            //CornerOutline

            //Draw title elements
            DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, -21, _HeaderOffset + 1);
            DrawText(Deumos_B4, HorizontalAlignment.Center, -20, _HeaderOffset);
            DrawImage(HorizontalAlignment.Left, 11, 0);
        }

        void Deumos_OnCreation()
        {
            Parent.MinimumSize = new Size(120, 80);
        }



        void Deumos_OnResize(EventArgs e)
        {
            Deumos_Path.Reset();

            Deumos_Path.AddLine(3, 0, 31, 0);
            Deumos_Path.AddLine(55, 24, 0, 24);
            Deumos_Path.AddLine(0, 24, 0, 3);
            Deumos_Path.CloseFigure();

            Deumos_Path.AddLine(Width - 68, 0, Width - 4, 0);
            Deumos_Path.AddLine(Width - 1, 3, Width - 1, 24);
            Deumos_Path.AddLine(Width - 1, 24, Width - 92, 24);
            Deumos_Path.CloseFigure();

            Deumos_PathClone = (GraphicsPath)Deumos_Path.Clone();
            Deumos_PathClone.Widen(Pens.Black);


        }


        #endregion
    }
}
