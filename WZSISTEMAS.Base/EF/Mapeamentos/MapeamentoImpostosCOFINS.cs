﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WZSISTEMAS.Base.EF.Mapeamentos;

public static class MapeamentoImpostosCOFINS
{
    public static void Mapear<T>(EntityTypeBuilder<T> builder)
        where T : class, IImpostoCOFINS
    {
        builder.Property(x => x.TipoCOFINS)
            .HasColumnName("TIPO_COFINS")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.COFINS)
            .HasColumnName("COFINS")
            .HasString()
            .HasMaxLength()
            .IsRequired();
    }
}
