// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="GameBooster.cs" company="Zeroit Dev Technologies">
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
        #region 58. Game Booster
        private Color GameBooster_C1 = Color.FromArgb(232, 232, 232);
        private Color GameBooster_C2 = Color.FromArgb(252, 252, 252);
        private Color GameBooster_C3 = Color.FromArgb(242, 242, 242);
        private SolidBrush GameBooster_B1 = new SolidBrush(Color.FromArgb(255, 255, 255));
        private SolidBrush GameBooster_B2 = new SolidBrush(Color.FromArgb(80, 80, 80));
        private SolidBrush GameBooster_B3 = new SolidBrush(Color.FromArgb(255, 255, 255));
        private Pen GameBooster_P1 = new Pen(Color.FromArgb(24, 24, 24));
        private Pen GameBooster_P2 = new Pen(Color.FromArgb(126, 126, 126));
        private Pen GameBooster_P3 = new Pen(Color.FromArgb(92, 92, 92));

        private Pen GameBooster_P4 = new Pen(Color.FromArgb(24, 24, 24));


        private Rectangle GameBooster_RT1;

        void GameBooster_PaintHook(PaintEventArgs e)
        {

            G.Clear(Color.FromArgb(51, 51, 51));

            DrawGradient(GameBooster_C2, GameBooster_C3, 0, 0, Width, 15);

            DrawText(GameBooster_B1, HorizontalAlignment.Left, 13, 1);
            DrawText(GameBooster_B2, HorizontalAlignment.Left, 12, 0);

            DrawGradient(Color.FromArgb(92, 92, 92), Color.FromArgb(49, 49, 49), 0, 0, Width, 26);
            G.DrawLine(new Pen(GameBooster_P1.Color), new Point(0, 26), new Point(Width, 26));
            G.DrawRectangle(GameBooster_P1, 0, 0, Width - 1, Height - 1);
            G.DrawRectangle(GameBooster_P2, 1, 1, Width - 3, Height - 3);
            DrawPixel(GameBooster_P1.Color, 1, 1);
            DrawPixel(GameBooster_P2.Color, 2, 2);
            DrawPixel(GameBooster_P1.Color, Width - 2, 1);
            DrawPixel(GameBooster_P2.Color, Width - 3, 2);
            DrawPixel(GameBooster_P1.Color, 1, Height - 2);
            DrawPixel(GameBooster_P2.Color, 2, Height - 3);
            DrawPixel(GameBooster_P1.Color, Width - 2, Height - 2);
            DrawPixel(GameBooster_P2.Color, Width - 3, Height - 3);
            DrawText(new SolidBrush(Color.FromArgb(61, 61, 61)), HorizontalAlignment.Center, 0, 1);
            DrawText(new SolidBrush(Color.White), HorizontalAlignment.Center, 0, 2);

        }

        #endregion
    }
}
