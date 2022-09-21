using System;
using System.ComponentModel.DataAnnotations;

namespace BookwormAPI.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string TheReview { get; set; }

        //this needs to be LIBRARY!! not user
        [Required]
        public int UserId {get; set;}

        [Required]
        public int BookId {get; set;}
        // public virtual Book Book {get; set;}

        

    
    }
}