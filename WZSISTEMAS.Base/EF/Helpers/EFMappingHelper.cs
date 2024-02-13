using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WZSISTEMAS.Base.EF.Helpers;

public static class EFMappingHelper
{

    public const string StringType = "VARCHAR";
    public const string DecimalType = "DECIMAL";
    public const string DateTimeType = "DATETIME2";
    public const string EnumType = "INT";
    public const string IntType = "INT";
    public const string LongType = "BIGINT";
    public const string BoolType = "BIT";

    public static PropertyBuilder<T> HasMaxLength<T>(this PropertyBuilder<T> builder)
        => builder.HasMaxLength(maxLength: -1);

    public static ReferenceReferenceBuilder<T1, T2> IsOptional<T1, T2>(this ReferenceReferenceBuilder<T1, T2> builder)
        where T1 : class
        where T2 : class
        => builder.IsRequired(false);

    public static PropertyBuilder<T> IsOptional<T>(this PropertyBuilder<T> builder)
        => builder.IsRequired(false);

    public static ReferenceCollectionBuilder<T1, T2> IsOptional<T1, T2>(this ReferenceCollectionBuilder<T1, T2> builder)
    where T1 : class
    where T2 : class
        => builder.IsRequired(false);

    public static PropertyBuilder<T> HasColumnType<T>(this PropertyBuilder<T> builder, SqlDbType sqlDbType)
    {
        return sqlDbType switch
        {
            SqlDbType.Bit => builder.HasBool(),
            SqlDbType.BigInt => builder.HasLong(),
            SqlDbType.DateTime2 => builder.HasDateTime(),
            SqlDbType.Decimal => builder.HasDecimal(),
            SqlDbType.Int => builder.HasInt(),
            SqlDbType.VarChar => builder.HasString(),
            _ => throw new NotSupportedException("O tipo de dados do SQL não é suportado")
        };
    }        

    public static PropertyBuilder<T> HasString<T>(this PropertyBuilder<T> builder)
        => builder.HasColumnType(StringType);

    public static PropertyBuilder<T> HasDecimal<T>(this PropertyBuilder<T> builder)
        => builder.HasColumnType(DecimalType);

    public static PropertyBuilder<T> HasLong<T>(this PropertyBuilder<T> builder)
        => builder.HasColumnType(LongType);

    public static PropertyBuilder<T> HasInt<T>(this PropertyBuilder<T> builder)
        => builder.HasColumnType(IntType);

    public static PropertyBuilder<T> HasEnum<T>(this PropertyBuilder<T> builder)
        => builder.HasColumnType(EnumType);

    public static PropertyBuilder<T> HasDateTime<T>(this PropertyBuilder<T> builder)
        => builder.HasColumnType(DateTimeType);

    public static PropertyBuilder<T> HasBool<T>(this PropertyBuilder<T> builder)
        => builder.HasColumnType(BoolType);
}
