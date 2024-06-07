using WebClient.Pages.Patient;

namespace WebClient.Models;

public class User
{
    public Guid Id { get; set; }
    public string Login { get; set; }
    public UserRoles Role { get; set; }
    public virtual Guid? FamilyId { get; set; }
    public virtual FamilyRole? FamilyRole { get; set; }
}