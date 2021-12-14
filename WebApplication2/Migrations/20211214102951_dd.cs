using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations
{
    public partial class dd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Indirim_IndirimId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Marka_MarkaId",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "MarkaId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IndirimId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Indirim_IndirimId",
                table: "Product",
                column: "IndirimId",
                principalTable: "Indirim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Marka_MarkaId",
                table: "Product",
                column: "MarkaId",
                principalTable: "Marka",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Indirim_IndirimId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Marka_MarkaId",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "MarkaId",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IndirimId",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Indirim_IndirimId",
                table: "Product",
                column: "IndirimId",
                principalTable: "Indirim",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Marka_MarkaId",
                table: "Product",
                column: "MarkaId",
                principalTable: "Marka",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
