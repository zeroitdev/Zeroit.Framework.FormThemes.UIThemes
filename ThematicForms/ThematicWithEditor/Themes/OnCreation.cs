// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="OnCreation.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Zeroit.Framework.FormThemes.UIThemes
{
    /// <summary>
    /// Class Thematic150WithEditor.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.FormThemes.UIThemes.ThemeContainer154" />
    public partial class Thematic150WithEditor
    {

        /// <summary>
        /// Called when [creation].
        /// </summary>
        protected override void OnCreation()
        {
            switch (Theme)
            {
                case themes.BasicCode:
                    if (!DesignMode)
                    {
                        System.Threading.Thread G = new System.Threading.Thread(MoveGlow);
                        System.Threading.Thread T = new System.Threading.Thread(MoveText);
                        G.IsBackground = true;
                        T.IsBackground = true;
                        G.Start();
                        T.Start();
                    }
                    break;

                //case themes.BlueAndWhite:
                //    //BaWGUI_OnSizeChanged();
                //break;
            }

        }

    }
}
