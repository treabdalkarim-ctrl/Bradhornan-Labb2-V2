namespace labb2.Domain
{
    public class Member

    {
public int Id { get; set; }
public string Name { get; set; } = string.Empty;
public string Email { get; set; } = string.Empty; 
public bool IsActive { get; set; }
public DateTime JoinedDate { get; set; }
public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
}
}