﻿// <auto-generated />
using FormularioTeste.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FormularioTeste.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FormularioTeste.Data.Models.DadosFormulario", b =>
                {
                    b.Property<int>("DadosFormularioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FormularioId");

                    b.Property<string>("NomeDoProprietario");

                    b.HasKey("DadosFormularioId");

                    b.HasIndex("FormularioId");

                    b.ToTable("DadosFormularios");
                });

            modelBuilder.Entity("FormularioTeste.Data.Models.Formulario", b =>
                {
                    b.Property<int>("FormularioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired();

                    b.Property<string>("NomeDoAnimal")
                        .IsRequired();

                    b.Property<string>("NomeDoProprietario")
                        .IsRequired();

                    b.Property<string>("RacaDoAnimal")
                        .IsRequired();

                    b.Property<string>("Telefone")
                        .IsRequired();

                    b.HasKey("FormularioId");

                    b.ToTable("Formularios");
                });

            modelBuilder.Entity("FormularioTeste.Data.Models.DadosFormulario", b =>
                {
                    b.HasOne("FormularioTeste.Data.Models.Formulario", "Formulario")
                        .WithMany()
                        .HasForeignKey("FormularioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
