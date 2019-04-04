// ***********************************************************************
// Assembly         : Zeroit.Framework.FormThemes.UIThemes
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-16-2018
// ***********************************************************************
// <copyright file="FormEditorsDialog.cs" company="Zeroit Dev Technologies">
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
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.FormThemes.UIThemes.ThematicForms.FormEditors
{
    /// <summary>
    /// Class FormEditorsDialog.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FormEditorsDialog : System.Windows.Forms.Form
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// at the default window position.
        /// </summary>
        public FormEditorsDialog() : this(FormInput.Empty())
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public FormEditorsDialog(Control c) : this(FormInput.Empty(), c)
        {
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// and positioned beneath the specified control.
        /// </summary>
        /// <param name="formInput">The form input.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="filler" /> is null.</exception>
        public FormEditorsDialog(FormInput formInput, Control c) : this(formInput)
        {
            Zeroit.Framework.FormThemes.UIThemes.ThematicForms.FormEditors.Utilities.Draw.SetStartPositionBelowControl(this, c);
        }

        /// <summary>
        /// Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// at the default window position.
        /// </summary>
        /// <param name="formInput">The form input.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="peaceInput" /> is null.</exception>
        public FormEditorsDialog(FormInput formInput)
        {
            if (formInput == null)
            {
                throw new ArgumentNullException("formInput");
            }


            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.SupportsTransparentBackColor, true);

            Set_Initial_Values(formInput);

            //AdjustDialogSize();
            //SetInitial_Values(pizaroAnimatorInput);

        }


        #endregion

        #region Public Properties

        /// <summary>
        /// The form input
        /// </summary>
        private FormInput formInput;

        /// <summary>
        /// Gets the form input.
        /// </summary>
        /// <value>The form input.</value>
        public FormInput FormInput
        {
            get { return formInput; }
        }


        #endregion


        #region Private Events

        /// <summary>
        /// Sets the initial values.
        /// </summary>
        /// <param name="formInput">The form input.</param>
        private void Set_Initial_Values(FormInput formInput)
        {


            #region Add Enum to ComboBox
            // get a list of member names from EasingFunctionTypes enum,
            // figure out the numeric value, and display
            foreach (string volume in Enum.GetNames(typeof(themes)))
            {
                main_formType_ComboBox.Items.Add(volume);

            }

            for (int i = 0; i < main_formType_ComboBox.Items.Count; i++)
            {
                if (formInput.Theme == (themes)Enum.Parse(typeof(themes), main_formType_ComboBox.Items[i].ToString()))
                {
                    main_formType_ComboBox.SelectedIndex = i;

                }

            }
            #endregion

            if (formInput.CustomTheme == true)
            {
                main_Custom_Yes_RadioBtn.Checked = true;
                main_Custom_No_RadioBtn.Checked = false;

            }
            else
            {
                main_Custom_Yes_RadioBtn.Checked = false;
                main_Custom_No_RadioBtn.Checked = true;
            }

            if (formInput.ActivateShadow)
            {

                Helper.ZeroitDropshadow AddShadow = new Helper.ZeroitDropshadow(this);
                AddShadow.ShadowBlur = formInput.ShadowBlur;
                AddShadow.ShadowSpread = formInput.ShadowSpread;
                AddShadow.ShadowV = formInput.ShadowVertical;
                AddShadow.ShadowH = formInput.ShadowHorizontal;
                AddShadow.ShadowColor = formInput.ShadowColor;
                AddShadow.ActivateShadow();

                main_Shadow_Yes_RadioBtn.Checked = true;

                
            }

            blur_Numeric.Value = formInput.ShadowBlur;
            spread_Numeric.Value = formInput.ShadowSpread;
            vertical_Numeric.Value = formInput.ShadowVertical;
            horizontal_Numeric.Value = formInput.ShadowHorizontal;
            colorSelector_Btn.BackColor = formInput.ShadowColor;

        }

        /// <summary>
        /// Sets the retrieved values.
        /// </summary>
        /// <param name="formInput">The form input.</param>
        private void Set_Retrieved_Values(FormInput formInput)
        {
            formInput.Theme = 
                (themes)Enum.Parse(
                typeof(themes),
                main_formType_ComboBox.SelectedItem.ToString());

            formInput.ShadowBlur = (int)blur_Numeric.Value;
            formInput.ShadowSpread = (int)spread_Numeric.Value;
            formInput.ShadowVertical = (int)vertical_Numeric.Value;
            formInput.ShadowHorizontal = (int)horizontal_Numeric.Value;
            formInput.ShadowColor = colorSelector_Btn.BackColor;

            if (main_Shadow_Yes_RadioBtn.Checked)
            {
                formInput.ActivateShadow = true;
            }

            else
            {
                formInput.ActivateShadow = false;
            }


        }

        /// <summary>
        /// Forms the changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FormChanged(object sender, EventArgs e)
        {
            if (main_formType_ComboBox.SelectedIndex == (int) themes.Advanced_System)
            {
                formPreviewer.Theme = themes.Spicylips;
                MessageBox.Show("Please this cannot be shown in the editor. Manually select it in the main form.",
                    "Theme cannot be viewed", MessageBoxButtons.OK);

            }
            else
            {
                formPreviewer.Theme = (themes)main_formType_ComboBox.SelectedIndex;

            }

        }



        #endregion

        /// <summary>
        /// Handles the Click event of the shadowColor_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void shadowColor_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                shadowColor_Btn.BackColor = colorSelector.Color;
            }
        }

        /// <summary>
        /// Handles the Click event of the okBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (main_Custom_Yes_RadioBtn.Checked)
            {
                formInput = new FormInput(themes.Spicylips, true,false, 10, -5, 0, 0, Color.Black);

                Set_Retrieved_Values(formInput);
            }
            else
            {
                formInput = new FormInput(themes.Spicylips, true, false, 10, -5, 0, 0, Color.Black);

                Set_Retrieved_Values(formInput);
            }

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of the cancelBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Handles the Click event of the closeBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the CheckedChanged event of the main_Shadow_Yes_RadioBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void main_Shadow_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (main_Shadow_Yes_RadioBtn.Checked)
            {
                shadow_GroupBox.Visible = true;
            }
        }

        /// <summary>
        /// Handles the Click event of the colorSelector_Btn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void colorSelector_Btn_Click(object sender, EventArgs e)
        {
            if (colorSelector.ShowDialog() == DialogResult.OK)
            {
                colorSelector_Btn.BackColor = colorSelector.Color;
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the main_Shadow_No_RadioBtn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void main_Shadow_No_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (main_Shadow_No_RadioBtn.Checked)
            {
                shadow_GroupBox.Visible = false;
            }
            else
            {
                shadow_GroupBox.Visible = true;
            }
        }
    }
}
