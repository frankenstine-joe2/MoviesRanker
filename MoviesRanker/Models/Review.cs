using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesRanker.Models
{
    public class Review
    {
        public int ID { get; set; }
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string ReviewContent { get; set; }
        [Range(0, 5)]
        public decimal Rating { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    }
}