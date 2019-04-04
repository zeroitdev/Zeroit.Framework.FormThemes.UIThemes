// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="ThematicVB.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Zeroit.Framework.FormThemes.UIThemes;

namespace Zeroit.Framework.Form.UIThemes
{
    /// <summary>
    /// Class ThematicVB.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.UIThemes.Theme" />
    [ToolboxItem(false)]
    public class ThematicVB : Theme
    {

        #region Private Fields

        /// <summary>
        /// Enum themes
        /// </summary>
        public enum themes 
        {
            /// <summary>
            /// The beta blue
            /// </summary>
            BetaBlue
        }

        /// <summary>
        /// The themes
        /// </summary>
        private themes _themes = themes.BetaBlue;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the themes.
        /// </summary>
        /// <value>The themes.</value>
        public themes Themes
        {
            get { return _themes; }
            set
            {
                _themes = value;
                Invalidate();
            }
        }

        #endregion

        /// <summary>
        /// Paints the hook.
        /// </summary>
        public override void PaintHook()
        {
            switch (_themes)
            {
                case themes.BetaBlue:
                    G.Clear(Color.FromKnownColor(KnownColor.Control));
                    // Clear the form first
                    //DrawGradient(Color.FromArgb(0, 105, 246), Color.FromArgb(0, 81, 181), 0, 0, Width, Height, 90S)   ' Form Gradient
                    G.Clear(Color.FromArgb(0, 95, 218));
                    DrawGradient(Color.FromArgb(0, 95, 218), Color.FromArgb(0, 55, 202), 0, 0, Width, 25, 90);
                    // Form Top Bar

                    DrawCorners(Color.Fuchsia, ClientRectangle);
                    // Then draw some clean corners
                    DrawBorders(Pens.DarkBlue, Pens.DodgerBlue, ClientRectangle);
                    // Then we draw our form borders

                    G.DrawLine(Pens.Black, 0, 25, Width, 25);
                    // Top Line
                    //G.DrawLine(Pens.Black, 0, Height - 25, Width, Height - 25)   ' Bottom Line

                    DrawText(HorizontalAlignment.Left, Color.White, 8, 2);
                    // Finally, we draw our text
                    break;
            }
            
        }
    }
}
