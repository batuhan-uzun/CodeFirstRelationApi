using CodeFirstRelationApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelationApi.Context
{
    public class PatikaSecondDbContext : DbContext
    {
        DbSet<PostEntity> Users => Set<PostEntity>();
        DbSet<UserEntity> Posts => Set<UserEntity>();
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>()
                .HasMany(x => x.Posts)
                .WithOne(x => x.User)
                .HasForeignKey(x => x.UserId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
