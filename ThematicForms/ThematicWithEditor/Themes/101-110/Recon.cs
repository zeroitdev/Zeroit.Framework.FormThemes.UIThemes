// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Recon.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 103. Recon

        void Recon_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(41, 41, 41));
            DrawGradient(Color.FromArgb(11, 11, 11), Color.FromArgb(26, 26, 26), 1, 1, ClientRectangle.Width, ClientRectangle.Height, 270);
            DrawBorders(Pens.Black, new Pen(Color.FromArgb(52, 52, 52)), ClientRectangle);
            DrawGradient(Color.FromArgb(42, 42, 42), Color.FromArgb(40, 40, 40), 5, 30, Width - 10, Height - 35, 90);
            G.DrawRectangle(new Pen(Color.FromArgb(18, 18, 18)), 5, 30, Width - 10, Height - 35);

            //Icon

            switch (_TextAlignment)
            {
                case TextAlign.Left:
                    break;
                case TextAlign.Center:
                    break;
                case TextAlign.Right:
                    break;
                default:
                    break;
            }

            if (_ShowIcon == false)
            {
                switch (_TextAlignment)
                {
                    case TextAlign.Left:
                        DrawText(HorizontalAlignment.Left, this.ForeColor, 6);
                        break;
                    case TextAlign.Center:
                        DrawText(HorizontalAlignment.Center, this.ForeColor, 0);
                        break;
                    case TextAlign.Right:
                        MessageBox.Show("Invalid Alignment, will not show text.");
                        break;
                }

            }
            else
            {
                switch (_TextAlignment)
                {
                    case TextAlign.Left:
                        DrawText(HorizontalAlignment.Left, this.ForeColor, 35);
                        break;
                    case TextAlign.Center:
                        DrawText(HorizontalAlignment.Center, this.ForeColor, 0);
                        break;
                    case TextAlign.Right:
                        MessageBox.Show("Invalid Alignment, will not show text.");
                        break;
                }
                G.DrawIcon(this.ParentForm.Icon, new Rectangle(new Point(6, 2), new Size(29, 29)));
            }

            DrawCorners(Color.Fuchsia, ClientRectangle);
        }

        #endregion
    }
}
