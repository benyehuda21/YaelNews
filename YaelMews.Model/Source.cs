﻿namespace YaelNews.Model
{
    public partial class Source
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string BaseUrl { get; set; } = null!;
        public string IconUrl { get; set; } = null!;
    }
}