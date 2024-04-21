﻿using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes.BaseValueTypes;
using SEOKeywordsSchema.Schemas.Things;
using SEOKeywordsSchema.Schemas.ValueObjects.Contracts;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.BaseMixedTypes;
public class CreativeWorkOrURL : TwoValues<CreativeWork, URL>
{
    protected CreativeWorkOrURL() { }
    public CreativeWorkOrURL(CreativeWork value1) : base(value1)
    {
    }
    public CreativeWorkOrURL(URL value2) : base(value2)
    {
    }

}


[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<SubjectOf>))]
public class SubjectOf : CreativeWorkOrURL
{
    protected SubjectOf() { }
    public SubjectOf(CreativeWork value1) : base(value1) { }
}
[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<MainEntityOfPage>))]
public class MainEntityOfPage : CreativeWorkOrURL {
    protected MainEntityOfPage() { }
    public MainEntityOfPage(CreativeWork value1) : base(value1) { }

    public MainEntityOfPage(URL value2) : base(value2)
    {
    }
}
