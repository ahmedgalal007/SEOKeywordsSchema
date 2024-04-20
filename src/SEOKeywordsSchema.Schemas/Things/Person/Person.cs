using SEOKeywordsSchema.Schemas.SchemaProperties;

namespace SEOKeywordsSchema.Schemas.Things;
public class Person : Thing, IPersonProperty
{
    public override string TypeName { get; protected set; } = nameof(Person);
    public string AdditionalName { get; set; }
    public Organization Affiliation { get; set; }
    public string award { get; set; }
    public string duns { get; set; }
    public string Email { get; set; }
    public string FamilyName { get; set; }
    public string FaxNumber { get; set; }
    public Place BirthPlace { get; set; }
    public Person Follows { get; set; }

}
