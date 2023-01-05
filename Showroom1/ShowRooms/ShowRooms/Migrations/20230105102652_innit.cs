using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowRooms.Migrations
{
    /// <inheritdoc />
    public partial class innit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorys_Car_CarId",
                table: "Categorys");

            migrationBuilder.DropIndex(
                name: "IX_Services_StoreID",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_StoreID",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Categorys_CarId",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "StoreID",
                table: "Stores");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Car");

            migrationBuilder.RenameColumn(
                name: "Service",
                table: "Stores",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categorys",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Car",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Services_StoreID",
                table: "Services",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_StoreID",
                table: "Contacts",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_CategoryID",
                table: "Car",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Categorys_CategoryID",
                table: "Car",
                column: "CategoryID",
                principalTable: "Categorys",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Categorys_CategoryID",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Services_StoreID",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_StoreID",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Car_CategoryID",
                table: "Car");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Stores",
                newName: "Service");

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Stores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StoreID",
                table: "Stores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categorys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Categorys",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Car",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Services_StoreID",
                table: "Services",
                column: "StoreID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_StoreID",
                table: "Contacts",
                column: "StoreID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categorys_CarId",
                table: "Categorys",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorys_Car_CarId",
                table: "Categorys",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id");
        }
    }
}
