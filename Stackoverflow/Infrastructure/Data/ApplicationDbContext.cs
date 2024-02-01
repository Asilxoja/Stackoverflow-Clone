using Domain;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Saved> Saveds { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionTag> QuestionTags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Answer>()
                .HasOne(a => a.User)
                .WithMany(u => u.Answers)
                .HasForeignKey(a => a.UserId)
                .IsRequired(false);

            modelBuilder.Entity<ApplicationUser>()
              .HasMany(e => e.Saves)
              .WithOne(e => e.User)
              .HasForeignKey(e => e.UserId)
              .IsRequired(false).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(e => e.Comments)
                .WithOne(e => e.UserComment)
                .HasForeignKey(e => e.UserId)
                .IsRequired(false);

            modelBuilder.Entity<ApplicationUser>()
               .HasMany(e => e.Questions)
               .WithOne(e => e.User)
               .HasForeignKey(e => e.UserId)
               .IsRequired(false);
        }
        private void ConfigureAnswerEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>()
                .HasMany(e => e.Saveds)
                .WithOne(e => e.Answer)
                .HasForeignKey(e => e.AnswerId)
                .IsRequired(false);

            modelBuilder.Entity<Answer>()
                .HasMany(e => e.Comments)
                .WithOne(e => e.Answer)
                .HasForeignKey(e => e.AnswerId)
                .IsRequired(false);
        }
    }
}
