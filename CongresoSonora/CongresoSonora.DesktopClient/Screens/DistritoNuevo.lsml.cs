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
    public partial class DistritoNuevo
    {
        partial void DistritoNuevo_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.DistritoProperty = new Distrito();
        }

        partial void DistritoNuevo_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.DistritoProperty);
        }

        partial void AddMethod_Execute()
        {
            // Write your code here.
            var dm = DistritoMunicipio.AddNew();
            dm.Municipios = this.Municipios.SelectedItem;

        }

        partial void RemoveMethod_Execute()
        {
            // Write your code here.
            DistritoMunicipio.DeleteSelected();
        }
    }
}