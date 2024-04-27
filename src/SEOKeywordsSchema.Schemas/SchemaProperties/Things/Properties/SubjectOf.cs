﻿using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.SchemaEntities;
using SEOKeywordsSchema.Schemas.Types.MixedTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.Things.Properties;
[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<SubjectOf>))]
public class SubjectOf : CreativeWorkOrURL, ISchemaProperty<SubjectOf>
{
    protected SubjectOf() { }
    public SubjectOf(CreativeWork value1) : base(value1) { }
}
