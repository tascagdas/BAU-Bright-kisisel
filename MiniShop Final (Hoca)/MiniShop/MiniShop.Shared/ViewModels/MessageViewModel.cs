using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MiniShop.Shared.ViewModels
{
    public class MessageViewModel
    {
        public int Id { get; set; }
        [DisplayName("Tarih/Saat:")]
        public DateTime SendingDate { get; set; } = DateTime.Now;

        [DisplayName("Mesaj:")]
        [Required(ErrorMessage = "Mesaj boş bırakılmamalıdır.")]
        public string Text { get; set; }

        [DisplayName("Yanıt:")]
        public string ReplyText { get; set; }
        public string ToId { get; set; }

        [DisplayName("Kime:")]
        public string ToName { get; set; }
        public string FromId { get; set; }

        [DisplayName("Kimden:")]
        public string FromName { get; set; }
        public bool IsRead { get; set; }
        public int RelatedId { get; set; } = 0;

        public List<SelectListItem> UserList { get; set; }
    }
}
