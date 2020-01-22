using System.Data.Entity.ModelConfiguration;
using static System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace WindNetEF
{
    class EntityConfigurationTemplate //: EntityTypeConfiguration<Model>
    {
        /*
        public EntityConfigurationTemplate()
        {
            //Table Name Override
            ToTable("tableName", "schema");

            //primaryKey
            HasKey(p => p.ModelId);

            //add identity to a column
            //default for primary keys
            Property(p => p.OrderId).HasDatabaseGeneratedOption(Identity);

            //restrictions on varchar columns
            //defaul nvarcahr(max)
            Property(p => p.ReferenceNumber)
                .IsRequired()
                .HasMaxLength(24);

            //one to one relation mapping
            HasRequired(m => m.DependentModel)
                .WithRequiredPrincipal(d => d.Model);

            //one to many relation mapping
            HasRequired(m => m.DetailModel)
                .WithMany(d => d.Models)
                .HasForeignKey(m => m.DetailId)
                .WillCascadeOnDelete(false);

            //many to many relation mapping
            HasMany(o => o.DependentModels)
                .WithMany(t => t.Models)
                .Map(m =>
                {
                    m.ToTable("many to many table name");
                    m.MapLeftKey("ModelId");
                    m.MapRightKey("DependentModelId");
                });


        }
        */
    }
}
