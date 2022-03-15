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
            Curves = new() {
                new BezierCurve(new Point(20+offset_x, 200+offset_y), new Point(220+offset_x, 200+offset_y)),
                new BezierCurve(new Point(120+offset_x, 100+offset_y), new Point(120+offset_x, 300+offset_y)),
                //new BezierCurve(new Point(20, 40), new Point(60, 80), new Point(100, 40)),
                new BezierCurve(new Point(20+offset_x, 200+offset_y), new Point(20+offset_x, 67+offset_y), new Point(220+offset_x, 67+offset_y), new Point(220+offset_x, 200+offset_y)),
                new BezierCurve(new Point(20+offset_x, 200+offset_y), new Point(20+offset_x, 333+offset_y), new Point(220+offset_x, 333+offset_y), new Point(220+offset_x, 200+offset_y))
                //new BezierCurve(new Point(20, 80), new Point(20, -100), new Point(100, -100), new Point(100, 80))
                //new BezierCurve(new Point(20, 100), new Point(30, 30), new Point(100, 20)),
                //new BezierCurve(new Point(100, 20), new Point(170, 30), new Point(180, 100)),
                //new BezierCurve(new Point(20, 200), new Point(20,100), new Point(220, 100), new Point(220, 200))
                //new BezierCurve(new Point(20, 100), new Point(20, 20), new Point(100, 20)),
                //new BezierCurve(new Point(20, 100), new Point(20, 20), new Point(100, 20))
            };
            color = PixelColors.Blue;
        }
    }
}
