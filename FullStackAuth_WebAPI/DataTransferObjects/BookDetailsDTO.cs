using FullStackAuth_WebAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FullStackAuth_WebAPI.DataTransferObjects
{
    public class BookDetailsDTO
    {
        [Key]
        public string BookId { get; set; }
        public double AverageRating { get; set; }
        public bool IsFavorite { get; set; }
        public List<ReviewWithUserDto> Reviews{ get; set; }

    }
}
