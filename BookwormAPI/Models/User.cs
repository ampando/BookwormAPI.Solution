using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BookwormAPI.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }
        

        public User()
        {
          this.Reviews = new HashSet<Review>();
          this.Ratings = new HashSet<Rating>();
        }

        public virtual ICollection<Review> Reviews {get; set;}
        public virtual ICollection<Rating> Ratings {get; set;}

    }
}