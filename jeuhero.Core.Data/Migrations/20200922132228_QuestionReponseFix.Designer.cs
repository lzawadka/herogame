﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using jeuhero.Core.Data.Models;

namespace jeuhero.Core.Data.Migrations
{
    [DbContext(typeof(DefaultContext))]
    [Migration("20200922132228_QuestionReponseFix")]
    partial class QuestionReponseFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("jeuhero.Core.Data.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Description")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("jeuhero.Core.Data.Models.Aventure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aventure");
                });

            modelBuilder.Entity("jeuhero.Core.Data.Models.Paragraphe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Paragraphe");
                });

            modelBuilder.Entity("jeuhero.Core.Data.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ParagrapheId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ParagrapheId")
                        .IsUnique();

                    b.ToTable("Question");
                });

            modelBuilder.Entity("jeuhero.Core.Data.Models.Answer", b =>
                {
                    b.HasOne("jeuhero.Core.Data.Models.Question", null)
                        .WithMany("MyAnswers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("jeuhero.Core.Data.Models.Question", b =>
                {
                    b.HasOne("jeuhero.Core.Data.Models.Paragraphe", null)
                        .WithOne("MyQuestion")
                        .HasForeignKey("jeuhero.Core.Data.Models.Question", "ParagrapheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
