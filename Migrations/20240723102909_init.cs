using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeledocWebApplication.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    inn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    statusType = table.Column<bool>(type: "bit", nullable: false),
                    creationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    editDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "founders",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    inn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    middlename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    creationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    editDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    clientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_founders", x => x.id);
                    table.ForeignKey(
                        name: "FK_founders_clients_clientId",
                        column: x => x.clientId,
                        principalTable: "clients",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_founders_clientId",
                table: "founders",
                column: "clientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "founders");

            migrationBuilder.DropTable(
                name: "clients");
        }
    }
}
