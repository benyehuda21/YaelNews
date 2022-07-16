using System.ComponentModel.DataAnnotations;

namespace YaelMews.Model
{
    public class Item
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public Guid SourceID { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public string? Writer { get; set; }
        public bool IsDeleted { get; set; }
    }
}
