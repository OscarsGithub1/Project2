using Project2.Models.Pages;
using Project2.Models.Pages;
using Project2.Models.ViewModels;

namespace Project2.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }

        LayoutModel Layout { get; }

        IContent Section { get; }
    }
}