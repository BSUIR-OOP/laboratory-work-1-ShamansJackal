using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_lab1.Structs;

namespace OOP_lab1.Shapes
{
    public class Rectangle : BaseShape
    {
        public Rectangle()
        {
            double offset_y = -50;
            double offset_x = 0;
            _curves = new List<BezierCurve>() {
                new BezierCurve(new Point(20 + offset_x, 200 + offset_y), new Point(220 + offset_x, 200 + offset_y)),
                new BezierCurve(new Point(120 + offset_x, 100 + offset_y), new Point(120 + offset_x, 300 + offset_y)),
                //new BezierCurve(new Point(20, 40), new Point(60, 80), new Point(100, 40)),
                new BezierCurve(new Point(20 + offset_x, 200 + offset_y), new Point(20 + offset_x, 67 + offset_y), new Point(220 + offset_x, 67 + offset_y), new Point(220 + offset_x, 200 + offset_y)),
                new BezierCurve(new Point(20 + offset_x, 200 + offset_y), new Point(20 + offset_x, 333 + offset_y), new Point(220 + offset_x, 333 + offset_y), new Point(220 + offset_x, 200 + offset_y))
            };
            color = PixelColors.Blue;
        }

        public Rectangle(int x, int y, int width, int height)
        {
            width /= 2;
            height /= 2;
            _curves = new List<BezierCurve>()
            {
                new BezierCurve(new Point(x-width, y-height), new Point(x+width, y-height)),
                new BezierCurve(new Point(x+width, y-height), new Point(x+width, y+height)),
                new BezierCurve(new Point(x+width, y+height), new Point(x-width, y+height)),
                new BezierCurve(new Point(x-width, y+height), new Point(x+width, y+height))
            };
        }
    }
}
