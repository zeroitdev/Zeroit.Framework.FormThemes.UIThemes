// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-25-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 11-25-2018
// ***********************************************************************
// <copyright file="DwmNative.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Runtime.InteropServices;

namespace Zeroit.Framework.FormThemes.Native
{
    /// <summary>
    /// Class DwmNative.
    /// </summary>
    class DwmNative
    {

        /// <summary>
        /// DWMs the set window attribute.
        /// </summary>
        /// <param name="hwnd">The HWND.</param>
        /// <param name="attr">The attribute.</param>
        /// <param name="attrValue">The attribute value.</param>
        /// <param name="attrSize">Size of the attribute.</param>
        /// <returns>System.Int32.</returns>
        [DllImport("dwmapi.dll", PreserveSig = true)]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, DWMWINDOWATTRIBUTE attr, ref int attrValue, int attrSize);

        /// <summary>
        /// Enum DWMWINDOWATTRIBUTE
        /// </summary>
        private enum DWMWINDOWATTRIBUTE : uint
        {
            /// <summary>
            /// The nc rendering enabled
            /// </summary>
            NCRenderingEnabled = 1,
            /// <summary>
            /// The nc rendering policy
            /// </summary>
            NCRenderingPolicy,
            /// <summary>
            /// The transitions force disabled
            /// </summary>
            TransitionsForceDisabled,
            /// <summary>
            /// The allow nc paint
            /// </summary>
            AllowNCPaint,
            /// <summary>
            /// The caption button bounds
            /// </summary>
            CaptionButtonBounds,
            /// <summary>
            /// The non client RTL layout
            /// </summary>
            NonClientRtlLayout,
            /// <summary>
            /// The force iconic representation
            /// </summary>
            ForceIconicRepresentation,
            /// <summary>
            /// The flip3 d policy
            /// </summary>
            Flip3DPolicy,
            /// <summary>
            /// The extended frame bounds
            /// </summary>
            ExtendedFrameBounds,
            /// <summary>
            /// The has iconic bitmap
            /// </summary>
            HasIconicBitmap,
            /// <summary>
            /// The disallow peek
            /// </summary>
            DisallowPeek,
            /// <summary>
            /// The excluded from peek
            /// </summary>
            ExcludedFromPeek,
            /// <summary>
            /// The cloak
            /// </summary>
            Cloak,
            /// <summary>
            /// The cloaked
            /// </summary>
            Cloaked,
            /// <summary>
            /// The freeze representation
            /// </summary>
            FreezeRepresentation
        }

        /// <summary>
        /// Allows the render in borderless.
        /// </summary>
        /// <param name="f">The f.</param>
        public static void AllowRenderInBorderless(System.Windows.Forms.Form f)
        {
            int val = 2;
            DwmSetWindowAttribute(f.Handle, DWMWINDOWATTRIBUTE.NCRenderingPolicy, ref val, 4);
        }


        /// <summary>
        /// DWMs the extend frame into client area.
        /// </summary>
        /// <param name="hwnd">The HWND.</param>
        /// <param name="margins">The margins.</param>
        /// <returns>System.Int32.</returns>
        [DllImport("dwmapi.dll", PreserveSig = true)]
        static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS margins);

        /// <summary>
        /// Struct MARGINS
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        private struct MARGINS
        {
            /// <summary>
            /// The left width
            /// </summary>
            public int leftWidth;
            /// <summary>
            /// The right width
            /// </summary>
            public int rightWidth;
            /// <summary>
            /// The top height
            /// </summary>
            public int topHeight;
            /// <summary>
            /// The bottom height
            /// </summary>
            public int bottomHeight;

            /// <summary>
            /// Initializes a new instance of the <see cref="MARGINS"/> struct.
            /// </summary>
            /// <param name="leftWidth">Width of the left.</param>
            /// <param name="rightWidth">Width of the right.</param>
            /// <param name="topHeight">Height of the top.</param>
            /// <param name="bottomHeight">Height of the bottom.</param>
            public MARGINS(int leftWidth, int rightWidth, int topHeight, int bottomHeight)
            {
                this.leftWidth = leftWidth;
                this.rightWidth = rightWidth;
                this.topHeight = topHeight;
                this.bottomHeight = bottomHeight;
            }
        }

        /// <summary>
        /// DWMs the is composition enabled.
        /// </summary>
        /// <param name="enabled">if set to <c>true</c> [enabled].</param>
        /// <returns>System.Int32.</returns>
        [DllImport("dwmapi.dll")]
        private static extern int DwmIsCompositionEnabled(out bool enabled);

        /// <summary>
        /// Determines whether [is composition enabled].
        /// </summary>
        /// <returns><c>true</c> if [is composition enabled]; otherwise, <c>false</c>.</returns>
        public static bool IsCompositionEnabled()
        {
            if (Environment.OSVersion.Version.Major < 6) return false;
            bool enabled;
            DwmIsCompositionEnabled(out enabled);
            return enabled;
        }

        /// <summary>
        /// Extends the frame into client area.
        /// </summary>
        /// <param name="f">The f.</param>
        /// <param name="left">The left.</param>
        /// <param name="top">The top.</param>
        /// <param name="right">The right.</param>
        /// <param name="bottom">The bottom.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool ExtendFrameIntoClientArea(System.Windows.Forms.Form f, int left, int top, int right, int bottom)
        {
            if (IsCompositionEnabled()) {
                MARGINS margins = new MARGINS(left, right, top, bottom);
                DwmExtendFrameIntoClientArea(f.Handle, ref margins);
                return true;
            }
            return false;
        }

    }
}
