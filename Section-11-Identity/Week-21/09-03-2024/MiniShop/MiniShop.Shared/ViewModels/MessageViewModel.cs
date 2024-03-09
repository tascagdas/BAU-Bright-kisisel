using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using MiniShop.Shared.ViewModels.IdentityModels;

namespace MiniShop.Shared.ViewModels;

public class MessageViewModel
{
    public int Id { get; set; }
    [DisplayName("Tarih:")] 
    public DateTime SendTime { get; set; } = DateTime.Now;
    [DisplayName("Mesaj:")]
    [Required(ErrorMessage = "Mesaj Boş bırakılamaz")]
    public string Text { get; set; }
    [DisplayName("Cevap:")]
    // [Required(ErrorMessage = "Mesaj Boş bırakılamaz")]
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