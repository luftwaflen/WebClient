namespace WebClient.Models;

public class Family
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public virtual List<User> FamilyMembers { get; set; }
}