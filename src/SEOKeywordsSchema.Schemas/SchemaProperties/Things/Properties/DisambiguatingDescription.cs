using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.Things.Properties;

[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<DisambiguatingDescription>))]
public class DisambiguatingDescription: Text, ISchemaProperty<DisambiguatingDescription> {
    protected DisambiguatingDescription() { }
    public DisambiguatingDescription(string value1) : base(value1) { }

}
