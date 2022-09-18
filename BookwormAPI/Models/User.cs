using System;
using System.Collections.Generic;


namespace BookwormAPI.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        

        public User()
        {
          this.Reviews = new HashSet<Review>();
        }

        public virtual ICollection<Review> Reviews {get; set;}

    }
}