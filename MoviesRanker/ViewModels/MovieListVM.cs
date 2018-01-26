using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MoviesRanker.Enums;

namespace MoviesRanker.ViewModels
{
    public class MovieListVM
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [Display(Name = "Genres")]
        public List<string> Genres { get; set; }
        [Display(Name = "Release Year")]
        public string ReleaseYear { get; set; }
        public double Rating { get; set; }
        [Display(Name = "MPA Rating")]
        public MPARating MpaRating { get; set; }

        public bool IsNew { get; set; }

        #region Un Used

        //[Display(Name = "Story line")]
        //public string StoryLine { get; set; }
        //[Display(Name = "File path")]
        //public string FilePath { get; set; }
        //[Display(Name = "Runtime")]
        //public string Runtime { get; set; }
        //public bool UseImdbPoster { get; set; }
        //public byte[] ThumbnailPoster { get; set; }
        //public string ImdbThumbnailPoster { get; set; }
        //public byte[] FullPoster { get; set; }
        //public string ImdbFullPoster { get; set; }
        //public byte[] IconPoster { get; set; }
        //public double MetaScore { get; set; }
        //public string ImdbLink { get; set; }
        //public string ActorsJSON { get; set; }
        //public string DirectorsJSON { get; set; }
        //public double Size { get; set; }
        //public int Downloads { get; set; }
        //public Language Language { get; set; }

        //public DateTime CreatedOn { get; set; }
        //public string CreatedBy { get; set; }
        //public DateTime ModifiedOn { get; set; }
        //public string ModifiedBy { get; set; }

        #endregion

    }
}