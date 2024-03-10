using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MiniShop.Shared.ViewModels.IdentityModels;

public class ResetPasswordViewModel
{
    public string UserId { get; set; }
    public string TokenCode { get; set; }
    [DisplayName("Parola")]
    [Required(ErrorMessage = "{0} alani bos birakilamaz")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [DisplayName("Parola")]
    [Required(ErrorMessage = "{0} alani bos birakilamaz")]
    [DataType(DataType.Password)]
    [Compare("Password",ErrorMessage = "sifreler eslesmedi!")]
    public string RePassword { get; set; }
}