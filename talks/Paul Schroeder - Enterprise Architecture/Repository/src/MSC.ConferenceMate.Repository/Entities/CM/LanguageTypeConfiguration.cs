// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace MSC.ConferenceMate.Repository.Entities.CM
{

    // LanguageType
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class LanguageTypeConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<LanguageType>
    {
        public LanguageTypeConfiguration()
            : this("dbo")
        {
        }

        public LanguageTypeConfiguration(string schema)
        {
            ToTable("LanguageType", schema);
            HasKey(x => x.LanguageTypeId);

            Property(x => x.LanguageTypeId).HasColumnName(@"LanguageTypeId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Code).HasColumnName(@"Code").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.DisplayText).HasColumnName(@"DisplayText").HasColumnType("nvarchar").IsRequired().HasMaxLength(128);
            Property(x => x.DisplayPriority).HasColumnName(@"DisplayPriority").HasColumnType("int").IsRequired();
            Property(x => x.NativeName).HasColumnName(@"NativeName").HasColumnType("nvarchar").IsRequired().HasMaxLength(100);
            Property(x => x.ThreeLetterIsoLanguageName).HasColumnName(@"ThreeLetterISOLanguageName").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(3);
            Property(x => x.TwoLetterIsoLanguageName).HasColumnName(@"TwoLetterISOLanguageName").HasColumnType("nchar").IsRequired().IsFixedLength().HasMaxLength(2);
            Property(x => x.LanguageCultureIdentifier).HasColumnName(@"LanguageCultureIdentifier").HasColumnType("int").IsOptional();
            Property(x => x.DataVersion).HasColumnName(@"DataVersion").HasColumnType("int").IsRequired();
            Property(x => x.CreatedUtcDate).HasColumnName(@"CreatedUtcDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.ModifiedUtcDate).HasColumnName(@"ModifiedUtcDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.ModifiedBy).HasColumnName(@"ModifiedBy").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").HasColumnType("bit").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>