namespace WebClient.Responses;

public class MessageResponse
{
    public Guid Id { get; set; }
    public string Sender { get; set; }
    public string Text { get; set; }
}