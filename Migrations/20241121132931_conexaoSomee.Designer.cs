﻿// <auto-generated />
using System;
using Futnatics.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Futnatics.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241121132931_conexaoSomee")]
    partial class conexaoSomee
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Futnatics.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cpf")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<int>("Rg")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CLIENTES", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cpf = 546812798,
                            Email = "Renanalmeidadantas2007@gmail.com",
                            Endereco = "Rua Jonas Cardoso N: 16B ",
                            Nome = "Renan",
                            Rg = 1241454213
                        },
                        new
                        {
                            Id = 2,
                            Cpf = 124345325,
                            Email = "DanilloLacerdad470",
                            Endereco = "Rua Serra Do Apodi",
                            Nome = "Danillo",
                            Rg = 235252436
                        },
                        new
                        {
                            Id = 3,
                            Cpf = 21345235,
                            Email = "FelipeSilva@gmail.com",
                            Endereco = "Rua Elisa do Apodi",
                            Nome = "Felipe",
                            Rg = 123542253
                        });
                });

            modelBuilder.Entity("Futnatics.Models.Partida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Estadio")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<string>("TimeCasa")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<string>("TimeFora")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("PARTIDAS", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Data = new DateTime(2024, 11, 4, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            Estadio = "Neo Quimica Arena",
                            TimeCasa = "Corinthians",
                            TimeFora = "Palmeiras"
                        },
                        new
                        {
                            Id = 2,
                            Data = new DateTime(2024, 11, 9, 16, 30, 0, 0, DateTimeKind.Unspecified),
                            Estadio = "Barradão",
                            TimeCasa = "Vitoria",
                            TimeFora = "Corinthians"
                        });
                });

            modelBuilder.Entity("Futnatics.Models.Time", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<string>("Estadio")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<DateTime>("FundadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<string>("MaiorRival")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<string>("Mascote")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("TIMES", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cidade = "São Paulo",
                            Estadio = "Neo Quimica Arena",
                            Estado = "SP",
                            FundadoEm = new DateTime(1910, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fworldvectorlogo.com%2Fpt%2Flogo%2Fcorinthians-1&psig=AOvVaw3JIoaqcowrWn3X94Ey9eGX&ust=1732226050083000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCODnvYTz64kDFQAAAAAdAAAAABAJ",
                            MaiorRival = "Palmeiras",
                            Mascote = "Mosqueteiro",
                            Nome = "Corinthians",
                            Pais = "Brasil",
                            Sigla = "Sccp"
                        },
                        new
                        {
                            Id = 2,
                            Cidade = "São Paulo",
                            Estadio = "Morumbi",
                            Estado = "SP",
                            FundadoEm = new DateTime(1930, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fpt.m.wikipedia.org%2Fwiki%2FFicheiro%3AS%25C3%25A3o_Paulo_Futebol_Clube.png&psig=AOvVaw1xeJ1hMP53za1kzJirVB35&ust=1732226361260000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCPDDj53064kDFQAAAAAdAAAAABAI",
                            MaiorRival = "Corinthians",
                            Mascote = "Santo Paulo",
                            Nome = "São Paulo",
                            Pais = "Brasil",
                            Sigla = "SPFC"
                        },
                        new
                        {
                            Id = 3,
                            Cidade = "Belo Horizonte",
                            Estadio = "Mineirão",
                            Estado = "BH",
                            FundadoEm = new DateTime(1921, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fpt.m.wikipedia.org%2Fwiki%2FFicheiro%3AS%25C3%25A3o_Paulo_Futebol_Clube.png&psig=AOvVaw1xeJ1hMP53za1kzJirVB35&ust=1732226361260000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCPDDj53064kDFQAAAAAdAAAAABAI",
                            MaiorRival = "Atlético Mg",
                            Mascote = "Raposa",
                            Nome = "Cruzeiro",
                            Pais = "Brasil",
                            Sigla = "Cru"
                        },
                        new
                        {
                            Id = 4,
                            Cidade = "Bragança Paulista",
                            Estadio = "Nabi Abi Chedid",
                            Estado = "SP",
                            FundadoEm = new DateTime(1928, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Logo = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fworldvectorlogo.com%2Fpt%2Flogo%2Fcorinthians-1&psig=AOvVaw3JIoaqcowrWn3X94Ey9eGX&ust=1732226050083000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCODnvYTz64kDFQAAAAAdAAAAABAJ",
                            MaiorRival = "Corinthians",
                            Mascote = "Touro",
                            Nome = "Bragantino",
                            Pais = "Brasil",
                            Sigla = "Bra"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
