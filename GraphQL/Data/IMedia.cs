using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.GraphQL.Data
{
    [UnionType("MediaContent")]
    public interface IMediaContent
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string? Title { get; set; }

        [StringLength(2000)]
        public string? Summary { get; set; }
    }
}