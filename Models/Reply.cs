using System.ComponentModel.DataAnnotations;
namespace DiscussionBoard.Models
{
    public class Reply
    {
        public int Id { get; set; }
        [Required]
        public required string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        [Required]
        public required User User { get; set; }
        public int TopicId { get; set; }
        [Required]
        public required Topic Topic { get; set; }
    }
}
