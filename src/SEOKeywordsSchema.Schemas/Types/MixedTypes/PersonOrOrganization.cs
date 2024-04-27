﻿using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.BaseValueTypes.MultibleValueTypes;
using SEOKeywordsSchema.Schemas.SchemaEntities;

namespace SEOKeywordsSchema.Schemas.Types.MixedTypes;
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
