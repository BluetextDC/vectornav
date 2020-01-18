using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Modules;
using Telerik.Sitefinity.Modules.Libraries;
using Telerik.Sitefinity.Services;
using SfImage = Telerik.Sitefinity.Libraries.Model.Image;

namespace BT_Widgets.Mvc.Models.CTA
{
    public class CTAModel
    {
        public string Link { get; set; }

        
        public CTAViewModel GetViewModel()
        {
            var viewModel = new CTAViewModel();
            viewModel.Link = this.Link;
            return viewModel;
        }
    }
}