using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowRooms.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_store_Car_CarID",
                table: "Car_store");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_store_Store_StoreID",
                table: "Car_store");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_Car_CarID",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Store_StoreID",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Service_Store_StoreID",
                table: "Service");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Store",
                table: "Store");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Service",
                table: "Service");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_CarID",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Car_store",
                table: "Car_store");

            migrationBuilder.DropColumn(
                name: "CarName",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "cylinder_number",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "exterior_color",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "work_productivity",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Store",
                newName: "Stores");

            migrationBuilder.RenameTable(
                name: "Service",
                newName: "Services");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categorys");

            migrationBuilder.RenameTable(
                name: "Car_store",
                newName: "Car_stores");

            migrationBuilder.RenameIndex(
                name: "IX_Service_StoreID",
                table: "Services",
                newName: "IX_Services_StoreID");

            migrationBuilder.RenameIndex(
                name: "IX_Contact_StoreID",
                table: "Contacts",
                newName: "IX_Contacts_StoreID");

            migrationBuilder.RenameColumn(
                name: "CarID",
                table: "Categorys",
                newName: "CarId");

            migrationBuilder.RenameIndex(
                name: "IX_Car_store_StoreID",
                table: "Car_stores",
                newName: "IX_Car_stores_StoreID");

            migrationBuilder.RenameIndex(
                name: "IX_Car_store_CarID",
                table: "Car_stores",
                newName: "IX_Car_stores_CarID");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Car",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Car",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CarId",
                table: "Categorys",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Categorys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stores",
                table: "Stores",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Services",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Car_stores",
                table: "Car_stores",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Categorys_CarId",
                table: "Categorys",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_stores_Car_CarID",
                table: "Car_stores",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_stores_Stores_StoreID",
                table: "Car_stores",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categorys_Car_CarId",
                table: "Categorys",
                column: "CarId",
                principalTable: "Car",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Stores_StoreID",
                table: "Contacts",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Stores_StoreID",
                table: "Services",
                column: "StoreID",
                principalTable: "Stores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_stores_Car_CarID",
                table: "Car_stores");

            migrationBuilder.DropForeignKey(
                name: "FK_Car_stores_Stores_StoreID",
                table: "Car_stores");

            migrationBuilder.DropForeignKey(
                name: "FK_Categorys_Car_CarId",
                table: "Categorys");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Stores_StoreID",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Stores_StoreID",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stores",
                table: "Stores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys");

            migrationBuilder.DropIndex(
                name: "IX_Categorys_CarId",
                table: "Categorys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Car_stores",
                table: "Car_stores");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Categorys");

            migrationBuilder.RenameTable(
                name: "Stores",
                newName: "Store");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "Service");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.RenameTable(
                name: "Categorys",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "Car_stores",
                newName: "Car_store");

            migrationBuilder.RenameIndex(
                name: "IX_Services_StoreID",
                table: "Service",
                newName: "IX_Service_StoreID");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_StoreID",
                table: "Contact",
                newName: "IX_Contact_StoreID");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Category",
                newName: "CarID");

            migrationBuilder.RenameIndex(
                name: "IX_Car_stores_StoreID",
                table: "Car_store",
                newName: "IX_Car_store_StoreID");

            migrationBuilder.RenameIndex(
                name: "IX_Car_stores_CarID",
                table: "Car_store",
                newName: "IX_Car_store_CarID");

            migrationBuilder.AlterColumn<int>(
                name: "CarID",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CarName",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "cylinder_number",
                table: "Category",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "exterior_color",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "work_productivity",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Store",
                table: "Store",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Service",
                table: "Service",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Car_store",
                table: "Car_store",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CarID",
                table: "Category",
                column: "CarID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_store_Car_CarID",
                table: "Car_store",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Car_store_Store_StoreID",
                table: "Car_store",
                column: "StoreID",
                principalTable: "Store",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Car_CarID",
                table: "Category",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Store_StoreID",
                table: "Contact",
                column: "StoreID",
                principalTable: "Store",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Store_StoreID",
                table: "Service",
                column: "StoreID",
                principalTable: "Store",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
