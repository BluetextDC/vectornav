using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.Web.Script.Serialization;
using Telerik.Sitefinity.Mvc;
using SfImage = Telerik.Sitefinity.Libraries.Model.Image;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Modules;
using Telerik.Sitefinity.Modules.Libraries;
using Telerik.Sitefinity.Services;

namespace BT_Widgets.Mvc.Controllers
{
    /// <summary>
    /// This class represents controller of the SampleList widget
    /// </summary>
    [ControllerToolboxItem(Name = "SampleList", SectionName = "Test_BT", Title = "Sample List")]
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
        public ListMode ListType
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
        public string ImageId
        {
            get
            {
                return this.imageId;
            }

            set
            {
                this.imageId = value;
            }
        }
        public string Link_Single { get; set; }
        public string Link { get; set; }
        public Guid? ImageId_Single
        {
            get;
            set;
        }
        public string Description { get => description; set => description = value; }
        #endregion

        #region Actions

        /// <summary>
        /// The default action
        /// </summary>
        /// <returns>The default widget view</returns>
        public ActionResult Index()
        {
            int cnt = 0;
            List<Employee> m_ListObject = new List<Employee>();
            this.ViewBag.ListTitle = this.ListTitle;
            this.ViewBag.ListType = this.ListType;
           
            foreach (var strval in this.DeserializeItems())
            {
                Employee m_object = new Employee();
                m_object.title = strval;
               
                m_object.GetImageSelected();
                m_ListObject.Add(m_object);
            }
            cnt = 0;
            foreach (var strval in this.DeserializeDescription())
            {
                m_ListObject[cnt].description = strval;
                cnt++;
            }
            cnt = 0;
            foreach (var strval in this.DeserializeImageId())
            {
                if (strval == null || strval.Trim().Length==0)
                {
                    cnt++;
                    continue;
                }
                try
                {
                    m_ListObject[cnt].ImageId = new Guid(strval);
                    m_ListObject[cnt].GetImageSelected();
                }
                catch 
                { 
                    //
                }
                cnt++;
            }
            cnt = 0;
            foreach (var strval in this.DeserializeLinks())
            {
                if (strval == null || strval.Trim().Length == 0)
                {
                    cnt++;
                    continue;
                }
                m_ListObject[cnt].CTALink = strval;
                
                cnt++;
            }
            this.ViewBag.ListItems_Obj = m_ListObject;

            return this.View();
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
        private IList<string> DeserializeDescription()
        {
            var serializer = new JavaScriptSerializer();
            IList<string> items = new List<string>();

            if (!string.IsNullOrEmpty(this.Description))
                items = serializer.Deserialize<IList<string>>(this.Description);

            return items;
        }
        private IList<string> DeserializeImageId()
        {
            var serializer = new JavaScriptSerializer();
            IList<string> items = new List<string>();

            if (!string.IsNullOrEmpty(this.ImageId))
                items = serializer.Deserialize<IList<string>>(this.ImageId);

            return items;
        }

        private IList<string> DeserializeLinks()
        {
            var serializer = new JavaScriptSerializer();
            IList<string> items = new List<string>();

            if (!string.IsNullOrEmpty(this.Link))
                items = serializer.Deserialize<IList<string>>(this.Link);

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
        private string listItems = string.Empty;// "[\"First Item\", \"Second Item\", \"Third Item\"]";
        private string description = string.Empty;// "[\"desc 1\", \"desc2\", \"desc 3\"]";
        private string imageId = string.Empty;//"[\"37fca50d-d127-4b4e-9011-4964aaa94482\", \"37fca50d-d127-4b4e-9011-4964aaa94482\", \"37fca50d-d127-4b4e-9011-4964aaa94482\"]";
        #endregion


        //#region For Image picker 
        ///// <summary>
        ///// Gets or sets the image identifier.
        ///// </summary>
        ///// <value>
        ///// The image identifier.
        ///// </value>
        //public Guid ImageId
        //{
        //    get;
        //    set;
        //}

        ///// <summary>
        ///// Gets or sets the name of the image provider.
        ///// </summary>
        ///// <value>
        ///// The name of the image provider.
        ///// </value>
        //public string ImageProviderName
        //{
        //    get;
        //    set;
        //}



        ///// <summary>
        ///// Gets the image.
        ///// </summary>
        ///// <returns></returns>
        //protected virtual SfImage GetImage()
        //{
        //    LibrariesManager librariesManager = LibrariesManager.GetManager(this.ImageProviderName);
        //    return librariesManager.GetImages().Where(i => i.Id == this.ImageId).Where(PredefinedFilters.PublishedItemsFilter<Telerik.Sitefinity.Libraries.Model.Image>()).FirstOrDefault();
        //}

        ///// <summary>
        ///// Gets the selected size URL.
        ///// </summary>
        ///// <param name="image">The image.</param>
        ///// <returns></returns>
        //protected virtual string GetSelectedSizeUrl(SfImage image)
        //{
        //    if (image.Id == Guid.Empty)
        //        return string.Empty;

        //    string imageUrl;

        //    var urlAsAbsolute = Config.Get<SystemConfig>().SiteUrlSettings.GenerateAbsoluteUrls;
        //    var originalImageUrl = image.ResolveMediaUrl(urlAsAbsolute);
        //    imageUrl = originalImageUrl;

        //    return imageUrl;
        //}
        //#endregion 

        //#region for image
        //public void GetImageSelected()
        //{

        //    this.ImageId = new Guid("37fca50d-d127-4b4e-9011-4964aaa94482");
        //    //{37fca50d-d127-4b4e-9011-4964aaa94482}
        //    #region for Image
        //    SfImage image;
        //    if (this.ImageId != Guid.Empty)
        //    {
        //        image = this.GetImage();
        //        if (image != null)
        //        {
        //            SelectedSizeUrl = this.GetSelectedSizeUrl(image);
        //            ImageAlternativeText = image.AlternativeText;
        //            ImageTitle = image.Title;
        //        }
        //    }
        //    #endregion for Image


        //}
        //#region for Image 
        ///// <summary>
        ///// Gets or sets the image title.
        ///// </summary>
        //public string ImageTitle { get; set; }

        ///// <summary>
        ///// Gets or sets the image alternative text.
        ///// </summary>
        //public string ImageAlternativeText { get; set; }

        ///// <summary>
        ///// Gets or sets the selected size image URL.
        ///// </summary>
        //public string SelectedSizeUrl { get; set; }
        //#endregion 
        //#endregion 
    }
}