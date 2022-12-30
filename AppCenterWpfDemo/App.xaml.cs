using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter;
using System.Windows;

namespace AppCenterWpfDemo
{
    /// <summary>
    /// Logica di interazione per App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            AppCenter.LogLevel = LogLevel.Verbose;
            AppCenter.Start("{Secret}", typeof(Analytics), typeof(Crashes));
        }
    }
}