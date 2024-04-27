using Microsoft.EntityFrameworkCore;
using SEOKeywordsSchema.Schemas.Contracts.Interfaces;
using SEOKeywordsSchema.Schemas.SchemaEntities.CreativeWorks.MediaObjects;
using SEOKeywordsSchema.Schemas.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEOKeywordsSchema.Schemas.SchemaProperties.Things.Properties;

[EntityTypeConfiguration(typeof(PropertyTypeConfigurationBase<Identifier>))]
public class Identifier:Text, ISchemaProperty<Identifier>
{
    protected Identifier() { }
    public Identifier(string value) : base(value) { }

    public static bool operator ==(Identifier type, string str)
    {
        return type.Equals(str);
    }
    public static bool operator !=(Identifier type, string str)
    {
        return !type.Equals(str);
    }

}
