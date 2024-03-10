namespace MiniShop.Entity.Concrete
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime SendingDate { get; set; } = DateTime.Now;
        public string Text { get; set; }
        public string ToId { get; set; }
        public string ToName { get; set; }
        public string FromId { get; set; }
        public string FromName { get; set; }
        public bool IsRead { get; set; }
        public int RelatedId { get; set; } = 0;
    }
}
