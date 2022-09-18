using Microsoft.EntityFrameworkCore;

namespace BookwormAPI.Models
{
    public class BookwormAPIContext : DbContext
    {
        public BookwormAPIContext(DbContextOptions<BookwormAPIContext> options)
            : base(options)
        {
        }

        //to add lazy loading?
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
            optionsBuilder.UseLazyLoadingProxies();
          }
        
        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        // builder.Entity<Book>()
        // .HasData(
        //     new Book { BookId = 1, Title = "Where The Wild Things Are", Author = "Maurice Sendak", AgeRange = "1-5", Summary = "Max sets sail to an island inhabited by Wild Things, who name him king.", Rating = "5", Genre = "Sci-Fi & Fantasy", Tags = "multi-cultural", Reviews = "This book is amazing!"  },
        //     new Book { BookId = 2, Title = "The Snowy Day", AgeRange = "1-5", Author = "Ezra Jack Keats", Summary = "Peter takes a walk in his snowsuit through New York capturing magic and wonder.", Rating = "5", Genre = "Picture", Tags = "multi-cultural", Reviews = "This book is amazing!"  },
        //     new Book { BookId = 3, Title = "Goodnight Moon", AgeRange = "Baby-3", Author = "Margaret Wise Brown", Summary = "A little bunny tucked away in bed, says goodnight to all of his favorite things.", Rating = "5", Genre = "Picture", Tags = "multi-cultural", Reviews = "This book is amazing!"  },
        //     new Book { BookId = 4, Title = "Where the Sidewalk Ends", AgeRange = "5-9", Author = "Shel Silverstein", Summary = "Collection of loopy and imaginative poems and drawings, loved by generations.", Rating = "5", Genre = "Literature & Fiction", Tags = "multi-cultural", Reviews = "This book is amazing!"  },
        //     new Book { BookId = 5, Title = "Pet Cemetary", AgeRange = "15-17", Author = "Stephen King", Summary = "When Dr. Louis Creed takes a new job and moves his family to the idyllic, rural town of Ludlow, Maine, this new beginning seems too good to be true.", Rating = "4", Genre = "Adventure, Scary", Tags = "fantasy, supernatural", Reviews = "There is no greater fear than that of losing a child. Stephen King explores the deepest depths of grief and the lengths a father is willing to go through in order to undo the mysterious power of what's beyond the Pet Sematary."  },
        //     new Book { BookId = 6, Title = "Twilight", AgeRange = "12-17", Author = "Stephanie Meyer", Summary = "Vampires, warewolves, and high school", Rating = "3.5", Genre = "romance, fantasy", Tags = "action, young adult", Reviews = "I'm team Edward"  },
        //     new Book { BookId = 7, Title = "The Giving Tree", AgeRange = "2-8", Author = "Shel Silverstein", Summary = "Once there was a tree...and she loved a little boy.", Rating = "5", Genre = "Bedtime, classics", Tags = "nature", Reviews = "Classic"  },
        //     new Book { BookId = 8, Title = "The Very Hungry Caterpillar", AgeRange = "2-5", Author = "Eric Carle", Summary = "Featuring interactive die-cut pages, this board book edition is the perfect size for little hands and great for teaching counting and days of the week.", Rating = "5", Genre = "Adventure", Tags = "nature, science", Reviews = "This book is amazing!" }
        //     );
        // }

        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
    }
}