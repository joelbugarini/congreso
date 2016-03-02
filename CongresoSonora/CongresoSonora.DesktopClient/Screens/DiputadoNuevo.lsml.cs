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
using System.Runtime.InteropServices.Automation;
using Microsoft.LightSwitch.Threading;
using System.Windows.Controls;

namespace LightSwitchApplication
{
    public partial class DiputadoNuevo
    {
        partial void DiputadoNuevo_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            this.DiputadoProperty = new Diputado();
        }

        partial void DiputadoNuevo_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.DiputadoProperty);
            
        }

        partial void AddComisiones_Execute()
        {
            // Write your code here.
            var dc = DiputadoComisions.AddNew();
            dc.Diputado = this.DiputadoProperty;
            dc.Comision = Comisions.SelectedItem;
        }

        partial void RemoveComisiones_Execute()
        {
            // Write your code here.
            DiputadoComisions.DeleteSelected();
        }

        partial void AddFile_Execute()
        {
            // Write your code here.

            if (AutomationFactory.IsAvailable)
            {
                Dispatchers.Main.Invoke(() =>
                {
                    var dialog = new OpenFileDialog();

                    if (dialog.ShowDialog() == true)
                    {
                        byte[] fileBuffer;
                        fileBuffer = new byte[dialog.File.Length];
                        dialog.File.OpenRead().Read(fileBuffer, 0, fileBuffer.Length);

                        this.DiputadoProperty.Curriculum = fileBuffer;
                    }

                });
            }

        }

        partial void OpenFile_Execute()
        {
            // Write your code here.
            if (this.DiputadoProperty.Curriculum != null)
            {
                var file = this.DiputadoProperty.Curriculum;
                string name = @"temp.pdf";
                string dir = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
                if (AutomationFactory.IsAvailable)
                {
                    Dispatchers.Main.Invoke(() =>
                    {
                        if (!Directory.Exists(dir))
                            Directory.CreateDirectory(dir);

                        if (File.Exists(dir + name))
                            File.Delete(dir + name);

                        FileInfo fi = new FileInfo(dir + name);
                        FileStream fs = fi.OpenWrite();
                        fs.Write(file, 0, file.Length);

                        fs.Flush();
                        fs.Close();

                        if (File.Exists(dir + name))
                        {
                            dynamic cmd = AutomationFactory.CreateObject("WScript.Shell");
                            cmd.Run(dir + name, 1, true);
                        }

                    });
                }
                //file.Open();
            }
        }

        partial void AddLegislatura_Execute()
        {        
            // Write your code here.
            var dl = LegislaturaDiputadoes.AddNew();
            dl.Diputado = this.DiputadoProperty;
            dl.Legislatura = Legislaturas.SelectedItem;
        }

        partial void RemoveLegislatura_Execute()
        {
            // Write your code here.
            LegislaturaDiputadoes.DeleteSelected();
        }
    }
}