using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.ValueObjects.Interfaces;


namespace SEOKeywordsSchema.Schemas.Schema.Org.Entities.Organizations;
public class Organization : Thing, IValuesMember<Organization>
{
    public override string TypeName { get; protected set; } = nameof(Organization);
    public Organization? Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    DefaultIdType IValuesMember<DefaultIdType, Organization>.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public Organization Delete(DefaultIdType id)
    {
        throw new NotImplementedException();
    }

    public Boolean Equals(IValuesMember<DefaultIdType, Organization>? other)
    {
        throw new NotImplementedException();
    }

    public Organization Update(Organization value)
    {
        throw new NotImplementedException();
    }
}

// TODO Airline
// TODO Consortium
// TODO Corporation
// TODO EducationalOrganization
// TODO FundingScheme
// TODO GovernmentOrganization
// TODO LibrarySystem
// TODO LocalBusiness
// TODO MedicalOrganization
// TODO NGO
// TODO NewsMediaOrganization
// TODO OnlineBusiness
// TODO PerformingGroup
// TODO PoliticalParty
// TODO Project
// TODO ResearchOrganization
// TODO SearchRescueOrganization
// TODO SportsOrganization
// TODO WorkersUnion
