using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCCore.Models;
using MVCCore.Services;

namespace MVCCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // private readonly IRepository _repository;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IUserService userService /*IRepository repository*/)
        {
            _logger = logger;
            _userService = userService;
            //_repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            await _userService.AddUser("Tom");
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}