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
    public partial class LegislaturaNueva
    {
        partial void LegislaturaNueva_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.LegislaturaProperty = new Legislatura();
        }

        partial void LegislaturaNueva_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.LegislaturaProperty);
        }

        partial void AddComision_Execute()
        {
            // Write your code here.
            var lc = LegislaturaComisions.AddNew();
            lc.Legislatura = this.LegislaturaProperty;
            lc.Comision = Comisions.SelectedItem;
        }

        partial void RemoveComision_Execute()
        {
            // Write your code here.
            LegislaturaComisions.DeleteSelected();
        }
    }
}