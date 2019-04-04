using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeroit.Framework.FormEditors.UIThemes.ControlEditor
{
    public enum controlType
    {
        Arc,
        Circle,
        Line,
        Polygon,
        Pie,
        Rectangle,
        
    }

    public enum shapes : int
    {
        None = 0,
        Rectangle = 1,
        Circle = 2,
        Polygon = 3,
        Pie = 4,
        Default = 5
        //Custom = 5,
        //RoundedRectangle = 2,
    }

}
