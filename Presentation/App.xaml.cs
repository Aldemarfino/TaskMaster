﻿using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Windows;

namespace Presentation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            PresentationTraceSources.DataBindingSource.Switch.Level = SourceLevels.Off;
        }
    }

}
