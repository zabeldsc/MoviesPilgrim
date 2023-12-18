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
    public DbSet<ViewLocacoes> ViewLocacoes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ViewLocacoes>().ToView("ViewLocacoes").HasKey(v => v.IdLocacao);

        base.OnModelCreating(modelBuilder);
    }
}
