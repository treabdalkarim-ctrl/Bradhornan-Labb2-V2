public class Event
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public int MaxParticipants { get; set; }

    public ICollection<Registration> Registrations { get; set; } = new List<Registration>();

}