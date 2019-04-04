// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Xtreme.cs" company="Zeroit Dev Technologies">
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
        #region 142. Xtreme

        void Xtreme_PaintHook(PaintEventArgs e)
        {
            //Body
            G.Clear(Color.FromArgb(30, 30, 30));
            G.FillRectangle(Brushes.Fuchsia, 0, 0, Width, 5);
            DrawBorders(Pens.Black, 0, 30, Width, Height);

            //HeaderShadow
            DrawGradient(Color.Black, Color.FromArgb(30, 30, 30), 1, 28, Width, 10);

            //BottomBody
            DrawGradient(Color.FromArgb(30, 30, 30), Color.Black, 0, Height - 23, Width, 10);
            DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(57, 57, 58), 0, Height - 12, Width / 2, Height, 360);
            DrawGradient(Color.FromArgb(0, 0, 0), Color.FromArgb(57, 57, 58), Width / 2, Height - 12, Width / 2, Height, 180);
            G.DrawLine(Pens.Black, 0, Height - 13, Width, Height - 13);
            G.DrawLine(new Pen(Color.FromArgb(57, 57, 58)), Width / 2, Height - 11, Width / 2, Height);


            //LeftSideBody
            G.FillRectangle(Brushes.Black, 0, 30, 8, Height);
            DrawBorders(Pens.Black, 1, 30, 9, Height - 2);
            G.DrawLine(new Pen(Color.FromArgb(40, 40, 40)), 8, 30, 8, Height);

            //RightSideBody
            G.FillRectangle(Brushes.Black, Width - 9, 30, 11, Height - 20);
            DrawBorders(Pens.Black, Width - 10, 30, 11, Height - 2);
            G.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), Width - 9, 30, Width - 9, Height);



            //Header
            G.FillRectangle(Brushes.Black, 0, 5, Width, 24);
            DrawText(Brushes.Red, HorizontalAlignment.Left, 55, 2);
            G.FillRectangle(new SolidBrush(Color.FromArgb(50, Color.White)), 0, 5, Width - 1, 11);
            DrawBorders(Pens.Black, 1, 4, Width - 2, 24);
            G.DrawLine(new Pen(Color.FromArgb(108, 108, 108)), 1, 5, Width, 5);
            G.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), 1, 28, Width - 2, 28);
            G.DrawLine(Pens.Black, 1, 30, Width - 3, 30);

            //-----------------------------------------------------
            //Box
            DrawBorders(Pens.Black, 8, 0, 34, 32);
            DrawGradient(Color.FromArgb(57, 57, 58), Color.FromArgb(2, 4, 12), 9, 1, 32, 16);
            DrawGradient(Color.FromArgb(2, 4, 23), Color.FromArgb(57, 57, 58), 9, 15, 32, 16);
            //Lines
            //if (!((Icon == null))) {
            //	G.DrawIcon(Icon, new Rectangle(10, 0, 32, 32));
            //} else {
            //	G.DrawIcon(Icon, new Rectangle(10, 0, 32, 32));
            //}


            DrawImage(HorizontalAlignment.Left, 9, 1);

            //Gloss
            G.FillRectangle(new SolidBrush(Color.FromArgb(15, Color.White)), 10, 2, 31, 13);
            //------------------------------------------------------

            //SideBoxes
            DrawGradient(Color.FromArgb(10, 10, 10), Color.FromArgb(47, 47, 47), 42, 2, 5, 15);
            DrawGradient(Color.FromArgb(47, 47, 47), Color.FromArgb(10, 10, 10), 42, 15, 5, 15);
            DrawGradient(Color.FromArgb(47, 47, 47), Color.FromArgb(10, 10, 10), 3, 2, 5, 15);
            DrawGradient(Color.FromArgb(10, 10, 10), Color.FromArgb(47, 47, 47), 3, 15, 5, 15);
            DrawBorders(Pens.Black, 42, 2, 5, 29);
            DrawBorders(Pens.Black, 3, 2, 5, 29);
            G.DrawLine(Pens.Black, 3, 15, 7, 15);
            G.DrawLine(Pens.Black, 42, 15, 46, 15);

            //Animation


            //Icon

            G.DrawLine(Pens.Black, 0, Height - 1, Width, Height - 1);
            DrawCorners(Color.Fuchsia);
        }

        #endregion
    }
}
