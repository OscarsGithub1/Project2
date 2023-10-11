using EPiServer.Web.Mvc;
using Project2.Models.Pages;
using Project2.Models.Pages;

namespace Project2.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
    }
}