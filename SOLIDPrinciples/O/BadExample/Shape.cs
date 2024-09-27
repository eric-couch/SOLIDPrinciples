using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.O.BadExample;

public class Shape
{
    public ShapeType Type { get; set; }
    public double Sides { get; set; }
    public double Radius { get; set; }
    public double Length { get; set; }
    public double Width { get; set; }

    // Area
    public double CalculateArea()
    {
        switch (Type)
        {
            case ShapeType.Circle:
                return Math.PI * (Radius * Radius);
            case ShapeType.Rectangle:
                return Length * Width;
            default:
                throw new InvalidOperationException("Unsupport shape type.");
        }
    }
}
