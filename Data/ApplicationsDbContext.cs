using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using app_tarefas.Models;

    public class ApplicationsDbContext : DbContext
    {
        public ApplicationsDbContext (DbContextOptions<ApplicationsDbContext> options)
            : base(options)
        {
        }

        public DbSet<app_tarefas.Models.Tipo> Tipo { get; set; } = default!;
    }
