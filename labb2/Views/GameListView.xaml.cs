using labb2.Data;
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

            var context = new AppDbContext();
            var service = new GameService(context);
            DataContext = new GameListViewModel(service);
        }
    }
}
