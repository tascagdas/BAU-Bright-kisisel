using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using MiniShop.Shared.ViewModels.IdentityModels;

namespace MiniShop.Shared.ViewModels;

public class MessageViewModel
{
    public int Id { get; set; }
    public DateTime SendTime { get; set; }
    [DisplayName("Mesaj:")]
    [Required(ErrorMessage = "Mesaj Boş bırakılamaz")]
    public string Text { get; set; }
    public string ToId { get; set; }
    [DisplayName("Kime:")]
    public string ToName { get; set; }
    public string FromId { get; set; }
    [DisplayName("Kimden:")]
    public string FromName { get; set; }
    public bool IsRead { get; set; }
    public List<SelectListItem> UserList { get; set; }
}