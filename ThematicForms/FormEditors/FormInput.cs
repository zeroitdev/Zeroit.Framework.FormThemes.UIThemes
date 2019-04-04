// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="FormInput.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Globalization;
using System.Reflection;

namespace Zeroit.Framework.FormThemes.UIThemes.ThematicForms.FormEditors
{
    /// <summary>
    /// Class FormInput.
    /// </summary>
    [TypeConverter(typeof(FormInput.FormConverter))]
    [Editor(typeof(FormInputEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [Serializable]
    public class FormInput
    {

        #region Private Fields


        /// <summary>
        /// The themes
        /// </summary>
        private themes _themes = themes.Mumtz;

        /// <summary>
        /// The custom theme
        /// </summary>
        private bool customTheme = true;

        /// <summary>
        /// The shadow blur
        /// </summary>
        private int shadowBlur = 10;
        /// <summary>
        /// The shadow spread
        /// </summary>
        private int shadowSpread = -5;
        /// <summary>
        /// The shadow vertical
        /// </summary>
        private int shadowVertical = 0;
        /// <summary>
        /// The shadow horizontal
        /// </summary>
        private int shadowHorizontal = 0;
        /// <summary>
        /// The shadow color
        /// </summary>
        private Color shadowColor = Color.Black;

        /// <summary>
        /// The activate shadow
        /// </summary>
        private bool activateShadow = false;

        #endregion

        #region Public Properties

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
            }
        }

        /// <summary>
        /// Gets or sets the theme.
        /// </summary>
        /// <value>The theme.</value>
        public themes Theme
        {
            get { return _themes; }
            set
            {
                _themes = value;

            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [activate shadow].
        /// </summary>
        /// <value><c>true</c> if [activate shadow]; otherwise, <c>false</c>.</value>
        public bool ActivateShadow
        {
            get { return activateShadow; }
            set
            {
                activateShadow = value;

            }
        }

        /// <summary>
        /// Gets or sets the shadow blur.
        /// </summary>
        /// <value>The shadow blur.</value>
        public int ShadowBlur
        {
            get { return shadowBlur; }
            set
            {
                shadowBlur = value;

            }
        }

        /// <summary>
        /// Gets or sets the shadow spread.
        /// </summary>
        /// <value>The shadow spread.</value>
        public int ShadowSpread
        {
            get { return shadowSpread; }
            set
            {
                shadowSpread = value;

            }
        }

        /// <summary>
        /// Gets or sets the shadow vertical.
        /// </summary>
        /// <value>The shadow vertical.</value>
        public int ShadowVertical
        {
            get { return shadowVertical; }
            set
            {
                shadowVertical = value;

            }
        }

        /// <summary>
        /// Gets or sets the shadow horizontal.
        /// </summary>
        /// <value>The shadow horizontal.</value>
        public int ShadowHorizontal
        {
            get { return shadowHorizontal; }
            set
            {
                shadowHorizontal = value;

            }
        }

        /// <summary>
        /// Gets or sets the color of the shadow.
        /// </summary>
        /// <value>The color of the shadow.</value>
        public Color ShadowColor
        {
            get { return shadowColor; }
            set
            {
                shadowColor = value;

            }
        }


        #endregion

        #region Constructor

        //Internal Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="FormInput"/> class.
        /// </summary>
        /// <param name="theme">The theme.</param>
        public FormInput(themes theme)
        {
            this._themes = theme;
        }

        /// <summary>
        /// Constructor for no input
        /// </summary>

        public FormInput() : this(themes.Spicylips)
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormInput"/> class.
        /// </summary>
        /// <param name="_themes">The themes.</param>
        /// <param name="customTheme">if set to <c>true</c> [custom theme].</param>
        /// <param name="activateShadow">if set to <c>true</c> [activate shadow].</param>
        /// <param name="shadowBlur">The shadow blur.</param>
        /// <param name="shadowSpread">The shadow spread.</param>
        /// <param name="shadowVertical">The shadow vertical.</param>
        /// <param name="shadowHorizontal">The shadow horizontal.</param>
        /// <param name="shadowColor">Color of the shadow.</param>
        public FormInput(
            themes _themes, 
            bool customTheme,
            bool activateShadow,
            int shadowBlur,
            int shadowSpread,
            int shadowVertical,
            int shadowHorizontal,
            Color shadowColor
            
            ) :this(themes.Resizable)
        {
            this._themes = _themes;
            this.customTheme = customTheme;
            this.activateShadow = activateShadow;
            this.shadowBlur = shadowBlur;
            this.shadowSpread = shadowSpread;
            this.shadowVertical = shadowVertical;
            this.shadowHorizontal = shadowHorizontal;
            this.shadowColor = shadowColor;
            
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>FormInput.</returns>
        public FormInput Clone()
        {
            return new FormInput
            (
                _themes
            );
        }

        /// <summary>
        /// Empties this instance.
        /// </summary>
        /// <returns>FormInput.</returns>
        public static FormInput Empty()
        {
            return new FormInput();
        }

        #endregion


        #region Converter

        /// <summary>
        /// Class FormConverter.
        /// </summary>
        /// <seealso cref="System.ComponentModel.TypeConverter" />
        internal class FormConverter : TypeConverter
        {

            /// <summary>
            /// Returns whether this converter can convert the object to the specified type, using the specified context.
            /// </summary>
            /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
            /// <param name="destinationType">A <see cref="T:System.Type" /> that represents the type you want to convert to.</param>
            /// <returns>true if this converter can perform the conversion; otherwise, false.</returns>
            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                if (destinationType == typeof(InstanceDescriptor)/* || destinationType == typeof(string)*/)
                {
                    return true;
                }
                return base.CanConvertTo(context, destinationType);
            }

            // This code allows the designer to generate the Shape constructor

            /// <summary>
            /// Converts the given value object to the specified type, using the specified context and culture information.
            /// </summary>
            /// <param name="context">An <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> that provides a format context.</param>
            /// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" />. If null is passed, the current culture is assumed.</param>
            /// <param name="value">The <see cref="T:System.Object" /> to convert.</param>
            /// <param name="destinationType">The <see cref="T:System.Type" /> to convert the <paramref name="value" /> parameter to.</param>
            /// <returns>An <see cref="T:System.Object" /> that represents the converted value.</returns>
            public override object ConvertTo(ITypeDescriptorContext context,
                CultureInfo culture,
                object value,
                Type destinationType)
            {
                
                    if (destinationType == typeof(string))
                    {
                        // Display string in designer
                        return "(FormInput)";
                    }
                    
                    else if (destinationType == typeof(InstanceDescriptor) && value is FormInput)
                    {
                        FormInput formInput = (FormInput)value;

                        if (formInput.CustomTheme == true)
                        {
                            ConstructorInfo ctor = typeof(FormInput).GetConstructor(new Type[]
                            {
                                
                                typeof(themes),
                                typeof(bool),
                                typeof(bool),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                typeof(int),
                                typeof(Color)



                            });
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, new object[] {
                                    
                                    formInput._themes,
                                    formInput.customTheme,
                                    formInput.activateShadow,
                                    formInput.shadowBlur,
                                    formInput.shadowSpread,
                                    formInput.shadowVertical,
                                    formInput.shadowHorizontal,
                                    formInput.shadowColor

                                });
                            }
                        }

                        
                        else
                        {
                            ConstructorInfo ctor = typeof(FormInput).GetConstructor(Type.EmptyTypes);
                            if (ctor != null)
                            {
                                return new InstanceDescriptor(ctor, null);
                            }
                        }
                    }
                
                return base.ConvertTo(context, culture, value, destinationType);
            }
        }

        #endregion

    }
}
