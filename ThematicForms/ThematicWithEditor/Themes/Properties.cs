// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="Properties.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Form control with themes.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using Zeroit.Framework.FormThemes.UIThemes.ThematicForms.FormEditors;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    /// <summary>
    /// Class Thematic150WithEditor.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.UIThemes.ThemeContainer154" />
    public partial class Thematic150WithEditor
    {

        #region Private Fields

        //private themes _themes = themes.Mumtz;
        //private LockSize locksize = new LockSize();

        /// <summary>
        /// The icon
        /// </summary>
        private Icon icon;
        /// <summary>
        /// The border
        /// </summary>
        private Color border;
        /// <summary>
        /// The show icon
        /// </summary>
        private bool showIcon = false;
        /// <summary>
        /// The lock dimension
        /// </summary>
        private bool lockDimension = false;


        /// <summary>
        /// The custom theme
        /// </summary>
        private bool customTheme = true;

        /// <summary>
        /// The form input
        /// </summary>
        private FormInput formInput = new FormInput(themes.Spicylips, true, false, 10, -5, 0, 0, Color.Black);
        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the form input.
        /// </summary>
        /// <value>The form input.</value>
        public FormInput FormInput
        {
            get { return formInput; }
            set
            {
                formInput = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [custom theme].
        /// </summary>
        /// <value><c>true</c> if [custom theme]; otherwise, <c>false</c>.</value>
        public bool CustomTheme
        {
            get { return customTheme; }
            set
            {
                customTheme = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [lock dimension].
        /// </summary>
        /// <value><c>true</c> if [lock dimension]; otherwise, <c>false</c>.</value>
        public bool LockDimension
        {
            get { return lockDimension; }
            set
            {
                lockDimension = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the text associated with this control.
        /// </summary>
        /// <value>The text.</value>
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        /// <value>The icon.</value>
        public Icon Icon
        {
            get { return icon; }
            set
            {
                icon = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show icon].
        /// </summary>
        /// <value><c>true</c> if [show icon]; otherwise, <c>false</c>.</value>
        public bool ShowIcon
        {
            get { return showIcon; }
            set
            {
                showIcon = value;
                Invalidate();
            }
        }


        //public LockSize LockSize
        //{
        //    get { return locksize; }
        //    set
        //    {
        //        locksize = value;
        //        Invalidate();
        //    }
        //}

        /// <summary>
        /// Gets or sets the theme.
        /// </summary>
        /// <value>The theme.</value>
        public themes Theme
        {
            get { return formInput.Theme; }
            set
            {
                formInput.Theme = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the border.
        /// </summary>
        /// <value>The border.</value>
        public Color Border
        {
            get { return border; }
            set
            {
                border = value;
                Invalidate();
            }
        }

        #endregion

    }
}
