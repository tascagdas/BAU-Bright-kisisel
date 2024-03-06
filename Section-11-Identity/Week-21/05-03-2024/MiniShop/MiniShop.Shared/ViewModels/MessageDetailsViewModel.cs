namespace MiniShop.Shared.ViewModels;

public class MessageDetailsViewModel
{
    public int Id { get; set; }
    public DateTime SendTime { get; set; }
    public string Text { get; set; }
    public string ToId { get; set; }
    public string ToName { get; set; }
    public string FromId { get; set; }
    public string FromName { get; set; }
    public bool IsRead { get; set; }
}