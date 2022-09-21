using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookwormAPI.Models
{
    public class Library
    {
        public int LibraryId { get; set; }
        [Required]
        public string Name { get; set; }
    

    public Library()
        {
          this.JoinEntities = new HashSet<BookLibrary>();
        }

        public virtual ICollection<BookLibrary> JoinEntities { get; set; }
  }
}