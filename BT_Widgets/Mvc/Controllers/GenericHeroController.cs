using System.ComponentModel;
using System.Web.Mvc;
using BT_Widgets.Mvc.Models.GenericHero;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers.Attributes;

namespace BT_Widgets.Mvc.Controllers
{
    //[EnhanceViewEngines]
    [ControllerToolboxItem(Name = "GenericHero", Title = "Generic Hero", SectionName = "Blue Text")]
    public class GenericHeroController : Controller
    {
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public GenericHeroModel Model
        {
            get
            {
                if (this.model == null)
                    this.model = new GenericHeroModel();

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
            return this.View("GenericHero." + this.Template, m_object);
        }

        private GenericHeroModel model;
        private string template = "Default";
    }
}
