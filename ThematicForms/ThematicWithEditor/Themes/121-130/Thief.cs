// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Thief.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 130. Thief

        private bool _bStripes;
        [Category("Thief Theme")]
        public bool HatchEnable
        {
            get { return _bStripes; }
            set
            {
                _bStripes = value;
                Invalidate();
            }
        }

        private bool _cStyle;

        [Category("Thief Theme")]
        public bool DarkTheme
        {
            get { return _cStyle; }
            set
            {
                _cStyle = value;
                Invalidate();
            }
        }

        private HorizontalAlignment _tAlign;

        [Category("Thief Theme")]
        public HorizontalAlignment TitleTextAlign
        {
            get { return _tAlign; }
            set
            {
                _tAlign = value;
                Invalidate();
            }
        }

        void Thief_PaintHook(PaintEventArgs e)
        {
            int ClientPtA = 0;
            int ClientPtB = 0;
            int GradA = 0;
            int GradB = 0;
            Pen PenColor = default(Pen);
            switch (HatchEnable)
            {
                case true:
                    ClientPtA = 38;
                    ClientPtB = 37;
                    break;
                case false:
                    ClientPtA = 21;
                    ClientPtB = -1;
                    break;
            }
            switch (DarkTheme)
            {
                case true:
                    GradA = 51;
                    GradB = 30;
                    PenColor = Pens.Black;
                    break;
                case false:
                    GradA = 200;
                    GradB = 160;
                    PenColor = Pens.DimGray;
                    break;
            }
            G.Clear(Color.FromArgb(GradA, GradA, GradA));
            DrawGradient(Color.FromArgb(GradA, GradA, GradA), Color.FromArgb(GradB, GradB, GradB), 0, 0, Width, 19, 90);
            switch (HatchEnable)
            {
                case true:
                    DrawGradient(Color.FromArgb(GradB, GradB, GradB), Color.FromArgb(GradA, GradA, GradA), 0, 19, Width, 18, 90);
                    break;
            }
            G.DrawLine(PenColor, 0, 20, Width, 20);
            G.DrawLine(PenColor, 0, ClientPtB, Width, ClientPtB);
            switch (HatchEnable)
            {
                case true:
                    for (int I = 0; I <= Width + 17; I += 4)
                    {
                        G.DrawLine(PenColor, I, 21, I - 17, ClientPtA);
                        G.DrawLine(PenColor, I - 1, 21, I - 18, ClientPtA);
                    }

                    break;
            }
            G.DrawLine(new Pen(new SolidBrush(Color.DodgerBlue)), 0, ClientPtA, Width, ClientPtA);
            G.DrawLine(new Pen(new SolidBrush(Color.DodgerBlue)), 0, Height - 2, Width, Height - 2);
            G.DrawLine(new Pen(new SolidBrush(Color.DodgerBlue)), 1, ClientPtA, 1, Height - 2);
            G.DrawLine(new Pen(new SolidBrush(Color.DodgerBlue)), Width - 2, ClientPtA, Width - 2, Height - 1);
            G.DrawString(".", this.Parent.Font, Brushes.Black, -2, Height - 12);
            G.DrawString(".", this.Parent.Font, Brushes.Black, Width - 5, Height - 12);
            DrawText(TitleTextAlign, Color.DodgerBlue, 6, 0);
            DrawBorders(Pens.Black, Pens.Transparent, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
        }


        #endregion
    }
}
