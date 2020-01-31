using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Sitefinity.Configuration;
using Telerik.Sitefinity.Modules;
using Telerik.Sitefinity.Modules.Libraries;
using Telerik.Sitefinity.Services;
using SfImage = Telerik.Sitefinity.Libraries.Model.Image;

namespace BT_Widgets.Mvc.Models.VideoBlock
{

    public class VideoBlock
    {
        private string m_title = "Title Not available";
        private string m_CTALink = "Link Not available";

        private string m_Description = "Description Not available";
        //private string m_imageUrl = "Image-URL not available";
        public string title
        {
            get => m_title;
            set => m_title = value;
        }
        public string description
        {
            get => m_Description;
            set => m_Description = value;
        }
        public string CTALink { get => m_CTALink; set => m_CTALink = value; }
        //public string imageUrl 
        //{ 
        //    get => m_imageUrl; 
        //    set => m_imageUrl = value; 
        //}

        #region For Image picker 
        /// <summary>
        /// Gets or sets the image identifier.
        /// </summary>
        /// <value>
        /// The image identifier.
        /// </value>
        public Guid ImageId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the image provider.
        /// </summary>
        /// <value>
        /// The name of the image provider.
        /// </value>
        public string ImageProviderName
        {
            get;
            set;
        }



        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <returns></returns>
        protected virtual SfImage GetImage()
        {
            LibrariesManager librariesManager = LibrariesManager.GetManager(this.ImageProviderName);
            return librariesManager.GetImages().Where(i => i.Id == this.ImageId).Where(PredefinedFilters.PublishedItemsFilter<Telerik.Sitefinity.Libraries.Model.Image>()).FirstOrDefault();
        }

        /// <summary>
        /// Gets the selected size URL.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <returns></returns>
        protected virtual string GetSelectedSizeUrl(SfImage image)
        {
            if (image.Id == Guid.Empty)
                return string.Empty;

            string imageUrl;

            var urlAsAbsolute = Config.Get<SystemConfig>().SiteUrlSettings.GenerateAbsoluteUrls;
            var originalImageUrl = image.ResolveMediaUrl(urlAsAbsolute);
            imageUrl = originalImageUrl;

            return imageUrl;
        }
        #endregion 

        #region for image
        public void GetImageSelected()
        {
            //if (this.ImageId != Guid.Empty)
            //{
            //    //delete this line
            //    this.ImageId = new Guid("37fca50d-d127-4b4e-9011-4964aaa94482");
            //}
            //{37fca50d-d127-4b4e-9011-4964aaa94482}
            #region for Image
            SfImage image;
            if (this.ImageId != Guid.Empty)
            {
                image = this.GetImage();
                if (image != null)
                {
                    SelectedSizeUrl = this.GetSelectedSizeUrl(image);
                    ImageAlternativeText = image.AlternativeText;
                    ImageTitle = image.Title;
                }
            }
            #endregion for Image


        }
        #region for Image 
        /// <summary>
        /// Gets or sets the image title.
        /// </summary>
        public string ImageTitle { get; set; }

        /// <summary>
        /// Gets or sets the image alternative text.
        /// </summary>
        public string ImageAlternativeText { get; set; }

        /// <summary>
        /// Gets or sets the selected size image URL.
        /// </summary>
        public string SelectedSizeUrl { get; set; }

        #endregion
        #endregion

    }
}
