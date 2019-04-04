using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeroit.Framework.FormEditors.UIThemes.ControlEditor
{
    
    public partial class ShapeDialog : System.Windows.Forms.Form
    {

        
        

        #region Constructor


        /// <summary>
        ///		Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        /// 	at the default window position.
        /// </summary>
        public ShapeDialog() : this(ShapePopulate.Empty())
        {
        }

        /// <summary>
        /// 	Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        /// 	at the default window position.
        /// </summary>
        /// <param name="shapePopulate">Existing <c>Filler</c> object.</param>
        /// <exception cref="System.ArgumentNullException">
        ///		Thrown if <paramref name="filler" /> is null.
        ///	</exception>
        public ShapeDialog(ShapePopulate shapePopulate)
        {
            if (shapePopulate == null)
            {
                throw new ArgumentNullException("shapePopulate");
            }


            InitializeComponent();
            //FillGradientComboBox();
            AdjustDialogSize();
            //Set_Rectangle_InitialValues();
            SetControls_Circle_To_Initial_Values(shapePopulate);
            SetControl_Rectangle_To_Initial_Values(shapePopulate);
            SetControls_Polygon_To_Initial_Values(shapePopulate);
            SetControls_Pie_To_Initial_Values(shapePopulate);

        }


        /// <summary>
        ///		Initializes a new instance of <c>FillerEditorDialog</c> using an empty <c>Filler</c>
        ///		and positioned beneath the specified control.
        /// </summary>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        public ShapeDialog(Control c) : this(ShapePopulate.Empty(), c)
        {
        }

        /// <summary>
        ///		Initializes a new instance of <c>FillerEditorDialog</c> using an existing <c>Filler</c>
        ///		and positioned beneath the specified control.
        /// </summary>
        /// <param name="filler">Existing <c>Filler</c> object.</param>
        /// <param name="c">Control beneath which the dialog should be placed.</param>
        /// <exception cref="System.ArgumentNullException">
        ///		Thrown if <paramref name="filler" /> is null.
        ///	</exception>
        public ShapeDialog(ShapePopulate shapePopulate, Control c) : this(shapePopulate)
        {
            Draw.SetStartPositionBelowControl(this, c);
        }


        #endregion

        #region Fields

        private const int No = 0;
        private const int Yes = 1;
        private ShapePopulate shapePopulate;
        
        #region Rectangle Parameters

        public static string rectangleRounding_Retrieved = "Yes";
        public static string rectangleBorder_Retrieved = "Yes";
        public static string rectangleColored_Retrieved = "Yes";

        public int rectangleCurve_Retrieved = 10;
        public static int rectangleBorderWidth_Retrieved = 2;
        public static Color rectangleColor_Retrieved = Color.Yellow;
        public static Color rectangleBorderColor_Retrieved = Color.DeepSkyBlue;

        public int rectangleCurve_UL_Retrieved = 10;
        public int rectangleCurve_UR_Retrieved = 10;
        public int rectangleCurve_DL_Retrieved = 10;
        public int rectangleCurve_DR_Retrieved = 10;

        #endregion

        #region Circle Parameters
        
        public string circleBorder_Retrieved = "Yes";
        public string circleColored_Retrieved = "Yes";

        public int circleBorderWidth_Retrieved = 2;
        public Color circleColor_Retrieved = Color.Yellow;
        public Color circleBorderColor_Retrieved = Color.DeepSkyBlue;

        
        #endregion

        #region Polygon Parameters

        
        public string polygonBorder_Retrieved = "Yes";
        public string polygonColored_Retrieved = "Yes";

        
        public int polygonBorderWidth_Retrieved = 2;
        public Color polygonColor_Retrieved = Color.Yellow;
        public Color polygonBorderColor_Retrieved = Color.DeepSkyBlue;

        public int polygonSides_Retrieved = 3;
        public int polygonAngle_Retrieved = 90;

        #endregion

        #region Pie Parameters

        public string pieRounding_Retrieved = "Yes";
        public string pieBorder_Retrieved = "Yes";
        public string pieColored_Retrieved = "Yes";

        
        public int pieBorderWidth_Retrieved = 2;
        public Color pieColor_Retrieved = Color.Yellow;
        public Color pieBorderColor_Retrieved = Color.DeepSkyBlue;
        public float pie_StartAngle_Retrieved = 0;
        public float pie_EndAngle_Retrieved = 90;


        #endregion


        #endregion

        #region Public Properties

        public ShapePopulate ShapePopulate
        {
            get { return shapePopulate; }
        }

        public int UL_Retrieved
        {
            get { return rectangleCurve_UL_Retrieved; }
            set
            {
                rectangleCurve_UL_Retrieved = value;
                Invalidate();
            }
        }


        #endregion

        #region Private Methods

        private void AdjustDialogSize()
        {
            // Three different possible group boxes - move them all to one coordinate
            int x = rectangle_GroupBox.Location.X;
            int y = controlTypeContainer.Location.Y;

            rectangle_GroupBox.Location = new Point(x, y);
            circle_GroupBox.Location = new Point(x, y);
            polygon_GroupBox.Location = new Point(x, y);
            pie_GroupBox.Location = new Point(x, y);
            //formName.Location = new Point(typeGroupBox.Location.X, formName.Location.Y - 5);

            int bottomY = Math.Max(rectangle_GroupBox.Bounds.Bottom,
                Math.Max(circle_GroupBox.Bounds.Bottom, 
                Math.Max(polygon_GroupBox.Bounds.Bottom, 
                Math.Max(pie_GroupBox.Bounds.Bottom,
                    controlTypeContainer.Bounds.Bottom))));



            int newHeight = bottomY + controlTypeContainer.Location.Y;

            this.Size = new Size(Size.Width, Size.Height - (ClientSize.Height - newHeight));
        }
        
        private void SetControl_Rectangle_To_Initial_Values(ShapePopulate shapePopulate)
        {
            
            rectangle_Rounding_Combo.SelectedIndex = No;
            rectangle_Border_Combo.SelectedIndex = No;
            rectangle_Colored_Combo.SelectedIndex = No;

            rectangleCurve_UL_Retrieved = shapePopulate.UpperLeftCurve;
            rectangleCurve_UR_Retrieved = shapePopulate.UpperRightCurve;
            rectangleCurve_DL_Retrieved = shapePopulate.DownLeftCurve;
            rectangleCurve_DR_Retrieved = shapePopulate.DownRightCurve;

            rectangle_Border_UL.Text = rectangleCurve_UL_Retrieved.ToString();
            rectangle_Border_UR.Text = rectangleCurve_UR_Retrieved.ToString();
            rectangle_Border_DL.Text = rectangleCurve_DL_Retrieved.ToString();
            rectangle_Border_DR.Text = rectangleCurve_DR_Retrieved.ToString();
            rectangle_Border_ALL.Text = shapePopulate.Curve.ToString();

            rectangleShape.UpperLeftCurve = shapePopulate.UpperLeftCurve;
            rectangleShape.UpperRightCurve = shapePopulate.UpperRightCurve;
            rectangleShape.DownLeftCurve = shapePopulate.DownLeftCurve;
            rectangleShape.DownRightCurve = shapePopulate.DownRightCurve;
            rectangleShape.Curve = shapePopulate.Curve;

            
            rectangleShape.BorderWidth = (shapePopulate.BorderWidth) / 4;
            

            if (shapePopulate.ShapeType == shapes.Rectangle)
            {
                rectangle_RadioBtn.Checked = true;

                rectangle_Curve_Numeric.Value = shapePopulate.Curve;
                rectangle_Border_Width_Numeric.Value = Convert.ToDecimal(shapePopulate.BorderWidth);
                rectangle_Color.BackColor = shapePopulate.ShapeColor;
                rectangle_BorderColor.BackColor = shapePopulate.BorderColor;

                
                
                rectangleShape.ShapeColor = shapePopulate.ShapeColor;
                rectangleShape.BorderColor = shapePopulate.BorderColor;
                
                
                if (shapePopulate.Rounding == true)
                {
                    rectangle_Rounding_Combo.SelectedIndex = Yes;
                    rectangleShape.Rounding = true;
                    
                }
                else if (shapePopulate.Rounding == false)
                {
                    rectangle_Rounding_Combo.SelectedIndex = No;
                    rectangleShape.Rounding = false;
                }

                if (shapePopulate.DrawBorder == true)
                {
                    rectangle_Border_Combo.SelectedIndex = Yes;
                    rectangleShape.DrawBorder = true;
                }
                else if (shapePopulate.DrawBorder == false)
                {
                    rectangle_Border_Combo.SelectedIndex = No;
                    rectangleShape.DrawBorder = false;
                }

                if (shapePopulate.ColorShape == true)
                {
                    rectangle_Colored_Combo.SelectedIndex = Yes;
                    rectangleShape.ColorShape = true;
                }
                else if (shapePopulate.ColorShape == false)
                {
                    rectangle_Colored_Combo.SelectedIndex = No;
                    rectangleShape.ColorShape = false;

                }

            }

            

            else if (shapePopulate.ShapeType == shapes.Circle)
            {
                circle_RadioBtn.Checked = true;
            }
            else if (shapePopulate.ShapeType == shapes.Polygon)
            {
                polygon_RadioBtn.Checked = true;
            }
            else if (shapePopulate.ShapeType == shapes.Pie)
            {
                pie_RadioBtn.Checked = true;
            }
            else
            {
                none_RadioBtn.Checked = true;
            }
        }

        private void SetControl_Rectangle_Passed_Values(ShapePopulate shapePopulate)
        {
            


            shapePopulate.Rounding = bool.Parse(rectangleRounding_Retrieved);
            shapePopulate.DrawBorder = bool.Parse(rectangleBorder_Retrieved);
            shapePopulate.ColorShape = bool.Parse(rectangleColored_Retrieved);
            shapePopulate.Curve = rectangleCurve_Retrieved;
            shapePopulate.BorderWidth = (int)rectangle_Border_Width_Numeric.Value;
            shapePopulate.ShapeColor = rectangle_Color.BackColor;
            shapePopulate.BorderColor = rectangle_BorderColor.BackColor;

            shapePopulate.UpperLeftCurve = rectangleCurve_UL_Retrieved * 4;
            shapePopulate.UpperRightCurve = rectangleCurve_UR_Retrieved * 4;
            shapePopulate.DownLeftCurve = rectangleCurve_DL_Retrieved * 4;
            shapePopulate.DownRightCurve = rectangleCurve_DR_Retrieved * 4;

        }

        private void SetControls_Circle_To_Initial_Values(ShapePopulate shapePopulate)
        {
            
            

            circle_Border_Combo.SelectedIndex = No;
            circle_Colored_Combo.SelectedIndex = No;
            

            if (shapePopulate.ShapeType == shapes.Circle)
            {
                circle_RadioBtn.Checked = true;
                
                circle_Border_Width_Numeric.Value = Convert.ToDecimal(shapePopulate.BorderWidth);
                circle_Color.BackColor = shapePopulate.ShapeColor;
                circle_BorderColor.BackColor = shapePopulate.BorderColor;


                circleShape.BorderWidth = shapePopulate.BorderWidth;
                circleShape.ShapeColor = shapePopulate.ShapeColor;
                circleShape.BorderColor = shapePopulate.BorderColor;
                

                if (shapePopulate.DrawBorder == true)
                {
                    circle_Border_Combo.SelectedIndex = Yes;
                    circleShape.DrawBorder = true;
                }
                else if (shapePopulate.DrawBorder == false)
                {
                    circle_Border_Combo.SelectedIndex = No;
                    circleShape.DrawBorder = false;
                }

                if (shapePopulate.ColorShape == true)
                {
                    circle_Colored_Combo.SelectedIndex = Yes;
                    circleShape.ColorShape = true;
                }
                else if (shapePopulate.ColorShape == false)
                {
                    circle_Colored_Combo.SelectedIndex = No;
                    circleShape.ColorShape = false;

                }

            }



            else if (shapePopulate.ShapeType == shapes.Rectangle)
            {
                rectangle_RadioBtn.Checked = true;
            }
            else if (shapePopulate.ShapeType == shapes.Polygon)
            {
                polygon_RadioBtn.Checked = true;
            }
            else if (shapePopulate.ShapeType == shapes.Pie)
            {
                pie_RadioBtn.Checked = true;
            }
            else
            {
                none_RadioBtn.Checked = true;
            }
        }

        private void SetControl_Circle_Passed_Values(ShapePopulate shapePopulate)
        {

            
            shapePopulate.DrawBorder = bool.Parse(circleBorder_Retrieved);
            shapePopulate.ColorShape = bool.Parse(circleColored_Retrieved);
            shapePopulate.BorderWidth = (int)circle_Border_Width_Numeric.Value;
            shapePopulate.ShapeColor = circle_Color.BackColor;
            shapePopulate.BorderColor = circle_BorderColor.BackColor;
            

        }

        private void SetControls_Polygon_To_Initial_Values(ShapePopulate shapePopulate)
        {



            polygon_Border_Combo.SelectedIndex = No;
            polygon_Colored_Combo.SelectedIndex = No;


            if (shapePopulate.ShapeType == shapes.Polygon)
            {
                polygon_RadioBtn.Checked = true;

                polygon_Border_Width_Numeric.Value = Convert.ToDecimal(shapePopulate.BorderWidth);
                polygon_Color.BackColor = shapePopulate.ShapeColor;
                polygon_BorderColor.BackColor = shapePopulate.BorderColor;
                polygon_Sides_Numeric.Value = Convert.ToDecimal(shapePopulate.PolygonSides);
                polygon_Angle_Numeric.Value = Convert.ToDecimal(shapePopulate.PolygonStartingAngle);


                polygonShape.BorderWidth = shapePopulate.BorderWidth;
                polygonShape.ShapeColor = shapePopulate.ShapeColor;
                polygonShape.BorderColor = shapePopulate.BorderColor;
                polygonShape.PolygonSides = shapePopulate.PolygonSides;
                polygonShape.PolygonStartingAngle = shapePopulate.PolygonStartingAngle;


                if (shapePopulate.DrawBorder == true)
                {
                    polygon_Border_Combo.SelectedIndex = Yes;
                    polygonShape.DrawBorder = true;
                }
                else if (shapePopulate.DrawBorder == false)
                {
                    polygon_Border_Combo.SelectedIndex = No;
                    polygonShape.DrawBorder = false;
                }

                if (shapePopulate.ColorShape == true)
                {
                    polygon_Colored_Combo.SelectedIndex = Yes;
                    polygonShape.ColorShape = true;
                }
                else if (shapePopulate.ColorShape == false)
                {
                    polygon_Colored_Combo.SelectedIndex = No;
                    polygonShape.ColorShape = false;

                }

            }



            else if (shapePopulate.ShapeType == shapes.Circle)
            {
                circle_RadioBtn.Checked = true;
            }
            else if (shapePopulate.ShapeType == shapes.Rectangle)
            {
                rectangle_RadioBtn.Checked = true;
            }
            else if (shapePopulate.ShapeType == shapes.Pie)
            {
                pie_RadioBtn.Checked = true;
            }
            else
            {
                none_RadioBtn.Checked = true;
            }
        }

        private void SetControl_Polygon_Passed_Values(ShapePopulate shapePopulate)
        {


            shapePopulate.DrawBorder = bool.Parse(polygonBorder_Retrieved);
            shapePopulate.ColorShape = bool.Parse(polygonColored_Retrieved);
            shapePopulate.BorderWidth = (int)polygon_Border_Width_Numeric.Value;
            shapePopulate.ShapeColor = polygon_Color.BackColor;
            shapePopulate.BorderColor = polygon_BorderColor.BackColor;
            shapePopulate.PolygonStartingAngle = polygonAngle_Retrieved;
            shapePopulate.PolygonSides = polygonSides_Retrieved;


        }

        private void SetControls_Pie_To_Initial_Values(ShapePopulate shapePopulate)
        {



            pie_Border_Combo.SelectedIndex = No;
            pie_Colored_Combo.SelectedIndex = No;


            if (shapePopulate.ShapeType == shapes.Pie)
            {
                pie_RadioBtn.Checked = true;

                pie_Border_Width_Numeric.Value = Convert.ToDecimal(shapePopulate.BorderWidth);
                pie_Color.BackColor = shapePopulate.ShapeColor;
                pie_BorderColor.BackColor = shapePopulate.BorderColor;
                pie_StartAngle_Numeric.Value = Convert.ToDecimal(shapePopulate.StartAngle);
                pie_EndAngle_Numeric.Value = Convert.ToDecimal(shapePopulate.EndAngle);


                pieShape.BorderWidth = shapePopulate.BorderWidth;
                pieShape.ShapeColor = shapePopulate.ShapeColor;
                pieShape.BorderColor = shapePopulate.BorderColor;
                pieShape.StartAngle = shapePopulate.StartAngle;
                pieShape.EndAngle = shapePopulate.EndAngle;


                if (shapePopulate.DrawBorder == true)
                {
                    pie_Border_Combo.SelectedIndex = Yes;
                    pieShape.DrawBorder = true;
                }
                else if (shapePopulate.DrawBorder == false)
                {
                    pie_Border_Combo.SelectedIndex = No;
                    pieShape.DrawBorder = false;
                }

                if (shapePopulate.ColorShape == true)
                {
                    pie_Colored_Combo.SelectedIndex = Yes;
                    pieShape.ColorShape = true;
                }
                else if (shapePopulate.ColorShape == false)
                {
                    pie_Colored_Combo.SelectedIndex = No;
                    pieShape.ColorShape = false;

                }

            }



            else if (shapePopulate.ShapeType == shapes.Circle)
            {
                circle_RadioBtn.Checked = true;
            }
            else if (shapePopulate.ShapeType == shapes.Rectangle)
            {
                rectangle_RadioBtn.Checked = true;
            }
            else if (shapePopulate.ShapeType == shapes.Polygon)
            {
                polygon_RadioBtn.Checked = true;
            }
            else
            {
                none_RadioBtn.Checked = true;
            }
        }

        private void SetControl_Pie_Passed_Values(ShapePopulate shapePopulate)
        {


            shapePopulate.DrawBorder = bool.Parse(pieBorder_Retrieved);
            shapePopulate.ColorShape = bool.Parse(pieColored_Retrieved);
            shapePopulate.BorderWidth = (int)pie_Border_Width_Numeric.Value;
            shapePopulate.ShapeColor = pie_Color.BackColor;
            shapePopulate.BorderColor = pie_BorderColor.BackColor;
            shapePopulate.StartAngle = pie_StartAngle_Retrieved;
            shapePopulate.EndAngle = pie_EndAngle_Retrieved;


        }



        #endregion

        #region Rectangle




        #endregion

        private void rectangle_Rounding_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (rectangle_Rounding_Combo.SelectedIndex == Yes)
            {
                rectangleRounding_Retrieved = "true";
                rectangleShape.Rounding = true;

                
            }
            else if(rectangle_Rounding_Combo.SelectedIndex == No)
            {
                rectangleRounding_Retrieved = "false";
                rectangleShape.Rounding = false;
                
            }
        }

        private void rectangle_Curve_Numeric_ValueChanged(object sender, EventArgs e)
        {
            rectangleCurve_Retrieved = (int)rectangle_Curve_Numeric.Value;
            rectangleShape.Curve = rectangleCurve_Retrieved;

            rectangleCurve_UL_Retrieved = rectangleCurve_Retrieved;
            rectangleCurve_UR_Retrieved = rectangleCurve_Retrieved;
            rectangleCurve_DL_Retrieved = rectangleCurve_Retrieved;
            rectangleCurve_DR_Retrieved = rectangleCurve_Retrieved;

        }


        private void rectangle_Border_UL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rectangle_Border_UL.Text == string.Empty)
                {
                    rectangleShape.UpperLeftCurve = 3;
                }

                int valueConverted = int.Parse(rectangle_Border_UL.Text);

                rectangleCurve_UL_Retrieved = valueConverted;

                rectangleShape.UpperLeftCurve = rectangleCurve_UL_Retrieved;


            }
            catch (Exception exception)
            {

                rectangleShape.UpperLeftCurve = 3;

            }
        }

        private void rectangle_Border_UR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rectangle_Border_UR.Text == string.Empty)
                {
                    rectangleShape.UpperRightCurve = 3;
                }

                int valueConverted = int.Parse(rectangle_Border_UR.Text);
                rectangleCurve_UR_Retrieved = valueConverted;

                rectangleShape.UpperRightCurve = rectangleCurve_UR_Retrieved;
            }
            catch (Exception exception)
            {

                rectangleShape.UpperRightCurve = 3;
            }
        }

        private void rectangle_Border_DL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rectangle_Border_DL.Text == string.Empty)
                {
                    rectangleShape.DownLeftCurve = 3;
                }
                int valueConverted = int.Parse(rectangle_Border_DL.Text);
                rectangleCurve_DL_Retrieved = valueConverted;

                rectangleShape.DownLeftCurve = rectangleCurve_DL_Retrieved;
            }
            catch (Exception exception)
            {

                rectangleShape.DownLeftCurve = 3;
            }
        }

        private void rectangle_Border_DR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rectangle_Border_DR.Text == string.Empty)
                {
                    rectangleShape.DownRightCurve = 3;
                }
                int valueConverted = int.Parse(rectangle_Border_DR.Text);
                rectangleCurve_DR_Retrieved = valueConverted;

                rectangleShape.DownRightCurve = rectangleCurve_DR_Retrieved;
            }
            catch (Exception exception)
            {

                rectangleShape.DownRightCurve = 3;
            }
        }

        private void rectangle_Border_ALL_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rectangle_Border_ALL.Text == string.Empty)
                {
                    rectangleShape.Curve = 3;
                }
                int valueConverted = int.Parse(rectangle_Border_ALL.Text);
                rectangleCurve_Retrieved = valueConverted;

                rectangleShape.Curve = rectangleCurve_Retrieved;

                rectangle_Border_UL.Text = rectangleCurve_Retrieved.ToString();
                rectangle_Border_UR.Text = rectangleCurve_Retrieved.ToString();
                rectangle_Border_DL.Text = rectangleCurve_Retrieved.ToString();
                rectangle_Border_DR.Text = rectangleCurve_Retrieved.ToString();

                rectangleShape.UpperLeftCurve = rectangleCurve_Retrieved;
                rectangleShape.UpperRightCurve = rectangleCurve_Retrieved;
                rectangleShape.DownLeftCurve = rectangleCurve_Retrieved;
                rectangleShape.DownRightCurve = rectangleCurve_Retrieved;
            }
            catch (Exception exception)
            {

                rectangleShape.Curve = 3;
            }
        }


        private void polygon_Sides_ValueChanged(object sender, EventArgs e)
        {
            polygonSides_Retrieved = (int)polygon_Sides_Numeric.Value;
            polygonShape.PolygonSides = polygonSides_Retrieved;
        }

        private void polygon_Angle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            polygonAngle_Retrieved = (int)polygon_Angle_Numeric.Value;
            polygonShape.PolygonStartingAngle = polygonAngle_Retrieved;
        }


        private void pie_StartAngle_ValueChanged(object sender, EventArgs e)
        {

            pie_StartAngle_Retrieved = (int)pie_StartAngle_Numeric.Value;
            pieShape.StartAngle = pie_StartAngle_Retrieved;
        }

        private void pie_EndAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pie_EndAngle_Retrieved = (int)pie_EndAngle_Numeric.Value;
            pieShape.EndAngle = pie_EndAngle_Retrieved;
        }

        


        private void rectangle_Border_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rectangle_Border_Combo.SelectedIndex == Yes)
            {
                rectangleBorder_Retrieved = "true";
                rectangleShape.DrawBorder = true;
            }
            else if(rectangle_Border_Combo.SelectedIndex == No)
            {
                rectangleBorder_Retrieved = "false";
                rectangleShape.DrawBorder = false;
            }
        }

        private void circle_Border_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (circle_Border_Combo.SelectedIndex == Yes)
            {
                circleBorder_Retrieved = "true";
                circleShape.DrawBorder = true;
            }
            else if (circle_Border_Combo.SelectedIndex == No)
            {
                circleBorder_Retrieved = "false";
                circleShape.DrawBorder = false;
            }
        }

        private void polygon_Border_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (polygon_Border_Combo.SelectedIndex == Yes)
            {
                polygonBorder_Retrieved = "true";
                polygonShape.DrawBorder = true;
            }
            else if (polygon_Border_Combo.SelectedIndex == No)
            {
                polygonBorder_Retrieved = "false";
                polygonShape.DrawBorder = false;
            }
        }

        private void pie_Border_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pie_Border_Combo.SelectedIndex == Yes)
            {
                pieBorder_Retrieved = "true";
                pieShape.DrawBorder = true;
            }
            else if (pie_Border_Combo.SelectedIndex == No)
            {
                pieBorder_Retrieved = "false";
                pieShape.DrawBorder = false;
            }
        }



        private void rectangle_Colored_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rectangle_Colored_Combo.SelectedIndex == Yes)
            {
                rectangleColored_Retrieved = "true";
                rectangleShape.ColorShape = true;
            }
            else if(rectangle_Colored_Combo.SelectedIndex == No)
            {
                rectangleColored_Retrieved = "false";
                rectangleShape.ColorShape = false;
            }
        }
        
        private void circle_Colored_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (circle_Colored_Combo.SelectedIndex == Yes)
            {
                circleColored_Retrieved = "true";
                circleShape.ColorShape = true;
            }
            else if (circle_Colored_Combo.SelectedIndex == No)
            {
                circleColored_Retrieved = "false";
                circleShape.ColorShape = false;
            }
        }

        private void polygon_Colored_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (polygon_Colored_Combo.SelectedIndex == Yes)
            {
                polygonColored_Retrieved = "true";
                polygonShape.ColorShape = true;
            }
            else if (polygon_Colored_Combo.SelectedIndex == No)
            {
                polygonColored_Retrieved = "false";
                polygonShape.ColorShape = false;
            }
        }

        private void pie_Colored_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pie_Colored_Combo.SelectedIndex == Yes)
            {
                pieColored_Retrieved = "true";
                pieShape.ColorShape = true;
            }
            else if (pie_Colored_Combo.SelectedIndex == No)
            {
                pieColored_Retrieved = "false";
                pieShape.ColorShape = false;
            }
        }




        private void rectangle_Border_Width_Numeric_ValueChanged(object sender, EventArgs e)
        {
            rectangleBorderWidth_Retrieved = (int) rectangle_Border_Width_Numeric.Value;
            rectangleShape.BorderWidth = rectangleBorderWidth_Retrieved;
        }

        private void circle_Border_Width_Numeric_ValueChanged(object sender, EventArgs e)
        {
            circleBorderWidth_Retrieved = (int)circle_Border_Width_Numeric.Value;
            circleShape.BorderWidth = circleBorderWidth_Retrieved;
        }

        private void polygon_Border_Width_Numeric_ValueChanged(object sender, EventArgs e)
        {
            polygonBorderWidth_Retrieved = (int)polygon_Border_Width_Numeric.Value;
            polygonShape.BorderWidth = polygonBorderWidth_Retrieved;
            
        }

        private void pie_Border_Width_Numeric_ValueChanged(object sender, EventArgs e)
        {
            pieBorderWidth_Retrieved = (int)pie_Border_Width_Numeric.Value;
            pieShape.BorderWidth = pieBorderWidth_Retrieved;

        }



        private void rectangle_Color_Click(object sender, EventArgs e)
        {
            shapeColorDialog.ShowDialog();

            rectangle_Color.BackColor = shapeColorDialog.Color;
            rectangleColor_Retrieved = shapeColorDialog.Color;

            if (rectangleShape.ColorShape == true)
            {
                rectangleShape.ShapeColor = rectangleColor_Retrieved;
                
                //rectangleShape.ShapeColor = shapeColorDialog.Color;
            }
        }

        private void circle_Color_Click(object sender, EventArgs e)
        {
            shapeColorDialog.ShowDialog();

            circle_Color.BackColor = shapeColorDialog.Color;
            circleColor_Retrieved = shapeColorDialog.Color;

            if (circleShape.ColorShape == true)
            {
                circleShape.ShapeColor = circleColor_Retrieved;

                //rectangleShape.ShapeColor = shapeColorDialog.Color;
            }
        }

        private void polygon_Color_Click(object sender, EventArgs e)
        {
            shapeColorDialog.ShowDialog();

            polygon_Color.BackColor = shapeColorDialog.Color;
            polygonColor_Retrieved = shapeColorDialog.Color;

            if (polygonShape.ColorShape == true)
            {
                polygonShape.ShapeColor = polygonColor_Retrieved;

                //rectangleShape.ShapeColor = shapeColorDialog.Color;
            }
        }

        private void pie_Color_Click(object sender, EventArgs e)
        {
            shapeColorDialog.ShowDialog();

            pie_Color.BackColor = shapeColorDialog.Color;
            pieColor_Retrieved = shapeColorDialog.Color;

            if (pieShape.ColorShape == true)
            {
                pieShape.ShapeColor = pieColor_Retrieved;

                //rectangleShape.ShapeColor = shapeColorDialog.Color;
            }
        }



        private void rectangle_BorderColor_Click(object sender, EventArgs e)
        {
            shapeColorDialog.ShowDialog();

            rectangle_BorderColor.BackColor = shapeColorDialog.Color;
            rectangleBorderColor_Retrieved = shapeColorDialog.Color;

            if (rectangleShape.DrawBorder == true)
            {
                rectangleShape.BorderColor = rectangleBorderColor_Retrieved;
            }
        }
        
        private void circle_BorderColor_Click(object sender, EventArgs e)
        {
            shapeColorDialog.ShowDialog();

            circle_BorderColor.BackColor = shapeColorDialog.Color;
            circleBorderColor_Retrieved = shapeColorDialog.Color;

            if (circleShape.DrawBorder == true)
            {
                circleShape.BorderColor = circleBorderColor_Retrieved;
            }
        }

        private void polygon_BorderColor_Click(object sender, EventArgs e)
        {
            shapeColorDialog.ShowDialog();

            polygon_BorderColor.BackColor = shapeColorDialog.Color;
            polygonBorderColor_Retrieved = shapeColorDialog.Color;

            if (polygonShape.DrawBorder == true)
            {
                polygonShape.BorderColor = polygonBorderColor_Retrieved;
            }
        }

        private void pie_BorderColor_Click(object sender, EventArgs e)
        {
            shapeColorDialog.ShowDialog();

            pie_BorderColor.BackColor = shapeColorDialog.Color;
            pieBorderColor_Retrieved = shapeColorDialog.Color;

            if (pieShape.DrawBorder == true)
            {
                pieShape.BorderColor = pieBorderColor_Retrieved;
            }
        }


        private void ShapeTypeChanged(object sender, EventArgs e)
        {
            rectangle_GroupBox.Visible = false;
            circle_GroupBox.Visible = false;
            polygon_GroupBox.Visible = false;
            pie_GroupBox.Visible = false;



            if (rectangle_RadioBtn.Checked)
            {
                rectangle_GroupBox.Visible = true;

            }
            else if (circle_RadioBtn.Checked)
            {
                circle_GroupBox.Visible = true;
            }
            else if (polygon_RadioBtn.Checked)
            {
                polygon_GroupBox.Visible = true;
            }
            else if (pie_RadioBtn.Checked)
            {
                pie_GroupBox.Visible = true;
            }

            else if (none_RadioBtn.Checked)
            {
                rectangle_GroupBox.Visible = false;
                circle_GroupBox.Visible = false;
                polygon_GroupBox.Visible = false;
                pie_GroupBox.Visible = false;
            }
        }


        private void okBtn_Click(object sender, EventArgs e)
        {

            if (rectangle_RadioBtn.Checked)
            {

                try
                {
                    //shapePopulate = new ShapePopulate(
                    //    shapes.Rectangle, 
                    //    Color.DeepSkyBlue, 
                    //    Color.Yellow,true,false,true, 
                    //    rectangleCurve_Retrieved, 
                    //    rectangleCurve_UL_Retrieved,
                    //    rectangleCurve_UR_Retrieved,
                    //    rectangleCurve_DL_Retrieved,
                    //    rectangleCurve_DR_Retrieved);

                    shapePopulate = new ShapePopulate(
                        shapes.Rectangle,
                        Color.DeepSkyBlue,
                        Color.Yellow, true, false, true,
                        10,
                        10,
                        10,
                        10,
                        10);
                    SetControl_Rectangle_Passed_Values(shapePopulate);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    this.Close();
                }


            }
            else if (circle_RadioBtn.Checked)
            {
                try
                {
                    shapePopulate = new ShapePopulate(shapes.Circle, Color.DeepSkyBlue,
                        Color.Yellow, true, false);
                    SetControl_Circle_Passed_Values(shapePopulate);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    this.Close();
                }



            }
            else if (polygon_RadioBtn.Checked)
            {
                try
                {
                    shapePopulate = new ShapePopulate(shapes.Polygon, 3, 90);
                    SetControl_Polygon_Passed_Values(shapePopulate);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    this.Close();
                }
                
            }

            else if (pie_RadioBtn.Checked)
            {
                try
                {
                    shapePopulate = new ShapePopulate(shapes.Pie, 3, 90, true);
                    SetControl_Pie_Passed_Values(shapePopulate);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    this.Close();
                }
                
            }
            else if (none_RadioBtn.Checked)
            {
                shapePopulate = new ShapePopulate(shapes.None, true);
            }
            else
            {
                shapePopulate = ShapePopulate.Empty();
            }
            DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.Red;
            closeBtn.FlatAppearance.BorderSize = 0;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.FromArgb(28, 28, 28);
            closeBtn.FlatAppearance.BorderSize = 1;
        }

        
    }
}
