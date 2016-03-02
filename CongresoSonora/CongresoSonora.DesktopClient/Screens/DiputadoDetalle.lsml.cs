using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.IO;
using System.Linq;
using System;
using System.Runtime.InteropServices.Automation;
using Microsoft.LightSwitch.Threading;
using System.Windows.Controls;

namespace LightSwitchApplication
{
    public partial class DiputadoDetalle
    {
        partial void Diputado_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Diputado);
        }

        partial void Diputado_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Diputado);
        }

        partial void DiputadoDetalle_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Diputado);
        }

        partial void AddComision_Execute()
        {
            // Write your code here.
            var dc = DiputadoComisions.AddNew();
            dc.Diputado = this.Diputado;
            dc.Comision = Comisions.SelectedItem;
        }

        partial void RemoveComision_Execute()
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

                        this.Diputado.Curriculum = fileBuffer;
                    }

                });
            }

        }

        partial void OpenFile_Execute()
        {
            // Write your code here.
            if (this.Diputado.Curriculum != null)
            {
                var file = this.Diputado.Curriculum;
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
    }
}