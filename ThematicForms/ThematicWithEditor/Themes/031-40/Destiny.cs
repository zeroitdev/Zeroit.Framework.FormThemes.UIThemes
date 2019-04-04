// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Destiny.cs" company="Zeroit Dev Technologies">
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
        #region 34. Destiny

        void Destiny_PaintHook(PaintEventArgs e)
        {
            G.Clear(BackColor);

            DrawGradient(Color.Teal, Color.Black, 0, 0, Width, 20, 90);
            G.DrawLine(Pens.Teal, 0, 20, Width, 20);

            DrawBorders(Pens.Black, Pens.Teal, ClientRectangle);
            DrawCorners(Color.Fuchsia, ClientRectangle);
            G.DrawString(Text, new Font("Arial", 8, FontStyle.Bold), new SolidBrush(ForeColor), 25, 5);

        }

        #endregion
    }
}
