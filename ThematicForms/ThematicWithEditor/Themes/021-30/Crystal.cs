// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Crystal.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 29. Crystal
        private RoundingType _Rounding;
        public enum RoundingType : int
        {
            TypeOne = 1,
            TypeTwo = 2,
            None = 0
        }

        [Category("Crystal Theme")]
        public RoundingType Rounding
        {
            get { return _Rounding; }
            set { _Rounding = value; }
        }


        void Crystal_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(230, 230, 230));

            //Draw titlebar gradient
            LinearGradientBrush LB = new LinearGradientBrush(new Rectangle(new Point(1, 1), new Size(Width - 2, 25)), Color.FromArgb(230, 230, 230), Color.FromArgb(210, 210, 210), 90f);
            G.FillRectangle(LB, new Rectangle(new Point(1, 1), new Size(Width - 2, 25)));

            //Draw glow
            G.FillRectangle(new SolidBrush(Color.FromArgb(230, 230, 230)), new Rectangle(new Point(1, 1), new Size(Width - 2, 11)));

            //Draw outline + rounded corners
            G.DrawRectangle(new Pen(Color.FromArgb(170, 170, 170)), new Rectangle(0, 0, Width - 1, Height - 1));
            G.DrawLine(new Pen(Color.FromArgb(170, 170, 170)), new Point(0, 26), new Point(Width, 26));

            switch (_Rounding)
            {
                case RoundingType.TypeOne:
                    //////left upper corner
                    DrawPixel(Color.Fuchsia, 0, 0);
                    DrawPixel(Color.Fuchsia, 1, 0);
                    DrawPixel(Color.Fuchsia, 0, 1);
                    DrawPixel(Color.FromArgb(170, 170, 170), 1, 1);
                    //////right upper corner
                    DrawPixel(Color.Fuchsia, Width - 1, 0);
                    DrawPixel(Color.Fuchsia, Width - 2, 0);
                    DrawPixel(Color.Fuchsia, Width - 1, 1);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 2, 1);
                    //////left bottom corner
                    DrawPixel(Color.Fuchsia, 0, Height - 1);
                    DrawPixel(Color.Fuchsia, 1, Height - 1);
                    DrawPixel(Color.Fuchsia, 0, Height - 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), 1, Height - 2);
                    //////right bottom corner
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 2, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 2, Height - 2);
                    break;
                case RoundingType.TypeTwo:
                    //////left upper corner
                    DrawPixel(Color.Fuchsia, 0, 0);
                    DrawPixel(Color.Fuchsia, 1, 0);
                    DrawPixel(Color.Fuchsia, 2, 0);
                    DrawPixel(Color.Fuchsia, 3, 0);
                    DrawPixel(Color.Fuchsia, 0, 1);
                    DrawPixel(Color.Fuchsia, 0, 2);
                    DrawPixel(Color.Fuchsia, 0, 3);
                    DrawPixel(Color.Fuchsia, 1, 1);
                    DrawPixel(Color.FromArgb(170, 170, 170), 2, 1);
                    DrawPixel(Color.FromArgb(170, 170, 170), 3, 1);
                    DrawPixel(Color.FromArgb(170, 170, 170), 1, 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), 1, 3);
                    //////right upper corner
                    DrawPixel(Color.Fuchsia, Width - 1, 0);
                    DrawPixel(Color.Fuchsia, Width - 2, 0);
                    DrawPixel(Color.Fuchsia, Width - 3, 0);
                    DrawPixel(Color.Fuchsia, Width - 4, 0);
                    DrawPixel(Color.Fuchsia, Width - 1, 1);
                    DrawPixel(Color.Fuchsia, Width - 1, 2);
                    DrawPixel(Color.Fuchsia, Width - 1, 3);
                    DrawPixel(Color.Fuchsia, Width - 2, 1);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 3, 1);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 4, 1);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 2, 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 2, 3);
                    //////left bottom corner
                    DrawPixel(Color.Fuchsia, 0, Height - 1);
                    DrawPixel(Color.Fuchsia, 0, Height - 2);
                    DrawPixel(Color.Fuchsia, 0, Height - 3);
                    DrawPixel(Color.Fuchsia, 0, Height - 4);
                    DrawPixel(Color.Fuchsia, 1, Height - 1);
                    DrawPixel(Color.Fuchsia, 2, Height - 1);
                    DrawPixel(Color.Fuchsia, 3, Height - 1);
                    DrawPixel(Color.Fuchsia, 1, Height - 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), 2, Height - 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), 3, Height - 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), 1, Height - 3);
                    DrawPixel(Color.FromArgb(170, 170, 170), 1, Height - 4);
                    //////right bottom corner
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 2);
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 3);
                    DrawPixel(Color.Fuchsia, Width - 1, Height - 4);
                    DrawPixel(Color.Fuchsia, Width - 2, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 3, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 4, Height - 1);
                    DrawPixel(Color.Fuchsia, Width - 2, Height - 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 3, Height - 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 4, Height - 2);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 2, Height - 3);
                    DrawPixel(Color.FromArgb(170, 170, 170), Width - 2, Height - 4);
                    break;
            }



            //Draw title & icon
            G.DrawString(Parent.FindForm().Text, new Font("Segoe UI", 9), Brushes.Black, new Point(27, 5));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(7, 6, 16, 16));
        }


        #endregion
    }
}
