using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerSidePaging.Migrations
{
    public partial class TitleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                column: "Title",
                value: "B Pragmatic Thinking and Learning: Refactor Your Wetware");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("41ff5488-fdab-45b5-bc3a-14302d59869a"),
                column: "Title",
                value: "Z Pragmatic Thinking and Learning: Refactor Your Wetware");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("493c3228-3444-4a49-9cc0-e8532edc59b2"),
                column: "Title",
                value: "A The Art of Learning: A Journey in the Pursuit of Excellence");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("494c3228-3444-4a49-9cc0-e8532edc59b2"),
                column: "Title",
                value: "K The Art of Learning: A Journey in the Pursuit of Excellence");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                column: "Title",
                value: "C Sapiens: A Brief History of Humankind");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b1c3b4d-48c7-402a-80c3-cc796ad49c6b"),
                column: "Title",
                value: "W Sapiens: A Brief History of Humankind");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                column: "Title",
                value: "E So Good They Can't Ignore You");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                column: "Title",
                value: "D Peak: Secrets from the New Science of Expertise");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d8683e5e-7494-4f81-8739-6e0de1bea7ee"),
                column: "Title",
                value: "YY Peak: Secrets from the New Science of Expertise");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                column: "Title",
                value: "Pragmatic Thinking and Learning: Refactor Your Wetware");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("41ff5488-fdab-45b5-bc3a-14302d59869a"),
                column: "Title",
                value: "Pragmatic Thinking and Learning: Refactor Your Wetware");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("493c3228-3444-4a49-9cc0-e8532edc59b2"),
                column: "Title",
                value: "The Art of Learning: A Journey in the Pursuit of Excellence");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("494c3228-3444-4a49-9cc0-e8532edc59b2"),
                column: "Title",
                value: "The Art of Learning: A Journey in the Pursuit of Excellence");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                column: "Title",
                value: "Sapiens: A Brief History of Humankind");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("5b1c3b4d-48c7-402a-80c3-cc796ad49c6b"),
                column: "Title",
                value: "Sapiens: A Brief History of Humankind");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                column: "Title",
                value: "So Good They Can't Ignore You");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                column: "Title",
                value: "Peak: Secrets from the New Science of Expertise");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d8683e5e-7494-4f81-8739-6e0de1bea7ee"),
                column: "Title",
                value: "Peak: Secrets from the New Science of Expertise");
        }
    }
}
