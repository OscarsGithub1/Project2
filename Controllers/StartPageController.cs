using Microsoft.AspNetCore.Mvc;
using Project2.Models.Pages;
using Project2.Models.ViewModels;
using Project2.Controllers;
using Project2.Models.Pages;
using Project2.Models.ViewModels;

namespace Project2.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        public IActionResult Index(StartPage currentPage)
        {
            var model = new StartPageViewModel(currentPage);

            return View(model);
        }
    }
}