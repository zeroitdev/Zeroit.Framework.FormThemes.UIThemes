// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Mumtz.cs" company="Zeroit Dev Technologies">
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
        #region 86. Mumtz

        void Mumtz_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.MediumTurquoise);
            G.FillRectangle(new SolidBrush(Color.White), new Rectangle(6, 36, Width - 13, Height - 43));
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(30, 9));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(6, 10, 16, 16));
            DrawCorners(Color.Fuchsia);
        }

        #endregion
    }
}
