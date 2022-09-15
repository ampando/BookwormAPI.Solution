using System;
using System.Collections;

namespace BookwormAPI.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string TheReview { get; set; }

        public int UserId {get; set;}

        public int BookId {get; set;}
        public virtual Book Book {get; set;}

        

    
    }
}