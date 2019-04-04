// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Hacker.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 64. Hacker

        private Color[] hacker_colors = new Color[]
        {
            Color.FromArgb(255, 16, 16, 16),
            Color.FromArgb(255, 14, 14, 14),
            Color.FromArgb(120, 80, 80, 80),
            Color.FromArgb(120, 64, 64, 64),
            Color.FromArgb(255, 20, 20, 20),
            Color.FromArgb(255, 12, 12, 12)

        };

        private HatchStyle hacker_hatchstyle = HatchStyle.DarkDownwardDiagonal;

        public enum HackerDrawMode
        {
            Solid,
            Hatch,
            Gradient
        }

        HackerDrawMode hackerDrawMode = HackerDrawMode.Hatch;

        private LinearGradientMode hacker_linearGradeMode = LinearGradientMode.ForwardDiagonal;

        [Category("Hacker Theme")]
        public Color[] HackerColors
        {
            get { return hacker_colors; }
            set
            {
                hacker_colors = value;
                Invalidate();
            }
        }

        [Category("Hacker Theme")]
        public HatchStyle HackerHatch
        {
            get { return hacker_hatchstyle; }
            set
            {
                hacker_hatchstyle = value;
                Invalidate();
            }
        }

        [Category("Hacker Theme")]
        public HackerDrawMode HackDrawMode
        {
            get { return hackerDrawMode; }
            set
            {
                hackerDrawMode = value;
                Invalidate();
            }
        }

        [Category("Hacker Theme")]
        public LinearGradientMode HackerGradMode
        {
            get { return hacker_linearGradeMode; }
            set
            {
                hacker_linearGradeMode = value;
                Invalidate();
            }
        }

        void Hacker_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Black);
            G.SmoothingMode = SmoothingMode.HighQuality;

            switch (hackerDrawMode)
            {
                case HackerDrawMode.Hatch:
                    {
                        //Form Border
                        HatchBrush HB = new HatchBrush(hacker_hatchstyle, hacker_colors[0], hacker_colors[1]);
                        G.FillRectangle(HB, new Rectangle(0, 0, Width - 1, Height - 1));
                        G.DrawRectangle(new Pen(Color.Black), 0, 0, Width - 1, Height - 1);
                        //Form Interior
                        HatchBrush HB2 = new HatchBrush(hacker_hatchstyle, hacker_colors[2], hacker_colors[3]);
                        G.FillRectangle(HB2, new Rectangle(6, 25, Width - 11, Height - 30));
                        //Title Box
                        HatchBrush HB3 = new HatchBrush(hacker_hatchstyle, hacker_colors[4], hacker_colors[5]);
                        Point[] p = {
                        new Point(3, 15),
                        new Point(20, 3),
                        new Point(230, 3),
                        new Point(230, 15),
                        new Point(200, 35),
                        new Point(3, 35)
                    };
                        G.FillPolygon(HB3, p);
                        G.DrawPolygon(Pens.Black, p);
                        break;
                    }

                case HackerDrawMode.Solid:
                    {
                        //Form Border
                        SolidBrush Solid1 = new SolidBrush(hacker_colors[0]);
                        G.FillRectangle(Solid1, new Rectangle(0, 0, Width - 1, Height - 1));
                        G.DrawRectangle(new Pen(Color.Black), 0, 0, Width - 1, Height - 1);
                        //Form Interior
                        SolidBrush Solid2 = new SolidBrush(hacker_colors[2]);
                        G.FillRectangle(Solid2, new Rectangle(6, 25, Width - 11, Height - 30));
                        //Title Box
                        SolidBrush Solid3 = new SolidBrush(hacker_colors[4]);
                        Point[] p = {
                        new Point(3, 15),
                        new Point(20, 3),
                        new Point(230, 3),
                        new Point(230, 15),
                        new Point(200, 35),
                        new Point(3, 35)
                    };
                        G.FillPolygon(Solid3, p);
                        G.DrawPolygon(Pens.Black, p);
                        break;
                    }

                case HackerDrawMode.Gradient:
                    {
                        //Form Border
                        LinearGradientBrush LinBr = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), hacker_colors[0], hacker_colors[1], hacker_linearGradeMode);
                        G.FillRectangle(LinBr, new Rectangle(0, 0, Width - 1, Height - 1));

                        G.DrawRectangle(new Pen(Color.Black), 0, 0, Width - 1, Height - 1);
                        //Form Interior
                        LinearGradientBrush LinBr1 = new LinearGradientBrush(new Rectangle(6, 25, Width - 11, Height - 30), hacker_colors[2], hacker_colors[3], hacker_linearGradeMode);
                        G.FillRectangle(LinBr1, new Rectangle(6, 25, Width - 11, Height - 30));
                        //Title Box
                        PointF[] p = {
                        new Point(3, 15),
                        new Point(20, 3),
                        new Point(230, 3),
                        new Point(230, 15),
                        new Point(200, 35),
                        new Point(3, 35)
                    };
                        LinearGradientBrush LinBr2 = new LinearGradientBrush(new Point(3, 15), new Point(230, 15), hacker_colors[4], hacker_colors[5]);

                        G.FillPolygon(LinBr2, p);
                        G.DrawPolygon(Pens.Black, p);
                        break;
                    }

            }

            //Icon and Form Title
            G.DrawString(Text, Font, new SolidBrush(ForeColor), new Point(40, 12));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(20, 12, 16, 16));
            //Draw Border
            DrawBorders(Pens.Black, 0);
        }

        #endregion
    }
}
