namespace WebClient.Models;

public class Diary
{
    public Guid Id { get; set; }
    public Guid PatientId { get; set; }
    public virtual Patient Patient { get; set; }
    public virtual List<DiaryNote> DiaryNotes { get; set; }
}