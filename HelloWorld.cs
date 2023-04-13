using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using Sdl.TranslationStudioAutomation.IntegrationApi.Extensions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HelloWorldPlugin
{
    [Action("HelloWorldPlugin", Icon = "ExportToExcel")]
    public class HelloWorldPlugin : AbstractAction
    {
        protected override void Execute()
        {
            MessageBox.Show("Hello, World!");
        }
    }
}
