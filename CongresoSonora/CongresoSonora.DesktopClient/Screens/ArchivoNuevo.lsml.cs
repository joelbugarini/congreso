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
    public partial class ArchivoNuevo
    {
        partial void ArchivoNuevo_InitializeDataWorkspace(List<IDataService> saveChangesTo)
        {
            // Write your code here.
            this.ArchivoProperty = new Archivo();
        }

        partial void ArchivoNuevo_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.ArchivoProperty);
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

                        this.ArchivoProperty.Documento = fileBuffer;
                    }

                });
            }

        }

        partial void OpenFile_Execute()
        {
            // Write your code here.
            if (this.ArchivoProperty.Documento != null)
            {
                var file = this.ArchivoProperty.Documento;
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