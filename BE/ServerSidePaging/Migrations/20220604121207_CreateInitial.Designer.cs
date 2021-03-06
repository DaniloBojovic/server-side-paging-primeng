// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServerSidePaging.Context;

#nullable disable

namespace ServerSidePaging.Migrations
{
    [DbContext(typeof(BooksContext))]
    [Migration("20220604121207_CreateInitial")]
    partial class CreateInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ServerSidePaging.Models.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("493c3228-3444-4a49-9cc0-e8532edc59b2"),
                            Author = "Josh Waitzkin",
                            Description = "With a narrative that combines heart-stopping martial arts wars and tense chess face-offs with life lessons that speak to all of us, 'The Art of Learning' takes readers through Waitzkin's unique journey to excellence.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1348688766l/857333.jpg",
                            Title = "The Art of Learning: A Journey in the Pursuit of Excellence"
                        },
                        new
                        {
                            Id = new Guid("40ff5488-fdab-45b5-bc3a-14302d59869a"),
                            Author = "Andy Hunt",
                            Description = "Software development happens in your head. Not in an editor, IDE, or design tool. You're well educated on how to work with software and hardware, but what about wetware--our own brains? Learning new skills and new technology is critical to your career, and it's all in your head.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1390692774l/3063393.jpg",
                            Title = "Pragmatic Thinking and Learning: Refactor Your Wetware"
                        },
                        new
                        {
                            Id = new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                            Author = "Yuval Noah Harari",
                            Description = "100,000 years ago, at least six human species inhabited the earth. Today there is just one. Us. Homo sapiens.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1420585954l/23692271.jpg",
                            Title = "Sapiens: A Brief History of Humankind"
                        },
                        new
                        {
                            Id = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            Author = "K. Anders Ericsson",
                            Description = "A survey of the psychology of expertise, providing techniques for developing mastery of any skill, drawn from the authors' extensive, pathfinding research",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1445050174l/26312997._SY475_.jpg",
                            Title = "Peak: Secrets from the New Science of Expertise"
                        },
                        new
                        {
                            Id = new Guid("d173e20d-159e-4127-9ce9-b0ac2564ad97"),
                            Author = " Cal Newport",
                            Description = "In this eye-opening account, Cal Newport debunks the long-held belief that 'follow your passion' is good advice.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1360564614l/13525945.jpg",
                            Title = "So Good They Can't Ignore You"
                        },
                        new
                        {
                            Id = new Guid("494c3228-3444-4a49-9cc0-e8532edc59b2"),
                            Author = "Josh Waitzkin",
                            Description = "With a narrative that combines heart-stopping martial arts wars and tense chess face-offs with life lessons that speak to all of us, 'The Art of Learning' takes readers through Waitzkin's unique journey to excellence.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1348688766l/857333.jpg",
                            Title = "The Art of Learning: A Journey in the Pursuit of Excellence"
                        },
                        new
                        {
                            Id = new Guid("41ff5488-fdab-45b5-bc3a-14302d59869a"),
                            Author = "Andy Hunt",
                            Description = "Software development happens in your head. Not in an editor, IDE, or design tool. You're well educated on how to work with software and hardware, but what about wetware--our own brains? Learning new skills and new technology is critical to your career, and it's all in your head.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1390692774l/3063393.jpg",
                            Title = "Pragmatic Thinking and Learning: Refactor Your Wetware"
                        },
                        new
                        {
                            Id = new Guid("5b1c3b4d-48c7-402a-80c3-cc796ad49c6b"),
                            Author = "Yuval Noah Harari",
                            Description = "100,000 years ago, at least six human species inhabited the earth. Today there is just one. Us. Homo sapiens.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1420585954l/23692271.jpg",
                            Title = "Sapiens: A Brief History of Humankind"
                        },
                        new
                        {
                            Id = new Guid("d8683e5e-7494-4f81-8739-6e0de1bea7ee"),
                            Author = "K. Anders Ericsson",
                            Description = "A survey of the psychology of expertise, providing techniques for developing mastery of any skill, drawn from the authors' extensive, pathfinding research",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1445050174l/26312997._SY475_.jpg",
                            Title = "Peak: Secrets from the New Science of Expertise"
                        },
                        new
                        {
                            Id = new Guid("d172e20d-159e-4127-9ce9-b0ac2564ad97"),
                            Author = " Cal Newport",
                            Description = "In this eye-opening account, Cal Newport debunks the long-held belief that 'follow your passion' is good advice.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1360564614l/13525945.jpg",
                            Title = "So Good They Can't Ignore You"
                        },
                        new
                        {
                            Id = new Guid("413c3228-3444-4a49-9cc0-e8532edc59b2"),
                            Author = "Josh Waitzkin",
                            Description = "With a narrative that combines heart-stopping martial arts wars and tense chess face-offs with life lessons that speak to all of us, 'The Art of Learning' takes readers through Waitzkin's unique journey to excellence.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1348688766l/857333.jpg",
                            Title = "The Art of Learning: A Journey in the Pursuit of Excellence"
                        },
                        new
                        {
                            Id = new Guid("40ff5588-fdab-45b5-bc3a-14302d59869a"),
                            Author = "Andy Hunt",
                            Description = "Software development happens in your head. Not in an editor, IDE, or design tool. You're well educated on how to work with software and hardware, but what about wetware--our own brains? Learning new skills and new technology is critical to your career, and it's all in your head.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1390692774l/3063393.jpg",
                            Title = "Pragmatic Thinking and Learning: Refactor Your Wetware"
                        },
                        new
                        {
                            Id = new Guid("5b1c2b4d-48c7-412a-80c3-cc796ad49c6b"),
                            Author = "Yuval Noah Harari",
                            Description = "100,000 years ago, at least six human species inhabited the earth. Today there is just one. Us. Homo sapiens.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1420585954l/23692271.jpg",
                            Title = "Sapiens: A Brief History of Humankind"
                        },
                        new
                        {
                            Id = new Guid("d8663e5e-7294-4f81-8739-6e0de1bea7ee"),
                            Author = "K. Anders Ericsson",
                            Description = "A survey of the psychology of expertise, providing techniques for developing mastery of any skill, drawn from the authors' extensive, pathfinding research",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1445050174l/26312997._SY475_.jpg",
                            Title = "Peak: Secrets from the New Science of Expertise"
                        },
                        new
                        {
                            Id = new Guid("d173e20d-559e-4127-9ce9-b0ac2564ad97"),
                            Author = " Cal Newport",
                            Description = "In this eye-opening account, Cal Newport debunks the long-held belief that 'follow your passion' is good advice.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1360564614l/13525945.jpg",
                            Title = "So Good They Can't Ignore You"
                        },
                        new
                        {
                            Id = new Guid("493c3628-3444-4a49-9cc0-e8532edc59b2"),
                            Author = "Josh Waitzkin",
                            Description = "With a narrative that combines heart-stopping martial arts wars and tense chess face-offs with life lessons that speak to all of us, 'The Art of Learning' takes readers through Waitzkin's unique journey to excellence.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1348688766l/857333.jpg",
                            Title = "The Art of Learning: A Journey in the Pursuit of Excellence"
                        },
                        new
                        {
                            Id = new Guid("40ff5488-fdab-45b5-bc3a-18302d59869a"),
                            Author = "Andy Hunt",
                            Description = "Software development happens in your head. Not in an editor, IDE, or design tool. You're well educated on how to work with software and hardware, but what about wetware--our own brains? Learning new skills and new technology is critical to your career, and it's all in your head.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1390692774l/3063393.jpg",
                            Title = "Pragmatic Thinking and Learning: Refactor Your Wetware"
                        },
                        new
                        {
                            Id = new Guid("5b1c2b4d-48c7-402a-80c3-cc799ad49c6b"),
                            Author = "Yuval Noah Harari",
                            Description = "100,000 years ago, at least six human species inhabited the earth. Today there is just one. Us. Homo sapiens.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1420585954l/23692271.jpg",
                            Title = "Sapiens: A Brief History of Humankind"
                        },
                        new
                        {
                            Id = new Guid("d8663e5e-7494-4f81-8839-6e0de1bea7ee"),
                            Author = "K. Anders Ericsson",
                            Description = "A survey of the psychology of expertise, providing techniques for developing mastery of any skill, drawn from the authors' extensive, pathfinding research",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1445050174l/26312997._SY475_.jpg",
                            Title = "Peak: Secrets from the New Science of Expertise"
                        },
                        new
                        {
                            Id = new Guid("d173e20d-159e-4627-9ce9-b0ac2564ad97"),
                            Author = " Cal Newport",
                            Description = "In this eye-opening account, Cal Newport debunks the long-held belief that 'follow your passion' is good advice.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1360564614l/13525945.jpg",
                            Title = "So Good They Can't Ignore You"
                        },
                        new
                        {
                            Id = new Guid("493c3228-3444-4a59-9cc0-e8532edc59b2"),
                            Author = "Josh Waitzkin",
                            Description = "With a narrative that combines heart-stopping martial arts wars and tense chess face-offs with life lessons that speak to all of us, 'The Art of Learning' takes readers through Waitzkin's unique journey to excellence.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1348688766l/857333.jpg",
                            Title = "The Art of Learning: A Journey in the Pursuit of Excellence"
                        },
                        new
                        {
                            Id = new Guid("40ff5488-fdab-49b5-bc3a-14302d59869a"),
                            Author = "Andy Hunt",
                            Description = "Software development happens in your head. Not in an editor, IDE, or design tool. You're well educated on how to work with software and hardware, but what about wetware--our own brains? Learning new skills and new technology is critical to your career, and it's all in your head.",
                            Img = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1390692774l/3063393.jpg",
                            Title = "Pragmatic Thinking and Learning: Refactor Your Wetware"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
