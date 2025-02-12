using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>()
                .ToTable("pontos_turisticos");  

            modelBuilder.Entity<TodoItem>()
                .Property(p => p.Id)
                .HasColumnName("id");  

            modelBuilder.Entity<TodoItem>()
                .Property(p => p.nome_Loc)
                .HasColumnName("nome_Loc");  

            modelBuilder.Entity<TodoItem>()
                .Property(p => p.est_Loc)
                .HasColumnName("est_Loc");  

            modelBuilder.Entity<TodoItem>()
                .Property(p => p.desc_Loc)
                .HasColumnName("desc_Loc");  

            modelBuilder.Entity<TodoItem>()
                .Property(p => p.ref_Loc)
                .HasColumnName("ref_Loc");  

            modelBuilder.Entity<TodoItem>()
                .Property(p => p.descritivos_Loc)
                .HasColumnName("descritivos_Loc");  
        }
    }
}
