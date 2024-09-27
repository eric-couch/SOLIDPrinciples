using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.D.BadExample;

public class Car
{
    private Engine engine;

    public Car()
    {
        this.engine = new Engine();     // Direct dependency on Engine class
    }

    public void StartCar()
    {
        engine.Start();
        Console.WriteLine("Car Started.");
    }

}
