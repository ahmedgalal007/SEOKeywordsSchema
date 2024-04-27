﻿using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.Types;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.Things.Properties;

[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<SameAs>))]
public class SameAs : List<URL>, ISchemaProperty<SameAs>
{
    protected SameAs() : base() { }
    public SameAs(string value) : base(new List<URL> { new URL(value) })
    {

    }
    public SameAs(List<URL> lst) : base(lst)
    {

    }
}
