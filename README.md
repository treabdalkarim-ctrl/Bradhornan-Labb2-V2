# Labb 2 – WPF + Entity Framework Core

Detta projekt är en WPF‑applikation byggd med MVVM‑mönstret och Entity Framework Core.
Syftet är att hantera spel, med funktioner för att lista, lägga till och ta bort spel.

## Funktioner
- Visa alla spel från databasen
- Lägga till nytt spel
- Ta bort valt spel
- Automatisk uppdatering av listan efter ändringar
- MVVM‑struktur med ViewModels, Views och Services
- Entity Framework Core med SQLite‑databas

## Projektstruktur
labb2/
├── Data/                # AppDbContext + EF-konfiguration
├── Domain/              # Modeller (Game, Member, Event, Registration)
├── Services/            # GameService för databasoperationer
├── ViewModels/          # GameListViewModel (MVVM)
├── Views/               # GameListView.xaml (GUI)
├── App.xaml             # Startkonfiguration
└── App.xaml.cs          # OnStartup → öppnar GameListView

Code:
## Tekniker
- C#
- WPF
- MVVM (CommunityToolkit.Mvvm)
- Entity Framework Core
- SQLite

## Kör projektet
1. Öppna projektet i Visual Studio
2. Bygg projektet (`Ctrl + Shift + B`)
3. Starta (`F5`)
4. Applikationen öppnar GameListView automatiskt

## Databas
Projektet använder en lokal SQLite‑databas som skapas automatiskt av EF Core.

## Författare
Tre Abdalkarim
