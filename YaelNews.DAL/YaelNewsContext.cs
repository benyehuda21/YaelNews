using Microsoft.EntityFrameworkCore;
using YaelNews.DbModel;

namespace YaelNews.DAL
{
    public partial class YaelNewsContext : DbContext
    {
        public YaelNewsContext()
        {
        }

        public YaelNewsContext(DbContextOptions<YaelNewsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<Source> Sources { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.Writer).HasMaxLength(50);

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.SourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Items_Sources");
            });

            modelBuilder.Entity<Source>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BaseUrl).HasMaxLength(250);

                entity.Property(e => e.IconUrl).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
