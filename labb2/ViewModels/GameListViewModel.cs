using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using labb2.Domain;
using labb2.Services;
using System.Collections.ObjectModel;

namespace labb2.ViewModels
{
    public partial class GameListViewModel : ObservableObject
    {
        private readonly GameService _service;

        [ObservableProperty]
        private Game? selectedGame;

        public ObservableCollection<Game> Games { get; } = new();

        public GameListViewModel(GameService service)
        {
            _service = service;
            LoadGamesCommand = new AsyncRelayCommand(LoadGamesAsync);
            AddGameCommand = new AsyncRelayCommand(AddGameAsync);
            DeleteGameCommand = new AsyncRelayCommand(DeleteGameAsync);
        }

        public IAsyncRelayCommand LoadGamesCommand { get; }
        public IAsyncRelayCommand AddGameCommand { get; }
        public IAsyncRelayCommand DeleteGameCommand { get; }

        private async Task LoadGamesAsync()
        {
            Games.Clear();
            var items = await _service.GetAllAsync();
            foreach (var g in items)
                Games.Add(g);
        }

        private async Task AddGameAsync()
        {
            var game = new Game
            {
                Title = "Nytt spel",
                Category = "Okänd",
                MinPlayers = 2,
                MaxPlayers = 4
            };

            await _service.AddAsync(game);
            await LoadGamesAsync();
        }

        private async Task DeleteGameAsync()
        {
            if (SelectedGame == null)
                return;

            await _service.DeleteAsync(SelectedGame);
            await LoadGamesAsync();
        }
    }
}