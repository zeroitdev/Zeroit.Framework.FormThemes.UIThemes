// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Loyal.cs" company="Zeroit Dev Technologies">
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
        #region 79. Loyal
        private TextAlign _TextAlignment = TextAlign.Center;
        private int _HeaderSize = 30;

        void Loyal_PaintHook(PaintEventArgs e)
        {

            var _with1 = G;
            StringFormat _StringF = new StringFormat { LineAlignment = StringAlignment.Center };
            _with1.Clear(Color.FromArgb(31, 31, 31));
            _with1.FillRectangle(new SolidBrush(Color.Aqua), new Rectangle(0, 0, Width, 5));
            _with1.FillRectangle(new SolidBrush(Color.FromArgb(34, 34, 34)), new Rectangle(0, 5, Width, _HeaderSize));
            _with1.DrawLine(new Pen(Color.FromArgb(38, 38, 38)), new Point(0, _HeaderSize + 5), new Point(Width, _HeaderSize + 5));
            _with1.DrawLine(new Pen(Color.FromArgb(24, 24, 24)), new Point(0, _HeaderSize + 6), new Point(Width, _HeaderSize + 6));
            _with1.DrawLine(Pens.Fuchsia, new Point(0, 0), new Point(0, 2));
            _with1.DrawLine(Pens.Fuchsia, new Point(0, 0), new Point(2, 0));
            _with1.DrawLine(Pens.Fuchsia, new Point(Width - 1, 0), new Point(Width - 1, 2));
            _with1.DrawLine(Pens.Fuchsia, new Point(Width - 1, 0), new Point(Width - 3, 0));


            switch (_TextAlignment)
            {
                case TextAlign.Center:
                    _StringF.Alignment = StringAlignment.Center;
                    _with1.DrawString(Text, new Font("Arial", 9), Brushes.White, new RectangleF(0, 5, Width, _HeaderSize), _StringF);

                    break;
                case TextAlign.Left:
                    _with1.DrawString(Text, new Font("Arial", 9), Brushes.White, new RectangleF(10, 5, Width, _HeaderSize), _StringF);

                    break;
                case TextAlign.Right:
                    int _TextLength = TextRenderer.MeasureText(Text, new Font("Arial", 9)).Width + 10;
                    _with1.DrawString(Text, new Font("Arial", 9), Brushes.White, new RectangleF(Width - _TextLength, 5, Width, _HeaderSize), _StringF);
                    break;
            }
        }

        #endregion
    }
}
