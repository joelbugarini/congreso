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
    public partial class MesaDirectivaDetalle
    {
        partial void MesaDirectiva_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.MesaDirectiva);
        }

        partial void MesaDirectiva_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.MesaDirectiva);
        }

        partial void MesaDirectivaDetalle_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.MesaDirectiva);
        }

        partial void AddDiputado_Execute()
        {
            // Write your code here.
            var md = MesaDirectivaDiputadoes.AddNew();
            md.MesaDirectiva = this.MesaDirectiva;
            md.Diputado = Diputadoes.SelectedItem;
        }

        partial void RemoveDiputado_Execute()
        {
            // Write your code here.
            MesaDirectivaDiputadoes.DeleteSelected();
        }
    }
}