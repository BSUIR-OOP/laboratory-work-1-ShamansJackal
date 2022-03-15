using OOP_lab1.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_lab1.Shapes
{
    public abstract class BaseShape
    {
        public PixelColor color;
        public List<BezierCurve> Curves { get; protected set; }

        public virtual void SetSize(int x1, int y1, int x2, int y2)
        {
            Curves = new List<BezierCurve>();
        }
    }
}
