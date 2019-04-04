// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Flow.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
        #region 53. Flow

        private Color Flow_C1 = Color.FromArgb(40, 40, 40);
        private Color Flow_C2 = Color.FromArgb(18, 18, 18);
        private SolidBrush Flow_B1 = new SolidBrush(Color.FromArgb(0, 132, 255));
        private Pen Flow_P1 = new Pen(Color.FromArgb(40, 40, 40));
        private Pen Flow_P2 = new Pen(Color.FromArgb(22, 22, 22));
        private Pen Flow_P3 = new Pen(Color.FromArgb(65, 65, 65));
        private Pen Flow_P4 = new Pen(Color.FromArgb(255, Color.Black));

        private TextureBrush Tile;
        private byte[] TileData = Convert.FromBase64String("AgIBAQEBAwMBAQEBAAABAQEBAQEBAgIBAQEBAwMBAQEBAAAB");
        private void CreateTile()
        {
            Bitmap TileImage = new Bitmap(6, 6);
            Color[] TileColors = new Color[] {
                Color.FromArgb(39, 39, 39),
                Color.FromArgb(35, 35, 35),
                Color.FromArgb(29, 29, 29),
                Color.FromArgb(26, 26, 26)
            };

            for (int I = 0; I <= 35; I++)
            {
                TileImage.SetPixel(I % 6, I / 6, TileColors[TileData[I]]);
            }

            Tile = new TextureBrush(TileImage);
            TileImage.Dispose();
        }

        private Pen[] Shade;
        private void CreateShade()
        {
            if (Shade != null)
            {
                for (int I = 0; I <= Shade.Length - 1; I++)
                {
                    Shade[I].Dispose();
                }
            }

            Bitmap ShadeImage = new Bitmap(1, 20);
            Graphics ShadeGraphics = Graphics.FromImage(ShadeImage);

            Rectangle ShadeBounds = new Rectangle(0, 0, 1, 20);
            LinearGradientBrush Gradient = new LinearGradientBrush(ShadeBounds, Color.FromArgb(50, 7, 7, 7), Color.Transparent, 90f);

            Shade = new Pen[20];
            ShadeGraphics.FillRectangle(Gradient, ShadeBounds);

            for (int I = 0; I <= Shade.Length - 1; I++)
            {
                Shade[I] = new Pen(ShadeImage.GetPixel(0, I));
            }

            Gradient.Dispose();
            ShadeGraphics.Dispose();
            ShadeImage.Dispose();
        }

        private Rectangle Flow_RT1;
        void Flow_PaintHook(PaintEventArgs e)
        {
            G.Clear(Flow_C1);

            DrawGradient(Flow_C2, Flow_C1, 0, 0, Width, 24);
            DrawText(Flow_B1, HorizontalAlignment.Left, 8, 0);

            Flow_RT1 = new Rectangle(8, 24, Width - 16, Height - 32);


            CreateTile();
            CreateShade();

            G.FillRectangle(Tile, Flow_RT1);

            for (int I = 0; I <= Shade.Length - 1; I++)
            {
                DrawBorders(Shade[I], Flow_RT1, I);
            }

            Flow_RT1 = new Rectangle(8, 24, Width - 16, Height - 32);
            DrawBorders(Flow_P1, Flow_RT1, 1);
            DrawBorders(Flow_P2, Flow_RT1);
            DrawCorners(Flow_C1, Flow_RT1);

            DrawBorders(Flow_P3, 1);
            DrawBorders(Flow_P4);

            DrawCorners(TransparencyKey);
        }


        #endregion
    }
}
