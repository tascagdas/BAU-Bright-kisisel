namespace MiniShop.Shared.ViewModels
{
    public class OrderViewModel
    {
        //Kişisel bilgiler
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Note { get; set; }
        //Ödeme bilgileri
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationMonth { get; set; }
        public string ExpirationYear { get; set; }
        public string Cvc { get; set; }
        public ShoppingCartViewModel ShoppingCart { get; set; }
    }
}
