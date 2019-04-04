// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Twitch.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Form control with themes.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
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
