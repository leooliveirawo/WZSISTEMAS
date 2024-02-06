﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WZSISTEMAS.Base.EF.Helpers;
using WZSISTEMAS.Base.NotaFiscal.Interfaces;

namespace WZSISTEMAS.Base.EF.Mapeamentos;

public static class MapeamentoImpostosPIS
{
    public static void Mapear<T>(EntityTypeBuilder<T> builder)
        where T : class, IImpostoPIS
    {
        builder.Property(x => x.TipoPIS)
            .HasColumnName("TIPO_PIS")
            .HasLong()
            .IsRequired();

        builder.Property(x => x.PIS)
            .HasColumnName("PIS")
            .HasString()
            .HasMaxLength()
            .IsRequired();
    }
}
