namespace WebClient.Models;

public class Recipe
{
    public Guid Id { get; set; }
    public string Text { get; set; }
    public virtual RecipeRelation RecipeRelation { get; set; }
}