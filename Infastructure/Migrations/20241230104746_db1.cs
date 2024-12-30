using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infastructure.Migrations
{
    /// <inheritdoc />
    public partial class db1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MealEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodCodes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodWeight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MealTotalWeight = table.Column<int>(type: "int", nullable: true),
                    Calories100g = table.Column<float>(type: "real", nullable: true),
                    MealProtein100g = table.Column<float>(type: "real", nullable: true),
                    MealCarbs100g = table.Column<float>(type: "real", nullable: true),
                    MealFats100g = table.Column<float>(type: "real", nullable: true),
                    CaloriesPerMeal = table.Column<float>(type: "real", nullable: true),
                    MealProteinPerMeal = table.Column<float>(type: "real", nullable: true),
                    MealCarbsPerMeal = table.Column<float>(type: "real", nullable: true),
                    MealFatsPerMeal = table.Column<float>(type: "real", nullable: true),
                    Rating = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealEntity", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MealEntity");
        }
    }
}
