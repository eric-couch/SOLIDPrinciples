using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.D.GoodExmaple;

public class ElectricMotor : IEngine
{
    public void Start()
    {
        Console.WriteLine("Start motor.");
    }
}
