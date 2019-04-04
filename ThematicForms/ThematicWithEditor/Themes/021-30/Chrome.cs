// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Chrome.cs" company="Zeroit Dev Technologies">
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
        #region 23. Chrome 

        private int X;
        private int Y;

        public void ChromeConstructor()
        {

        }

        void Chrome_OnMouseMove(MouseEventArgs e)
        {
            X = e.Location.X;
            Y = e.Location.Y;

        }

        void Chrome_OnMouseClick(MouseEventArgs e)
        {
            if (new Rectangle(Width - 22, 5, 15, 15).Contains(new Point(X, Y)))
            {
                ParentForm.FindForm().Close();
            }

        }


        void Chrome_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.White);
            DrawCorners(Color.Fuchsia);
            DrawCorners(Color.Fuchsia, 1, 0, Width - 2, Height);
            DrawCorners(Color.Fuchsia, 0, 1, Width, Height - 2);
            DrawCorners(Color.Fuchsia, 2, 0, Width - 4, Height);
            DrawCorners(Color.Fuchsia, 0, 2, Width, Height - 4);

            G.SmoothingMode = SmoothingMode.HighQuality;
            if (new Rectangle(Width - 22, 5, 15, 15).Contains(new Point(X, Y)))
            {
                G.FillEllipse(new SolidBrush(Color.FromArgb(114, 114, 114)), new Rectangle(Width - 24, 6, 16, 16));
                G.DrawString("r", new Font("Webdings", 8), new SolidBrush(BackColor), new Point(Width - 23, 5));
            }
            else
            {
                G.DrawString("r", new Font("Webdings", 8), new SolidBrush(Color.FromArgb(90, 90, 90)), new Point(Width - 23, 5));
            }

            DrawText(new SolidBrush(ForeColor), new Point(8, 7));
        }

        #endregion
    }
}
