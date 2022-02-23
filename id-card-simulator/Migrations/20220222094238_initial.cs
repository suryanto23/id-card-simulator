using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace id_card_simulator.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Residents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nin = table.Column<string>(type: "varchar(50)", nullable: false),
                    FullName = table.Column<string>(type: "varchar(100)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaceOfBirth = table.Column<string>(type: "varchar(100)", nullable: false),
                    Gender = table.Column<string>(type: "varchar(30)", nullable: false),
                    Address = table.Column<string>(type: "varchar(200)", nullable: false),
                    Religion = table.Column<string>(type: "varchar(50)", nullable: false),
                    MarriedStatus = table.Column<string>(type: "varchar(50)", nullable: false),
                    Profession = table.Column<string>(type: "varchar(100)", nullable: false),
                    Nationality = table.Column<string>(type: "varchar(100)", nullable: false),
                    IssuedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "varchar(80)", nullable: false),
                    City = table.Column<string>(type: "varchar(50)", nullable: false),
                    Province = table.Column<string>(type: "varchar(80)", nullable: false),
                    Neighborhood = table.Column<int>(type: "int", nullable: false),
                    Hamlet = table.Column<int>(type: "int", nullable: false),
                    UrbanDistrict = table.Column<string>(type: "varchar(100)", nullable: false),
                    SubDistrict = table.Column<string>(type: "varchar(100)", nullable: false),
                    BloodType = table.Column<string>(type: "varchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residents", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Residents");
        }
    }
}
