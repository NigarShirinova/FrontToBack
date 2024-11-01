using Microsoft.AspNetCore.Mvc;
using Purple_Buzz.Data;
using Purple_Buzz.Models.About;
using Purple_Buzz.Models.Home;

namespace Purple_Buzz.Controllers
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
            var worksList = new List<WorksVM>();

            foreach (var work in works)
            {
                var workVM = new WorksVM()
                {
                    Name = work.Name,
                    Description = work.Description,
                    PhotoPath = work.PhotoPath
                };
                worksList.Add(workVM);
            }

            var viewModel = new HomeIndexVM
            {
                Works = worksList
            };

            return View(viewModel);
        }
    }
}
