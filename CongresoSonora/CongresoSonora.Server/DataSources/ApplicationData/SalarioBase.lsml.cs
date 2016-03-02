using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class SalarioBase
    {
        partial void PuestoSalario_Compute(ref string result)
        {
            // Set result to the desired field value
            result = this.Puesto + " - " + this.SueldoNeto.ToString("C");
        }
    }
}