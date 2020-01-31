namespace BT_Widgets.Mvc.Models.HomePageHero
{
    public class HomePageHeroViewModel
    {
        public string Link { get; set;  }
        public string Title_VM { get; set; }
        public string Subtitle { get; set; }
        public string ListItem_ValueVM { get; set; }


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



        #region for Video 
        /// <summary>
        /// Gets or sets the Video title.
        /// </summary>
        public string Video { get; set; }

        /// <summary>
        /// Gets or sets the selected size Video URL.
        /// </summary>
        public string SelectedVideoSizeUrl { get; set; }
        #endregion 
    }
}
