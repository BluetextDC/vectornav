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


namespace BT_Widgets.Mvc.Models.GatedResourceForm
{
    public class GatedResourceFormModel
    {
        public string Link { get; set; }
       
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }  

        public string Message { get; set; }       

        public bool Consent { get; set; }

        public GatedResourceFormViewModel GetViewModel()
        {
            var viewModel = new GatedResourceFormViewModel();

         
            viewModel.Name = this.Name; 
            viewModel.Email = this.Email;
            viewModel.Phone = this.Phone;
            viewModel.Message = this.Message;            
            viewModel.Consent = this.Consent;
            viewModel.Link = this.Link;

            return viewModel;
        }
    }
}