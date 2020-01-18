using BT_Widgets.Mvc.Models.FullwidthStatistics;
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

namespace BT_Widgets.Mvc.Models.FullwidthStatistics
{
    public class FullwidthStatisticsModel
    {
        //public string Link { get; set; }  
        public string Title_Jp { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public string ListItem_Value { get; set; }


        public FullwidthStatisticsViewModel GetViewModel()
        {
            var viewModel = new FullwidthStatisticsViewModel();

            //viewModel.Link = this.Link;
            viewModel.Title_JpVM = this.Title_Jp;
            viewModel.ListItem_ValueVM = this.ListItem_Value;
            viewModel.Value = this.Value;
            viewModel.Description = this.Description;
            return viewModel;
        }
    }
}