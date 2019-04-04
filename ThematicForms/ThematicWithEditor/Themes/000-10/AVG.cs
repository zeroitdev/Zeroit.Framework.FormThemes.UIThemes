// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="AVG.cs" company="Zeroit Dev Technologies">
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
        #region 9. AVG

        void AVG_PaintHook(PaintEventArgs e)
        {
            G.Clear(Border);
            G.FillRectangle(new SolidBrush(Color.FromArgb(39, 43, 57)), new Rectangle(1, 1, Width - 2, Height - 2));
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(40, 20));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(9, 18, 25, 25));
        }

        #endregion
    }
}
