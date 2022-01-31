using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mango.Services.ProductAPI.Migrations
{
    public partial class Addproductsimageurls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2020849e-2eee-4549-a964-4843d4496946"),
                column: "ImageUrl",
                value: "http://127.0.0.1:10001/devstoreaccount1/mango/11.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("39641b44-9835-4c26-934f-e709cd5de375"),
                column: "ImageUrl",
                value: "http://127.0.0.1:10001/devstoreaccount1/mango/14.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48d167ed-a297-4b96-bda4-52e8f2a825d3"),
                column: "ImageUrl",
                value: "http://127.0.0.1:10001/devstoreaccount1/mango/13.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6c77914c-34ea-4d5b-8917-fbec96da7711"),
                column: "ImageUrl",
                value: "http://127.0.0.1:10001/devstoreaccount1/mango/12.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2020849e-2eee-4549-a964-4843d4496946"),
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("39641b44-9835-4c26-934f-e709cd5de375"),
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("48d167ed-a297-4b96-bda4-52e8f2a825d3"),
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6c77914c-34ea-4d5b-8917-fbec96da7711"),
                column: "ImageUrl",
                value: "");
        }
    }
}
