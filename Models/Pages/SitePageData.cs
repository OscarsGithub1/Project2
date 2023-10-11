using static Project2.Globals;
using System.ComponentModel.DataAnnotations;

namespace Project2.Models.Pages
{
    public abstract class SitePageData : PageData
    {
        [Display(
            GroupName = GroupNames.MetaData,
            Order = 100
        )]
        [CultureSpecific]
        public virtual string MetaTitle
        {
            get
            {
                var metaTitle = this.GetPropertyValue(p => p.MetaTitle);

                return !string.IsNullOrEmpty(metaTitle) ? metaTitle : PageName;
            }

            set => this.SetPropertyValue(p => p.MetaTitle, value);
        }
    }
}