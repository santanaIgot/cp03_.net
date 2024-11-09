﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CP3.Data.Migrations
{
    /// <inheritdoc />
    public partial class Subindo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_barco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Ano = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Estado = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Preco = table.Column<double>(type: "BINARY_DOUBLE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_barco", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_barco");
        }
    }
}
