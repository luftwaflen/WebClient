namespace WebClient.Requests;

public class AddMessageRequest
{
    public string ChatId { get; set; }
    public string SenderId { get; set; }
    public string Text { get; set; }
}