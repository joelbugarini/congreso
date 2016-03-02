using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Threading;
using System.Globalization;

namespace LightSwitchApplication
{
    public partial class Sintesis
    {
        partial void Nombre_Compute(ref string result)
        {
            // Set result to the desired field value
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            result = "Síntesis del día " + this.Fecha.ToLongDateString();
        }
    }
}