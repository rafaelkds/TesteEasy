using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Api.Entities;

namespace Api.Context
{
    public class EasyContext : DbContext
    {
        public DbSet<Candidato> Candidatos { get; set; }

        public EasyContext(DbContextOptions<EasyContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidato>().HasKey(c => c.Id);
            modelBuilder.Entity<Candidato>().Property(c => c.Nome).HasMaxLength(100).IsRequired();
        }
    }
}
