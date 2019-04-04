// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Recon.cs" company="Zeroit Dev Technologies">
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
