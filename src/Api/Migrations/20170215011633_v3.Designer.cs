using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Api.Context;

namespace Api.Migrations
{
    [DbContext(typeof(EasyContext))]
    [Migration("20170215011633_v3")]
    partial class v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Api.Entities.Candidato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Banco")
                        .HasMaxLength(200);

                    b.Property<string>("BancoAgencia")
                        .HasMaxLength(20);

                    b.Property<string>("BancoBeneficiario")
                        .HasMaxLength(100);

                    b.Property<string>("BancoConta")
                        .HasMaxLength(20);

                    b.Property<bool>("BancoContaCorrente");

                    b.Property<bool>("BancoContaPoupanca");

                    b.Property<string>("BancoCpf")
                        .HasMaxLength(14);

                    b.Property<string>("BancoNome")
                        .HasMaxLength(100);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<bool>("HorasAcimaDeOito");

                    b.Property<bool>("HorasAteQuatro");

                    b.Property<bool>("HorasFimDeSemana");

                    b.Property<bool>("HorasQuatroASeis");

                    b.Property<bool>("HorasSeisAOito");

                    b.Property<string>("LinkCrud")
                        .HasMaxLength(200);

                    b.Property<string>("Linkedin")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("PeriodoComercial");

                    b.Property<bool>("PeriodoMadrugada");

                    b.Property<bool>("PeriodoManha");

                    b.Property<bool>("PeriodoNoite");

                    b.Property<bool>("PeriodoTarde");

                    b.Property<string>("Portfolio")
                        .HasMaxLength(100);

                    b.Property<int>("Pretensao");

                    b.Property<string>("Skype")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Whatsapp")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Candidatos");
                });

            modelBuilder.Entity("Api.Entities.Conhecimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Android");

                    b.Property<int>("Angular");

                    b.Property<int>("Asp");

                    b.Property<int>("Bootstrap");

                    b.Property<int?>("C");

                    b.Property<int?>("Cake");

                    b.Property<int>("CandidatoId");

                    b.Property<int?>("Cplusplus");

                    b.Property<int?>("Css");

                    b.Property<int?>("Django");

                    b.Property<int?>("Html");

                    b.Property<int?>("Illustrator");

                    b.Property<int>("Ionic");

                    b.Property<int>("Ios");

                    b.Property<int?>("Java");

                    b.Property<int>("Jquery");

                    b.Property<int?>("Magento");

                    b.Property<int?>("MySql");

                    b.Property<string>("Outros")
                        .HasMaxLength(500);

                    b.Property<int?>("Photoshop");

                    b.Property<int>("Php");

                    b.Property<int?>("Python");

                    b.Property<int?>("Ruby");

                    b.Property<int?>("Salesforce");

                    b.Property<int?>("Seo");

                    b.Property<int?>("SqlServer");

                    b.Property<int>("Wordpress");

                    b.HasKey("Id");

                    b.HasIndex("CandidatoId")
                        .IsUnique();

                    b.ToTable("Conhecimento");
                });

            modelBuilder.Entity("Api.Entities.Conhecimento", b =>
                {
                    b.HasOne("Api.Entities.Candidato", "Candidato")
                        .WithOne("Conhecimento")
                        .HasForeignKey("Api.Entities.Conhecimento", "CandidatoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
