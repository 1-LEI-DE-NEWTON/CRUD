using CRUD.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Infra.Mappings
{
    public class AlunoMapping : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("BIGINT");

            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("VARCHAR(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnName("Email")
                .HasColumnType("VARCHAR(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.DataNascimento)
                .HasColumnName("DataNascimento")
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(x => x.Telefone)
                .HasColumnName("Telefone")
                .HasColumnType("VARCHAR(20)")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.Matricula)
                .HasColumnName("Matricula")
                .HasColumnType("VARCHAR(20)")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(x => x.Curso)
                .HasColumnName("Curso")
                .HasColumnType("VARCHAR(100)")
                .HasMaxLength(100)
                .IsRequired();

            /*
            builder.HasMany(x => x.Notas)
                .WithOne(x => x.Aluno)
                .HasForeignKey(x => x.AlunoId)
                .OnDelete(DeleteBehavior.Restrict);
            */
        }
    }
}
