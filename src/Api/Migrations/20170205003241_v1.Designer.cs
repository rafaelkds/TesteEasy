using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Api.Context;

namespace Api.Migrations
{
    [DbContext(typeof(EasyContext))]
    [Migration("20170205003241_v1")]
    partial class v1
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

                    b.Property<string>("Banco");

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

                    b.Property<int>("ConhecimentoAndroid");

                    b.Property<int>("ConhecimentoAngular");

                    b.Property<int>("ConhecimentoAsp");

                    b.Property<int>("ConhecimentoBootstrap");

                    b.Property<int?>("ConhecimentoC");

                    b.Property<int?>("ConhecimentoCake");

                    b.Property<int?>("ConhecimentoCplusplus");

                    b.Property<int?>("ConhecimentoCss");

                    b.Property<int?>("ConhecimentoDjango");

                    b.Property<int?>("ConhecimentoHtml");

                    b.Property<int?>("ConhecimentoIllustrator");

                    b.Property<int>("ConhecimentoIonic");

                    b.Property<int>("ConhecimentoIos");

                    b.Property<int?>("ConhecimentoJava");

                    b.Property<int>("ConhecimentoJquery");

                    b.Property<int?>("ConhecimentoMagento");

                    b.Property<int?>("ConhecimentoMySql");

                    b.Property<string>("ConhecimentoOutros");

                    b.Property<int?>("ConhecimentoPhotoshop");

                    b.Property<int>("ConhecimentoPhp");

                    b.Property<int?>("ConhecimentoPython");

                    b.Property<int?>("ConhecimentoRuby");

                    b.Property<int?>("ConhecimentoSalesforce");

                    b.Property<int?>("ConhecimentoSeo");

                    b.Property<int?>("ConhecimentoSqlServer");

                    b.Property<int>("ConhecimentoWordpress");

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

                    b.Property<string>("LinkCrud");

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
        }
    }
}
