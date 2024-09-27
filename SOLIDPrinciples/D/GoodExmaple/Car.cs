using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.D.GoodExmaple;

public class Car
{
    public IEngine engine;

    public Car(IEngine engine)
    {
        this.engine = engine;
    }

    public void Start()
    {
        engine.Start();
        Console.WriteLine("Car Started.");
    }
}
