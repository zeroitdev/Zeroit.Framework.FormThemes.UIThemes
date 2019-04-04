// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Avatar.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {
        #region 8. Avatar

        void Avatar_PaintHook(PaintEventArgs e)
        {
            LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(255, 32, 32, 32), Color.FromArgb(255, 10, 10, 10), 90f);
            G.DrawRectangle(new Pen(Border), new Rectangle(0, 0, Width, Height));
            G.FillRectangle(LGB1, new Rectangle(0, 0, Width, Height));
            G.DrawString(Parent.FindForm().Text, Font, new SolidBrush(ForeColor), new Point(25, 5));
            G.DrawIcon(Parent.FindForm().Icon, new Rectangle(7, 6, 16, 16));
            //Dim HB As New HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(175, Color.DarkBlue), Color.FromArgb(255, 21, 21, 21))
            LinearGradientBrush LGB2 = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(125, Color.DeepSkyBlue), Color.FromArgb(175, 25, 25, 112), 85f);
            G.FillRectangle(LGB2, new Rectangle(6, 25, Width - 11, Height - 30));
            DrawCorners(Color.Fuchsia);


        }

        #endregion
    }
}
