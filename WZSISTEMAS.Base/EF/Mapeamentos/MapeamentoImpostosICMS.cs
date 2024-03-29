﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WZSISTEMAS.Base.EF.Mapeamentos;
public static class MapeamentoImpostosICMS
{
    public static void Mapear<T>(EntityTypeBuilder<T> builder)
        where T : class, IImpostoICMS
    {
        builder.Property(x => x.TipoICMS)
            .HasColumnName("TIPO_ICMS")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.ICMS)
            .HasColumnName("ICMS")
            .HasString()
            .HasMaxLength()
            .IsRequired();
    }
}
