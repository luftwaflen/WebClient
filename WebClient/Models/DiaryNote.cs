namespace WebClient.Models;

public class DiaryNote
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public string PressureSYS { get; set; }
    public string PressureDIA { get; set; }
    public string Pulse { get; set; }
    public string Description { get; set; }
}