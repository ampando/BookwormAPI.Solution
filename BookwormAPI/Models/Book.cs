using System;
using System.Collections.Generic;


namespace BookwormAPI.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string AgeRange { get; set; }
        public string Summary { get; set; }
        public string Rating { get; set; }
        public string Genre { get; set; }
        public string Tags { get; set; }
        // public string Reviews { get; set; }

        public Book()
        {
          this.Reviews = new HashSet<Review>();
          this.Ratings = new HashSet<Rating>();
        }

        public virtual ICollection<Review> Reviews { get; set;}
        public virtual ICollection<Rating> Ratings { get; set; }

    }
}