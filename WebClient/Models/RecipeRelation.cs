namespace WebClient.Models;

public class RecipeRelation
{
    public Guid PatientId { get; set; }
    public Guid DoctorId { get; set; }
    public Guid RecipeId { get; set; }
    public virtual Patient Patient { get; set; }
    public virtual Doctor Doctor { get; set; }
    public virtual Recipe Recipe { get; set; }
}