

using System.ComponentModel;
using System.Web.Mvc;
using BT_Widgets.Mvc.Models.ContactUs;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers.Attributes;

namespace BT_Widgets.Mvc.Controllers
{
    //[EnhanceViewEngines]
    [ControllerToolboxItem(Name = "ContactUs", Title = "ContactUs", SectionName = "Blue Text")]
    public class ContactUsController : Controller
    {
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public ContactUsModel Model
        {
            get
            {
                if (this.model == null)
                    this.model = new ContactUsModel();

                return this.model;
            }
        }

        public string Template
        {
            get { return this.template; }
            set { this.template = value; }
        }

        public ActionResult Index()
        {
            var m_object = this.Model.GetViewModel();
            if (m_object.Link != null && m_object.Link.Trim().Length > 0)
            {
                m_object.Link = m_object.Link.Replace("href=", " class=\"btn btn_border2\" href=");
            }
            return this.View("ContactUs." + this.Template, m_object);
        }

        private ContactUsModel model;
        private string template = "Default";
    }
}

