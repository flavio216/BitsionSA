﻿// <auto-generated />
using Bitsion.ContextData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bitsion.ContextData.Migrations
{
    [DbContext(typeof(BitsionDB))]
    partial class BitsionDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bitsion.Entities.Client", b =>
                {
                    b.Property<int>("cli_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("cli_Active")
                        .HasColumnType("bit");

                    b.Property<bool>("cli_Diabetic")
                        .HasColumnType("bit");

                    b.Property<string>("cli_Diseases")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cli_Dni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("cli_Drive")
                        .HasColumnType("bit");

                    b.Property<string>("cli_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("cli_OtherDiseases")
                        .HasColumnType("bit");

                    b.Property<bool>("cli_UseGlasses")
                        .HasColumnType("bit");

                    b.Property<int>("cli_doc_DocumentType")
                        .HasColumnType("int");

                    b.Property<int>("cli_gen_Gender")
                        .HasColumnType("int");

                    b.HasKey("cli_Id");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            cli_Id = 1,
                            cli_Active = true,
                            cli_Diabetic = true,
                            cli_Diseases = "Hipertensión",
                            cli_Dni = "40777666",
                            cli_Drive = true,
                            cli_Name = "Roberto Gomez",
                            cli_OtherDiseases = false,
                            cli_UseGlasses = true,
                            cli_doc_DocumentType = 1,
                            cli_gen_Gender = 1
                        },
                        new
                        {
                            cli_Id = 2,
                            cli_Active = true,
                            cli_Diabetic = false,
                            cli_Diseases = "Ceguera",
                            cli_Dni = "14557234",
                            cli_Drive = true,
                            cli_Name = "Fulanita Perez",
                            cli_OtherDiseases = false,
                            cli_UseGlasses = true,
                            cli_doc_DocumentType = 1,
                            cli_gen_Gender = 2
                        });
                });

            modelBuilder.Entity("Bitsion.Entities.DocumentType", b =>
                {
                    b.Property<int>("doc_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("doc_Document")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("doc_Id");

                    b.ToTable("DocumentTypes");

                    b.HasData(
                        new
                        {
                            doc_Id = 1,
                            doc_Document = "DNI"
                        },
                        new
                        {
                            doc_Id = 2,
                            doc_Document = "Pasaporte"
                        },
                        new
                        {
                            doc_Id = 3,
                            doc_Document = "Carnet Extranjero"
                        });
                });

            modelBuilder.Entity("Bitsion.Entities.Gender", b =>
                {
                    b.Property<int>("gen_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("gen_Gender")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("gen_Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            gen_Id = 1,
                            gen_Gender = "Masculino"
                        },
                        new
                        {
                            gen_Id = 2,
                            gen_Gender = "Femenino"
                        },
                        new
                        {
                            gen_Id = 3,
                            gen_Gender = "Prefiero no decirlo"
                        },
                        new
                        {
                            gen_Id = 4,
                            gen_Gender = "Otro"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
