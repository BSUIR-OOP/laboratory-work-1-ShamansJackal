using OOP_lab1.Structs;
using System.Collections.Generic;

namespace OOP_lab1.Shapes
{
    public abstract class BaseShape
    {
        public PixelColor color = PixelColors.White;
        protected IEnumerable<BezierCurve> _curves = new List<BezierCurve>();
        public IEnumerable<BezierCurve> Curves => _curves;
    }
}
