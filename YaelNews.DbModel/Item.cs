using System;
using System.Collections.Generic;

namespace YaelNews.DbModel
{
    public partial class Item
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public Guid SourceId { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Writer { get; set; } = null!;
        public bool IsDeleted { get; set; }

        public virtual Source Source { get; set; } = null!;
    }
}