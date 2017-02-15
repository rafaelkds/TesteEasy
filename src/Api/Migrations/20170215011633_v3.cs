using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Api.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidatos_Conhecimento_ConhecimentoId",
                table: "Candidatos");

            migrationBuilder.DropIndex(
                name: "IX_Candidatos_ConhecimentoId",
                table: "Candidatos");

            migrationBuilder.DropColumn(
                name: "ConhecimentoId",
                table: "Candidatos");

            migrationBuilder.AlterColumn<string>(
                name: "Outros",
                table: "Conhecimento",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CandidatoId",
                table: "Conhecimento",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "LinkCrud",
                table: "Candidatos",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Banco",
                table: "Candidatos",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Conhecimento_CandidatoId",
                table: "Conhecimento",
                column: "CandidatoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Conhecimento_Candidatos_CandidatoId",
                table: "Conhecimento",
                column: "CandidatoId",
                principalTable: "Candidatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Conhecimento_Candidatos_CandidatoId",
                table: "Conhecimento");

            migrationBuilder.DropIndex(
                name: "IX_Conhecimento_CandidatoId",
                table: "Conhecimento");

            migrationBuilder.DropColumn(
                name: "CandidatoId",
                table: "Conhecimento");

            migrationBuilder.AlterColumn<string>(
                name: "Outros",
                table: "Conhecimento",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LinkCrud",
                table: "Candidatos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Banco",
                table: "Candidatos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConhecimentoId",
                table: "Candidatos",
                nullable: false,
                defaultValue: 0);

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
    }
}
