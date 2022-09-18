using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookwormAPI.Models
{
    public class Library
    {
        public int LibraryId { get; set; }
        public virtual ICollection<Review> Reviews {get; set;}
        public virtual ICollection<Rating> Ratings {get; set;}
        [Required]
        public string Name { get; set; }
        

        public Library()
        {
          this.Reviews = new HashSet<Review>();
          this.Ratings = new HashSet<Rating>();
        }     
        //public virtual ApplicationUser User { get; set; }
    }
}


/*library class below (from web app client side)
public class Library
  { 
    public Library()
    {
      this.JoinEntities = new HashSet<BookLibrary>();
    }

    public int LibraryId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<BookLibrary> JoinEntities { get; set; }
    }
  }*/