// <auto-generated />
using System;
using FeedbackSystem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FeedbackSystem.Migrations
{
    [DbContext(typeof(FeedbackSysContext))]
    [Migration("20220107142045_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FeedbackSystem.Models.Product", b =>
                {
                    b.Property<int>("Pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Pid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FeedbackSystem.Models.Question", b =>
                {
                    b.Property<int>("Qid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QType")
                        .HasColumnType("int");

                    b.Property<string>("Questions")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Qid");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("FeedbackSystem.Models.Survey", b =>
                {
                    b.Property<int>("Sid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sid");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("FeedbackSystem.Models.Transaction", b =>
                {
                    b.Property<int>("Tid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductPid")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionQid")
                        .HasColumnType("int");

                    b.Property<int?>("SurveySid")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Tid");

                    b.HasIndex("ProductPid");

                    b.HasIndex("QuestionQid");

                    b.HasIndex("SurveySid");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("FeedbackSystem.Models.Transaction", b =>
                {
                    b.HasOne("FeedbackSystem.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductPid");

                    b.HasOne("FeedbackSystem.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionQid");

                    b.HasOne("FeedbackSystem.Models.Survey", "Survey")
                        .WithMany()
                        .HasForeignKey("SurveySid");

                    b.Navigation("Product");

                    b.Navigation("Question");

                    b.Navigation("Survey");
                });
#pragma warning restore 612, 618
        }
    }
}
