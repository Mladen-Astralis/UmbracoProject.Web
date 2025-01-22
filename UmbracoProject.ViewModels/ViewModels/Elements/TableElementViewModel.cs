using UmbracoProject.PublishedContentModels.Models;

namespace UmbracoProject.ViewModels.ViewModels.Elements
{
    public class TableElementViewModel : IBlockListViewModel
    {
        public TableElementViewModel(TableElement model)
        {
            TableText = model.TableText.ToHtmlString();
        }

        public string TableText { get; }
    }
}
