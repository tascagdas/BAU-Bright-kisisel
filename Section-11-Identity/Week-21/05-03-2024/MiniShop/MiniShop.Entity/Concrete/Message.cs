namespace MiniShop.Entity.Concrete;

public class Message
{
    public int Id { get; set; }
    public DateTime SendTime { get; set; }
    public string Text { get; set; }
    public string ToId { get; set; }
    public string FromId { get; set; }
    public bool IsRead { get; set; }
}