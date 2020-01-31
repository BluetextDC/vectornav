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
using SfVideo = Telerik.Sitefinity.Libraries.Model.Video;


namespace BT_Widgets.Mvc.Models.HomePageHero
{
    public class HomePageHeroModel
    {
        public string Link { get; set; }
        public string Title { get; set; }        
        public string Subtitle { get; set; }       
        public string ListItem_Value { get; set; }


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



        #region For Video picker 
        /// <summary>
        /// Gets or sets the Video identifier.
        /// </summary>
        /// <value>
        /// The Video identifier.
        /// </value>
        public Guid VideoId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the Video provider.
        /// </summary>
        /// <value>
        /// The name of the Video provider.
        /// </value>
        public string VideoProviderName
        {
            get;
            set;
        }



        /// <summary>
        /// Gets the Video.
        /// </summary>
        /// <returns></returns>

        protected virtual SfVideo GetVideo()
        {
            LibrariesManager librariesManager = LibrariesManager.GetManager(this.VideoProviderName);
            return librariesManager.GetVideos().Where(i => i.Id == this.VideoId).Where(PredefinedFilters.PublishedItemsFilter<Telerik.Sitefinity.Libraries.Model.Video>()).FirstOrDefault();
        }

        /// <summary>
        /// Gets the selected size URL.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <returns></returns>
        protected virtual string GetSelectedVideoSizeUrl(SfVideo video)
        {
            if (video.Id == Guid.Empty)
                return string.Empty;

            string videoUrl;
            var urlAsAbsolute = Config.Get<SystemConfig>().SiteUrlSettings.GenerateAbsoluteUrls;
            var originalvideoUrl = video.ResolveMediaUrl(urlAsAbsolute);
            videoUrl = originalvideoUrl;

            return videoUrl;
        }
        #endregion 


        public HomePageHeroViewModel GetViewModel()
        {
            var viewModel = new HomePageHeroViewModel();

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


            #region for Video
            SfVideo video;
            if (this.VideoId != Guid.Empty)
            {
                video = this.GetVideo();
                if (video != null)
                {
                    viewModel.SelectedVideoSizeUrl = this.GetSelectedVideoSizeUrl(video);                   
                    viewModel.Video = video.Title;
                }
            }
            #endregion for Image
            viewModel.Link = this.Link;
            viewModel.Title_VM = this.Title;
            viewModel.Subtitle = this.Subtitle;
            viewModel.ListItem_ValueVM = this.ListItem_Value;
            return viewModel;
        }
    }
}