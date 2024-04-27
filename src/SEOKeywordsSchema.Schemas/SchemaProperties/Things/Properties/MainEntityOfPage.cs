using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.SchemaEntities;
using SEOKeywordsSchema.Schemas.Types.MixedTypes;
using SEOKeywordsSchema.Schemas.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.Things.Properties;
[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<MainEntityOfPage>))]
public class MainEntityOfPage : CreativeWorkOrURL, ISchemaProperty<MainEntityOfPage>
{
    protected MainEntityOfPage() { }
    public MainEntityOfPage(CreativeWork value1) : base(value1) { }

    public MainEntityOfPage(URL value2) : base(value2)
    {
    }
}