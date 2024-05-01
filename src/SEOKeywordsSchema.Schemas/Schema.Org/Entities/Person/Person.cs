using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;

using SEOKeywordsSchema.Schemas.SchemaProperties;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Organizations;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.Places;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Persons;
public class Person : Thing, IPersonProperty, IValuesMember<Person>
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
    public Person? Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    DefaultIdType IValuesMember<DefaultIdType, Person>.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public Person Delete(DefaultIdType id)
    {
        throw new NotImplementedException();
    }

    public Boolean Equals(IValuesMember<DefaultIdType, Person>? other)
    {
        throw new NotImplementedException();
    }

    public Person Update(Person value)
    {
        throw new NotImplementedException();
    }
}
