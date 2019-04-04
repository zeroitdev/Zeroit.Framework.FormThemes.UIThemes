// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="xVisual.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 143. xVisual

        TextureBrush TopTexture = Utilities.Draw.NoiseBrush(new Color[]{
            Color.FromArgb(66, 64, 62),
            Color.FromArgb(63, 61, 59),
            Color.FromArgb(69, 67, 65)
        });

        TextureBrush InnerTexture = Utilities.Draw.NoiseBrush(new Color[]{
            Color.FromArgb(57, 53, 50),
            Color.FromArgb(56, 52, 49),
            Color.FromArgb(58, 55, 51)
        });

        Font drawFont = new Font("Arial", 11, FontStyle.Bold);

        void xVisual_PaintHook(System.Windows.Forms.PaintEventArgs e)
        {

            G.Clear(Color.Fuchsia);

            Rectangle mainRect = new Rectangle(0, 0, Width, Height);
            LinearGradientBrush LeftHighlight = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(66, 64, 63), Color.FromArgb(56, 54, 53), 90);
            LinearGradientBrush RightHighlight = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(80, 78, 77), Color.FromArgb(70, 68, 67), 90);
            LinearGradientBrush TopOverlay = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, 53), Color.FromArgb(15, Color.White), Color.FromArgb(100, Color.FromArgb(43, 40, 38)), 90);

            LinearGradientBrush mainGradient = new LinearGradientBrush(mainRect, Color.FromArgb(73, 71, 69), Color.FromArgb(69, 67, 64), 90);
            G.FillRectangle(mainGradient, mainRect);
            //Outside Rectangle
            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));

            G.FillRectangle(InnerTexture, new Rectangle(10, 53, Width - 21, Height - 84));
            //Inner Rectangle
            G.DrawRectangle(Pens.Black, new Rectangle(10, 53, Width - 21, Height - 84));

            G.FillRectangle(TopTexture, new Rectangle(0, 0, Width - 1, 53));
            //Top Bar Rectangle
            G.FillRectangle(TopOverlay, new Rectangle(0, 0, Width - 1, 53));
            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, 53));

            ColorBlend blend = new ColorBlend();

            //Add the Array of Color
            Color[] bColors = new Color[] {
                Color.FromArgb(10, Color.White),
                Color.FromArgb(10, Color.Black),
                Color.FromArgb(10, Color.White)
            };
            blend.Colors = bColors;

            //Add the Array Single (0-1) colorpoints to place each Color
            float[] bPts = new float[] {
                0,
                0.7f,
                1
            };
            blend.Positions = bPts;

            Rectangle rect = new Rectangle(0, 0, Width - 1, 53);
            using (LinearGradientBrush br = new LinearGradientBrush(rect, Color.White, Color.Black, LinearGradientMode.Vertical))
            {

                //Blend the colors into the Brush
                br.InterpolationColors = blend;

                //Fill the rect with the blend
                G.FillRectangle(br, rect);

            }

            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(173, 172, 172)), 4, 1, Width - 5, 1);
            //Top Middle Highlight
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(110, 109, 107)), 11, Height - 30, Width - 12, Height - 30);
            //Bottom Middle Highlight

            G.FillRectangle(Utilities.Draw.GetBrush(Color.FromArgb(173, 172, 172)), 3, 2, 1, 1);
            //Top Left Corner Highlight
            G.FillRectangle(Utilities.Draw.GetBrush(Color.FromArgb(133, 132, 132)), 2, 2, 1, 1);
            G.FillRectangle(Utilities.Draw.GetBrush(Color.FromArgb(113, 112, 112)), 2, 3, 1, 1);
            G.FillRectangle(Utilities.Draw.GetBrush(Color.FromArgb(83, 82, 82)), 1, 4, 1, 1);

            G.FillRectangle(Utilities.Draw.GetBrush(Color.FromArgb(173, 172, 172)), Width - 4, 2, 1, 1);
            //Top Right Corner Highlight
            G.FillRectangle(Utilities.Draw.GetBrush(Color.FromArgb(133, 132, 132)), Width - 3, 2, 1, 1);
            G.FillRectangle(Utilities.Draw.GetBrush(Color.FromArgb(113, 112, 112)), Width - 3, 3, 1, 1);
            G.FillRectangle(Utilities.Draw.GetBrush(Color.FromArgb(83, 82, 82)), Width - 2, 4, 1, 1);

            //// Shadows
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(91, 90, 89)), 1, 52, Width - 2, 52);
            //Middle Top Horizontal
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(40, 37, 34)), 11, 54, Width - 12, 54);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(45, 42, 39)), 11, 55, Width - 12, 55);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(50, 47, 44)), 11, 56, Width - 12, 56);

            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(50, 47, 44)), 11, Height - 32, Width - 12, Height - 32);
            //Middle Bottom Horizontal
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(52, 49, 46)), 11, Height - 33, Width - 12, Height - 33);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(54, 51, 48)), 11, Height - 34, Width - 12, Height - 34);


            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(59, 57, 55)), 1, 54, 9, 54);
            //Left Horizontal
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(64, 62, 60)), 1, 55, 9, 55);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(73, 71, 69)), 1, 56, 9, 56);

            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(59, 57, 55)), Width - 10, 54, Width - 2, 54);
            //Right Horizontal
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(64, 62, 60)), Width - 10, 55, Width - 2, 55);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(73, 71, 69)), Width - 10, 56, Width - 2, 56);

            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(59, 57, 55)), 1, 54, 1, Height - 5);
            //Left Vertical
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(64, 62, 60)), 2, 55, 2, Height - 4);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(73, 71, 69)), 3, 56, 3, Height - 3);
            G.DrawLine(new Pen(LeftHighlight), 1, 5, 1, 51);
            G.DrawLine(new Pen(RightHighlight), 2, 5, 2, 51);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(69, 67, 65)), 9, 56, 9, Height - 31);

            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(59, 57, 55)), Width - 2, 54, Width - 2, Height - 5);
            //Right Vertical
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(64, 62, 60)), Width - 3, 55, Width - 3, Height - 4);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(73, 71, 69)), Width - 4, 56, Width - 4, Height - 3);
            G.DrawLine(new Pen(LeftHighlight), Width - 2, 5, Width - 2, 51);
            G.DrawLine(new Pen(RightHighlight), Width - 3, 5, Width - 3, 51);
            G.DrawLine(Utilities.Draw.GetPen(Color.FromArgb(69, 67, 65)), Width - 10, 56, Width - 10, Height - 31);

            G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(255, 255, 255)), new Rectangle(0, 0, Width, 37), new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            });

            //////left upper corner
            G.FillRectangle(Brushes.Fuchsia, 0, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 1, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 2, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 3, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, 2, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, 3, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 1, 1, 1, 1);

            G.FillRectangle(Brushes.Black, 1, 3, 1, 1);
            G.FillRectangle(Brushes.Black, 1, 2, 1, 1);
            G.FillRectangle(Brushes.Black, 2, 1, 1, 1);
            G.FillRectangle(Brushes.Black, 3, 1, 1, 1);
            //'////right upper corner
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 2, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 3, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 4, 0, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 2, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, 3, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 2, 1, 1, 1);

            G.FillRectangle(Brushes.Black, Width - 2, 3, 1, 1);
            G.FillRectangle(Brushes.Black, Width - 2, 2, 1, 1);
            G.FillRectangle(Brushes.Black, Width - 3, 1, 1, 1);
            G.FillRectangle(Brushes.Black, Width - 4, 1, 1, 1);
            //'////left bottom corner
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 2, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 3, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 0, Height - 4, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 1, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 2, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 3, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 1, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, 1, Height - 2, 1, 1);

            G.FillRectangle(Brushes.Black, 1, Height - 3, 1, 1);
            G.FillRectangle(Brushes.Black, 1, Height - 4, 1, 1);
            G.FillRectangle(Brushes.Black, 3, Height - 2, 1, 1);
            G.FillRectangle(Brushes.Black, 2, Height - 2, 1, 1);
            //'////right bottom corner
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 2, Height, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 3, Height, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 4, Height, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 2, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 3, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 2, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 3, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 4, Height - 1, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 1, Height - 4, 1, 1);
            G.FillRectangle(Brushes.Fuchsia, Width - 2, Height - 2, 1, 1);

            G.FillRectangle(Brushes.Black, Width - 2, Height - 3, 1, 1);
            G.FillRectangle(Brushes.Black, Width - 2, Height - 4, 1, 1);
            G.FillRectangle(Brushes.Black, Width - 4, Height - 2, 1, 1);
            G.FillRectangle(Brushes.Black, Width - 3, Height - 2, 1, 1);

        }

        #endregion
    }
}
