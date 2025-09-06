using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WEB_353504_LEBEDEVA.UI.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private readonly ILogger<CartViewComponent> _logger;

        public CartViewComponent(ILogger<CartViewComponent> logger)
        {
            _logger = logger;
        }

        public IViewComponentResult Invoke()
        {
            var cartTotal = 00.0m;
            var itemsCount = 0;

            _logger.LogInformation("CartViewComponent executed with total: {Total}, count: {Count}", cartTotal, itemsCount);

            return View(new CartViewModel
            {
                Total = cartTotal,
                ItemsCount = itemsCount
            });
        }
    }
    public class CartViewModel
    {
        public decimal Total { get; set; }
        public int ItemsCount { get; set; }
    }
}
