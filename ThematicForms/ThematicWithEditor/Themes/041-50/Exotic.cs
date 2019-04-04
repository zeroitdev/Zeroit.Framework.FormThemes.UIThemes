﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Exotic.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 49. Exotic

        private bool _test = true;
        public bool test
        {
            get { return _test; }
            set
            {
                _test = value;
                Invalidate();
            }
        }

        void Exotic_PaintHook(PaintEventArgs e)
        {
            int Size1 = 0;
            int Size2 = 0;
            switch (test)
            {
                case true:
                    Size1 = 38;
                    Size2 = 37;
                    break;
                case false:
                    Size1 = 21;
                    Size2 = -1;
                    break;
            }
            G.Clear(Color.Black);
            switch (test)
            {
                case true:
                    DrawGradient(Color.FromArgb(240, 248, 250), Color.FromArgb(0, 0, 0), 0, 19, Width, 18, 90);
                    break;
            }
            G.DrawLine(Pens.AliceBlue, 0, 20, Width, 20);
            G.DrawLine(Pens.AliceBlue, 0, Size2, Width, Size2);
            switch (test)
            {
                case true:
                    for (int I = 0; I <= Width + 17; I += 4)
                    {
                        G.DrawLine(Pens.Black, I, 21, I - 17, Size1);
                        G.DrawLine(Pens.Black, I - 1, 21, I - 18, Size1);
                    }

                    break;
            }
            DrawBorders(Pens.Black, Pens.AliceBlue, ClientRectangle);
            DrawCorners(Color.Black, ClientRectangle);
            DrawText((HorizontalAlignment)Top, Color.FromArgb(240, 248, 255), 0);
        }

        #endregion
    }
}
