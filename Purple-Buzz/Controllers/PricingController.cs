using Microsoft.AspNetCore.Mvc;
using Purple_Buzz.Data;
using Purple_Buzz.Models.Home;
using Purple_Buzz.Models.Pricing;

namespace Purple_Buzz.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            var pricings = _context.Pricing.ToList();
            var pricingsList = new List<PricingVM>();

            foreach (var pricing in pricings)
            {
                var pricingVM = new PricingVM()
                {
                    Name = pricing.Name,
                    Description1 = pricing.Description1,
                    Description2 = pricing.Description2,
                    Description3 = pricing.Description3,
                    Description4 = pricing.Description4,
                    Description5 = pricing.Description5,
                    Price = pricing.Price
                    
                };
                pricingsList.Add(pricingVM);
            }

            var viewModel = new PricingIndexVM
            {
                Pricing = pricingsList
            };

            return View(viewModel);
        }
    }
}
