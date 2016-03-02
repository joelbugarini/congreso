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
    public partial class SintesisNueva
    {
        partial void SintesisNueva_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.SintesisProperty = new Sintesis();
        }

        partial void SintesisNueva_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.SintesisProperty);
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
                        dialog.File.OpenRead().Read(fileBuffer,0,fileBuffer.Length);

                        this.SintesisProperty.Archivo = fileBuffer;
                    }

                });
            }
            
        }

        partial void OpenFile_Execute()
        {
            // Write your code here.
            if (this.SintesisProperty.Archivo != null)
            {
                var file = this.SintesisProperty.Archivo;
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