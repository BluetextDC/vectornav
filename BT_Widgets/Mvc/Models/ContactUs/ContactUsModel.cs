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

namespace BT_Widgets.Mvc.Models.ContactUs
{
    public class ContactUsModel
    {
        public string Link { get; set; }
     
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Company { get; set; }

        public string Email { get; set; }

        public string Message { get; set; }

        public bool SalesSupport { get; set; }

        public bool CustomerSupport { get; set; }

        public bool Agreetorecievenews { get; set; }


       
        public ContactUsViewModel GetViewModel()
        {
            var viewModel = new ContactUsViewModel();

         
            viewModel.FirstName = this.FirstName;
            viewModel.LastName = this.LastName;
            viewModel.Company = this.Company;
            viewModel.Email = this.Email;
            viewModel.Message = this.Message;
            viewModel.SalesSupport = this.SalesSupport;
            viewModel.CustomerSupport = this.CustomerSupport;
            viewModel.Agreetorecievenews = this.Agreetorecievenews;
            viewModel.Link = this.Link;

            return viewModel;
        }
    }
}