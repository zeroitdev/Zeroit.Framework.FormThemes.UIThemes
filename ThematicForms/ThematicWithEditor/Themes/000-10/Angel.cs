// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Angel.cs" company="Zeroit Dev Technologies">
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
        #region 4. Angel

        #region " Back End "

        #region " Declarations "
        private int H = 52;
        private bool D = false;
        private Point P;
        #endregion
        private Alignment A = Alignment.Left;

        #region " Mouse States "
        // Get more free themes at ThemesVB.NET
        void Angel_OnMouseUp(MouseEventArgs e)
        {

            D = false;
        }

        void Angel_OnMouseDown(MouseEventArgs e)
        {

            if (new Rectangle(0, 0, Width, H).Contains(e.Location) && e.Button == MouseButtons.Left)
            {
                P = e.Location;
                D = true;
            }
        }

        void Angel_OnMouseMove(MouseEventArgs e)
        {

            if (D == true)
            {
                ParentForm.Location = new Point(MousePosition.X - P.X, MousePosition.Y - P.Y);
            }
        }


        #endregion

        #region " Properties "

        #region " Appearance "
        [Category("Appearance")]
        //public Alignment TextAlignment
        //{
        //    get { return A; }
        //    set
        //    {
        //        A = value;
        //        Invalidate();
        //    }
        //}

        #endregion

        #endregion

        #region " Paint "

        void Angel_PaintHook(PaintEventArgs e)
        {

            G.Clear(Color.Black);
            G.DrawRectangle(new Pen(Color.FromArgb(10, 33, 55)), new Rectangle(0, 0, Width - 1, H));
            G.FillRectangle(new LinearGradientBrush(new Point(1, 1), new Point(1, H), Color.FromArgb(75, 168, 218), Color.FromArgb(33, 112, 177)), new Rectangle(1, 1, Width - 2, H - 1));
            G.FillRectangle(new LinearGradientBrush(new Point(2, 2), new Point(2, H - 1), Color.FromArgb(54, 131, 203), Color.FromArgb(26, 86, 145)), new Rectangle(2, 2, Width - 4, H - 3));
            G.DrawRectangle(new Pen(Color.FromArgb(27, 48, 66)), new Rectangle(1, H + 1, Width - 3, Height - H - 3));
            G.FillRectangle(new SolidBrush(Color.FromArgb(17, 33, 47)), new Rectangle(2, H + 1, Width - 4, Height - H - 3));

            StringFormat F = new StringFormat { LineAlignment = StringAlignment.Center };
            switch (A)
            {
                case Alignment.Left:
                    G.DrawString(Text, Font, Brushes.White, new Rectangle(8, 0, Width, H), F);
                    break;
                case Alignment.Center:
                    F.Alignment = StringAlignment.Center;
                    G.DrawString(Text, Font, Brushes.White, new Rectangle(0, 0, Width - 1, H), F);
                    break;
                case Alignment.Right:
                    G.DrawString(Text, Font, Brushes.White, new Rectangle(Width - TextRenderer.MeasureText(Text, Font).Width - 8, 0, TextRenderer.MeasureText(Text, Font).Width + 8, H), F);
                    break;
            }

        }



        #endregion

        #endregion


        #endregion
    }
}
