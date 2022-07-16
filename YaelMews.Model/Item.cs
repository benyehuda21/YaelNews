using System.ComponentModel.DataAnnotations;

namespace YaelMews.Model
{
    public class Item
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Content { get; set; } = null!;
        [Required]
        public Guid SourceID { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public string? Writer { get; set; }
        public bool IsDeleted { get; set; }
    }
}
