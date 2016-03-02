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
    public partial class LegislaturaDetalle
    {
        partial void Legislatura_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Legislatura);
        }

        partial void Legislatura_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Legislatura);
        }

        partial void LegislaturaDetalle_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Legislatura);
        }

        partial void AddComision_Execute()
        {
            // Write your code here.
            var lc = LegislaturaComisions.AddNew();
            lc.Legislatura = this.Legislatura;
            lc.Comision = Comisions.SelectedItem;
        }

        partial void RemoveComision_Execute()
        {
            // Write your code here.
            LegislaturaComisions.DeleteSelected();
        }
    }
}