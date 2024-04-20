using FSH.WebApi.Domain.Schemas.Properties;
using FSH.WebApi.Domain.Schemas.Things;
using Host.Common.ValueObjects;

namespace Host.Schemas.Properties;

public class PersonOrOrganization : TwoValues<Person, Organization>
{
    public PersonOrOrganization(Person value1) : base(value1)
    {
    }
    public PersonOrOrganization(Organization value2) : base(value2)
    {
    }
}
