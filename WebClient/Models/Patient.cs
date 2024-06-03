namespace WebClient.Models;

public class Patient
{
    public Guid Id { get; set; }
    public virtual User User { get; set; }
    public virtual Doctor? PersonalDoctor { get; set; }
    public virtual List<RecipeRelation> RecipeRelations { get; set; }
}