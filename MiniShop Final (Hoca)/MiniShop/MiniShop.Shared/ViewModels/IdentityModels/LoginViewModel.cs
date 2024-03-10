using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MiniShop.Shared.ViewModels.IdentityModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Boş bırakılamaz")]
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Boş bırakılamaz")]
        [DisplayName("Parola")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Beni hatırla")]
        public bool RememberMe { get; set; }
    }
}
