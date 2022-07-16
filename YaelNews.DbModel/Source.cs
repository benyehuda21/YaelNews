namespace YaelNews.DbModel
{
    public partial class Source
    {
        public Source()
        {
            Items = new List<Item>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string BaseUrl { get; set; } = null!;
        public string IconUrl { get; set; } = null!;

        public virtual List<Item> Items { get; set; }
    }
}