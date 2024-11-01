using Microsoft.AspNetCore.Mvc;
using PB401PurpleBuzz.Data;
using PB401PurpleBuzz.Models.Pricing;

namespace PB401PurpleBuzz.Controllers
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
            var plans = _context.Plans.ToList();
            var plansList = new List<PlanVM>();
            foreach (var plan in plans)
            {
                var planVM = new PlanVM
                {
                    PlanType = plan.PlanType,
                    Price = plan.Price,
                    UserCount = plan.UserCount,
                    Capacity = plan.Capacity,
                    Source = plan.Source,
                    Support = plan.Support,
                    Addition = plan.Addition
                };
                plansList.Add(planVM);  
            }
            var model=new PricingIndexVM { Plans = plansList };
            return View(model);
        }
    }
}
