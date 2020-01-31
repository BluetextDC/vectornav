namespace BT_Widgets.Mvc.Models.FiftyFiftyTwoColumn
{
    public class FiftyFiftyTwoColumnViewModel
    {
        public string Link { get; set;  }
        public string Title_JpVM { get; set; }
        public string ListItem_ValueVM { get; set; }
        public string RichText { get; set; }

        


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
