using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.GraphQL.Data
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = default!;

        // Books the user has checked out
        public ICollection<Book> Books { get; set; } = 
            new List<Book>();
    }
}
