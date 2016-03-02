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
    public partial class Application
    {
        partial void ArchivoBuscar_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Biblioteca);
        }

        partial void ArchivoDetalle_CanRun(ref bool result, int ArchivoId)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Biblioteca);
        }

        partial void ArchivoNuevo_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Biblioteca);
        }

        partial void CargoComisions_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Camara);
        }

        partial void CargosMesaDirectiva_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Camara);
        }

        partial void Comisiones_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Camara);
        }

        partial void DepartamentoNuevo_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.RecursosHumanos);
        }

        partial void DiputadoBusqueda_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Camara);
        }

        partial void DiputadoDetalle_CanRun(ref bool result, int DiputadoId)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Camara);
        }

        partial void DiputadoNuevo_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Camara);
        }     

        partial void EmpleadoBuscar_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.RecursosHumanos);
        }

        partial void EmpleadoNuevo_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.RecursosHumanos);
        }

        partial void LegislaturaBuscar_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Camara);
        }

        partial void LegislaturaDetalle_CanRun(ref bool result, int LegislaturaId)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Camara);
        }

        partial void LegislaturaNueva_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Camara);
        }

        partial void MesaDirectivaBuscar_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Camara);
        }

        partial void MesaDirectivaDetalle_CanRun(ref bool result, int MesaDirectivaId)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Camara);
        }

        partial void MesaDirectivaNueva_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Camara);
        }

        partial void NotaBuscar_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Comunicacion);
        }

        partial void NotaDetalle_CanRun(ref bool result, int NotaId)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Comunicacion);
        }

        partial void NotaNueva_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Comunicacion);
        }

        partial void Partidos_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Camara);
        }

        partial void RecepcionBuscar_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.ArencionCiudadana);
        }

        partial void RecepcionNueva_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.ArencionCiudadana);
        }

        partial void SintesisBuscar_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Comunicacion);
        }

        partial void SintesisDetalle_CanRun(ref bool result, int SintesisId)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Comunicacion);
        }

        partial void SintesisNueva_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Comunicacion);
        }

        partial void ViaticoBuscar_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.RecursosHumanos);
        }

        partial void ViaticoNuevo_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.RecursosHumanos);
        }

        partial void Tabulador_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.RecursosHumanos);
        }

        partial void Honorarios_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.RecursosHumanos);
        }

        partial void EpocaLegislativa_CanRun(ref bool result)
        {
            // Set result to the desired field value
            result = Application.Current.User.HasPermission(Permissions.Camara);
        }       
    }
}