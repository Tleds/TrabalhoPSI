﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PUC.LDSI.DataBase.Context;

namespace PUC.LDSI.DataBase.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191104032025_AppMigration")]
    partial class AppMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Matricula")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.Property<string>("Senha")
                        .HasMaxLength(100);

                    b.Property<int?>("TurmaId");

                    b.HasKey("Id");

                    b.HasIndex("TurmaId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasMaxLength(255);

                    b.Property<string>("Disciplina")
                        .HasMaxLength(100);

                    b.Property<string>("Materia")
                        .HasMaxLength(100);

                    b.Property<int>("ProfessorId");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Avaliacoes");
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.OpcaoAvaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasMaxLength(255);

                    b.Property<int?>("QuestaoId");

                    b.Property<bool>("Verdadeira")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("QuestaoId");

                    b.ToTable("OpcoesAvaliacao");
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.OpcaoProva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OpcaoId");

                    b.Property<int?>("QuestaoProvaId");

                    b.Property<bool>("Resposta");

                    b.HasKey("Id");

                    b.HasIndex("OpcaoId");

                    b.HasIndex("QuestaoProvaId");

                    b.ToTable("OpcoesProva");
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.Property<string>("Senha")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.Prova", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlunoId");

                    b.Property<int>("AvaliacaoId");

                    b.Property<DateTime>("DataProva");

                    b.Property<decimal>("NotaEmitida")
                        .HasColumnType("decimal(10,4)");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("AvaliacaoId");

                    b.ToTable("Provas");
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.Publicacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AvaliacaoId");

                    b.Property<DateTime>("DataFim")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("DATETIME");

                    b.Property<DateTime>("DataPublicacao")
                        .HasColumnType("DATETIME");

                    b.Property<int?>("TurmaId");

                    b.Property<int>("ValorProva")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("AvaliacaoId");

                    b.HasIndex("TurmaId");

                    b.ToTable("Publicacoes");
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.Questao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AvaliacaoId");

                    b.Property<string>("Enunciado")
                        .HasMaxLength(255);

                    b.Property<int>("Tipo")
                        .HasColumnType("INT");

                    b.HasKey("Id");

                    b.HasIndex("AvaliacaoId");

                    b.ToTable("Questoes");
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.QuestaoProva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Nota")
                        .HasColumnType("DECIMAL(5,2)");

                    b.Property<int?>("ProvaId");

                    b.Property<int?>("QuestaoId");

                    b.HasKey("Id");

                    b.HasIndex("ProvaId");

                    b.HasIndex("QuestaoId");

                    b.ToTable("QuestoesProva");
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.Aluno", b =>
                {
                    b.HasOne("PUC.LDSI.Domain.Entities.Turma", "Turma")
                        .WithMany("Alunos")
                        .HasForeignKey("TurmaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.Avaliacao", b =>
                {
                    b.HasOne("PUC.LDSI.Domain.Entities.Professor", "Professor")
                        .WithMany()
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.OpcaoAvaliacao", b =>
                {
                    b.HasOne("PUC.LDSI.Domain.Entities.Questao", "Questao")
                        .WithMany()
                        .HasForeignKey("QuestaoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.OpcaoProva", b =>
                {
                    b.HasOne("PUC.LDSI.Domain.Entities.OpcaoAvaliacao", "Opcao")
                        .WithMany()
                        .HasForeignKey("OpcaoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PUC.LDSI.Domain.Entities.QuestaoProva", "QuestaoProva")
                        .WithMany()
                        .HasForeignKey("QuestaoProvaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.Prova", b =>
                {
                    b.HasOne("PUC.LDSI.Domain.Entities.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PUC.LDSI.Domain.Entities.Avaliacao", "Avaliacao")
                        .WithMany("Provas")
                        .HasForeignKey("AvaliacaoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.Publicacao", b =>
                {
                    b.HasOne("PUC.LDSI.Domain.Entities.Avaliacao", "Avaliacao")
                        .WithMany("Publicacoes")
                        .HasForeignKey("AvaliacaoId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PUC.LDSI.Domain.Entities.Turma", "Turma")
                        .WithMany()
                        .HasForeignKey("TurmaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.Questao", b =>
                {
                    b.HasOne("PUC.LDSI.Domain.Entities.Avaliacao", "Avaliacao")
                        .WithMany("Questoes")
                        .HasForeignKey("AvaliacaoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("PUC.LDSI.Domain.Entities.QuestaoProva", b =>
                {
                    b.HasOne("PUC.LDSI.Domain.Entities.Prova", "Prova")
                        .WithMany()
                        .HasForeignKey("ProvaId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("PUC.LDSI.Domain.Entities.Questao", "Questao")
                        .WithMany()
                        .HasForeignKey("QuestaoId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
