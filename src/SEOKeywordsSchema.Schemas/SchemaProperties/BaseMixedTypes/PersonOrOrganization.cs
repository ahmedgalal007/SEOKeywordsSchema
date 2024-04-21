using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Things;
using SEOKeywordsSchema.Schemas.ValueObjects.Contracts;

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

