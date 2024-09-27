using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.I.BadExample;

public interface IShape
{
    double Area();
    double Volume();    // problem: 2D shapes don't have volume
}
