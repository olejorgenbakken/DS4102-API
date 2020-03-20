using System.ComponentModel.DataAnnotations;

namespace moviesAPI.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int releaseYear { get; set; }
    }
}