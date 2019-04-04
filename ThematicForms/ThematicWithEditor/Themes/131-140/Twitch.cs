// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Twitch.cs" company="Zeroit Dev Technologies">
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
        #region 131. Twitch

        bool twitch_Fill = true;

        [Category("Twitch Theme")]
        public bool Fill
        {
            get { return twitch_Fill; }
            set
            {
                twitch_Fill = value;
                Invalidate();
            }

        }

        void Twitch_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.Red);
            G.FillRectangle(Brushes.White, new Rectangle(0, 0, Width, Height));
            G.FillRectangle(new SolidBrush(Color.FromArgb(40, 40, 40)), new Rectangle(0, 0, Width, 30));
            //G.FillRectangle(New SolidBrush(Color.FromArgb(40, 40, 40)), New Rectangle(0, 30, 10, Height - 30))
            //G.DrawLine(Pens.Black, Width - 11, 30, Width - 10, Height - 30)
            G.FillRectangle(new SolidBrush(Color.FromArgb(40, 40, 40)), new Rectangle(Width - 10, 30, 10, Height - 30));
            //G.DrawLine(Pens.Black, 10, Height - 11, Width - 10, Height - 11)
            G.FillRectangle(new SolidBrush(Color.FromArgb(40, 40, 40)), new Rectangle(0, Height - 10, Width, 10));
            DrawCorners(Color.Fuchsia);
            G.DrawString(Parent.FindForm().Text, Font, Brushes.White, 5, 6);
            if (Fill == true)
            {
                G.FillRectangle(new SolidBrush(Color.FromArgb(40, 40, 40)), new Rectangle(0, 0, Width, Height));
                DrawCorners(Color.Fuchsia);
                G.DrawString(Parent.FindForm().Text, Font, Brushes.White, 5, 6);
            }
        }

        #endregion
    }
}
