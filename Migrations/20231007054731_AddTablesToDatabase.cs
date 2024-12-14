using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegistrationWeb.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Declarationtable",
                columns: table => new
                {
                    DeclarationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CapitalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    signeddate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Declarationtable", x => x.DeclarationId);
                });

            migrationBuilder.CreateTable(
                name: "Edutable",
                columns: table => new
                {
                    EduId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tenth = table.Column<int>(type: "int", nullable: false),
                    tenthboard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    twelth = table.Column<int>(type: "int", nullable: false),
                    twelthboard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UGCousre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UG = table.Column<int>(type: "int", nullable: false),
                    PGCousre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PGUniversity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PG = table.Column<int>(type: "int", nullable: true),
                    project = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    software = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edutable", x => x.EduId);
                });

            migrationBuilder.CreateTable(
                name: "PersAsstable",
                columns: table => new
                {
                    PersAssId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    strength = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weaknesses = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hobbies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sports = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Goals = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    atMNJ = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersAsstable", x => x.PersAssId);
                });

            migrationBuilder.CreateTable(
                name: "Personaltable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PAN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passport = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personaltable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrevEmptable",
                columns: table => new
                {
                    PrevEmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HRName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HRMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HREmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepManager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContRepManager = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CTC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrevEmptable", x => x.PrevEmpId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Declarationtable");

            migrationBuilder.DropTable(
                name: "Edutable");

            migrationBuilder.DropTable(
                name: "PersAsstable");

            migrationBuilder.DropTable(
                name: "Personaltable");

            migrationBuilder.DropTable(
                name: "PrevEmptable");
        }
    }
}
