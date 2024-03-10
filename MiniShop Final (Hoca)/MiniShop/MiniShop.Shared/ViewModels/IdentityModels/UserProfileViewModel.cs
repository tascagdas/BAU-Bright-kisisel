namespace MiniShop.Shared.ViewModels.IdentityModels
{
    public class UserProfileViewModel
    {
        public UserViewModel User { get; set; }
        public List<AdminOrderViewModel> Orders { get; set; }
    }
}
