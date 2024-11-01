using Microsoft.AspNetCore.Mvc;
using PB401PurpleBuzz.Data;
using PB401PurpleBuzz.Entities;
using PB401PurpleBuzz.Models.About;

namespace PB401PurpleBuzz.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController( AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var teamMembers= _context.TeamMembers.ToList();
            var aboutServices= _context.AboutServices.ToList();
            var teamMembersList=new List<TeamMemberVM>();
            var aboutServicesList=new List<AboutServiceVM>();
            foreach (var member in teamMembers)
            {
                var teamMemberVM = new TeamMemberVM
                {
                    PhotoUrl = member.PhotoUrl,
                    Name = member.Name,
                    Surname = member.Surname,
                    Position = member.Position
                };
                teamMembersList.Add(teamMemberVM);
            }

            foreach (var service in aboutServices)
            {
                var aboutServiceVM = new AboutServiceVM
                {
                    Icon = service.Icon,
                    Title = service.Title,
                    Description = service.Description
                };
                aboutServicesList.Add(aboutServiceVM);
            }
            var model = new AboutIndexVM { TeamMembers = teamMembersList,AboutServices=aboutServicesList };
            return View(model);
        }
    }
}
