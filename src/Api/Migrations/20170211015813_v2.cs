using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Api.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "ConhecimentoWordpress",
                table: "Candidatos",
                newName: "ConhecimentoId");

            migrationBuilder.CreateTable(
                name: "Conhecimento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Android = table.Column<int>(nullable: false),
                    Angular = table.Column<int>(nullable: false),
                    Asp = table.Column<int>(nullable: false),
                    Bootstrap = table.Column<int>(nullable: false),
                    C = table.Column<int>(nullable: true),
                    Cake = table.Column<int>(nullable: true),
                    Cplusplus = table.Column<int>(nullable: true),
                    Css = table.Column<int>(nullable: true),
                    Django = table.Column<int>(nullable: true),
                    Html = table.Column<int>(nullable: true),
                    Illustrator = table.Column<int>(nullable: true),
                    Ionic = table.Column<int>(nullable: false),
                    Ios = table.Column<int>(nullable: false),
                    Java = table.Column<int>(nullable: true),
                    Jquery = table.Column<int>(nullable: false),
                    Magento = table.Column<int>(nullable: true),
                    MySql = table.Column<int>(nullable: true),
                    Outros = table.Column<string>(nullable: true),
                    Photoshop = table.Column<int>(nullable: true),
                    Php = table.Column<int>(nullable: false),
                    Python = table.Column<int>(nullable: true),
                    Ruby = table.Column<int>(nullable: true),
                    Salesforce = table.Column<int>(nullable: true),
                    Seo = table.Column<int>(nullable: true),
                    SqlServer = table.Column<int>(nullable: true),
                    Wordpress = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conhecimento", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidatos_ConhecimentoId",
                table: "Candidatos",
                column: "ConhecimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidatos_Conhecimento_ConhecimentoId",
                table: "Candidatos",
                column: "ConhecimentoId",
                principalTable: "Conhecimento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidatos_Conhecimento_ConhecimentoId",
                table: "Candidatos");

            migrationBuilder.DropTable(
                name: "Conhecimento");

            migrationBuilder.DropIndex(
                name: "IX_Candidatos_ConhecimentoId",
                table: "Candidatos");

            migrationBuilder.RenameColumn(
                name: "ConhecimentoId",
                table: "Candidatos",
                newName: "ConhecimentoWordpress");

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
        }
    }
}
