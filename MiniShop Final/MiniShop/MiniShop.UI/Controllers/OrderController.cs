using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ComplexTypes;
using MiniShop.Shared.ViewModels;

namespace MiniShop.UI.Controllers;

public class OrderController : Controller
{
    private readonly UserManager<User> _userManager;
    private readonly IShoppingCartService _shoppingCartManager;
    private readonly IOrderService _orderManager;
    private readonly IShoppingCartItemService _shoppingCartItemManager;

    public OrderController(UserManager<User> userManager, IShoppingCartService shoppingCartManager,
        IOrderService orderManager, IShoppingCartItemService shoppingCartItemManager)
    {
        _userManager = userManager;
        _shoppingCartManager = shoppingCartManager;
        _orderManager = orderManager;
        _shoppingCartItemManager = shoppingCartItemManager;
    }

    //Login olmus kullanicinin gecmis siparislerini gosterecek.
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Checkout()
    {
        var userId = _userManager.GetUserId(User);
        var user = await _userManager.FindByIdAsync(userId);
        var shoppingCart = await _shoppingCartManager.GetShoppingCartByUserIdAsync(userId);

        OrderViewModel orderViewModel = new OrderViewModel
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Address = user.Address,
            City = user.City,
            Email = user.Email,
            PhoneNumber = user.PhoneNumber,
            Note = "Lutfen hizli gonderin :))",
            CardNumber = "5528790000000008",
            CardName = "Sezen Aksu",
            ExpirationMonth = "8",
            ExpirationYear = "2028",
            Cvc = "343",
            ShoppingCart = shoppingCart.Data
        };
        orderViewModel.ShoppingCart = shoppingCart.Data;
        return View(orderViewModel);
    }

    [HttpPost]
    public async Task<IActionResult> Checkout(OrderViewModel orderViewModel)
    {
        var userId = _userManager.GetUserId(User);
        var shoppingCart = await _shoppingCartManager.GetShoppingCartByUserIdAsync(userId);
        orderViewModel.ShoppingCart = shoppingCart.Data;

        //Odeme islemi basliyor. (iyzico)

        if (ModelState.IsValid)
        {
            // yapilacak odeme isteginin authorization secenekleri icin nesne yaratiliyor.

            Options options = new Options();
            options.ApiKey = "sandbox-UlaILFwQQUCQA648QP1e4xzwppazrJge";
            options.SecretKey = "sandbox-nj7t2SyzWlCzvOupNbwNm9U6nK4ipLRe";
            options.BaseUrl = "https://sandbox-api.iyzipay.com";


            //yapilacak odeme icin nesne yaratiliyor.

            CreatePaymentRequest request = new CreatePaymentRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "Tascagdas-MiniShopApp";
            request.Price = orderViewModel.ShoppingCart.TotalPrice().ToString().Replace(",", ".");
            request.PaidPrice = orderViewModel.ShoppingCart.TotalPrice().ToString().Replace(",", ".");
            request.Currency = Currency.TRY.ToString();
            request.Installment = 1;
            request.BasketId = orderViewModel.ShoppingCart.Id.ToString();
            request.PaymentChannel = PaymentChannel.WEB.ToString();
            request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

            // odemenin yapilacagi kart icin nesne yaratiliyor.

            PaymentCard paymentCard = new PaymentCard();
            paymentCard.CardHolderName = orderViewModel.CardName;
            paymentCard.CardNumber = orderViewModel.CardNumber;
            paymentCard.ExpireMonth = orderViewModel.ExpirationMonth;
            paymentCard.ExpireYear = orderViewModel.ExpirationYear;
            paymentCard.Cvc = orderViewModel.Cvc;
            paymentCard.RegisterCard = 0;
            request.PaymentCard = paymentCard;


            //Musteri bilgileri icin nesne yaratilip requestin icine konuluyor.

            Buyer buyer = new Buyer();
            buyer.Id = userId;
            buyer.Name = orderViewModel.FirstName;
            buyer.Surname = orderViewModel.LastName;
            buyer.GsmNumber = orderViewModel.PhoneNumber;
            buyer.Email = orderViewModel.Email;
            buyer.IdentityNumber = "74300864791";
            buyer.LastLoginDate = "2015-10-05 12:43:35";
            buyer.RegistrationDate = "2013-04-21 15:12:09";
            buyer.RegistrationAddress = orderViewModel.Address;
            buyer.Ip = "85.34.78.112";
            buyer.City = orderViewModel.City;
            buyer.Country = "Turkiye";
            buyer.ZipCode = "34732";
            request.Buyer = buyer;


            // fatura ve kargo Adresi kisimlari degistirilmedi...
            Address shippingAddress = new Address();
            shippingAddress.ContactName = "Jane Doe";
            shippingAddress.City = "Istanbul";
            shippingAddress.Country = "Turkey";
            shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            shippingAddress.ZipCode = "34742";
            request.ShippingAddress = shippingAddress;

            Address billingAddress = new Address();
            billingAddress.ContactName = "Jane Doe";
            billingAddress.City = "Istanbul";
            billingAddress.Country = "Turkey";
            billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
            billingAddress.ZipCode = "34742";
            request.BillingAddress = billingAddress;


            // sepet urunleri icin nesne yaratiliyor.

            List<BasketItem> basketItems = new List<BasketItem>();
            BasketItem basketItem;
            foreach (var item in orderViewModel.ShoppingCart.ShoppingCartItems)
            {
                basketItem = new BasketItem();
                basketItem.Id = item.ProductId.ToString();
                basketItem.Name = item.ProductName;
                basketItem.Category1 = "Elektronik";
                basketItem.Category2 = "";
                basketItem.ItemType = BasketItemType.PHYSICAL.ToString();
                basketItem.Price = (item.ProductPrice * item.Quantity).ToString().Replace(",", ".");
                basketItems.Add(basketItem);
            }

            request.BasketItems = basketItems;

            Payment payment = Payment.Create(request, options);


            if (payment.Status == "success")
            {
                //eger odeme basarili ise artik siparisi kendi veri tabanimiza kaydediyoruz.
                Order order = new Order
                {
                    OrderNumber = payment.PaymentId,
                    UserId = userId,
                    FirstName = orderViewModel.FirstName,
                    LastName = orderViewModel.LastName,
                    Address = orderViewModel.Address,
                    City = orderViewModel.City,
                    PhoneNumber = orderViewModel.PhoneNumber,
                    Email = orderViewModel.Email,
                    Note = orderViewModel.Note,
                    PaymentType = PaymentType.CreditCard,
                    OrderState = OrderState.Received,
                    ConversationId = payment.ConversationId,
                    PaymentId = payment.PaymentId,
                    OrderDate = DateTime.Now,
                    OrderDetails = shoppingCart.Data.ShoppingCartItems.Select(x => new OrderDetail
                    {
                        ProductId = x.ProductId,
                        Price = x.ProductPrice,
                        Quantity = x.Quantity
                    }).ToList()
                };
                await _orderManager.CreateAsync(order);
                await _shoppingCartItemManager.ClearShoppingCartAsync(shoppingCart.Data.Id);
                return Redirect("~/");
            }

            ModelState.AddModelError("", payment.ErrorMessage);
        }

        return View(orderViewModel);
    }
}