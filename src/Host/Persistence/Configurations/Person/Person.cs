//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using SEOKeywordsSchema.Schemas.Things;

//namespace Host.Persistence.Configurations.Persons;

//public class PersonConfig : IEntityTypeConfiguration<Person>
//{
//    public void Configure(EntityTypeBuilder<Person> builder)
//    {
//        builder.HasOne(e => e.Affiliation).WithOne().HasForeignKey<Person>().OnDelete(DeleteBehavior.NoAction);
//        builder.HasOne(e => e.BirthPlace).WithOne().HasForeignKey<Place>().OnDelete(DeleteBehavior.NoAction);
//        builder.HasOne(e => e.Follows).WithOne().HasForeignKey<Person>().OnDelete(DeleteBehavior.NoAction);
//    }
//}
