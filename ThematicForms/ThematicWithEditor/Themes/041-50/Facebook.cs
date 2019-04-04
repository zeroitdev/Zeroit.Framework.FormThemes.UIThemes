// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Facebook.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 50. Facebook

        private Color _MainColour = Color.FromArgb(252, 252, 252);
        private Color _HeaderColour = Color.FromArgb(67, 96, 156);

        private SolidBrush _MainBrushColour;
        private SolidBrush _HeaderBrushColour;
        private Font Facebook_F = new Font("Tahoma", 13, FontStyle.Bold);


        void Facebook_Paint(PaintEventArgs e)
        {
            _MainBrushColour = new SolidBrush(_MainColour);
            _HeaderBrushColour = new SolidBrush(_HeaderColour);
            _BorderColour = Color.DarkGray;
            MoveHeight = 45;

            Graphics G = default(Graphics);
            G = e.Graphics;
            G.SmoothingMode = SmoothingMode.HighQuality;

            G.Clear(_MainColour);

            G.FillRectangle(_HeaderBrushColour, new Rectangle(-1, -1, this.Width + 1, 45));
            G.DrawLine(new Pen(new SolidBrush(_BorderColour)), new Point(-1, 45), new Point(this.Width - 1, 45));
            G.DrawRectangle(new Pen(new SolidBrush(_BorderColour)), new Rectangle(0, 0, Width - 1, Height - 1));
            Bitmap I = this.ParentForm.Icon.ToBitmap();
            Image IM = I;
            string FormText = this.ParentForm.Text;
            G.TextRenderingHint = TextRenderingHint.AntiAlias;
            G.DrawString(FormText, Facebook_F, new SolidBrush(Color.FromArgb(220, 220, 220)), new Point(43, 11));
            G.DrawImage(IM, new Rectangle(8, 6, 32, 32));

            I.Dispose();
            IM.Dispose();
        }


        #endregion
    }
}
