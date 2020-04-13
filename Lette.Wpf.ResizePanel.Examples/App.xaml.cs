using System.Windows;

namespace Lette.Wpf.ResizePanel.Examples
{
    public partial class App
    {
        private void OnApplicationStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
