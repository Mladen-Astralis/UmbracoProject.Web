using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using J2N.Collections.Generic;
using UmbracoProject.PublishedContentModels.Models;

namespace UmbracoProject.ViewModels.ViewModels.Pages
{
    public class AboutUsPageViewModel
    {
        public AboutUsPageViewModel(AboutUs model)
        {
            Title = model.Title;
            Description = model.Description.ToHtmlString();
            DateAndTime = model.DateAndTime.ToString("dd/MM/yyyy H:mm");
            DropDown = model.DropdownList;
            DropDownMultiple = model.DropdownListMultiple;
        }

        public string Title { get; }
        public string Description { get; }
        public string DateAndTime { get; }
        public string DropDown { get; }
        public IEnumerable<string> DropDownMultiple { get; }
    }
}
