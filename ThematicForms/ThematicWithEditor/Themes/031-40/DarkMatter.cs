// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="DarkMatter.cs" company="Zeroit Dev Technologies">
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
        #region 31. Dark Matter
        public enum ColorTheme
        {
            GammaRay = 0,
            RedShift = 1,
            Subspace = 2,
            SolarFlare = 3
        }
        private ColorTheme _ThemeColor;

        HatchBrush T = new HatchBrush(HatchStyle.LightUpwardDiagonal, Color.Black, Color.FromArgb(39, 39, 41));
        Color tGlow;
        Color tColor;

        [Category("Dark Matter Theme")]
        public ColorTheme ThemeStyle
        {
            get { return _ThemeColor; }
            set
            {
                _ThemeColor = value;
                Invalidate();
            }
        }

        void DarkMatter_PaintHook(PaintEventArgs e)
        {
            G.SmoothingMode = SmoothingMode.HighQuality;

            switch (_ThemeColor)
            {
                case ColorTheme.GammaRay:
                    //GammaRay
                    tGlow = Color.FromArgb(35, Color.LawnGreen);
                    tColor = Color.FromArgb(255, Color.LawnGreen);
                    break;
                case ColorTheme.RedShift:
                    //RedShift
                    tGlow = Color.FromArgb(35, Color.Red);
                    tColor = Color.FromArgb(255, Color.Red);
                    break;
                case ColorTheme.Subspace:
                    //SubSpace
                    tGlow = Color.FromArgb(35, Color.DodgerBlue);
                    tColor = Color.FromArgb(255, Color.DodgerBlue);
                    break;
                case ColorTheme.SolarFlare:
                    //SolarFlare
                    tGlow = Color.FromArgb(35, Color.Gold);
                    tColor = Color.FromArgb(255, Color.Gold);
                    break;
            }

            G.Clear(Color.FromArgb(39, 41, 41));
            DrawGradient(Color.FromArgb(109, 109, 111), Color.FromArgb(26, 26, 29), ClientRectangle, 45);
            //Border Out
            DrawGradient(Color.FromArgb(58, 58, 60), Color.FromArgb(14, 14, 14), new Rectangle(2, 2, Width - 4, Height - 4), 45);

            DrawBorders(new Pen(new SolidBrush(Color.Black)));

            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 4, 0);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 4, 1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 4, -1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 6, 0);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 6, 1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 6, -1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 5, 1);
            DrawText(new SolidBrush(tGlow), HorizontalAlignment.Left, 5, -1);

            DrawText(new SolidBrush(tColor), HorizontalAlignment.Left, 5, 0);
            DrawCorners(Color.Cyan);
        }

        #endregion
    }
}
