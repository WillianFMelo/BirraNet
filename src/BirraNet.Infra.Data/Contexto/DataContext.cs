using BirraNet.Infra.Data.Entidades;
using Microsoft.EntityFrameworkCore;

namespace BirraNet.Infra.Data.Contexto
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options: options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PerguntaEntity>()
                .Property(p => p.Texto)
                .HasMaxLength(500)
                .IsRequired();            

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<PerguntaEntity> Perguntas { get; set; }
        public DbSet<MensagemEntity> Mensagens { get; set; }
        public DbSet<CervejaEntity> Cervejas { get; set; }

    }
}
