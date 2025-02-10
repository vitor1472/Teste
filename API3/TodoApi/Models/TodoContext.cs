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
        .ToTable("pontos_turisticos");  // Nome da tabela no banco de dados

    // Mapeamento das propriedades para as colunas
    modelBuilder.Entity<TodoItem>()
        .Property(p => p.Id)
        .HasColumnName("id");  // Coluna 'id' do tipo int

    modelBuilder.Entity<TodoItem>()
        .Property(p => p.nome_Loc)
        .HasColumnName("nome_Loc");  // Coluna 'nome_Loc' do tipo nvarchar

    modelBuilder.Entity<TodoItem>()
        .Property(p => p.est_Loc)
        .HasColumnName("est_Loc");  // Coluna 'est_Loc' do tipo nvarchar

    modelBuilder.Entity<TodoItem>()
        .Property(p => p.desc_Loc)
        .HasColumnName("desc_Loc");  // Coluna 'desc_Loc' do tipo nvarchar

    modelBuilder.Entity<TodoItem>()
        .Property(p => p.ref_Loc)
        .HasColumnName("ref_Loc");  // Coluna 'ref_Loc' do tipo nvarchar

    modelBuilder.Entity<TodoItem>()
        .Property(p => p.descritivos_Loc)
        .HasColumnName("descritivos_Loc");  // Coluna 'descritivos_Loc' do tipo nvarchar
}
    }
}
