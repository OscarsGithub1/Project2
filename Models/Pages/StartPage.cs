using EPiServer.Web;
using Project2.Models.Pages;
using System.ComponentModel.DataAnnotations;
using static Project2.Globals;

namespace Project2.Models.Pages
{
    [ContentType(
        GUID = "2B81E893-1E14-4B4E-B9EC-FEAD0F29ABDD",
        GroupName = GroupNames.Specialized,
        DisplayName = "Start",
        Description = "This is a start template"
    )]
    [AvailableContentTypes(Availability.Specific,
        Include = new[]
        {
            typeof(SettingsPage)
        }
    )]
    [ImageUrl("/gfx/page-type-thumbnail.png")]
    public class StartPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10,
            Name = "Image",
            Description = "This is an image"
        )]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20
        )]
        public virtual string Heading { get; set; } = string.Empty;

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30
        )]
        [UIHint(UIHint.Textarea)]
        public virtual string Preamble { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 40
        )]
        public virtual XhtmlString MainBody { get; set; }
    }
}