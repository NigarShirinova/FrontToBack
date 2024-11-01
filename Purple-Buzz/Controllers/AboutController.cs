using Microsoft.AspNetCore.Mvc;
using Purple_Buzz.Data;
using Purple_Buzz.Models.About;

namespace Purple_Buzz.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;
        public AboutController(AppDbContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            var teamMembers = _context.TeamMembers.ToList();
            var teamMembersList = new List<TeamMemberVM>();

            var aims = _context.Aims.ToList();
            var aimsList = new List<AimVM>();

            foreach(var aim in aims)
            {
                var aimVM = new AimVM()
                {
                    Name = aim.Name,
                    Description = aim.Description,
                    Icon = aim.Icon
                };
                aimsList.Add(aimVM);
            }

            foreach(var teamMember in teamMembers)
            {
                var teamMemberVM = new TeamMemberVM()
                {
                    Name = teamMember.Name,
                    Surname = teamMember.Surname,
                    PhotoPath = teamMember.PhotoPath,
                    Position = teamMember.Position         
                };
                teamMembersList.Add(teamMemberVM);

                
            }
            var viewModel = new AboutIndexVM
            {
                TeamMembers = teamMembersList,
                Aims = aimsList
            };
            return View(viewModel);
        }
    }
}
