namespace UmbracoProject.ViewModels.Common
{
    public class NavigationViewModel
    {
        public int MaxLevel { get; set; }
        public string HomeUrl { get; set; }
        public List<NavigationItemViewModel> NavigationItems { get; set; }
    }
}
