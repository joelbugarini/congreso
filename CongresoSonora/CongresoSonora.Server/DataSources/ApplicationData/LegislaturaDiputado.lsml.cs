﻿using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class LegislaturaDiputado
    {
        partial void Nombre_Compute(ref string result)
        {
            // Set result to the desired field value
            result = Legislatura.Romano;
        }
    }
}