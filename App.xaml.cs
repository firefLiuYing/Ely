using System.Configuration;
using System.Data;
using System.Windows;
using Ely.Scripts.Frame;

namespace Ely;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private void Application_Startup(object sender, StartupEventArgs e)
    {
        Entry entry = new();
        entry.StartUp();
    }
}