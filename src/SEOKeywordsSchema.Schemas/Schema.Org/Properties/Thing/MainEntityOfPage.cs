using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.Schema.Org.Entities.CreativeWork;
using SEOKeywordsSchema.Schemas.Schema.Org.Types;
using SEOKeywordsSchema.Schemas.Schema.Org.Types.MixedTypes;

namespace SEOKeywordsSchema.Schemas.Schema.Org.Properties.Thing;
[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<MainEntityOfPage>))]
public class MainEntityOfPage : CreativeWorkOrURL, ISchemaProperty<MainEntityOfPage>
{
    protected MainEntityOfPage() { }
    public MainEntityOfPage(CreativeWork value1) : base(value1) { }

    public MainEntityOfPage(URL value2) : base(value2)
    {
    }
}