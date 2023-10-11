using Project2.Models.Pages;
using System.ComponentModel.DataAnnotations;
using static Project2.Globals;
using Project2.Models.Pages;

namespace Project2.Models.Pages
{
    [ContentType(
        GUID = "9CAB9C24-C847-4787-9352-06F59DA9A684",
        GroupName = GroupNames.Specialized
    )]
    public class StartPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content
        )]
        public virtual string Heading { get; set; } = string.Empty;
    }
}