using labb2.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace labb2
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var window = new GameListView();
            window.Show();
        }
    }
}
