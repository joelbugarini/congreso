using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.IO;
using System.Linq;
using System;

namespace LightSwitchApplication
{
    public partial class EmpleadoDetalle
    {
        partial void Empleado_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Empleado);
        }

        partial void Empleado_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Empleado);
        }

        partial void EmpleadoDetalle_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Empleado);
        }
    }
}