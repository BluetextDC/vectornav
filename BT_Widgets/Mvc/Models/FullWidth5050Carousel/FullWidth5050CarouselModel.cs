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

namespace BT_Widgets.Mvc.Models.FullWidth5050Carousel
{
    public class FullWidth5050CarouselModel
    {
      
        public string Content { get; set; }     

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
        /// Gets the view model.
        /// </summary>
        /// <returns></returns>
        //public CustomImageViewModel GetViewModel()
        //{
        //    var viewModel = new CustomImageViewModel();
        //    SfImage image;
        //    if (this.ImageId != Guid.Empty)
        //    {
        //        image = this.GetImage();
        //        if (image != null)
        //        {
        //            viewModel.SelectedSizeUrl = this.GetSelectedSizeUrl(image);
        //            viewModel.ImageAlternativeText = image.AlternativeText;
        //            viewModel.ImageTitle = image.Title;
        //        }
        //    }

        //    return viewModel;
        //}

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
        public FullWidth5050CarouselViewModel GetViewModel()
        {
            var viewModel = new FullWidth5050CarouselViewModel();

            #region for Image
            SfImage image;
            if (this.ImageId != Guid.Empty)
            {
                image = this.GetImage();
                if (image != null)
                {
                    viewModel.SelectedSizeUrl = this.GetSelectedSizeUrl(image);
                    viewModel.ImageAlternativeText = image.AlternativeText;
                    viewModel.ImageTitle = image.Title;
                }
            }
            #endregion for Image

            viewModel.Content = this.Content;           
            return viewModel;
        }
    }
}