﻿// <auto-generated />
using ExercicioEFCoreCodeFirst;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExercicioEFCoreCodeFirst.Migrations
{
    [DbContext(typeof(IrpfContext))]
    [Migration("20191113230044_ dbinitial")]
    partial class dbinitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExercicioEFCoreCodeFirst.Contribuinte", b =>
                {
                    b.Property<int>("ContribuinteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("LastName");

                    b.HasKey("ContribuinteID");

                    b.ToTable("Contribuintes");
                });

            modelBuilder.Entity("ExercicioEFCoreCodeFirst.Declaracao", b =>
                {
                    b.Property<int>("DeclaracaoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContribuinteID");

                    b.Property<string>("Data");

                    b.Property<int>("NmroDependentes");

                    b.Property<double>("Previdencia");

                    b.Property<double>("RendimentoTrib");

                    b.Property<bool>("Status");

                    b.HasKey("DeclaracaoID");

                    b.HasIndex("ContribuinteID")
                        .IsUnique();

                    b.ToTable("Declaracoes");
                });

            modelBuilder.Entity("ExercicioEFCoreCodeFirst.Deducao", b =>
                {
                    b.Property<int>("DeducaoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeclaracaoID");

                    b.Property<string>("TipoDeducao");

                    b.Property<double>("Valor");

                    b.HasKey("DeducaoID");

                    b.HasIndex("DeclaracaoID");

                    b.ToTable("Deducoes");
                });

            modelBuilder.Entity("ExercicioEFCoreCodeFirst.Declaracao", b =>
                {
                    b.HasOne("ExercicioEFCoreCodeFirst.Contribuinte", "Contribuinte")
                        .WithOne("Declaracao")
                        .HasForeignKey("ExercicioEFCoreCodeFirst.Declaracao", "ContribuinteID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ExercicioEFCoreCodeFirst.Deducao", b =>
                {
                    b.HasOne("ExercicioEFCoreCodeFirst.Declaracao", "Declaracao")
                        .WithMany("Deducoes")
                        .HasForeignKey("DeclaracaoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
