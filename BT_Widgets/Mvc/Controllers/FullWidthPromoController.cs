
using System.ComponentModel;
using System.Web.Mvc;
using BT_Widgets.Mvc.Models.FullWidthPromo;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers.Attributes;

namespace BT_Widgets.Mvc.Controllers
{
    //[EnhanceViewEngines]
    [ControllerToolboxItem(Name = "FullWidthPromo", Title = "Full Width Promo", SectionName = "Blue Text")]
    public class FullWidthPromoController : Controller
    {
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public FullWidthPromoModel Model
        {
            get
            {
                if (this.model == null)
                    this.model = new FullWidthPromoModel();

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
            //FullWidthPromoViewModel m_object = new FullWidthPromoViewModel();
           
        

            var m_object = this.Model.GetViewModel();

            try
            {

                if (m_object.Link != null && m_object.Link.Trim().Length > 0)
                {
                    m_object.Link = m_object.Link.Replace("href=", " class=\"btn btn_border3\" href=");
                }
                else
                { 
                    m_object.Link = string.Empty;

                }
                if (m_object.Title_JpVM  == null)
                {
                    m_object.Title_JpVM = "Title";
                }
                if (m_object.Title_JpVM == null )
                {
                    m_object.Sub_Title_JpVM = "Sub-Title";
                }
                if (m_object.ListItem_ValueVM == null)
                {
                    m_object.ListItem_ValueVM = "Red";
                }
            }
            catch 
            {
                m_object.Link = string.Empty;
                m_object.Title_JpVM = "Title";
                m_object.Sub_Title_JpVM = "Sub-Title";
                m_object.ListItem_ValueVM = "Red";
            }
            return this.View("FullWidthPromo." + this.Template, m_object);
        }

        private FullWidthPromoModel model;
        private string template = "Default";
    }
}