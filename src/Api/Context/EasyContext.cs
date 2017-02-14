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
            modelBuilder.Entity<Candidato>().HasOne(c => c.Conhecimento);
            modelBuilder.Entity<Candidato>().Property(c => c.Nome).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.Email).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.Skype).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.Whatsapp).HasMaxLength(20).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.Linkedin).HasMaxLength(100);
            modelBuilder.Entity<Candidato>().Property(c => c.Cidade).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.Estado).HasMaxLength(2).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.Portfolio).HasMaxLength(100);
            modelBuilder.Entity<Candidato>().Property(c => c.HorasAteQuatro).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.HorasQuatroASeis).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.HorasSeisAOito).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.HorasAcimaDeOito).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.HorasFimDeSemana).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.PeriodoManha).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.PeriodoTarde).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.PeriodoNoite).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.PeriodoMadrugada).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.PeriodoComercial).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.Pretensao).IsRequired();
            modelBuilder.Entity<Candidato>().Property(c => c.Banco).HasMaxLength(200);

            modelBuilder.Entity<Candidato>().Property(c => c.BancoBeneficiario).HasMaxLength(100);
            modelBuilder.Entity<Candidato>().Property(c => c.BancoCpf).HasMaxLength(14);
            modelBuilder.Entity<Candidato>().Property(c => c.BancoNome).HasMaxLength(100);
            modelBuilder.Entity<Candidato>().Property(c => c.BancoAgencia).HasMaxLength(20);
            modelBuilder.Entity<Candidato>().Property(c => c.BancoContaCorrente);
            modelBuilder.Entity<Candidato>().Property(c => c.BancoContaPoupanca);
            modelBuilder.Entity<Candidato>().Property(c => c.BancoConta).HasMaxLength(20);
            modelBuilder.Entity<Candidato>().Property(c => c.LinkCrud).HasMaxLength(200);

            modelBuilder.Entity<Conhecimento>().Property(c => c.Ionic).IsRequired();
            modelBuilder.Entity<Conhecimento>().Property(c => c.Android).IsRequired();
            modelBuilder.Entity<Conhecimento>().Property(c => c.Ios).IsRequired();
            modelBuilder.Entity<Conhecimento>().Property(c => c.Bootstrap).IsRequired();
            modelBuilder.Entity<Conhecimento>().Property(c => c.Jquery).IsRequired();
            modelBuilder.Entity<Conhecimento>().Property(c => c.Angular).IsRequired();
            modelBuilder.Entity<Conhecimento>().Property(c => c.Asp).IsRequired();
            modelBuilder.Entity<Conhecimento>().Property(c => c.Php).IsRequired();
            modelBuilder.Entity<Conhecimento>().Property(c => c.Wordpress).IsRequired();
            modelBuilder.Entity<Conhecimento>().Property(c => c.Outros).HasMaxLength(500);
        }
    }
}
