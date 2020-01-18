﻿using BT_Widgets.Mvc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Telerik.Sitefinity.Frontend.Mvc.Infrastructure.Controllers;
using Telerik.Sitefinity.Mvc;

namespace BT_Widgets.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "CustomImage", Title = "Image", SectionName = "Blue Text", ModuleName = "Libraries")]
    public class CustomImageController: Controller
    {
        /// <summary>
        /// Gets the Image widget model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public virtual CustomImageModel Model
        {
            get
            {
                if (this.model == null)
                    this.model = new CustomImageModel();

                return this.model;
            }
        }

        #region Actions

        /// <summary>
        /// Renders appropriate view.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult" />.
        /// </returns>
        public ActionResult Index()
        {
            var viewModel = this.Model.GetViewModel();
            
            return View("Default", viewModel);
        }

        #endregion

        #region Private fields

        private CustomImageModel model;

        #endregion
    }
}
