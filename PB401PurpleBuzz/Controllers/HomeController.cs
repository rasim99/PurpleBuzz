using Microsoft.AspNetCore.Mvc;
using PB401PurpleBuzz.Data;
using PB401PurpleBuzz.Models.Home;

namespace PB401PurpleBuzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var works = _context.Works.ToList();
            var recentWorks=_context.RecentWorks.ToList();

            var worksList = new List<WorkVM>();
            var recentWorksList=new List<RecentWorkVM>();
            foreach (var item in works)
            {
                var workVM = new WorkVM
                {
                    Description = item.Description,
                    PhotoUrl = item.PhotoUrl,
                    WorkName = item.WorkName
                };
                worksList.Add(workVM);
            }
            foreach (var item in recentWorks)
            {
                var recentWorkVM = new RecentWorkVM
                {
                    WorkName = item.WorkName,
                    Description = item.Description,
                    PhotoUrl = item.PhotoUrl
                };
                recentWorksList.Add(recentWorkVM);
            }
            var model = new HomeIndexVM { Works=worksList ,RecentWorks=recentWorksList };
            return View(model);
        }
    }
}
