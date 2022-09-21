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
        public string Genre { get; set; }
        public string Tags { get; set; }
        
        public Book()
        {
          this.JoinEntities = new HashSet<BookLibrary>();
        }

        public virtual ICollection<BookLibrary> JoinEntities { get; set; }

    }
}
