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
    public partial class DistritoDetail
    {
        partial void Distrito_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Distrito);
        }

        partial void Distrito_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Distrito);
        }

        partial void DistritoDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Distrito);
        }
    }
}