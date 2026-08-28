using labb2.Services;
using labb2.ViewModels;
using System.Windows;

namespace labb2.Views
{
    public partial class GameListView : Window
    {
        public GameListView()
        {
            InitializeComponent();

            var service = new GameService();
            DataContext = new GameListViewModel(service);
        }
    }
}
