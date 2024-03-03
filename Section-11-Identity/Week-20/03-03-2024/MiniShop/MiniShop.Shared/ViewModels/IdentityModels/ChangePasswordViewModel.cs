using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MiniShop.Shared.ViewModels.IdentityModels;

public class ChangePasswordViewModel
{
    [DisplayName("Eski sifreniz")]
    [Required(ErrorMessage = "{0} alani bos birakilamaz!")]
    [DataType(DataType.Password)]
    public string OldPassword { get; set; }
    [DisplayName("Yeni sifreniz")]
    [Required(ErrorMessage = "{0} alani bos birakilamaz!")]
    [DataType(DataType.Password)]
    public string NewPassword { get; set; }
    [DisplayName("Tekrar Yeni sifreniz")]
    [Required(ErrorMessage = "{0} alani bos birakilamaz!")]
    [DataType(DataType.Password)]
    [Compare("NewPassword", ErrorMessage = "yeni sifreler ayni degil!")]
    public string ReNewPassword { get; set; }
}