// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Classic.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
        #region 25. Classic

        //private Bloom[] Classic_Bloom;
        private Rectangle Classic_R1;
        private LinearGradientBrush Classic_L1;
        private HatchBrush Classic_H;

        void Classic_PaintHook(PaintEventArgs e)
        {
            //Classic_Bloom = new Bloom[]{
            //    new Bloom("Border", Color.Black),
            //    new Bloom("Highlight Border", Color.FromArgb(87, 87, 87)),
            //    new Bloom("BackColor", Color.FromArgb(51, 51, 51)),
            //    new Bloom("Text Color", Color.FromArgb(128, Color.White)),
            //    new Bloom("Background", Color.FromArgb(73, 73, 73)),
            //    new Bloom("Grid Color", Color.FromArgb(128, 31, 31, 31)),
            //    new Bloom("Gradient #1", Color.FromArgb(128, Color.Black)),
            //    new Bloom("Highlight", Color.FromArgb(26, Color.White)),
            //    new Bloom("Shadow", Color.FromArgb(10, Color.Black)),
            //    new Bloom("Trasparency", Color.Fuchsia)
            //{ Pen = new Pen(Bloom[1].Value, 2) }
            //};


            G.Clear(Color.Black);
            DrawBorders(new Pen(Color.FromArgb(87, 87, 87)), 1, 1, Width - 2, Height - 2);
            G.FillRectangle(new SolidBrush(Color.FromArgb(51, 51, 51)), 2, 2, Width - 4, 18);
            G.FillRectangle(new SolidBrush(Color.FromArgb(51, 51, 51)), 2, Height - 20, Width - 4, 18);
            G.DrawLine(new Pen(Color.FromArgb(87, 87, 87)), 2, 21, Width - 2, 21);
            G.FillRectangle(new SolidBrush(Color.FromArgb(73, 73, 73)), 2, 22, Width - 4, Height - 44);
            G.DrawLine(new Pen(Color.FromArgb(87, 87, 87)), 2, Height - 21, Width - 2, Height - 21);

            Classic_H = new HatchBrush(HatchStyle.SmallCheckerBoard, Color.FromArgb(128, 31, 31, 31), Color.Empty);
            Classic_R1 = new Rectangle(2, 2, Width - 4, Height);
            Classic_L1 = new LinearGradientBrush(Classic_R1, Color.Empty, Color.Black, 270f);

            G.FillRectangle(Classic_L1, ClientRectangle);

            G.FillRectangle(Classic_H, 2, 22, Width - 4, Height - 44);

            G.FillRectangle(new SolidBrush(Color.FromArgb(255, Color.FromArgb(18, 17, 17))), 0, 0, Width, 30);

            //G.FillRectangle(new SolidBrush(Color.FromArgb(255,Color.Black)), 0, 4, Width, Height - 10);

            if (_Round)
            {
                G.DrawArc(Pens.Fuchsia, -1, -1, 9, 9, 180, 90);
                G.DrawArc(Pens.Fuchsia, Width - 9, -1, 9, 9, 270, 90);

                G.DrawArc(Pens.Fuchsia, Width - 9, Height - 9, 9, 9, 360, 90);
                G.DrawArc(Pens.Fuchsia, -1, Height - 9, 9, 9, 90, 90);

                G.DrawArc(Pens.Black, 0, 0, 9, 9, 180, 90);
                G.DrawArc(Pens.Black, Width - 10, 0, 9, 9, 270, 90);

                G.DrawArc(Pens.Black, Width - 10, Height - 10, 9, 9, 360, 90);
                G.DrawArc(Pens.Black, 0, Height - 10, 9, 9, 90, 90);
            }
            else
            {
                DrawCorners(Color.Fuchsia);
            }

            DrawText(new SolidBrush(ForeColor), 5, 5);
        }

        private bool _Round = false;
        public bool NewProperty
        {
            get { return _Round; }
            set
            {
                _Round = value;
                Invalidate();
            }
        }

        #endregion
    }
}
