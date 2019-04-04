// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Skype.cs" company="Zeroit Dev Technologies">
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
        #region 115. Skype

        void Skype_PaintHook(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(148, 195, 255));
            G.DrawRectangle(new Pen(Color.FromArgb(105, 142, 191)), 0, 0, Width - 1, Height - 1);

            DrawGradient(Color.FromArgb(241, 247, 255), Color.FromArgb(148, 195, 255), 1, 1, Width - 2, 25);
            DrawGradient(Color.FromArgb(211, 230, 255), Color.FromArgb(148, 195, 255), 2, 2, Width - 4, 25);

            G.DrawString(Text, new Font("Arial", 10, FontStyle.Bold), new SolidBrush(Color.FromArgb(51, 51, 51)), 5, 3);
        }

        #endregion
    }
}
