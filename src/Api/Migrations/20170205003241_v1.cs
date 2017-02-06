using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Banco",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BancoAgencia",
                table: "Candidatos",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BancoBeneficiario",
                table: "Candidatos",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BancoConta",
                table: "Candidatos",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "BancoContaCorrente",
                table: "Candidatos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "BancoContaPoupanca",
                table: "Candidatos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "BancoCpf",
                table: "Candidatos",
                maxLength: 14,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BancoNome",
                table: "Candidatos",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Candidatos",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoAndroid",
                table: "Candidatos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoAngular",
                table: "Candidatos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoAsp",
                table: "Candidatos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoBootstrap",
                table: "Candidatos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoC",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoCake",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoCplusplus",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoCss",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoDjango",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoHtml",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoIllustrator",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoIonic",
                table: "Candidatos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoIos",
                table: "Candidatos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoJava",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoJquery",
                table: "Candidatos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoMagento",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoMySql",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConhecimentoOutros",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoPhotoshop",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoPhp",
                table: "Candidatos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoPython",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoRuby",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoSalesforce",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoSeo",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoSqlServer",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoWordpress",
                table: "Candidatos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Candidatos",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Candidatos",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "HorasAcimaDeOito",
                table: "Candidatos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HorasAteQuatro",
                table: "Candidatos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HorasFimDeSemana",
                table: "Candidatos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HorasQuatroASeis",
                table: "Candidatos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HorasSeisAOito",
                table: "Candidatos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LinkCrud",
                table: "Candidatos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Linkedin",
                table: "Candidatos",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PeriodoComercial",
                table: "Candidatos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PeriodoMadrugada",
                table: "Candidatos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PeriodoManha",
                table: "Candidatos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PeriodoNoite",
                table: "Candidatos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PeriodoTarde",
                table: "Candidatos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Portfolio",
                table: "Candidatos",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pretensao",
                table: "Candidatos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Skype",
                table: "Candidatos",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Whatsapp",
                table: "Candidatos",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Banco",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "BancoAgencia",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "BancoBeneficiario",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "BancoConta",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "BancoContaCorrente",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "BancoContaPoupanca",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "BancoCpf",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "BancoNome",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoAndroid",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoAngular",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoAsp",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoBootstrap",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoC",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoCake",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoCplusplus",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoCss",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoDjango",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoHtml",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoIllustrator",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoIonic",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoIos",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoJava",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoJquery",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoMagento",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoMySql",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoOutros",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoPhotoshop",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoPhp",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoPython",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoRuby",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoSalesforce",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoSeo",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoSqlServer",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoWordpress",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "HorasAcimaDeOito",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "HorasAteQuatro",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "HorasFimDeSemana",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "HorasQuatroASeis",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "HorasSeisAOito",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "LinkCrud",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "Linkedin",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "PeriodoComercial",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "PeriodoMadrugada",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "PeriodoManha",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "PeriodoNoite",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "PeriodoTarde",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "Portfolio",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "Pretensao",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "Skype",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "Whatsapp",
                table: "Candidatos");
        }
    }
}
