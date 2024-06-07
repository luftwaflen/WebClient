namespace WebClient.Models;

public class Patient
{
    public Guid Id { get; set; }
    public virtual User User { get; set; }
}