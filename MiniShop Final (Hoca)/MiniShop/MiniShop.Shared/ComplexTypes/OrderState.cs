using System.ComponentModel.DataAnnotations;

namespace MiniShop.Shared.ComplexTypes
{
    public enum OrderState
    {
        [Display(Name = "Sipariş alındı")]
        Recieved = 0,

        [Display(Name = "Hazırlanıyor")]
        Preparing = 1,

        [Display(Name = "Gönderildi")]
        Sent = 2,

        [Display(Name = "Teslim edildi")]
        Delivered = 3
    }
}
