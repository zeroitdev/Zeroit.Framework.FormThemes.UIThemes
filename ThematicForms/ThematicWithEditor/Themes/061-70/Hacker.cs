// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Hacker.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
