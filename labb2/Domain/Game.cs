public class Game
{
    public int Id { get; set; }
    public string? Title { get; set; } 
    public string? Category { get; set; } 
    public int MinPlayers { get; set; }
    public int MaxPlayers { get; set; }
    public int PlayTimeMinutes { get; set; }
    public bool IsResvered { get; set; }
}