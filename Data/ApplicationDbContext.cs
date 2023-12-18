using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoviesPilgrim.Models;
using System.Linq;

namespace MoviesPilgrim.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<FilmeModel> Filmes { get; set; }
    public DbSet<ClienteModel> Clientes { get; set; } // Adicionando DbSet para ClienteModel
    public DbSet<EnderecoModel> Enderecos { get; set; }
    public DbSet<LocacaoModel> Locacoes {get; set; }
    public DbSet<ViewLocacoes> ViewLocacoes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ViewLocacoes>().ToView("ViewLocacoes").HasKey(v => v.IdLocacao);

        modelBuilder.Entity<ClienteModel>()
               .HasOne(c => c.Endereco)
               .WithMany()
               .HasForeignKey(c => c.FkIdEndereco);

        base.OnModelCreating(modelBuilder);
    }
}
