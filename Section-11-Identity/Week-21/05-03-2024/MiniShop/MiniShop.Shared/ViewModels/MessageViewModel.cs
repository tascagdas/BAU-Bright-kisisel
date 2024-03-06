using MiniShop.Shared.ViewModels.IdentityModels;

namespace MiniShop.Shared.ViewModels;

public class MessageViewModel
{
    public MessageDetailsViewModel MessageDetails { get; set; }
    public List<UserViewModel> UserList { get; set; }
}