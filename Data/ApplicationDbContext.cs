using app_tarefas.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Gerenciador_de_tarefas_aspnet.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Tipo> Tipos { get; set; } = null!;
    public ICollection<Tarefa> Tarefas { get; set; } = new List<Tarefa>();

public DbSet<app_tarefas.Models.Tarefa> Tarefa { get; set; } = default!;

}