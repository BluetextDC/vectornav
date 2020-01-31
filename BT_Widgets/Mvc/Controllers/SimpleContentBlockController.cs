﻿using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;

namespace SimpleContentBlock.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "SimpleContentBlock", Title = "Simple Content Block", SectionName = "Test_BT")]
    public class SimpleContentBlockController : Controller
    {
        public string Text { get; set; }

        public ActionResult Index()
        {
            return this.Content(this.Text);
        }
    }
}