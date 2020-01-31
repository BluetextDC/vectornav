
using System.ComponentModel;
using System.Web.Mvc;
using BT_Widgets.Mvc.Models.FullWidth5050Carousel;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers.Attributes;

namespace BT_Widgets.Mvc.Controllers
{
    //[EnhanceViewEngines]
    [ControllerToolboxItem(Name = "FullWidth5050Carousel", Title = "FullWidth5050Carousel", SectionName = "Test_BT")]
    public class FullWidth5050CarouselController : Controller
    {
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public FullWidth5050CarouselModel Model
        {
            get
            {
                if (this.model == null)
                    this.model = new FullWidth5050CarouselModel();

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
            //if (m_object.Link != null && m_object.Link.Trim().Length > 0)
            //{
            //    m_object.Link = m_object.Link.Replace("href=", " class=\"btn btn_border3\" href=");
            //}
            return this.View("FullWidth5050Carousel." + this.Template, m_object);
        }

        private FullWidth5050CarouselModel model;
        private string template = "Default";
    }
}