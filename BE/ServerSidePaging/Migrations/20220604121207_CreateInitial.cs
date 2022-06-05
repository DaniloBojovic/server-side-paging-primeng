using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerSidePaging.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "Img", "Title" },
                values: new object[,]
                {
                    { new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"), "Andy Hunt", "Software development happens in your head. Not in an editor, IDE, or design tool. You're well educated on how to work with software and hardware, but what about wetware--our own brains? Learning new skills and new technology is critical to your career, and it's all in your head.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1390692774l/3063393.jpg", "Pragmatic Thinking and Learning: Refactor Your Wetware" },
                    { new Guid("40ff5488-fdab-45b5-bc3a-18302d59869a"), "Andy Hunt", "Software development happens in your head. Not in an editor, IDE, or design tool. You're well educated on how to work with software and hardware, but what about wetware--our own brains? Learning new skills and new technology is critical to your career, and it's all in your head.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1390692774l/3063393.jpg", "Pragmatic Thinking and Learning: Refactor Your Wetware" },
                    { new Guid("40ff5488-fdab-49b5-bc3a-14302d59869a"), "Andy Hunt", "Software development happens in your head. Not in an editor, IDE, or design tool. You're well educated on how to work with software and hardware, but what about wetware--our own brains? Learning new skills and new technology is critical to your career, and it's all in your head.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1390692774l/3063393.jpg", "Pragmatic Thinking and Learning: Refactor Your Wetware" },
                    { new Guid("40ff5588-fdab-45b5-bc3a-14302d59869a"), "Andy Hunt", "Software development happens in your head. Not in an editor, IDE, or design tool. You're well educated on how to work with software and hardware, but what about wetware--our own brains? Learning new skills and new technology is critical to your career, and it's all in your head.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1390692774l/3063393.jpg", "Pragmatic Thinking and Learning: Refactor Your Wetware" },
                    { new Guid("413c3228-3444-4a49-9cc0-e8532edc59b2"), "Josh Waitzkin", "With a narrative that combines heart-stopping martial arts wars and tense chess face-offs with life lessons that speak to all of us, 'The Art of Learning' takes readers through Waitzkin's unique journey to excellence.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1348688766l/857333.jpg", "The Art of Learning: A Journey in the Pursuit of Excellence" },
                    { new Guid("41ff5488-fdab-45b5-bc3a-14302d59869a"), "Andy Hunt", "Software development happens in your head. Not in an editor, IDE, or design tool. You're well educated on how to work with software and hardware, but what about wetware--our own brains? Learning new skills and new technology is critical to your career, and it's all in your head.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1390692774l/3063393.jpg", "Pragmatic Thinking and Learning: Refactor Your Wetware" },
                    { new Guid("493c3228-3444-4a49-9cc0-e8532edc59b2"), "Josh Waitzkin", "With a narrative that combines heart-stopping martial arts wars and tense chess face-offs with life lessons that speak to all of us, 'The Art of Learning' takes readers through Waitzkin's unique journey to excellence.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1348688766l/857333.jpg", "The Art of Learning: A Journey in the Pursuit of Excellence" },
                    { new Guid("493c3228-3444-4a59-9cc0-e8532edc59b2"), "Josh Waitzkin", "With a narrative that combines heart-stopping martial arts wars and tense chess face-offs with life lessons that speak to all of us, 'The Art of Learning' takes readers through Waitzkin's unique journey to excellence.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1348688766l/857333.jpg", "The Art of Learning: A Journey in the Pursuit of Excellence" },
                    { new Guid("493c3628-3444-4a49-9cc0-e8532edc59b2"), "Josh Waitzkin", "With a narrative that combines heart-stopping martial arts wars and tense chess face-offs with life lessons that speak to all of us, 'The Art of Learning' takes readers through Waitzkin's unique journey to excellence.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1348688766l/857333.jpg", "The Art of Learning: A Journey in the Pursuit of Excellence" },
                    { new Guid("494c3228-3444-4a49-9cc0-e8532edc59b2"), "Josh Waitzkin", "With a narrative that combines heart-stopping martial arts wars and tense chess face-offs with life lessons that speak to all of us, 'The Art of Learning' takes readers through Waitzkin's unique journey to excellence.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1348688766l/857333.jpg", "The Art of Learning: A Journey in the Pursuit of Excellence" },
                    { new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"), "Yuval Noah Harari", "100,000 years ago, at least six human species inhabited the earth. Today there is just one. Us. Homo sapiens.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1420585954l/23692271.jpg", "Sapiens: A Brief History of Humankind" },
                    { new Guid("5b1c2b4d-48c7-402a-80c3-cc799ad49c6b"), "Yuval Noah Harari", "100,000 years ago, at least six human species inhabited the earth. Today there is just one. Us. Homo sapiens.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1420585954l/23692271.jpg", "Sapiens: A Brief History of Humankind" },
                    { new Guid("5b1c2b4d-48c7-412a-80c3-cc796ad49c6b"), "Yuval Noah Harari", "100,000 years ago, at least six human species inhabited the earth. Today there is just one. Us. Homo sapiens.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1420585954l/23692271.jpg", "Sapiens: A Brief History of Humankind" },
                    { new Guid("5b1c3b4d-48c7-402a-80c3-cc796ad49c6b"), "Yuval Noah Harari", "100,000 years ago, at least six human species inhabited the earth. Today there is just one. Us. Homo sapiens.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1420585954l/23692271.jpg", "Sapiens: A Brief History of Humankind" },
                    { new Guid("d172e20d-159e-4127-9ce9-b0ac2564ad97"), " Cal Newport", "In this eye-opening account, Cal Newport debunks the long-held belief that 'follow your passion' is good advice.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1360564614l/13525945.jpg", "So Good They Can't Ignore You" },
                    { new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"), " Cal Newport", "In this eye-opening account, Cal Newport debunks the long-held belief that 'follow your passion' is good advice.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1360564614l/13525945.jpg", "So Good They Can't Ignore You" },
                    { new Guid("d173e20d-159e-4627-9ce9-b0ac2564ad97"), " Cal Newport", "In this eye-opening account, Cal Newport debunks the long-held belief that 'follow your passion' is good advice.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1360564614l/13525945.jpg", "So Good They Can't Ignore You" },
                    { new Guid("d173e20d-559e-4127-9ce9-b0ac2564ad97"), " Cal Newport", "In this eye-opening account, Cal Newport debunks the long-held belief that 'follow your passion' is good advice.", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1360564614l/13525945.jpg", "So Good They Can't Ignore You" },
                    { new Guid("d8663e5e-7294-4f81-8739-6e0de1bea7ee"), "K. Anders Ericsson", "A survey of the psychology of expertise, providing techniques for developing mastery of any skill, drawn from the authors' extensive, pathfinding research", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1445050174l/26312997._SY475_.jpg", "Peak: Secrets from the New Science of Expertise" },
                    { new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"), "K. Anders Ericsson", "A survey of the psychology of expertise, providing techniques for developing mastery of any skill, drawn from the authors' extensive, pathfinding research", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1445050174l/26312997._SY475_.jpg", "Peak: Secrets from the New Science of Expertise" },
                    { new Guid("d8663e5e-7494-4f81-8839-6e0de1bea7ee"), "K. Anders Ericsson", "A survey of the psychology of expertise, providing techniques for developing mastery of any skill, drawn from the authors' extensive, pathfinding research", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1445050174l/26312997._SY475_.jpg", "Peak: Secrets from the New Science of Expertise" },
                    { new Guid("d8683e5e-7494-4f81-8739-6e0de1bea7ee"), "K. Anders Ericsson", "A survey of the psychology of expertise, providing techniques for developing mastery of any skill, drawn from the authors' extensive, pathfinding research", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1445050174l/26312997._SY475_.jpg", "Peak: Secrets from the New Science of Expertise" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
