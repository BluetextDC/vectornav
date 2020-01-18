using BT_Widgets.Mvc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace BT_Widgets.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "PageSelectorInDesigner", Title = "PageSelectorInDesigner", SectionName = "Test_BT")]
    public class PageSelectorInDesignerController : Controller
    {
        /// <summary> 
        /// Gets or sets the message.
        /// </summary>
        [Category("String Properties")]
        public string Message 
        { 
            get; 
            set; 
        }

        [Category("String Properties")]
        public string SelectedPageId
        {
            get;
            set;
        }

        [Category("String Properties")]
        public string SelectedPage
        {
            get;
            set;
        }

        /// <summary> 
        /// This is the default Action. 
        /// </summary> 
        public ActionResult Index()
        {
            
            var model = new PageSelectorInDesignerModel();

            if (string.IsNullOrEmpty(this.Message))
            {
                model.Message = "Hello, World!";
            }

            else
            {
                model.Message = this.Message;
            }

            return View("Default", model);
        }
    }
}