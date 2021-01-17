using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
  public partial class InitialCreate : Migration
  {
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
          name: "ClimateDetails",
          columns: table => new
          {
            ClimateDetailId = table.Column<int>(type: "INTEGER", nullable: false)
                  .Annotation("Sqlite:Autoincrement", true),
            ClimateName = table.Column<string>(type: "varchar(30)", nullable: false),
            GlobalRadiation = table.Column<int>(type: "int(3)", nullable: false),
            OutTemp = table.Column<int>(type: "int(2)", nullable: false),
            OutCoefficient = table.Column<int>(type: "int(3)", nullable: false),
            InTemp = table.Column<int>(type: "int(2)", nullable: false),
            InCoefficient = table.Column<int>(type: "int(3)", nullable: false)
          },
          constraints: table =>
          {
            table.PrimaryKey("PK_ClimateDetails", x => x.ClimateDetailId);
          });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(
          name: "ClimateDetails");
    }
  }
}