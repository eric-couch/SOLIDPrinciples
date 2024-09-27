using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.I.BadExample;

public class circle : IShape
{
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public double Volume()
    {
        throw new InvalidOperationException("No volume for 2D shapes.");
    }
}
