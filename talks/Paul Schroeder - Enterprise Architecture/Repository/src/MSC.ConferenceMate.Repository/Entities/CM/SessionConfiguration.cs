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

    // Session
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.33.0.0")]
    public partial class SessionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Session>
    {
        public SessionConfiguration()
            : this("dbo")
        {
        }

        public SessionConfiguration(string schema)
        {
            ToTable("Session", schema);
            HasKey(x => x.SessionId);

            Property(x => x.SessionId).HasColumnName(@"SessionId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Title).HasColumnName(@"Title").HasColumnType("nvarchar").IsRequired().HasMaxLength(1000);
            Property(x => x.ShortTitle).HasColumnName(@"ShortTitle").HasColumnType("nvarchar").IsOptional().HasMaxLength(500);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(4000);
            Property(x => x.RoomId).HasColumnName(@"RoomId").HasColumnType("int").IsOptional();
            Property(x => x.StartTime).HasColumnName(@"StartTime").HasColumnType("datetime2").IsOptional();
            Property(x => x.EndTime).HasColumnName(@"EndTime").HasColumnType("datetime2").IsOptional();
            Property(x => x.DataVersion).HasColumnName(@"DataVersion").HasColumnType("int").IsRequired();
            Property(x => x.CreatedUtcDate).HasColumnName(@"CreatedUtcDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.CreatedBy).HasColumnName(@"CreatedBy").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.ModifiedUtcDate).HasColumnName(@"ModifiedUtcDate").HasColumnType("datetime2").IsRequired();
            Property(x => x.ModifiedBy).HasColumnName(@"ModifiedBy").HasColumnType("nvarchar").IsRequired().HasMaxLength(200);
            Property(x => x.IsDeleted).HasColumnName(@"IsDeleted").HasColumnType("bit").IsRequired();

            // Foreign keys
            HasOptional(a => a.Room).WithMany(b => b.Sessions).HasForeignKey(c => c.RoomId).WillCascadeOnDelete(false); // FK_Session_Room
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>