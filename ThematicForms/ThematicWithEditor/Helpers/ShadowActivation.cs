// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="ShadowActivation.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Zeroit.Framework.FormThemes.Native;
using static Zeroit.Framework.FormThemes.UIThemes.Shadow;

namespace Zeroit.Framework.FormThemes.UIThemes
{
    public partial class Thematic150WithEditor
    {


        private void OnParentLoad()
        {
            //if (!DesignMode)
            //    Parent.FindForm().Load += ParentForm_Load;

            
        }

        //private int shadowBlur = 10;
        //private int shadowSpread = -5;
        //private int shadowVertical = 0;
        //private int shadowHorizontal = 0;
        //private Color shadowColor = Color.Black;

        /// <summary>
        /// The activate shadow
        /// </summary>
        private bool activateShadow = false;

        /// <summary>
        /// Gets or sets a value indicating whether [activate shadow].
        /// </summary>
        /// <value><c>true</c> if [activate shadow]; otherwise, <c>false</c>.</value>
        public bool ActivateShadow
        {
            get { return formInput.ActivateShadow; }
            set
            {
                formInput.ActivateShadow = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the shadow blur.
        /// </summary>
        /// <value>The shadow blur.</value>
        [Category("Shadow Properties")]
        [Browsable(false)]
        public int ShadowBlur
        {
            get { return formInput.ShadowBlur; }
            set
            {
                formInput.ShadowBlur = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the shadow spread.
        /// </summary>
        /// <value>The shadow spread.</value>
        [Browsable(false)]
        [Category("Shadow Properties")]
        public int ShadowSpread
        {
            get { return formInput.ShadowSpread; }
            set
            {
                formInput.ShadowSpread = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the shadow vertical.
        /// </summary>
        /// <value>The shadow vertical.</value>
        [Browsable(false)]
        [Category("Shadow Properties")]
        public int ShadowVertical
        {
            get { return formInput.ShadowVertical; }
            set
            {
                formInput.ShadowVertical = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the shadow horizontal.
        /// </summary>
        /// <value>The shadow horizontal.</value>
        [Browsable(false)]
        [Category("Shadow Properties")]
        public int ShadowHorizontal
        {
            get { return formInput.ShadowHorizontal; }
            set
            {
                formInput.ShadowHorizontal = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the color of the shadow.
        /// </summary>
        /// <value>The color of the shadow.</value>
        [Browsable(false)]
        [Category("Shadow Properties")]
        public Color ShadowColor
        {
            get { return formInput.ShadowColor; }
            set
            {
                formInput.ShadowColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The shadows
        /// </summary>
        private Shadow shadows = new UIThemes.Shadow();
        /// <summary>
        /// Gets or sets the shadows.
        /// </summary>
        /// <value>The shadows.</value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Shadow Shadows
        {
            get { return shadows; }
            set
            {
                shadows = value;
                Invalidate();
            }
        }


        //ZeroitDropshadow AddShadow = null;
        public void Shadow(Control control)
        {
            //System.Windows.Forms.Form form = control as System.Windows.Forms.Form;


            
            #region New Shadow Code ( Improved Performance )

            if (!DesignMode)
            {
                //if (form.Location.IsEmpty)
                //{
                //    form.Location = new Point(this.Location.X - Shadows.BorderSize, this.Location.Y - Shadows.BorderSize);
                //    //form.CenterToScreen();
                //}

                //Check if we can use the aero shadow
                if ((Shadows.TypeOfShadow.Equals(ShadowType.AeroShadow) || Shadows.TypeOfShadow.Equals(ShadowType.Default)) &&
                    DwmNative.ExtendFrameIntoClientArea((System.Windows.Forms.Form)control, 0, 0, 0, 1))
                {
                    //We can! Tell windows to allow the rendering to happen on our borderless form
                    DwmNative.AllowRenderInBorderless((System.Windows.Forms.Form)control);
                }
                
                //else if (Shadows.TypeOfShadow.Equals(ShadowType.Default) || Shadows.TypeOfShadow.Equals(ShadowType.FlatShadow))
                //{
                //    //No aero for us! We must create the typical flat shadow.
                //    new ShadowForm()
                //    {
                //        ShadowColor = Shadows.ShadowColor,
                //        WindowOpacity = Shadows.WindowOpacity,
                //        BorderSize = Shadows.BorderSize
                //    }.Show(this);
                //}

                else if(Shadows.TypeOfShadow.Equals(ShadowType.SlowPerformer))
                {
                    
                    Helper.ZeroitDropshadow AddShadow = new Helper.ZeroitDropshadow((System.Windows.Forms.Form)control);
                    AddShadow.ShadowBlur = ShadowBlur;
                    AddShadow.ShadowSpread = ShadowSpread;
                    AddShadow.ShadowV = ShadowVertical;
                    AddShadow.ShadowH = ShadowHorizontal;
                    AddShadow.ShadowColor = ShadowColor;

                    AddShadow.ActivateShadow();

                    //if (ActivateShadow)
                    //{
                    //    AddShadow.ActivateShadow();
                    //}


                }

            }

            #endregion
        }



    }

    public class Shadow
    {
        public enum ShadowType
        {
            Default,
            AeroShadow,
            FlatShadow,
            SlowPerformer,
            None
        }

        private ShadowType typeOfShadow = ShadowType.Default;
        public ShadowType TypeOfShadow
        {
            get { return typeOfShadow; }
            set
            {
                if(value == ShadowType.SlowPerformer)
                {
                    MessageBox.Show("This has serious implication on performance. Use at your own risk");
                }

                typeOfShadow = value;
            }
        }

        /// <summary>
        /// Gets or sets the color of the shadow.
        /// </summary>
        /// <value>The color of the shadow.</value>
        [Browsable(true)]
        [Category("Shadow")]
        public Color ShadowColor
        {
            get;
            set;
        } = Color.Black;

        private float windowOpacity = 0.30F;
        /// <summary>
        /// Gets or sets the shadow opacity.
        /// </summary>
        /// <value>The shadow opacity.</value>        
        public float WindowOpacity
        {
            get { return windowOpacity; }
            set
            {
                if (value > 1)
                {
                    value = 1;
                }

                if (value < 0)
                {
                    value = 0;
                }

                windowOpacity = value;


            }
        }

        public int BorderSize { get; set; } = 5;

    }
}
