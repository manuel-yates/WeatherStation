using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Weatherstation.CoreServer.Migrations
{
    /// <inheritdoc />
    public partial class AddedValueType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ValueType",
                table: "Entries",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValueType",
                table: "Entries");
        }
    }
}
