using MoviesRanker.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesRanker.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string StoryLine { get; set; }
        public string FilePath { get; set; }
        public string Runtime { get; set; }
        public string GenresJSON { get; set; }
        public bool UseImdbPoster { get; set; }
        public byte[] ThumbnailPoster { get; set; }
        public string ImdbThumbnailPoster { get; set; }
        public byte[] FullPoster { get; set; }
        public string ImdbFullPoster { get; set; }
        public byte[] IconPoster { get; set; }
        public string ReleaseYear { get; set; }
        public double Rating { get; set; }
        public double MetaScore { get; set; }
        public string ImdbLink { get; set; }
        public string ActorsJSON { get; set; }
        public string DirectorsJSON { get; set; }
        public double Size { get; set; }
        public int Downloads { get; set; }
        public MPARating MpaRating { get; set; }
        public Language Language { get; set; }


        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

    }
}