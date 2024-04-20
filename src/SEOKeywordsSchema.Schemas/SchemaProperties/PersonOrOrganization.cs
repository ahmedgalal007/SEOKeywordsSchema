using SEOKeywordsSchema.Schemas.Things;
using SEOKeywordsSchema.Schemas.ValueObjects.Contracts;

namespace SEOKeywordsSchema.Schemas.SchemaProperties;

public class PersonOrOrganization : TwoValues<Person, Organization>
{
    public PersonOrOrganization(Person value1) : base(value1)
    {
    }
    public PersonOrOrganization(Organization value2) : base(value2)
    {
    }
}
