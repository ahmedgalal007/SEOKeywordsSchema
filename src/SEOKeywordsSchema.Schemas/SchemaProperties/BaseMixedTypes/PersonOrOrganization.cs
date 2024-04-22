using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.ValueObjects.Contracts;
using SEOKeywordsSchema.Schemas.Things;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes;
public class PersonOrOrganization : TwoValues<Person, Organization>
{
    protected PersonOrOrganization() { }
    public PersonOrOrganization(Person value1) : base(value1)
    {
    }
    public PersonOrOrganization(Organization value2) : base(value2)
    {
    }
}

