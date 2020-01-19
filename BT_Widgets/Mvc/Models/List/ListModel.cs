using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Modules;
using Telerik.Sitefinity.Modules.Libraries;
using Telerik.Sitefinity.Services;
using SfImage = Telerik.Sitefinity.Libraries.Model.Image;

namespace BT_Widgets.Mvc.Models.List
{
    public class ListModel
    {
        public string ListTitle { get; set; }
     
        public string ListType { get; set; }

        public IList<string> ListItems { get; set; }

       
    }
}