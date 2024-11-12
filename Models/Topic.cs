using System.ComponentModel.DataAnnotations;

namespace DiscussionBoard.Models
{
    public class Topic
    {
        public int Id { get; set; }
        [Required]
        public required string Title { get; set; }
        [Required]
        public required string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        [Required]
        public required User User { get; set; }
    }
}
