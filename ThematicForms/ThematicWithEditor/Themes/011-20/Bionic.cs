// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Bionic.cs" company="Zeroit Dev Technologies">
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
        #region 13. Bionic

        #region " Declarations "
        private bool _Down = false;
        private int _Header = 34;
        #endregion
        private Point _MousePoint;

        #region " MouseStates "
        void Bionic_OnMouseUp(MouseEventArgs e)
        {
            //base.OnMouseUp(e);
            _Down = false;
        }
        // Get more free themes at ThemesVB.NET
        void Bionic_OnMouseDown(MouseEventArgs e)
        {
            //base.OnMouseDown(e);
            if (e.Location.Y < _Header && e.Button == MouseButtons.Left)
            {
                _Down = true;
                _MousePoint = e.Location;
            }
        }

        void Bionic_OnMouseMove(MouseEventArgs e)
        {
            //base.OnMouseMove(e);
            if (_Down == true)
            {
                ParentForm.Location = new Point(MousePosition.X - _MousePoint.X, MousePosition.Y - _MousePoint.Y);
            }
        }
        #endregion

        void Bionic_OnPaint(PaintEventArgs e)
        {
            Graphics G = e.Graphics;
            G.Clear(Color.FromArgb(29, 29, 29));
            G.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), new Rectangle(2, 2, Width - 4, 15));
            G.FillRectangle(new SolidBrush(Color.FromArgb(48, 48, 48)), new Rectangle(2, 32, Width - 4, Height - 34));
            StringFormat _StringF = new StringFormat();
            _StringF.Alignment = StringAlignment.Center;
            _StringF.LineAlignment = StringAlignment.Center;
            G.DrawString(Parent.FindForm().Text, new Font("Arial", 11), Brushes.White, new RectangleF(2, 2, Width - 4, 30), _StringF);
        }

        #endregion
    }
}
