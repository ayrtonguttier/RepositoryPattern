using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Data.EF.Configuration
{
    public class PessoaConfiguration : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("TB_PESSOA");

            builder.HasKey(x => x.ID);

            FormatoID(builder.Property(x => x.ID));
            FormatoNome(builder.Property(x => x.Nome));
            FormatoSobreNome(builder.Property(x => x.Sobrenome));
        }

        private void FormatoSobreNome(PropertyBuilder<string> propertyBuilder)
        {
            propertyBuilder.HasColumnName("NM_SOBRENOME");
            propertyBuilder.HasColumnType("VARCHAR");
            propertyBuilder.HasMaxLength(100);
            propertyBuilder.IsRequired();
        }

        private void FormatoNome(PropertyBuilder<string> propertyBuilder)
        {
            propertyBuilder.HasColumnName("NM_NOME");
            propertyBuilder.HasColumnType("VARCHAR");
            propertyBuilder.HasMaxLength(100);
            propertyBuilder.IsRequired();
        }

        private void FormatoID(PropertyBuilder<int> propertyBuilder)
        {
            propertyBuilder.HasColumnName("ID_PESSOA");
            propertyBuilder.HasColumnType("INT");
            propertyBuilder.IsRequired();
            propertyBuilder.UseIdentityColumn();
        }
    }
}
