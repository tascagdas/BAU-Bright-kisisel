using System.ComponentModel.DataAnnotations;

namespace MiniShop.Shared.ComplexTypes
{
    public enum OrderState
    {
        [Display(Name = "Sipariş Alındı")]
        Received=0,
        
        [Display(Name = "Hazırlanıyor")]
        Preparing=1,
        
        [Display(Name = "Gönderildi")]
        Sent=2,
        
        [Display(Name = "Teslim Edildi")]
        Delivered=3
    }
}
