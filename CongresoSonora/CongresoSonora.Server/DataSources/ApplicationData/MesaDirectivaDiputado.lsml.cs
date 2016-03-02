using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class MesaDirectivaDiputado
    {
        partial void DiputadoNombre_Compute(ref string result)
        {
            // Set result to the desired field value
            result = Diputado.Nombre;
        }
    }
}