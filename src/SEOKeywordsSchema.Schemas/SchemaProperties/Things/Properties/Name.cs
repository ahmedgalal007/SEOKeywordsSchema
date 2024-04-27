using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.Things.Properties;

[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<Name>))]
public class Name: List<Text>, ISchemaProperty<Name>
{
    public Name(String value):base(new List<Text> { new Text(value)})
    { }

    public static implicit operator Name(string value)
    {
        return new Name(value);
    }
}
