﻿// <auto-generated />
using System;
using Messeger.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Messeger.DAL.Migrations
{
    [DbContext(typeof(Messeger_DBContext))]
    partial class Messeger_DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Messeger.Entity.Member", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Email");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<string>("Surname");

                    b.Property<string>("TagName");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("Messeger.Entity.Message", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Desc");

                    b.Property<string>("Header");

                    b.Property<bool>("IsActive");

                    b.Property<int>("MemberID");

                    b.HasKey("ID");

                    b.HasIndex("MemberID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Messeger.Entity.MessageDetails", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<int>("MemberID");

                    b.Property<int>("MessageID");

                    b.Property<string>("Text");

                    b.HasKey("ID");

                    b.HasIndex("MemberID");

                    b.HasIndex("MessageID");

                    b.ToTable("MessageDetails");
                });

            modelBuilder.Entity("Messeger.Entity.MessageMember", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<int>("MemberID");

                    b.Property<int>("MessageID");

                    b.HasKey("ID");

                    b.HasIndex("MemberID");

                    b.HasIndex("MessageID");

                    b.ToTable("MessageMembers");
                });

            modelBuilder.Entity("Messeger.Entity.Message", b =>
                {
                    b.HasOne("Messeger.Entity.Member", "Member")
                        .WithMany("Messages")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Messeger.Entity.MessageDetails", b =>
                {
                    b.HasOne("Messeger.Entity.Member", "Member")
                        .WithMany("MessageDetails")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Messeger.Entity.Message", "Message")
                        .WithMany("MessageDetails")
                        .HasForeignKey("MessageID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Messeger.Entity.MessageMember", b =>
                {
                    b.HasOne("Messeger.Entity.Member", "Member")
                        .WithMany("MessageMembers")
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Messeger.Entity.Message", "Message")
                        .WithMany("MessageMembers")
                        .HasForeignKey("MessageID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
