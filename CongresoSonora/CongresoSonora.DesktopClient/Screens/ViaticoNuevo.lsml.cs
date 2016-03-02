using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.IO;
using System.Linq;
using System;
using System.Windows;
using System.Windows.Controls;

namespace LightSwitchApplication
{
    public partial class ViaticoNuevo
    {
        partial void ViaticoNuevo_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.ViaticoProperty = new Viatico();
            

        }

        partial void ViaticoNuevo_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.ViaticoProperty);
        }

        partial void LLANOS_Execute()
        {
            // Write your code here.
            var r = this;
            //var re = 4;
        }
    }
}