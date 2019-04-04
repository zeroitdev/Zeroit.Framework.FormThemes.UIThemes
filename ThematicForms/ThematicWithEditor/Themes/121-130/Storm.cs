// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Storm.cs" company="Zeroit Dev Technologies">
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
        #region 121. Storm

        private Color Storm_C1 = Color.FromArgb(90, 90, 110);
        private Color Storm_C2 = Color.FromArgb(175, 175, 190);
        private Color Storm_C3 = Color.FromArgb(140, 140, 155);
        private Pen Storm_P1 = new Pen(Color.FromArgb(70, 70, 90));
        private Pen Storm_P2 = new Pen(Color.FromArgb(105, 105, 120));
        private Pen Storm_P3 = new Pen(Color.FromArgb(25, 25, 30));

        private HatchBrush Storm_B1;

        private int _TopHeight = 40;
        private int _BottomHeight = 40;
        void Storm_PaintHook(PaintEventArgs e)
        {
            Storm_B1 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(35, 35, 45), Color.FromArgb(40, 40, 50));

            G.Clear(Storm_C1);

            if (!(_TopHeight == 0))
            {
                DrawGradient(Storm_C2, Storm_C3, 0, 0, Width, _TopHeight);
                G.DrawLine(Storm_P1, 0, _TopHeight - 1, Width, _TopHeight - 1);
                G.DrawLine(Storm_P2, 0, _TopHeight, Width, _TopHeight);
            }

            if (!(_BottomHeight == 0))
            {
                G.FillRectangle(Storm_B1, 0, Height - _BottomHeight, Width, _BottomHeight);
                G.DrawLine(Storm_P3, 0, Height - _BottomHeight, Width, Height - _BottomHeight);
            }

            DrawText(new SolidBrush(Color.FromArgb(195, 193, 191)), HorizontalAlignment.Left, 4, 0);

        }

        #endregion
    }
}
