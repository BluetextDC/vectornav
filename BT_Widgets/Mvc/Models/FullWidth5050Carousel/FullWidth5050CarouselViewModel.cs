namespace BT_Widgets.Mvc.Models.FullWidth5050Carousel
{
    public class FullWidth5050CarouselViewModel
    {
        public string Content { get; set;  }     


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

    }
}
