using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MiniShop.Shared.ViewModels.IdentityModels;

public class UserViewModel
{
    public string Id { get; set; }
    [DisplayName("Ad")]
    [Required(ErrorMessage = "{0} alaniı boş bırakılamaz!")]
    public string FirstName { get; set; }
    [DisplayName("Soyad")]
    [Required(ErrorMessage = "{0} alaniı boş bırakılamaz!")]
    public string LastName { get; set; }
    [DisplayName("Adres")]
    [Required(ErrorMessage = "{0} alaniı boş bırakılamaz!")]
    public string Address { get; set; }
    [DisplayName("Șehir")]
    [Required(ErrorMessage = "{0} alaniı boş bırakılamaz!")]
    public string City { get; set; }
    [DisplayName("Cinsiyet")]
    [Required(ErrorMessage = "{0} alaniı boş bırakılamaz!")]
    public string Gender { get; set; }
    [DisplayName("Kullaniıcı Adı")]
    [Required(ErrorMessage = "{0} alaniı boş bırakılamaz!")]
    public string UserName { get; set; }
    [DisplayName("E-mail adresi")]
    [Required(ErrorMessage = "{0} alaniı boş bırakılamaz!")]
    public string Email { get; set; }
    [DisplayName("Telefon Numarası")]
    [Required(ErrorMessage = "{0} alaniı boş bırakılamaz!")]
    public string PhoneNumber { get; set; }
    [DisplayName("Doğum Tarihi")]
    [Required(ErrorMessage = "{0} alaniı boş bırakılamaz!")]
    public DateTime? DateOfBirth { get; set; }
}