using System;
using System.ComponentModel.DataAnnotations;

namespace BookwormAPI.Models
{
    public class Rating
    {
        public int RatingId { get; set; }
        [Required]
        public double TheRating { get; set; }

        //this needs to be LIBRARY!! not user
        [Required]
        public int UserId {get; set;}

        [Required]
        public int BookId {get; set;}

    
    }
}