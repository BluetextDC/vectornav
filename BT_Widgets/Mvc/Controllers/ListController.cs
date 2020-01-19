//using OpenTK.Graphics.ES11;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Telerik.Sitefinity.Mvc;
using Microsoft.CSharp;
using BT_Widgets.Mvc.Models.List;

namespace BT_Widgets.Mvc.Controllers

{
    /// <summary>
    /// This class represents controller of the SampleList widget
    /// </summary>
    [ControllerToolboxItem(Name = "SampleList", SectionName = "Test_BT", Title = "ListItem")]
    public class ListController : Controller
    {
        #region Public properties

        /// <summary>
        /// Gets or sets the list title.
        /// </summary>
        /// <value>
        /// The list title.
        /// </value>
        public string ListTitle
        {
            get
            {
                return this.listTitle;
            }

            set
            {
                this.listTitle = value;
            }
        }

        /// <summary>
        /// Gets or sets the type of the html elements used for the list.
        /// </summary>
        /// <value>
        /// The type of the list.
        /// </value>
        public string ListType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the list items.
        /// </summary>
        /// <value>
        /// The list items.
        /// </value>
        public string ListItems
        {
            get
            {
                return this.listItems;
            }

            set
            {
                this.listItems = value;
            }
        }

        #endregion 

        #region Actions

        /// <summary>
        /// The default action
        /// </summary>
        /// <returns>The default widget view</returns>
        public ActionResult Index()
        {
            ListModel m_object = new ListModel();
            m_object.ListTitle = "title " + System.DateTime.Now.Second.ToString();
            m_object.ListType = "type  " + System.DateTime.Now.Second.ToString();
            m_object.ListItems = this.DeserializeItems();

            return this.View(m_object);
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Deserialize the items.
        /// </summary>
        /// <returns>The list of items</returns>
        private IList<string> DeserializeItems()
        {
            var serializer = new JavaScriptSerializer();
            IList<string> items = new List<string>();

            if (!string.IsNullOrEmpty(this.ListItems))
                items = serializer.Deserialize<IList<string>>(this.ListItems);

            return items;
        }

        #endregion

        #region Private fields and constants

        /// <summary>
        /// The list title
        /// </summary>
        private string listTitle = "My list title";

        /// <summary>
        /// The list items
        /// </summary>
        private string listItems = "[\"First Item\", \"Second Item\", \"Third Item\"]";

        #endregion
    }
}