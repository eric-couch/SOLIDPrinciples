﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.L.BadExample;

public class Square : Rectangle
{
    public override double Width
    {
        get => base.Width;
        set => base.Width = base.Height = value;
    }

    public override double Height
    {
        get => base.Height;
        set => base.Width = base.Height = value;
    }
}
