using WebClient.Pages.Patient;

namespace WebClient.Models;

public class User
{
    public Guid Id { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public UserRoles Role { get; set; }
    public virtual Family? Family { get; set; }
    public virtual FamilyRole? FamilyRole { get; set; }
}