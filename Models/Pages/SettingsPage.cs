using Project2.Models.Pages;
using System.ComponentModel.DataAnnotations;
using static Project2.Globals;

namespace Project2.Models.Pages
{
    [ContentType(
        GUID = "7708B0DD-2FC3-4814-9F30-BE39455E8149",
        GroupName = GroupNames.Specialized
    )]
    [ImageUrl("/gfx/page-type-thumbnail.png")]
    public class SettingsPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10
        )]
        public virtual PageReference MoviesContainer { get; set; }
    }
}