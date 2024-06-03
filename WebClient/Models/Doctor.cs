namespace WebClient.Models;

public class Doctor
{
    public Guid Id { get; set; }
    public virtual User User { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public virtual List<Patient> Patients { get; set; }
    public virtual List<RecipeRelation> RecipeRelations { get; set; }
}