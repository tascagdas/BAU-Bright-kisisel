using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MiniShop.Shared.ViewModels.IdentityModels;

public class RegisterViewModel
{
    [DisplayName("Ad")]
    [Required(ErrorMessage = "Lütfen ad alanını boş bırakmayınız.")]
    public string FirstName { get; set; }
    
    [DisplayName("Soyad")]
    [Required(ErrorMessage = "Lütfen soyad alanını boş bırakmayınız.")]
    public string LastName { get; set; }
    
    [DisplayName("Kullaniıcı Adı")]
    [Required(ErrorMessage = "Lütfen kullanıcı adı alanını boş bırakmayınız.")]
    public string UserName { get; set; }
    
    [DisplayName("E-mail")]
    [Required(ErrorMessage = "Lütfen E-Mail alanını boş bırakmayınız.")]
    [DataType(DataType.EmailAddress,ErrorMessage = "Lütfen geçerli bir E-mail adresi giriniz.")]
    public string Email { get; set; }
    
    [DisplayName("Parola")]
    [Required(ErrorMessage = "Lütfen Parola alanını boş bırakmayınız.")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    [DisplayName("Parola Tekrar")]
    [Required(ErrorMessage = "Lütfen Parola Tekrar alanını boş bırakmayınız.")]
    [DataType(DataType.Password)]
    [Compare("Password",ErrorMessage = "Parolalar uyuşmuyor.")]
    public string Repassword { get; set; }
}