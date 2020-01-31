namespace BT_Widgets.Mvc.Models.SidebarCTA
{
    public class SidebarCTAViewModel
    {
        public string Link { get; set;  }
        public string Title_JpVM { get; set; }
     

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
