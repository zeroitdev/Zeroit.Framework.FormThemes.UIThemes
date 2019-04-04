// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Login.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
        #region 78. Login

        private __CloseChoice _CloseChoice = __CloseChoice.Form;
        public __CloseChoice CloseChoice
        {
            get { return _CloseChoice; }
            set { _CloseChoice = value; }
        }


        void Login_PaintHook(PaintEventArgs e)
        {

            var _with2 = G;
            _with2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with2.SmoothingMode = SmoothingMode.HighQuality;
            _with2.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with2.FillRectangle(new SolidBrush(Color.FromArgb(35, 35, 35)), new Rectangle(0, 0, Width, Height));
            _with2.FillRectangle(new SolidBrush(Color.FromArgb(54, 54, 54)), new Rectangle(2, 35, Width - 4, Height - 37));
            _with2.DrawRectangle(new Pen(Color.FromArgb(35, 35, 35)), new Rectangle(0, 0, Width, Height));
            Point[] ControlBoxPoints = {
                new Point(Width - 90, 0),
                new Point(Width - 90, 22),
                new Point(Width - 15, 22),
                new Point(Width - 15, 0)
            };
            _with2.DrawLines(new Pen(Color.FromArgb(35, 35, 35)), ControlBoxPoints);
            _with2.DrawLine(new Pen(Color.FromArgb(35, 35, 35)), Width - 65, 0, Width - 65, 22);
            GetMouseLocation = PointToClient(MousePosition);
            switch (State)
            {
                case MouseState.Over:
                    if (GetMouseLocation.X > Width - 39 && GetMouseLocation.X < Width - 16 && GetMouseLocation.Y < 22)
                    {
                        _with2.FillRectangle(new SolidBrush(Color.FromArgb(42, 42, 42)), new Rectangle(Width - 39, 0, 23, 22));
                    }
                    else if (GetMouseLocation.X > Width - 64 && GetMouseLocation.X < Width - 41 && GetMouseLocation.Y < 22)
                    {
                        _with2.FillRectangle(new SolidBrush(Color.FromArgb(42, 42, 42)), new Rectangle(Width - 64, 0, 23, 22));
                    }
                    else if (GetMouseLocation.X > Width - 89 && GetMouseLocation.X < Width - 66 && GetMouseLocation.Y < 22)
                    {
                        _with2.FillRectangle(new SolidBrush(Color.FromArgb(42, 42, 42)), new Rectangle(Width - 89, 0, 23, 22));
                    }
                    break;
            }


            //_with2.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), Width - 40, 0, Width - 40, 22);

            //'Close Button
            //_with2.DrawLine(new Pen(Color.FromArgb(255, 255, 255), 2), Width - 33, 6, Width - 22, 16);
            //_with2.DrawLine(new Pen(Color.FromArgb(255, 255, 255), 2), Width - 33, 16, Width - 22, 6);

            //'Minimize Button

            //_with2.DrawLine(new Pen(Color.FromArgb(255, 255, 255)), Width - 83, 16, Width - 72, 16);

            //'Maximize Button

            //_with2.DrawLine(new Pen(Color.FromArgb(255, 255, 255)), Width - 58, 16, Width - 47, 16);
            //_with2.DrawLine(new Pen(Color.FromArgb(255, 255, 255)), Width - 58, 16, Width - 58, 6);
            //_with2.DrawLine(new Pen(Color.FromArgb(255, 255, 255)), Width - 47, 16, Width - 47, 6);
            //_with2.DrawLine(new Pen(Color.FromArgb(255, 255, 255)), Width - 58, 6, Width - 47, 6);
            //_with2.DrawLine(new Pen(Color.FromArgb(255, 255, 255)), Width - 58, 7, Width - 47, 7);

            if (_ShowIcon)
            {
                _with2.DrawIcon(Parent.FindForm().Icon, new Rectangle(6, 6, 22, 22));
                _with2.DrawString(Text, Font, new SolidBrush(Color.FromArgb(255, 255, 255)), new RectangleF(31, 0, Width - 110, 35), new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Near
                });
            }
            else
            {
                _with2.DrawString(Text, Font, new SolidBrush(Color.FromArgb(255, 255, 255)), new RectangleF(4, 0, Width - 110, 35), new StringFormat
                {
                    LineAlignment = StringAlignment.Center,
                    Alignment = StringAlignment.Near
                });
            }
            _with2.InterpolationMode = (InterpolationMode)7;
        }


        #endregion
    }
}
