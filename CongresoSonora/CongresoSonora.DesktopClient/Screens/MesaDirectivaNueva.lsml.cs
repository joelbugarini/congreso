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
    public partial class MesaDirectivaNueva
    {
        partial void MesaDirectivaNueva_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.MesaDirectivaProperty = new MesaDirectiva();
        }

        partial void MesaDirectivaNueva_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.MesaDirectivaProperty);
        }

        partial void AddDiputado_Execute()
        {
            // Write your code here.
            var md = MesaDirectivaDiputadoes.AddNew();
            md.MesaDirectiva = this.MesaDirectivaProperty;
            md.Diputado = Diputadoes.SelectedItem;
        }

        partial void RemoveDiputado_Execute()
        {
            // Write your code here.
            MesaDirectivaDiputadoes.DeleteSelected();
        }
    }
}